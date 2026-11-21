using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C3C RID: 15420
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelKeepMovementMode
	{
		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x060277FE RID: 161790 RVA: 0x00B13FBC File Offset: 0x00B121BC
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x060277FF RID: 161791 RVA: 0x00B13FC4 File Offset: 0x00B121C4
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x06027800 RID: 161792 RVA: 0x00B13FCC File Offset: 0x00B121CC
		public EMovementMode? TargetMovementMode
		{
			get
			{
				return this.TargetMovementModeInternal;
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x06027801 RID: 161793 RVA: 0x00B13FD4 File Offset: 0x00B121D4
		public byte? TargetCustomMode
		{
			get
			{
				return this.TargetCustomModeInternal;
			}
		}

		// Token: 0x06027802 RID: 161794 RVA: 0x00B13FDC File Offset: 0x00B121DC
		public void SetInitDataWithTargetMode(EMovementMode targetMovementMode, byte? targetCustomMode = null)
		{
			this.TargetMovementModeInternal = new EMovementMode?(targetMovementMode);
			this.TargetCustomModeInternal = targetCustomMode;
		}

		// Token: 0x06027803 RID: 161795 RVA: 0x00B13FF4 File Offset: 0x00B121F4
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

		// Token: 0x06027804 RID: 161796 RVA: 0x00B1420A File Offset: 0x00B1240A
		[NullableContext(0)]
		public static ValueTuple<EMovementMode, int>? GetMovementModeByConfigState(EKeepMovementState keepMovementState)
		{
			return new ValueTuple<EMovementMode, int>?(SeamlessTravelKeepMovementMode.configStateToMovementMode[keepMovementState]);
		}

		// Token: 0x06027805 RID: 161797 RVA: 0x00B1421C File Offset: 0x00B1241C
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

		// Token: 0x06027806 RID: 161798 RVA: 0x00B142DE File Offset: 0x00B124DE
		public void Tick(float delta)
		{
			this.CheckAndKeepMoveState();
		}

		// Token: 0x06027807 RID: 161799 RVA: 0x00B142E8 File Offset: 0x00B124E8
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

		// Token: 0x06027808 RID: 161800 RVA: 0x00B14434 File Offset: 0x00B12634
		public void Destroy()
		{
			global::Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepMovementMode] 清理", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInitInternal = false;
			this.ActorComp = null;
			this.Context = null;
		}

		// Token: 0x06027809 RID: 161801 RVA: 0x00B14478 File Offset: 0x00B12678
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

		// Token: 0x0602780A RID: 161802 RVA: 0x00B14504 File Offset: 0x00B12704
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

		// Token: 0x0602780C RID: 161804 RVA: 0x00B1456F File Offset: 0x00B1276F
		// Note: this type is marked as 'beforefieldinit'.
		static SeamlessTravelKeepMovementMode()
		{
			Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>> dictionary = new Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>>();
			dictionary[EKeepMovementState.Kite] = new ValueTuple<EMovementMode, int>(EMovementMode.MOVE_Custom, 10);
			dictionary[EKeepMovementState.Soar] = new ValueTuple<EMovementMode, int>(EMovementMode.MOVE_Custom, 7);
			SeamlessTravelKeepMovementMode.configStateToMovementMode = dictionary;
		}

		// Token: 0x0401587C RID: 88188
		[Nullable(new byte[]
		{
			1,
			0
		})]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EKeepMovementState, ValueTuple<EMovementMode, int>> configStateToMovementMode;

		// Token: 0x0401587D RID: 88189
		private CharacterActorComponent ActorComp;

		// Token: 0x0401587E RID: 88190
		private SeamlessTravelContext Context;

		// Token: 0x0401587F RID: 88191
		private EMovementMode? TargetMovementModeInternal;

		// Token: 0x04015880 RID: 88192
		private byte? TargetCustomModeInternal;

		// Token: 0x04015881 RID: 88193
		private bool IsInitInternal;

		// Token: 0x04015882 RID: 88194
		private bool IsActiveInternal;
	}
}
