using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.View
{
	// Token: 0x020069F4 RID: 27124
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritHintView : UiPanelBase
	{
		// Token: 0x060437AD RID: 276397 RVA: 0x0107F8F0 File Offset: 0x0107DAF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060437AE RID: 276398 RVA: 0x0107F9E0 File Offset: 0x0107DBE0
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIText text3 = base.GetText(5);
			if (text3 != null)
			{
				text3.SetUIActive(false);
			}
			base.SetUiActive(false);
			this.AddEvents();
		}

		// Token: 0x060437AF RID: 276399 RVA: 0x0107FA94 File Offset: 0x0107DC94
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x060437B0 RID: 276400 RVA: 0x0107FA9C File Offset: 0x0107DC9C
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged)))
			{
				EventSystem.Instance.Add(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged));
			}
			if (!EventSystem.Instance.Has<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged)))
			{
				EventSystem.Instance.Add<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged));
			}
		}

		// Token: 0x060437B1 RID: 276401 RVA: 0x0107FB1C File Offset: 0x0107DD1C
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged)))
			{
				EventSystem.Instance.Remove(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged));
			}
			if (EventSystem.Instance.Has<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged)))
			{
				EventSystem.Instance.Remove<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged));
			}
		}

		// Token: 0x060437B2 RID: 276402 RVA: 0x0107FB9B File Offset: 0x0107DD9B
		public void Tick(float delta)
		{
			this.RemainKeepVisibleTime -= (double)delta;
			this.CheckAndUpdateVisible();
			this.UpdateLocation(delta);
		}

		// Token: 0x060437B3 RID: 276403 RVA: 0x0107FBBC File Offset: 0x0107DDBC
		[NullableContext(2)]
		private SceneItemSunSpiritLauncherComponent GetWatchSelectedLauncherComp()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			if (entity == null || !entity.Valid)
			{
				return null;
			}
			if (entity == null)
			{
				return null;
			}
			RoleSceneInteractComponent component = entity.GetComponent<RoleSceneInteractComponent>();
			if (component == null)
			{
				return null;
			}
			return component.GetSunSpiritLauncherUiTarget();
		}

		// Token: 0x060437B4 RID: 276404 RVA: 0x0107FC04 File Offset: 0x0107DE04
		private void CheckAndUpdateVisible()
		{
			if (this.RemainKeepVisibleTime <= 0.0)
			{
				this.RemainKeepVisibleTime = 0.0;
			}
			if (this.RemainKeepVisibleTime > 0.0 || this.GetWatchSelectedLauncherComp() != null)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null || !rootItem.IsUIActiveSelf())
				{
					this.ShowHintView();
					this.UpdateHint();
					return;
				}
			}
			else
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 != null && rootItem2.IsUIActiveSelf())
				{
					this.HideHintView();
				}
			}
		}

		// Token: 0x060437B5 RID: 276405 RVA: 0x0107FC88 File Offset: 0x0107DE88
		private void ShowHintView()
		{
			base.SetUiActive(true);
			if (this.SequencePlayer == null)
			{
				this.OnEndSequenceEvent("Start");
				return;
			}
			if (this.SequencePlayer.IsSequenceFinish("Start"))
			{
				this.SequencePlayer.PlaySequence("Start", false, null);
			}
		}

		// Token: 0x060437B6 RID: 276406 RVA: 0x0107FCDC File Offset: 0x0107DEDC
		private void HideHintView()
		{
			if (this.SequencePlayer == null)
			{
				this.OnEndSequenceEvent("Close");
				return;
			}
			if (this.SequencePlayer.IsSequenceFinish("Close"))
			{
				this.ToggleLoopSequence(false);
				this.SequencePlayer.PlaySequence("Close", false, null);
			}
		}

		// Token: 0x060437B7 RID: 276407 RVA: 0x0107FD30 File Offset: 0x0107DF30
		private void ToggleLoopSequence(bool bEnable)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			if (this.SequencePlayer.IsSequenceFinish("Loop"))
			{
				if (bEnable)
				{
					this.SequencePlayer.PlaySequence("Loop", false, null);
					return;
				}
			}
			else if (!bEnable)
			{
				this.SequencePlayer.StopSequenceByKey("Loop", false, false);
			}
		}

		// Token: 0x060437B8 RID: 276408 RVA: 0x0107FD8B File Offset: 0x0107DF8B
		private void OnEndSequenceEvent(string seqName)
		{
			if (seqName == "Start")
			{
				this.ToggleLoopSequence(true);
				return;
			}
			if (seqName == "Close")
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x060437B9 RID: 276409 RVA: 0x0107FDB8 File Offset: 0x0107DFB8
		private void OnSunSpiritOccupiedByPlayerChanged()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			float? num = (instance != null) ? new float?(instance.GetSunSpiritConfig().CharacterHintUiShowDurationWhenUpdate) : null;
			double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
			if (num2 != null)
			{
				this.SetVisibleForDuration(num2.Value * 1000.0);
			}
			this.UpdateHint();
		}

		// Token: 0x060437BA RID: 276410 RVA: 0x0107FE31 File Offset: 0x0107E031
		[NullableContext(2)]
		private void OnSunSpiritLauncherWatchSelectedChanged(SceneItemSunSpiritLauncherComponent oldSunSpiritLauncher, SceneItemSunSpiritLauncherComponent newSunSpiritLauncher)
		{
			this.CheckAndUpdateVisible();
		}

		// Token: 0x060437BB RID: 276411 RVA: 0x0107FE39 File Offset: 0x0107E039
		private void SetVisibleForDuration(double duration)
		{
			if (duration <= 0.0)
			{
				return;
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null || !rootItem.IsUIActiveSelf())
			{
				this.ShowHintView();
			}
			this.RemainKeepVisibleTime = duration;
		}

		// Token: 0x060437BC RID: 276412 RVA: 0x0107FE6C File Offset: 0x0107E06C
		private void UpdateHint()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			int num;
			if (instance == null)
			{
				num = 0;
			}
			else
			{
				CreatureModel instance2 = CreatureModel.Instance;
				int playerId = (instance2 != null) ? instance2.GetPlayerId() : 0;
				AreaModel instance3 = AreaModel.Instance;
				num = instance.GetSunSpiritNumByPlayerIdAndAreaId(playerId, (instance3 != null) ? instance3.GetCurrentAreaId(null) : 0, true, delegate(SunSpiritData sunSpiritData)
				{
					SunSpiritOccupiedByPlayerState sunSpiritOccupiedByPlayerState = sunSpiritData.GetSunSpiritState() as SunSpiritOccupiedByPlayerState;
					return sunSpiritOccupiedByPlayerState != null && !sunSpiritOccupiedByPlayerState.IsFinished;
				});
			}
			int num2 = num;
			this.UpdateTxtNum(num2);
			this.UpdateLocation(0f);
		}

		// Token: 0x060437BD RID: 276413 RVA: 0x0107FEE8 File Offset: 0x0107E0E8
		private void UpdateTxtNum(int num)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x060437BE RID: 276414 RVA: 0x0107FF04 File Offset: 0x0107E104
		private void UpdateLocation(float delta)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			FVectorDouble? fvectorDouble = (baseCharacter != null) ? new FVectorDouble?(baseCharacter.D_K2_GetActorLocation()) : null;
			if (fvectorDouble == null)
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			BattleUiModel instance = BattleUiModel.Instance;
			if (instance == null)
			{
				return;
			}
			SunSpiritModel instance2 = SunSpiritModel.Instance;
			SunSpiritConfig sunSpiritConfig = (instance2 != null) ? instance2.GetSunSpiritConfig() : null;
			if (sunSpiritConfig == null)
			{
				return;
			}
			FVector2D fvector2D = default(FVector2D);
			APlayerController player = characterController;
			FVectorDouble value = fvectorDouble.Value;
			if (!UGameplayStatics.D_ProjectWorldToScreen(player, value, ref fvector2D, false))
			{
				return;
			}
			this.TargetAnchorOffset.FromUeVector2D(fvector2D);
			this.TargetAnchorOffset.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset);
			this.TargetAnchorOffset.Y *= -1.0;
			this.TargetAnchorOffset.AdditionEqual(sunSpiritConfig.CharacterHintUiAnchorOffset);
			if (this.RootItem == null)
			{
				return;
			}
			if (Math.Abs(this.TargetAnchorOffset.X - this.CurrentAnchorOffset.X) > 500.0 || Math.Abs(this.TargetAnchorOffset.Y - this.CurrentAnchorOffset.Y) > 500.0)
			{
				this.CurrentAnchorOffset.X = this.TargetAnchorOffset.X;
				this.CurrentAnchorOffset.Y = this.TargetAnchorOffset.Y;
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAnchorOffset(this.CurrentAnchorOffset.ToUeVector2D(false));
				return;
			}
			else
			{
				this.CurrentSpeed.X = this.GetSpeed((double)delta, this.TargetAnchorOffset.X, this.CurrentAnchorOffset.X, this.CurrentSpeed.X);
				this.CurrentSpeed.Y = this.GetSpeed((double)delta, this.TargetAnchorOffset.Y, this.CurrentAnchorOffset.Y, this.CurrentSpeed.Y);
				double num = this.CurrentSpeed.X * (double)delta;
				double num2 = this.CurrentSpeed.Y * (double)delta;
				if (Math.Abs(num) < 0.5 && Math.Abs(num2) < 0.5)
				{
					return;
				}
				this.CurrentAnchorOffset.X += num;
				this.CurrentAnchorOffset.Y += num2;
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetAnchorOffset(this.CurrentAnchorOffset.ToUeVector2D(false));
				return;
			}
		}

		// Token: 0x060437BF RID: 276415 RVA: 0x01080174 File Offset: 0x0107E374
		private double GetSpeed(double delta, double target, double cur, double lastSpeed)
		{
			double num = target - cur;
			bool flag = false;
			if (num < 0.0)
			{
				num = -num;
				flag = true;
			}
			if (num < 1.0)
			{
				return 0.0;
			}
			double num2;
			if (delta >= 200.0)
			{
				num2 = num / delta;
			}
			else
			{
				num2 = num / 200.0;
			}
			if (flag)
			{
				num2 = -num2;
			}
			return MathUtils.Instance.Lerp(lastSpeed, num2, 0.5);
		}

		// Token: 0x0402338F RID: 144271
		public const int MAX_DELTA_TIME = 200;

		// Token: 0x04023390 RID: 144272
		public const float MIN_DELTA_OFFSET = 0.5f;

		// Token: 0x04023391 RID: 144273
		public const int MAX_POS_OFFSET = 500;

		// Token: 0x04023392 RID: 144274
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023393 RID: 144275
		private double RemainKeepVisibleTime;

		// Token: 0x04023394 RID: 144276
		private readonly Vector2D TargetAnchorOffset = Vector2D.Create();

		// Token: 0x04023395 RID: 144277
		private readonly Vector2D CurrentAnchorOffset = Vector2D.Create();

		// Token: 0x04023396 RID: 144278
		private readonly Vector2D CurrentSpeed = Vector2D.Create();

		// Token: 0x0200CB5F RID: 52063
		[NullableContext(0)]
		public enum EChildType
		{
			// Token: 0x0403D677 RID: 251511
			NormalTxtNum,
			// Token: 0x0403D678 RID: 251512
			DefaultBg,
			// Token: 0x0403D679 RID: 251513
			NotEnoughBgOverlay,
			// Token: 0x0403D67A RID: 251514
			NotEnoughTxtNum,
			// Token: 0x0403D67B RID: 251515
			EnoughBgOverlay,
			// Token: 0x0403D67C RID: 251516
			EnoughTxtNum
		}
	}
}
