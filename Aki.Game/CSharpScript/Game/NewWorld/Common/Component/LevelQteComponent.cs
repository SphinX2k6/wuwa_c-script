using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007085 RID: 28805
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelQteComponent : EntityComponent
	{
		// Token: 0x0604627E RID: 287358 RVA: 0x01186B3C File Offset: 0x01184D3C
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LevelQteComponent levelQteComponent = args.GetP1<CreateEntityData>().GetParam<LevelQteComponent>() as LevelQteComponent;
			this.QteConfig = levelQteComponent.QteConfig;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0604627F RID: 287359 RVA: 0x01186B78 File Offset: 0x01184D78
		protected override bool OnEnd()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive())
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
			return true;
		}

		// Token: 0x06046280 RID: 287360 RVA: 0x01186BA4 File Offset: 0x01184DA4
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

		// Token: 0x06046281 RID: 287361 RVA: 0x01186C4E File Offset: 0x01184E4E
		public void StopQte()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive())
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
		}

		// Token: 0x06046282 RID: 287362 RVA: 0x01186C79 File Offset: 0x01184E79
		public bool IsQteActive()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			return activeQteContext != null && activeQteContext.IsActive();
		}

		// Token: 0x06046283 RID: 287363 RVA: 0x01186C8C File Offset: 0x01184E8C
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

		// Token: 0x06046284 RID: 287364 RVA: 0x01186D24 File Offset: 0x01184F24
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

		// Token: 0x06046285 RID: 287365 RVA: 0x01186DBC File Offset: 0x01184FBC
		[NullableContext(1)]
		private EntityContext CreateEntityContext()
		{
			EntityContext entityContext = EntityContext.Create(base.Entity.Id, null);
			entityContext.ClientExecuteActions = true;
			return entityContext;
		}

		// Token: 0x06046286 RID: 287366 RVA: 0x01186DEC File Offset: 0x01184FEC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LevelQteComponent levelQteComponent = (LevelQteComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (levelQteComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("QteConfig"))
			{
				if (levelQteComponent.QteConfig == null)
				{
					this.QteConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IQteType>(this.QteConfig), "QteConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActiveQteContext"))
			{
				if (levelQteComponent.ActiveQteContext == null)
				{
					this.ActiveQteContext = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CommonQteContextBase>(this.ActiveQteContext), "ActiveQteContext"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024C06 RID: 150534
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04024C07 RID: 150535
		private IQteType QteConfig;

		// Token: 0x04024C08 RID: 150536
		private CommonQteContextBase ActiveQteContext;
	}
}
