using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Game.NewWorld.Character.Custom.Components.Range;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x0200630D RID: 25357
	[NullableContext(2)]
	[Nullable(0)]
	public class TriggerComponent : EntityComponent
	{
		// Token: 0x17007449 RID: 29769
		// (get) Token: 0x0603D5F9 RID: 251385 RVA: 0x011BEC34 File Offset: 0x011BCE34
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

		// Token: 0x1700744A RID: 29770
		// (get) Token: 0x0603D5FA RID: 251386 RVA: 0x011BECE4 File Offset: 0x011BCEE4
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

		// Token: 0x0603D5FB RID: 251387 RVA: 0x011BEDB0 File Offset: 0x011BCFB0
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

		// Token: 0x0603D5FC RID: 251388 RVA: 0x011BEE2C File Offset: 0x011BD02C
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
			if (config != null && config.OnlineDisableTip.GetValueOrDefault() && !RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new MessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.RegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new MessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x0603D5FD RID: 251389 RVA: 0x011BEEE0 File Offset: 0x011BD0E0
		protected override bool OnEnd()
		{
			this.Config = null;
			if (RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new MessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.UnRegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trigger, new MessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x0603D5FE RID: 251390 RVA: 0x011BEF34 File Offset: 0x011BD134
		[NullableContext(1)]
		public TriggerContext CreateTriggerContext(int targetId)
		{
			return TriggerContext.Create(base.Entity.Id, targetId, null, null, null);
		}

		// Token: 0x0603D5FF RID: 251391 RVA: 0x011BEF6D File Offset: 0x011BD16D
		[NullableContext(1)]
		private void OnServerMessageEmit(AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			if (errorCode == ErrorCode.ErrOnlineInteractNotOpen || errorCode == ErrorCode.ErrOnlineInteractNoPermission || errorCode == ErrorCode.ErrInteractMultiGameMode)
			{
				LevelGamePlayController.Instance.ShowFakeErrorCodeTips(600064);
			}
		}

		// Token: 0x0603D600 RID: 251392 RVA: 0x011BEF9C File Offset: 0x011BD19C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			TriggerComponent triggerComponent = (TriggerComponent)componentTemplate;
			if (triggerComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (triggerComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			if (triggerComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			this.EntityConfigId = triggerComponent.EntityConfigId;
			return true;
		}

		// Token: 0x1700744B RID: 29771
		// (get) Token: 0x0603D601 RID: 251393 RVA: 0x011BF049 File Offset: 0x011BD249
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700744C RID: 29772
		// (get) Token: 0x0603D602 RID: 251394 RVA: 0x011BF04C File Offset: 0x011BD24C
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040208D4 RID: 133332
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040208D5 RID: 133333
		private RangeComponent RangeComp;

		// Token: 0x040208D6 RID: 133334
		private TriggerComponent Config;

		// Token: 0x040208D7 RID: 133335
		private int EntityConfigId;
	}
}
