using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C8B RID: 19595
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelKeepMovementMode
	{
		// Token: 0x17007CF7 RID: 31991
		// (get) Token: 0x06032A4B RID: 207435 RVA: 0x00BCF358 File Offset: 0x00BCD558
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x17007CF8 RID: 31992
		// (get) Token: 0x06032A4C RID: 207436 RVA: 0x00BCF360 File Offset: 0x00BCD560
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x17007CF9 RID: 31993
		// (get) Token: 0x06032A4D RID: 207437 RVA: 0x00BCF368 File Offset: 0x00BCD568
		public EMovementMode? TargetMovementMode
		{
			get
			{
				return this.TargetMovementModeInternal;
			}
		}

		// Token: 0x17007CFA RID: 31994
		// (get) Token: 0x06032A4E RID: 207438 RVA: 0x00BCF370 File Offset: 0x00BCD570
		public byte? TargetCustomMode
		{
			get
			{
				return this.TargetCustomModeInternal;
			}
		}

		// Token: 0x06032A4F RID: 207439 RVA: 0x00BCF378 File Offset: 0x00BCD578
		public void SetInitDataWithTargetMode(EMovementMode targetMovementMode, byte? targetCustomMode = null)
		{
			this.TargetMovementModeInternal = new EMovementMode?(targetMovementMode);
			this.TargetCustomModeInternal = targetCustomMode;
		}

		// Token: 0x06032A50 RID: 207440 RVA: 0x00BCF390 File Offset: 0x00BCD590
		[NullableContext(0)]
		public static ValueTuple<EMovementMode, byte>? GetCurrentKeepableMovementMode([Nullable(1)] SeamlessTravelContext context)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			object obj;
			if (baseCharacter == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					obj = null;
				}
				else
				{
					BaseMoveComponent moveComp = characterActorComponent.MoveComp;
					obj = ((moveComp != null) ? moveComp.CharacterMovement : null);
				}
			}
			object obj2 = obj;
			TEnumAsByte<EMovementMode>? tenumAsByte = (obj2 != null) ? new TEnumAsByte<EMovementMode>?(obj2.MovementMode) : null;
			byte? b = (obj2 != null) ? new byte?(obj2.CustomMovementMode) : null;
			if (tenumAsByte == null || b == null)
			{
				return null;
			}
			KeepMovementStateFeatures keepMovementStateFeatures = context.KeepMovementStateFeatures;
			if (keepMovementStateFeatures != null && keepMovementStateFeatures.KeepSoar)
			{
				ValueTuple<EMovementMode, int>? movementModeByConfigState = SeamlessTravelKeepMovementMode.GetMovementModeByConfigState(EKeepMovementState.Soar);
				if (movementModeByConfigState != null && tenumAsByte == movementModeByConfigState.Value.Item1)
				{
					byte? b2 = b;
					int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
					int item = movementModeByConfigState.Value.Item2;
					if (num.GetValueOrDefault() == item & num != null)
					{
						return new ValueTuple<EMovementMode, byte>?(new ValueTuple<EMovementMode, byte>(tenumAsByte.Value, b.Value));
					}
				}
			}
			KeepMovementStateFeatures keepMovementStateFeatures2 = context.KeepMovementStateFeatures;
			if (keepMovementStateFeatures2 != null && keepMovementStateFeatures2.KeepKite)
			{
				ValueTuple<EMovementMode, int>? movementModeByConfigState2 = SeamlessTravelKeepMovementMode.GetMovementModeByConfigState(EKeepMovementState.Kite);
				if (movementModeByConfigState2 != null && tenumAsByte == movementModeByConfigState2.Value.Item1)
				{
					byte? b2 = b;
					int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
					int item = movementModeByConfigState2.Value.Item2;
					if (num.GetValueOrDefault() == item & num != null)
					{
						return new ValueTuple<EMovementMode, byte>?(new ValueTuple<EMovementMode, byte>(tenumAsByte.Value, b.Value));
					}
				}
			}
			return null;
		}

		// Token: 0x06032A51 RID: 207441 RVA: 0x00BCF5A6 File Offset: 0x00BCD7A6
		[NullableContext(0)]
		public static ValueTuple<EMovementMode, int>? GetMovementModeByConfigState(EKeepMovementState keepMovementState)
		{
			return new ValueTuple<EMovementMode, int>?(SeamlessTravelKeepMovementMode.configStateToMovementMode[keepMovementState]);
		}

		// Token: 0x06032A52 RID: 207442 RVA: 0x00BCF5B8 File Offset: 0x00BCD7B8
		[NullableContext(1)]
		public void Init(SeamlessTravelContext context, [Nullable(2)] Action<bool> callback = null)
		{
			global::Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepMovementMode] 初始化(开始)", default(ReadOnlySpan<ValueTuple<string, object>>));
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.ActorComp = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			if (this.ActorComp == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[无缝传送KeepMovementMode] 初始化失败，无效的ActorComp";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (this.IsInit)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			this.Context = context;
			if (this.Context == null)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			this.IsInitInternal = true;
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06032A53 RID: 207443 RVA: 0x00BCF67A File Offset: 0x00BCD87A
		public void Tick(float delta)
		{
			this.CheckAndKeepMoveState();
		}

		// Token: 0x06032A54 RID: 207444 RVA: 0x00BCF684 File Offset: 0x00BCD884
		public void CheckAndKeepMoveState()
		{
			if (!this.IsInit || !this.IsActive)
			{
				return;
			}
			if (this.TargetMovementMode == null)
			{
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			UCharacterMovementComponent ucharacterMovementComponent;
			if (actorComp == null)
			{
				ucharacterMovementComponent = null;
			}
			else
			{
				BaseMoveComponent moveComp = actorComp.MoveComp;
				ucharacterMovementComponent = ((moveComp != null) ? moveComp.CharacterMovement : null);
			}
			UCharacterMovementComponent ucharacterMovementComponent2 = ucharacterMovementComponent;
			if (ucharacterMovementComponent2 == null)
			{
				return;
			}
			TEnumAsByte<EMovementMode> movementMode = ucharacterMovementComponent2.MovementMode;
			byte customMovementMode = ucharacterMovementComponent2.CustomMovementMode;
			TEnumAsByte<EMovementMode> left = movementMode;
			EMovementMode? targetMovementMode = this.TargetMovementMode;
			if (!(left != ((targetMovementMode != null) ? new TEnumAsByte<EMovementMode>?(targetMovementMode.GetValueOrDefault()) : null)))
			{
				if (this.TargetCustomMode == null)
				{
					return;
				}
				int num = (int)customMovementMode;
				byte? targetCustomMode = this.TargetCustomMode;
				int? num2 = (targetCustomMode != null) ? new int?((int)targetCustomMode.GetValueOrDefault()) : null;
				if (num == num2.GetValueOrDefault() & num2 != null)
				{
					return;
				}
			}
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = this.TargetMovementMode.Value,
				CustomMode = this.TargetCustomMode.GetValueOrDefault(),
				Context = "[SeamlessTravelKeepMovementMode.CheckAndKeepMoveState]"
			});
		}

		// Token: 0x06032A55 RID: 207445 RVA: 0x00BCF7D0 File Offset: 0x00BCD9D0
		public void Destroy()
		{
			global::Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepMovementMode] 清理", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInitInternal = false;
			this.ActorComp = null;
			this.Context = null;
		}

		// Token: 0x06032A56 RID: 207446 RVA: 0x00BCF814 File Offset: 0x00BCDA14
		public void AppearEffect(Action<bool> callback = null)
		{
			if (!this.IsInit)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (this.IsActive)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Actor.IsValid())
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			global::Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepMovementMode] 开启效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsActiveInternal = true;
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06032A57 RID: 207447 RVA: 0x00BCF8A0 File Offset: 0x00BCDAA0
		public void DisappearEffect(Action<bool> callback = null)
		{
			if (!this.IsInit)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (!this.IsActive)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			global::Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepMovementMode] 关闭效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsActiveInternal = false;
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06032A59 RID: 207449 RVA: 0x00BCF90B File Offset: 0x00BCDB0B
		// Note: this type is marked as 'beforefieldinit'.
		static SeamlessTravelKeepMovementMode()
		{
			Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>> dictionary = new Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>>();
			dictionary[EKeepMovementState.Kite] = new ValueTuple<EMovementMode, int>(EMovementMode.MOVE_Custom, 10);
			dictionary[EKeepMovementState.Soar] = new ValueTuple<EMovementMode, int>(EMovementMode.MOVE_Custom, 7);
			SeamlessTravelKeepMovementMode.configStateToMovementMode = dictionary;
		}

		// Token: 0x0401AF1F RID: 110367
		[Nullable(new byte[]
		{
			1,
			0
		})]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>> configStateToMovementMode;

		// Token: 0x0401AF20 RID: 110368
		private CharacterActorComponent ActorComp;

		// Token: 0x0401AF21 RID: 110369
		private SeamlessTravelContext Context;

		// Token: 0x0401AF22 RID: 110370
		private EMovementMode? TargetMovementModeInternal;

		// Token: 0x0401AF23 RID: 110371
		private byte? TargetCustomModeInternal;

		// Token: 0x0401AF24 RID: 110372
		private bool IsInitInternal;

		// Token: 0x0401AF25 RID: 110373
		private bool IsActiveInternal;
	}
}
