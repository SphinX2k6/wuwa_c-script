using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF0 RID: 19696
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerMergeMonsterHeadStateView : BattleChildView
	{
		// Token: 0x06031556 RID: 202070 RVA: 0x00DC8330 File Offset: 0x00DC6530
		protected unsafe override void OnRegisterComponent()
		{
			int num = 35;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.HitEffectDuration = (float)ConfigCommonParamById.GetIntConfig("HitEffectDuration").Value;
		}

		// Token: 0x06031557 RID: 202071 RVA: 0x00DC8810 File Offset: 0x00DC6A10
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitAllTweenAnim();
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargeBufferPercent").Value / 10000f;
			this.VisibleMachine = new VisibleAnimMachine();
			this.VisibleMachine.InitCallback(new Action<bool>(this.OnRealVisibleChanged), new Action<bool>(this.OnPlayVisibleAnim), new Action<bool>(this.OnStopVisibleAnim));
			this.VisibleMachine.InitVisible(false);
			this.HideInvisibleNode();
			FColor color = FColor.FromHex("ED601BFF");
			base.GetText(1).SetColor(color);
			UUIItem item = base.GetItem(13);
			item.SetAnchorOffsetY(-15f);
			item.SetUIActive(false);
		}

		// Token: 0x06031558 RID: 202072 RVA: 0x00DC88D0 File Offset: 0x00DC6AD0
		private void HideInvisibleNode()
		{
			base.GetSprite(10).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
			UUIItem item = base.GetItem(32);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.GetItem(34).SetUIActive(false);
			base.GetItem(35).SetUIActive(false);
		}

		// Token: 0x06031559 RID: 202073 RVA: 0x00DC8929 File Offset: 0x00DC6B29
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.VisibleMachine.Reset();
			this.VisibleMachine = null;
			if (this.HitEffectCountdown >= 0f)
			{
				this.PlayHitEffect(0f);
			}
		}

		// Token: 0x0603155A RID: 202074 RVA: 0x00DC8967 File Offset: 0x00DC6B67
		protected override void OnBeforeShow()
		{
			this.RefreshInner();
			this.VisibleMachine.SetVisible(true, 667f);
			this.PlayHitEffect(0f);
		}

		// Token: 0x0603155B RID: 202075 RVA: 0x00DC898B File Offset: 0x00DC6B8B
		public void Refresh(TowerMergeHeadStateInfo info)
		{
			this.Info = info;
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (info == null)
			{
				this.StopBarLerpAnimation();
				return;
			}
			this.RefreshInner();
		}

		// Token: 0x0603155C RID: 202076 RVA: 0x00DC89AD File Offset: 0x00DC6BAD
		private void RefreshInner()
		{
			this.RefreshBossLevel();
			this.RefreshBossName();
			this.RefreshHp(false);
		}

		// Token: 0x0603155D RID: 202077 RVA: 0x00DC89C4 File Offset: 0x00DC6BC4
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.HpParentWidth = base.GetItem(8).GetParentAsUIItem().GetWidth();
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/LGUI/MPC_UIShader.MPC_UIShader", delegate([Nullable(2)] UMaterialParameterCollection collection, string _)
			{
				this.GlobalShaderCollection = collection;
			}, 103, "js_undefined");
		}

		// Token: 0x0603155E RID: 202078 RVA: 0x00DC8A12 File Offset: 0x00DC6C12
		public void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x0603155F RID: 202079 RVA: 0x00DC8A1B File Offset: 0x00DC6C1B
		public void OnLanguageChange()
		{
			this.RefreshBossName();
		}

		// Token: 0x06031560 RID: 202080 RVA: 0x00DC8A24 File Offset: 0x00DC6C24
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (this.IsPlayingHpBarAnim)
			{
				float num = this.HpStateMachine.UpdatePercent(delta);
				if (num < 0f)
				{
					this.StopBarLerpAnimation();
				}
				else if (num <= 1f)
				{
					this.SetBarBufferPercent(num);
				}
			}
			if (this.HitEffectCountdown > this.HitEffectDuration)
			{
				this.PlayHitEffect(0f);
				this.HitEffectCountdown = -1f;
			}
			if (this.HitEffectCountdown >= 0f)
			{
				this.HitEffectCountdown += delta;
			}
		}

		// Token: 0x06031561 RID: 202081 RVA: 0x00DC8AB0 File Offset: 0x00DC6CB0
		private void RefreshHp(bool bPlayBarAnimation = false)
		{
			if (this.Info.TotalHpMax <= 0f)
			{
				return;
			}
			float num = this.Info.TotalHp / this.Info.TotalHpMax;
			this.SetHpBarPercent(num);
			if (bPlayBarAnimation)
			{
				this.PlayBarAnimation(num);
			}
			else
			{
				this.StopBarLerpAnimation();
			}
			this.CurrentBarPercent = num;
		}

		// Token: 0x06031562 RID: 202082 RVA: 0x00DC8B08 File Offset: 0x00DC6D08
		private void PlayBarAnimation(float hpPercent)
		{
			if (hpPercent < this.CurrentBarPercent)
			{
				bool flag = this.HpStateMachine.IsOriginState();
				this.HpStateMachine.GetHit(hpPercent, this.CurrentBarPercent);
				if (flag && !this.HpStateMachine.IsOriginState())
				{
					this.SetBarBufferPercent(this.CurrentBarPercent);
				}
				this.IsPlayingHpBarAnim = true;
				if (this.CurrentBarPercent - hpPercent < this.HitLargePercent)
				{
					this.PlayTweenAnim(25);
					return;
				}
				this.PlayTweenAnim(26);
				this.HitEffectCountdown = 0f;
				this.PlayHitEffect(1f);
			}
		}

		// Token: 0x06031563 RID: 202083 RVA: 0x00DC8B94 File Offset: 0x00DC6D94
		private void PlayHitEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, TowerMergeMonsterHeadStateView.RgbSplitProgress, param);
			}
		}

		// Token: 0x06031564 RID: 202084 RVA: 0x00DC8BB9 File Offset: 0x00DC6DB9
		private void StopBarLerpAnimation()
		{
			base.GetItem(8).SetUIActive(false);
			this.HpStateMachine.Reset();
			this.IsPlayingHpBarAnim = false;
		}

		// Token: 0x06031565 RID: 202085 RVA: 0x00DC8BDA File Offset: 0x00DC6DDA
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(7).SetFillAmount(percent);
		}

		// Token: 0x06031566 RID: 202086 RVA: 0x00DC8BEC File Offset: 0x00DC6DEC
		private void SetBarBufferPercent(float percent)
		{
			float num = this.HpParentWidth * this.CurrentBarPercent;
			float num2 = this.HpParentWidth * percent;
			float num3 = num2 - num;
			float num4 = num2 - (this.HpParentWidth + num3) / 2f;
			UUIItem item = base.GetItem(8);
			item.SetAnchorOffsetX(num4);
			item.SetWidth(num3);
			item.SetUIActive(true);
			base.GetSprite(9).SetAnchorOffsetX(-num4);
		}

		// Token: 0x06031567 RID: 202087 RVA: 0x00DC8C4D File Offset: 0x00DC6E4D
		private void RefreshBossLevel()
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x06031568 RID: 202088 RVA: 0x00DC8C64 File Offset: 0x00DC6E64
		private void RefreshBossName()
		{
			UUIText text = base.GetText(1);
			if (this.Info == null)
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(this.Info.MainMonsterInfoId);
			string text2 = (waveConfigById != null) ? waveConfigById.GetValueOrDefault().Name : null;
			if (!string.IsNullOrEmpty(text2))
			{
				LguiUtil.Instance.SetLocalTextNew(text, text2, Array.Empty<object>());
				return;
			}
			text.SetText(string.Empty, true);
		}

		// Token: 0x06031569 RID: 202089 RVA: 0x00DC8CE8 File Offset: 0x00DC6EE8
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x0603156A RID: 202090 RVA: 0x00DC8CFC File Offset: 0x00DC6EFC
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x0603156B RID: 202091 RVA: 0x00DC8D84 File Offset: 0x00DC6F84
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0603156C RID: 202092 RVA: 0x00DC8DE0 File Offset: 0x00DC6FE0
		public void HideWithAnim()
		{
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x0603156D RID: 202093 RVA: 0x00DC8DF3 File Offset: 0x00DC6FF3
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.Hide(null);
			}
		}

		// Token: 0x0603156E RID: 202094 RVA: 0x00DC8E00 File Offset: 0x00DC7000
		private void OnPlayVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.PlaySequencePurely(visible ? "ShowView" : "CloseView", false, false, null, null, false);
		}

		// Token: 0x0603156F RID: 202095 RVA: 0x00DC8E34 File Offset: 0x00DC7034
		private void OnStopVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x06031570 RID: 202096 RVA: 0x00DC8E43 File Offset: 0x00DC7043
		[NullableContext(1)]
		public string GetResourceId()
		{
			return "UiItem_BossState_Prefab";
		}

		// Token: 0x0401A1FE RID: 107006
		[StaticVariableRuleIgnore]
		private static readonly FName RgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401A1FF RID: 107007
		private const float SHOW_VIEW_ANIM_TIME = 667f;

		// Token: 0x0401A200 RID: 107008
		private const float CLOSE_VIEW_ANIM_TIME = 167f;

		// Token: 0x0401A201 RID: 107009
		public TowerMergeHeadStateInfo Info;

		// Token: 0x0401A202 RID: 107010
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A203 RID: 107011
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401A204 RID: 107012
		private float HitLargePercent;

		// Token: 0x0401A205 RID: 107013
		private float CurrentBarPercent = 1f;

		// Token: 0x0401A206 RID: 107014
		[Nullable(1)]
		private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

		// Token: 0x0401A207 RID: 107015
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401A208 RID: 107016
		private float HitEffectCountdown = -1f;

		// Token: 0x0401A209 RID: 107017
		private float HitEffectDuration;

		// Token: 0x0401A20A RID: 107018
		private float HpParentWidth;

		// Token: 0x0401A20B RID: 107019
		private bool IsPlayingHpBarAnim;

		// Token: 0x0401A20C RID: 107020
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200A98E RID: 43406
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034622 RID: 214562
			BossLevelText,
			// Token: 0x04034623 RID: 214563
			BossNameText,
			// Token: 0x04034624 RID: 214564
			RageItem,
			// Token: 0x04034625 RID: 214565
			ToughBg,
			// Token: 0x04034626 RID: 214566
			RageBar,
			// Token: 0x04034627 RID: 214567
			HpShieldBarItem,
			// Token: 0x04034628 RID: 214568
			HpBarItem,
			// Token: 0x04034629 RID: 214569
			NormalHpBarSprite,
			// Token: 0x0403462A RID: 214570
			BarBufferCanvas,
			// Token: 0x0403462B RID: 214571
			BarBufferSprite,
			// Token: 0x0403462C RID: 214572
			ShieldBarSprite,
			// Token: 0x0403462D RID: 214573
			ToughItem,
			// Token: 0x0403462E RID: 214574
			MaxHardnessEffect,
			// Token: 0x0403462F RID: 214575
			BuffHorizontalItem,
			// Token: 0x04034630 RID: 214576
			HpLight,
			// Token: 0x04034631 RID: 214577
			HardnessNormal,
			// Token: 0x04034632 RID: 214578
			HardnessBreak,
			// Token: 0x04034633 RID: 214579
			FallDownItem,
			// Token: 0x04034634 RID: 214580
			FallDownBar,
			// Token: 0x04034635 RID: 214581
			FallDownBarSign,
			// Token: 0x04034636 RID: 214582
			RageReduceLittle,
			// Token: 0x04034637 RID: 214583
			HpFlicker,
			// Token: 0x04034638 RID: 214584
			RageReduceLargeCanvas,
			// Token: 0x04034639 RID: 214585
			RageReduceLarge,
			// Token: 0x0403463A RID: 214586
			RageEmpty,
			// Token: 0x0403463B RID: 214587
			AnimSmallHit,
			// Token: 0x0403463C RID: 214588
			AnimBigHit,
			// Token: 0x0403463D RID: 214589
			AnimToughStart,
			// Token: 0x0403463E RID: 214590
			AnimToughHit,
			// Token: 0x0403463F RID: 214591
			AnimToughFlick,
			// Token: 0x04034640 RID: 214592
			AnimToughClose,
			// Token: 0x04034641 RID: 214593
			AnimBreak,
			// Token: 0x04034642 RID: 214594
			MoraleLevelItem,
			// Token: 0x04034643 RID: 214595
			BloodModeIcon,
			// Token: 0x04034644 RID: 214596
			WeaknessContainer,
			// Token: 0x04034645 RID: 214597
			HpWeaknessNode,
			// Token: 0x04034646 RID: 214598
			HpWeaknessSprite1,
			// Token: 0x04034647 RID: 214599
			HpWeaknessSprite2,
			// Token: 0x04034648 RID: 214600
			HpWeaknessSprite3,
			// Token: 0x04034649 RID: 214601
			HpWeaknessEffect,
			// Token: 0x0403464A RID: 214602
			AniHpWeaknessFull,
			// Token: 0x0403464B RID: 214603
			AniHpWeaknessBreak
		}
	}
}
