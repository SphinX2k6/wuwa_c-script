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
	// Token: 0x02005B51 RID: 23377
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritHintView : UiPanelBase
	{
		// Token: 0x060397F6 RID: 235510 RVA: 0x01023F38 File Offset: 0x01022138
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

		// Token: 0x060397F7 RID: 235511 RVA: 0x01024028 File Offset: 0x01022228
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

		// Token: 0x060397F8 RID: 235512 RVA: 0x010240DC File Offset: 0x010222DC
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x060397F9 RID: 235513 RVA: 0x010240E4 File Offset: 0x010222E4
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

		// Token: 0x060397FA RID: 235514 RVA: 0x01024164 File Offset: 0x01022364
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

		// Token: 0x060397FB RID: 235515 RVA: 0x010241E3 File Offset: 0x010223E3
		public void Tick(float delta)
		{
			this.RemainKeepVisibleTime -= (double)delta;
			this.CheckAndUpdateVisible();
			this.UpdateLocation(delta);
		}

		// Token: 0x060397FC RID: 235516 RVA: 0x01024204 File Offset: 0x01022404
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

		// Token: 0x060397FD RID: 235517 RVA: 0x0102424C File Offset: 0x0102244C
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

		// Token: 0x060397FE RID: 235518 RVA: 0x010242D0 File Offset: 0x010224D0
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

		// Token: 0x060397FF RID: 235519 RVA: 0x01024324 File Offset: 0x01022524
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

		// Token: 0x06039800 RID: 235520 RVA: 0x01024378 File Offset: 0x01022578
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

		// Token: 0x06039801 RID: 235521 RVA: 0x010243D3 File Offset: 0x010225D3
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

		// Token: 0x06039802 RID: 235522 RVA: 0x01024400 File Offset: 0x01022600
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

		// Token: 0x06039803 RID: 235523 RVA: 0x01024479 File Offset: 0x01022679
		[NullableContext(2)]
		private void OnSunSpiritLauncherWatchSelectedChanged(SceneItemSunSpiritLauncherComponent oldSunSpiritLauncher, SceneItemSunSpiritLauncherComponent newSunSpiritLauncher)
		{
			this.CheckAndUpdateVisible();
		}

		// Token: 0x06039804 RID: 235524 RVA: 0x01024481 File Offset: 0x01022681
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

		// Token: 0x06039805 RID: 235525 RVA: 0x010244B4 File Offset: 0x010226B4
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

		// Token: 0x06039806 RID: 235526 RVA: 0x01024530 File Offset: 0x01022730
		private void UpdateTxtNum(int num)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x06039807 RID: 235527 RVA: 0x0102454C File Offset: 0x0102274C
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

		// Token: 0x06039808 RID: 235528 RVA: 0x010247BC File Offset: 0x010229BC
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

		// Token: 0x0401E581 RID: 124289
		public const int MAX_DELTA_TIME = 200;

		// Token: 0x0401E582 RID: 124290
		public const float MIN_DELTA_OFFSET = 0.5f;

		// Token: 0x0401E583 RID: 124291
		public const int MAX_POS_OFFSET = 500;

		// Token: 0x0401E584 RID: 124292
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401E585 RID: 124293
		private double RemainKeepVisibleTime;

		// Token: 0x0401E586 RID: 124294
		private readonly Vector2D TargetAnchorOffset = Vector2D.Create();

		// Token: 0x0401E587 RID: 124295
		private readonly Vector2D CurrentAnchorOffset = Vector2D.Create();

		// Token: 0x0401E588 RID: 124296
		private readonly Vector2D CurrentSpeed = Vector2D.Create();

		// Token: 0x0200B73E RID: 46910
		[NullableContext(0)]
		public enum EChildType
		{
			// Token: 0x04038A59 RID: 232025
			NormalTxtNum,
			// Token: 0x04038A5A RID: 232026
			DefaultBg,
			// Token: 0x04038A5B RID: 232027
			NotEnoughBgOverlay,
			// Token: 0x04038A5C RID: 232028
			NotEnoughTxtNum,
			// Token: 0x04038A5D RID: 232029
			EnoughBgOverlay,
			// Token: 0x04038A5E RID: 232030
			EnoughTxtNum
		}
	}
}
