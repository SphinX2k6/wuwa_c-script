using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D0E RID: 23822
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSportsState : LevelEventBase
	{
		// Token: 0x0603A41E RID: 238622 RVA: 0x01076639 File Offset: 0x01074839
		public LevelEventSportsState(int id) : base(id)
		{
		}

		// Token: 0x0603A41F RID: 238623 RVA: 0x01076644 File Offset: 0x01074844
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			ISportConfig config = (inParams as SetSportsState).Config;
			switch (config.Type)
			{
			case ESportStateType.Slide:
				CharacterSlideComponent.SetSlideConfig((config as ISlideConfig).SlideId);
				return;
			case ESportStateType.Ski:
			{
				ISkiConfig skiConfig = config as ISkiConfig;
				switch (skiConfig.Config.Type)
				{
				case ESkiConfig.Open:
					this.EnterSkiMode(skiConfig.Config as IOpenSkiConfig, context);
					return;
				case ESkiConfig.Close:
					this.ExitSkiMode(skiConfig.Config as ICloseSkiConfig, context);
					return;
				case ESkiConfig.Accelerate:
					this.SetSkiAccel(skiConfig.Config as IAccelerateSkiConfig, context);
					break;
				default:
					return;
				}
				break;
			}
			case ESportStateType.PetalGrab:
				break;
			case ESportStateType.PetalFly:
				this.SetMovementState(config.Type);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603A420 RID: 238624 RVA: 0x01076704 File Offset: 0x01074904
		private unsafe void EnterSkiMode(IOpenSkiConfig config, GeneralContext context)
		{
			EGeneralContextType? type = context.Type;
			if (type != null)
			{
				EGeneralContextType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault == EGeneralContextType.Entity || valueOrDefault - EGeneralContextType.Trigger <= 1)
				{
					Entity entity = null;
					string text = this.ParseSource(context);
					if (config.Target.Type == ETargetEntityType.Player)
					{
						TsBaseCharacter baseCharacter = Global.BaseCharacter;
						entity = ((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null);
					}
					if (entity == null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.LevelEvent;
						ELogAuthor author = ELogAuthor.YJX;
						string message = "目前仅Role支持触发滑雪模式";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ContextType", context.Type);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ContextSource", text);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
					bool flag = text == "180700235";
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.YJX;
					string message2 = "进入滑雪模式";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", context.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ContextSource", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NeedSetBase", flag);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					CharacterSlideComponent component = entity.GetComponent<CharacterSlideComponent>();
					if (component == null)
					{
						return;
					}
					component.EnterSkiMode(config, flag);
					return;
				}
			}
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.LevelEvent;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "LevelEventSportsState Ski: 类型必须对应GeneralLogicTreeContext | Entity | Trigger";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ContextType", context.Type);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603A421 RID: 238625 RVA: 0x0107688C File Offset: 0x01074A8C
		private unsafe void ExitSkiMode(ICloseSkiConfig config, GeneralContext context)
		{
			EGeneralContextType? type = context.Type;
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case EGeneralContextType.Entity:
				case EGeneralContextType.LevelPlay:
				case EGeneralContextType.Trigger:
				case EGeneralContextType.GeneralLogicTree:
				{
					Entity entity = null;
					string item = this.ParseSource(context);
					if (config.Target.Type == ETargetEntityType.Player)
					{
						TsBaseCharacter baseCharacter = Global.BaseCharacter;
						entity = ((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null);
					}
					if (entity == null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.LevelEvent;
						ELogAuthor author = ELogAuthor.YJX;
						string message = "目前仅Role支持关闭滑雪模式";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ContextType", context.Type);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ContextSource", item);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.YJX;
					string message2 = "退出滑雪模式";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", context.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ContextSource", item);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					CharacterSlideComponent component = entity.GetComponent<CharacterSlideComponent>();
					if (component == null)
					{
						return;
					}
					component.ExitSkiMode(true);
					return;
				}
				}
			}
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.LevelEvent;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "LevelEventSportsState Ski: 类型必须对应GeneralLogicTreeContext | Entity | LevelPlay | Trigger";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ContextType", context.Type);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603A422 RID: 238626 RVA: 0x01076A00 File Offset: 0x01074C00
		private void SetMovementState(ESportStateType type)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			if (entity == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.LJM, "[LevelEventSportsState][SetMovementState] 目前仅支持主角触发", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.LJM, "[LevelEventSportsState][SetMovementState] 角色运动组件不可用", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (type == ESportStateType.PetalFly)
			{
				component.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Custom,
					CustomMode = 19,
					Context = "[CharacterFlowerFlyingComponent.LevelEventSportsState]"
				});
			}
		}

		// Token: 0x0603A423 RID: 238627 RVA: 0x01076A94 File Offset: 0x01074C94
		private void SetSkiAccel(IAccelerateSkiConfig config, GeneralContext context)
		{
			if (!(context is TriggerContext))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "LevelEventSportsState Ski: Triggered类型必须对应TriggerContext";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ContextType", context.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TriggerContext triggerContext = context as TriggerContext;
			CharacterSlideComponent component = EntitySystem.Instance.GetComponent<CharacterSlideComponent>(triggerContext.OtherEntityId.Value);
			if (component == null)
			{
				return;
			}
			component.SetSkiAccel(config);
		}

		// Token: 0x0603A424 RID: 238628 RVA: 0x01076B04 File Offset: 0x01074D04
		private string ParseSource(GeneralContext inContext)
		{
			string result = "";
			EGeneralContextType? type = inContext.Type;
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case EGeneralContextType.Entity:
				{
					CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>((inContext as EntityContext).EntityId.Value);
					result = (((component != null) ? component.GetPbDataId().ToString() : null) ?? "");
					break;
				}
				case EGeneralContextType.LevelPlay:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("LevelPlay:");
					defaultInterpolatedStringHandler.AppendFormatted<int>((inContext as LevelPlayContext).LevelPlayId);
					result = defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				case EGeneralContextType.Trigger:
				{
					CreatureDataComponent component2 = EntitySystem.Instance.GetComponent<CreatureDataComponent>((inContext as TriggerContext).TriggerEntityId.Value);
					result = (((component2 != null) ? component2.GetPbDataId().ToString() : null) ?? "");
					break;
				}
				case EGeneralContextType.GeneralLogicTree:
				{
					GeneralLogicTreeContext generalLogicTreeContext = inContext as GeneralLogicTreeContext;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(generalLogicTreeContext.TreeConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(generalLogicTreeContext.NodeId);
					result = defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				}
			}
			return result;
		}
	}
}
