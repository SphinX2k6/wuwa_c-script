using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006206 RID: 25094
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelQteComponent : EntityComponent
	{
		// Token: 0x0603C49C RID: 246940 RVA: 0x011300A0 File Offset: 0x0112E2A0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LevelQteComponent levelQteComponent = args.GetP1<CreateEntityData>().GetParam<LevelQteComponent>() as LevelQteComponent;
			this.QteConfig = levelQteComponent.QteConfig;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0603C49D RID: 246941 RVA: 0x011300DC File Offset: 0x0112E2DC
		protected override bool OnEnd()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive())
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
			return true;
		}

		// Token: 0x0603C49E RID: 246942 RVA: 0x01130108 File Offset: 0x0112E308
		public bool StartQte(bool restartIfSameQteExist = false)
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive() && restartIfSameQteExist)
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
			IQteType qteConfig = this.QteConfig;
			if ((((qteConfig != null) ? new Aki.TDConfigMgr.Component.EQteType?(qteConfig.Type) : null) ?? ((Aki.TDConfigMgr.Component.EQteType)1)) == Aki.TDConfigMgr.Component.EQteType.SingleBtn)
			{
				this.ActiveQteContext = CommonQteController.Instance.StartQte(this.QteConfig.QteId, new TCommonQteCallback(this.OnQteSuccess), new TCommonQteCallback(this.OnQteFailed), EQteSource.Level, null);
				if (this.ActiveQteContext != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603C49F RID: 246943 RVA: 0x011301B2 File Offset: 0x0112E3B2
		public void StopQte()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive())
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
		}

		// Token: 0x0603C4A0 RID: 246944 RVA: 0x011301DD File Offset: 0x0112E3DD
		public bool IsQteActive()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			return activeQteContext != null && activeQteContext.IsActive();
		}

		// Token: 0x0603C4A1 RID: 246945 RVA: 0x011301F0 File Offset: 0x0112E3F0
		private void OnQteSuccess(CommonQteContextBase context)
		{
			this.ActiveQteContext = null;
			IQteType qteConfig = this.QteConfig;
			if ((((qteConfig != null) ? new Aki.TDConfigMgr.Component.EQteType?(qteConfig.Type) : null) ?? ((Aki.TDConfigMgr.Component.EQteType)1)) == Aki.TDConfigMgr.Component.EQteType.SingleBtn)
			{
				ISingleBtnQte singleBtnQte = (ISingleBtnQte)this.QteConfig;
				List<ActionInfo> actions = singleBtnQte.SuccessCallback.Actions;
				string sendSelfEvent = singleBtnQte.SuccessCallback.SendSelfEvent;
				if (actions != null)
				{
					LevelGeneralController.Instance.ExecuteActionsNew(actions, this.CreateEntityContext(), null);
				}
				if (sendSelfEvent != null)
				{
					LevelGeneralNetworks.RequestEntitySendEvent(this.CreatureDataComp.GetCreatureDataId(), sendSelfEvent);
				}
				return;
			}
		}

		// Token: 0x0603C4A2 RID: 246946 RVA: 0x01130288 File Offset: 0x0112E488
		private void OnQteFailed(CommonQteContextBase context)
		{
			this.ActiveQteContext = null;
			IQteType qteConfig = this.QteConfig;
			if ((((qteConfig != null) ? new Aki.TDConfigMgr.Component.EQteType?(qteConfig.Type) : null) ?? ((Aki.TDConfigMgr.Component.EQteType)1)) == Aki.TDConfigMgr.Component.EQteType.SingleBtn)
			{
				ISingleBtnQte singleBtnQte = (ISingleBtnQte)this.QteConfig;
				List<ActionInfo> actions = singleBtnQte.FailureCallback.Actions;
				string sendSelfEvent = singleBtnQte.FailureCallback.SendSelfEvent;
				if (actions != null)
				{
					LevelGeneralController.Instance.ExecuteActionsNew(actions, this.CreateEntityContext(), null);
				}
				if (sendSelfEvent != null)
				{
					LevelGeneralNetworks.RequestEntitySendEvent(this.CreatureDataComp.GetCreatureDataId(), sendSelfEvent);
				}
				return;
			}
		}

		// Token: 0x0603C4A3 RID: 246947 RVA: 0x01130320 File Offset: 0x0112E520
		[NullableContext(1)]
		private EntityContext CreateEntityContext()
		{
			EntityContext entityContext = EntityContext.Create(base.Entity.Id, null);
			entityContext.ClientExecuteActions = true;
			return entityContext;
		}

		// Token: 0x0603C4A4 RID: 246948 RVA: 0x01130350 File Offset: 0x0112E550
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LevelQteComponent levelQteComponent = (LevelQteComponent)componentTemplate;
			if (levelQteComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (levelQteComponent.QteConfig == null)
			{
				this.QteConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.QteConfig), "QteConfig"))
			{
				return false;
			}
			if (levelQteComponent.ActiveQteContext == null)
			{
				this.ActiveQteContext = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActiveQteContext), "ActiveQteContext"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170071C8 RID: 29128
		// (get) Token: 0x0603C4A5 RID: 246949 RVA: 0x011303F1 File Offset: 0x0112E5F1
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEC1 RID: 130753
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FEC2 RID: 130754
		private IQteType QteConfig;

		// Token: 0x0401FEC3 RID: 130755
		private CommonQteContextBase ActiveQteContext;
	}
}
