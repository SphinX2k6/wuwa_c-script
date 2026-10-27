using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.View
{
	// Token: 0x020069F7 RID: 27127
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritLauncherHintView : UiPanelBase
	{
		// Token: 0x060437C2 RID: 276418 RVA: 0x01080224 File Offset: 0x0107E424
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x060437C3 RID: 276419 RVA: 0x010802C0 File Offset: 0x0107E4C0
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
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

		// Token: 0x060437C4 RID: 276420 RVA: 0x01080374 File Offset: 0x0107E574
		protected override void OnBeforeDestroy()
		{
			this.ClearTargetLauncherComp();
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			this.RemoveEvents();
		}

		// Token: 0x060437C5 RID: 276421 RVA: 0x01080390 File Offset: 0x0107E590
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged)))
			{
				EventSystem.Instance.Add<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged));
			}
			this.ChangeTargetLauncherComp(this.GetWatchSelectedLauncherComp());
		}

		// Token: 0x060437C6 RID: 276422 RVA: 0x010803E2 File Offset: 0x0107E5E2
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged)))
			{
				EventSystem.Instance.Remove<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(EEventName.OnSunSpiritLauncherWatchSelectedChanged, new Action<SceneItemSunSpiritLauncherComponent, SceneItemSunSpiritLauncherComponent>(this.OnSunSpiritLauncherWatchSelectedChanged));
			}
		}

		// Token: 0x060437C7 RID: 276423 RVA: 0x0108041D File Offset: 0x0107E61D
		public void Tick(double delta)
		{
			this.CheckAndUpdateVisible();
			this.UpdateLocation(delta);
		}

		// Token: 0x060437C8 RID: 276424 RVA: 0x0108042C File Offset: 0x0107E62C
		private void OnSunSpiritLauncherWatchSelectedChanged(SceneItemSunSpiritLauncherComponent oldSunSpiritLauncher, SceneItemSunSpiritLauncherComponent newSunSpiritLauncher)
		{
			this.ChangeTargetLauncherComp(this.GetWatchSelectedLauncherComp());
		}

		// Token: 0x060437C9 RID: 276425 RVA: 0x0108043C File Offset: 0x0107E63C
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

		// Token: 0x060437CA RID: 276426 RVA: 0x01080490 File Offset: 0x0107E690
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

		// Token: 0x060437CB RID: 276427 RVA: 0x010804E4 File Offset: 0x0107E6E4
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

		// Token: 0x060437CC RID: 276428 RVA: 0x0108053F File Offset: 0x0107E73F
		[NullableContext(1)]
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

		// Token: 0x060437CD RID: 276429 RVA: 0x0108056A File Offset: 0x0107E76A
		private void OnSunSpiritOccupiedByGearChanged()
		{
			this.UpdateHint();
		}

		// Token: 0x060437CE RID: 276430 RVA: 0x01080572 File Offset: 0x0107E772
		private void OnSunSpiritOccupiedByPlayerChanged()
		{
			this.UpdateHint();
		}

		// Token: 0x060437CF RID: 276431 RVA: 0x0108057C File Offset: 0x0107E77C
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

		// Token: 0x060437D0 RID: 276432 RVA: 0x010805C4 File Offset: 0x0107E7C4
		private void ChangeTargetLauncherComp(SceneItemSunSpiritLauncherComponent newSunSpiritLauncher)
		{
			if (newSunSpiritLauncher == this.TargetLauncherComp)
			{
				return;
			}
			this.ClearTargetLauncherComp();
			if (newSunSpiritLauncher != null)
			{
				this.SetupTargetLauncherComp(newSunSpiritLauncher);
			}
			this.CheckAndUpdateVisible();
			this.UpdateHint();
		}

		// Token: 0x060437D1 RID: 276433 RVA: 0x010805EC File Offset: 0x0107E7EC
		private void ClearTargetLauncherComp()
		{
			if (this.TargetGearComp != null && EventSystem.Instance.HasWithTarget(this.TargetGearComp.Entity, EEventName.OnSunSpiritOccupiedByGearChanged, new Action(this.OnSunSpiritOccupiedByGearChanged)))
			{
				EventSystem.Instance.RemoveWithTargetUseKey(this, this.TargetGearComp.Entity, EEventName.OnSunSpiritOccupiedByGearChanged, new Action(this.OnSunSpiritOccupiedByGearChanged));
			}
			if (EventSystem.Instance.Has(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged)))
			{
				EventSystem.Instance.Remove(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged));
			}
			this.TargetLauncherComp = null;
			this.TargetGearComp = null;
		}

		// Token: 0x060437D2 RID: 276434 RVA: 0x01080698 File Offset: 0x0107E898
		[NullableContext(1)]
		private void SetupTargetLauncherComp(SceneItemSunSpiritLauncherComponent newSunSpiritLauncher)
		{
			if (newSunSpiritLauncher == null || newSunSpiritLauncher.GetTargetGear() == null)
			{
				return;
			}
			this.TargetLauncherComp = newSunSpiritLauncher;
			this.TargetGearComp = newSunSpiritLauncher.GetTargetGear();
			if (!EventSystem.Instance.HasWithTarget(this.TargetGearComp.Entity, EEventName.OnSunSpiritOccupiedByGearChanged, new Action(this.OnSunSpiritOccupiedByGearChanged)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey(this, this.TargetGearComp.Entity, EEventName.OnSunSpiritOccupiedByGearChanged, new Action(this.OnSunSpiritOccupiedByGearChanged));
			}
			if (!EventSystem.Instance.Has(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged)))
			{
				EventSystem.Instance.Add(EEventName.OnSunSpiritOccupiedByPlayerChanged, new Action(this.OnSunSpiritOccupiedByPlayerChanged));
			}
		}

		// Token: 0x060437D3 RID: 276435 RVA: 0x01080750 File Offset: 0x0107E950
		private void CheckAndUpdateVisible()
		{
			if (this.TargetLauncherComp != null)
			{
				if (this.RootItem != null && !this.RootItem.IsUIActiveSelf())
				{
					this.ShowHintView();
					this.UpdateHint();
					return;
				}
			}
			else
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null && rootItem.IsUIActiveSelf())
				{
					this.HideHintView();
				}
			}
		}

		// Token: 0x060437D4 RID: 276436 RVA: 0x010807A4 File Offset: 0x0107E9A4
		private void SwitchToEnough()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(true);
		}

		// Token: 0x060437D5 RID: 276437 RVA: 0x010807FC File Offset: 0x0107E9FC
		private void SwitchToNotEnough()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(true);
		}

		// Token: 0x060437D6 RID: 276438 RVA: 0x01080854 File Offset: 0x0107EA54
		private void UpdateHint()
		{
			if (this.TargetLauncherComp != null)
			{
				int numOfNeededSunSpirit = this.TargetLauncherComp.GetNumOfNeededSunSpirit();
				int numOfSunSpiritRelatedToLauncher = this.TargetLauncherComp.GetNumOfSunSpiritRelatedToLauncher(true, true, true, true);
				if (numOfNeededSunSpirit > numOfSunSpiritRelatedToLauncher)
				{
					this.SwitchToNotEnough();
				}
				else
				{
					this.SwitchToEnough();
				}
				this.UpdateTxtNum(numOfNeededSunSpirit);
				this.UpdateLocation(0.0);
			}
		}

		// Token: 0x060437D7 RID: 276439 RVA: 0x010808AD File Offset: 0x0107EAAD
		private void UpdateTxtNum(int num)
		{
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(num.ToString(), true);
		}

		// Token: 0x060437D8 RID: 276440 RVA: 0x010808E4 File Offset: 0x0107EAE4
		private void UpdateLocation(double delta)
		{
			SceneItemSunSpiritLauncherComponent targetLauncherComp = this.TargetLauncherComp;
			if (targetLauncherComp == null || !targetLauncherComp.GetHintViewLocation(this.TmpVector))
			{
				return;
			}
			Vector tmpVector = this.TmpVector;
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
			FVectorDouble fvectorDouble = tmpVector.ToUeVector(false);
			if (!UGameplayStatics.D_ProjectWorldToScreen(player, fvectorDouble, ref fvector2D, false))
			{
				return;
			}
			this.TargetAnchorOffset.FromUeVector2D(fvector2D);
			this.TargetAnchorOffset.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset);
			this.TargetAnchorOffset.Y *= -1.0;
			this.TargetAnchorOffset.AdditionEqual(sunSpiritConfig.LauncherHintUiAnchorOffset);
			if (this.RootItem == null)
			{
				return;
			}
			this.CurrentAnchorOffset.FromUeVector2D(this.RootItem.GetAnchorOffset());
			double num = this.TargetAnchorOffset.X - this.CurrentAnchorOffset.X;
			double num2 = this.TargetAnchorOffset.Y - this.CurrentAnchorOffset.Y;
			if (Math.Abs(num) < 0.5 && Math.Abs(num2) < 0.5)
			{
				return;
			}
			if (delta != 0.0 && !sunSpiritConfig.LauncherHintUiPosLerpSpeed.IsNearlyZero(9.999999747378752E-05) && Math.Abs(num) <= 500.0 && Math.Abs(num2) <= 500.0)
			{
				double num3 = sunSpiritConfig.LauncherHintUiPosLerpSpeed.X * 1000.0;
				double num4 = sunSpiritConfig.LauncherHintUiPosLerpSpeed.Y * 1000.0;
				double num5 = (delta > 200.0) ? 200.0 : delta;
				double alpha = MathUtils.Instance.Clamp(Math.Abs(num3 * num5 / num), 0.0, 1.0);
				double alpha2 = MathUtils.Instance.Clamp(Math.Abs(num4 * num5 / num2), 0.0, 1.0);
				this.CurrentAnchorOffset.X = MathUtils.Instance.Lerp(this.CurrentAnchorOffset.X, this.TargetAnchorOffset.X, alpha);
				this.CurrentAnchorOffset.Y = MathUtils.Instance.Lerp(this.CurrentAnchorOffset.Y, this.TargetAnchorOffset.Y, alpha2);
			}
			else
			{
				this.CurrentAnchorOffset.DeepCopy(this.TargetAnchorOffset);
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(this.CurrentAnchorOffset.ToUeVector2D(false));
		}

		// Token: 0x040233A1 RID: 144289
		private SceneItemSunSpiritLauncherComponent TargetLauncherComp;

		// Token: 0x040233A2 RID: 144290
		private SceneItemSunSpiritGearComponent TargetGearComp;

		// Token: 0x040233A3 RID: 144291
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040233A4 RID: 144292
		[Nullable(1)]
		private readonly Vector2D TargetAnchorOffset = Vector2D.Create();

		// Token: 0x040233A5 RID: 144293
		[Nullable(1)]
		private readonly Vector2D CurrentAnchorOffset = Vector2D.Create();

		// Token: 0x040233A6 RID: 144294
		[Nullable(1)]
		private readonly Vector TmpVector = Vector.Create();
	}
}
