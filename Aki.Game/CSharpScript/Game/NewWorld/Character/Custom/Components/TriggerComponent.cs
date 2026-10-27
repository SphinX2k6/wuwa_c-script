using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x020070AE RID: 28846
	[NullableContext(2)]
	[Nullable(0)]
	public class TriggerComponent : EntityComponent
	{
		// Token: 0x17009C57 RID: 40023
		// (get) Token: 0x06046551 RID: 288081 RVA: 0x011A1334 File Offset: 0x0119F534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				TriggerComponent config = this.Config;
				if (config != null && config.ClientPrePerformance.GetValueOrDefault())
				{
					TriggerComponent config2 = this.Config;
					if (((config2 != null) ? config2.Actions : null) != null)
					{
						List<ActionInfo> list = new List<ActionInfo>();
						foreach (ActionInfo actionInfo in this.Config.Actions)
						{
							if (actionInfo.Name != EAction.PlayEffect)
							{
								list.Add(actionInfo);
							}
						}
						return list;
					}
					return null;
				}
				else
				{
					TriggerComponent config3 = this.Config;
					if (config3 == null)
					{
						return null;
					}
					return config3.Actions;
				}
			}
		}

		// Token: 0x17009C58 RID: 40024
		// (get) Token: 0x06046552 RID: 288082 RVA: 0x011A13E4 File Offset: 0x0119F5E4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				TriggerComponent config = this.Config;
				if (config != null && config.ClientPrePerformance.GetValueOrDefault())
				{
					TriggerComponent config2 = this.Config;
					bool flag;
					if (config2 == null)
					{
						flag = (null != null);
					}
					else
					{
						ITriggerExitConfig exitConfig = config2.ExitConfig;
						flag = (((exitConfig != null) ? exitConfig.Actions : null) != null);
					}
					if (flag)
					{
						List<ActionInfo> list = new List<ActionInfo>();
						foreach (ActionInfo actionInfo in this.Config.ExitConfig.Actions)
						{
							if (actionInfo.Name != EAction.PlayEffect)
							{
								list.Add(actionInfo);
							}
						}
						return list;
					}
					return null;
				}
				else
				{
					TriggerComponent config3 = this.Config;
					if (config3 == null)
					{
						return null;
					}
					ITriggerExitConfig exitConfig2 = config3.ExitConfig;
					if (exitConfig2 == null)
					{
						return null;
					}
					return exitConfig2.Actions;
				}
			}
		}

		// Token: 0x06046553 RID: 288083 RVA: 0x011A14B0 File Offset: 0x0119F6B0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object obj;
			if (args == null)
			{
				obj = null;
			}
			else
			{
				CreateEntityData p = args.GetP1<CreateEntityData>();
				obj = ((p != null) ? p.GetParam<TriggerComponent>() : null);
			}
			TriggerComponent config = obj as TriggerComponent;
			PawnSensoryInfoComponent component = base.Entity.GetComponent<PawnSensoryInfoComponent>();
			if (component != null && component.LogicRange == 0f)
			{
				component.SetLogicRange(300f);
			}
			this.Config = config;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.EntityConfigId = this.CreatureDataComp.GetPbDataId();
			return true;
		}

		// Token: 0x06046554 RID: 288084 RVA: 0x011A152C File Offset: 0x0119F72C
		protected override bool OnStart()
		{
			this.RangeComp = base.Entity.GetComponent<RangeComponent>();
			if (this.RangeComp == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[TriggerComponent] RangeComp缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", this.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			TriggerComponent config = this.Config;
			if (config != null && config.OnlineDisableTip.GetValueOrDefault() && !RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new TMessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.RegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new TMessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x06046555 RID: 288085 RVA: 0x011A15E0 File Offset: 0x0119F7E0
		protected override bool OnEnd()
		{
			this.Config = null;
			if (RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new TMessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.UnRegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new TMessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x06046556 RID: 288086 RVA: 0x011A1634 File Offset: 0x0119F834
		[NullableContext(1)]
		public TriggerContext CreateTriggerContext(int targetId)
		{
			return TriggerContext.Create(base.Entity.Id, targetId, null, null, null);
		}

		// Token: 0x06046557 RID: 288087 RVA: 0x011A166D File Offset: 0x0119F86D
		[NullableContext(1)]
		private void OnServerMessageEmit(AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			if (errorCode == ErrorCode.ErrOnlineInteractNotOpen || errorCode == ErrorCode.ErrOnlineInteractNoPermission || errorCode == ErrorCode.ErrInteractMultiGameMode)
			{
				LevelGamePlayController.Instance.ShowFakeErrorCodeTips(600064);
			}
		}

		// Token: 0x06046558 RID: 288088 RVA: 0x011A169C File Offset: 0x0119F89C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			TriggerComponent triggerComponent = (TriggerComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (triggerComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (triggerComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (triggerComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TriggerComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EntityConfigId"))
			{
				this.EntityConfigId = triggerComponent.EntityConfigId;
			}
			return true;
		}

		// Token: 0x04024DAD RID: 150957
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04024DAE RID: 150958
		private RangeComponent RangeComp;

		// Token: 0x04024DAF RID: 150959
		private TriggerComponent Config;

		// Token: 0x04024DB0 RID: 150960
		private int EntityConfigId;
	}
}
