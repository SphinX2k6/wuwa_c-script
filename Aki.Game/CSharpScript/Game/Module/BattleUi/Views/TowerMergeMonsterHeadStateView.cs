using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D0E RID: 23822
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerMergeMonsterHeadStateView : BattleChildView
	{
		// Token: 0x0603C5FD RID: 247293 RVA: 0x00E77CB8 File Offset: 0x00E75EB8
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

		// Token: 0x0603C5FE RID: 247294 RVA: 0x00E78198 File Offset: 0x00E76398
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

		// Token: 0x0603C5FF RID: 247295 RVA: 0x00E78258 File Offset: 0x00E76458
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

		// Token: 0x0603C600 RID: 247296 RVA: 0x00E782B1 File Offset: 0x00E764B1
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

		// Token: 0x0603C601 RID: 247297 RVA: 0x00E782EF File Offset: 0x00E764EF
		protected override void OnBeforeShow()
		{
			this.RefreshInner();
			this.VisibleMachine.SetVisible(true, 667f);
			this.PlayHitEffect(0f);
		}

		// Token: 0x0603C602 RID: 247298 RVA: 0x00E78313 File Offset: 0x00E76513
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

		// Token: 0x0603C603 RID: 247299 RVA: 0x00E78335 File Offset: 0x00E76535
		private void RefreshInner()
		{
			this.RefreshBossLevel();
			this.RefreshBossName();
			this.RefreshHp(false);
		}

		// Token: 0x0603C604 RID: 247300 RVA: 0x00E7834C File Offset: 0x00E7654C
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.HpParentWidth = base.GetItem(8).GetParentAsUIItem().GetWidth();
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/LGUI/MPC_UIShader.MPC_UIShader", delegate([Nullable(2)] UMaterialParameterCollection collection, string _)
			{
				this.GlobalShaderCollection = collection;
			}, 103, "js_undefined");
		}

		// Token: 0x0603C605 RID: 247301 RVA: 0x00E7839A File Offset: 0x00E7659A
		public void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x0603C606 RID: 247302 RVA: 0x00E783A3 File Offset: 0x00E765A3
		public void OnLanguageChange()
		{
			this.RefreshBossName();
		}

		// Token: 0x0603C607 RID: 247303 RVA: 0x00E783AC File Offset: 0x00E765AC
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

		// Token: 0x0603C608 RID: 247304 RVA: 0x00E78438 File Offset: 0x00E76638
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

		// Token: 0x0603C609 RID: 247305 RVA: 0x00E78490 File Offset: 0x00E76690
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

		// Token: 0x0603C60A RID: 247306 RVA: 0x00E7851C File Offset: 0x00E7671C
		private void PlayHitEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, TowerMergeMonsterHeadStateView.RgbSplitProgress, param);
			}
		}

		// Token: 0x0603C60B RID: 247307 RVA: 0x00E78541 File Offset: 0x00E76741
		private void StopBarLerpAnimation()
		{
			base.GetItem(8).SetUIActive(false);
			this.HpStateMachine.Reset();
			this.IsPlayingHpBarAnim = false;
		}

		// Token: 0x0603C60C RID: 247308 RVA: 0x00E78562 File Offset: 0x00E76762
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(7).SetFillAmount(percent);
		}

		// Token: 0x0603C60D RID: 247309 RVA: 0x00E78574 File Offset: 0x00E76774
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

		// Token: 0x0603C60E RID: 247310 RVA: 0x00E785D5 File Offset: 0x00E767D5
		private void RefreshBossLevel()
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603C60F RID: 247311 RVA: 0x00E785EC File Offset: 0x00E767EC
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

		// Token: 0x0603C610 RID: 247312 RVA: 0x00E78670 File Offset: 0x00E76870
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x0603C611 RID: 247313 RVA: 0x00E78684 File Offset: 0x00E76884
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

		// Token: 0x0603C612 RID: 247314 RVA: 0x00E78704 File Offset: 0x00E76904
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

		// Token: 0x0603C613 RID: 247315 RVA: 0x00E78760 File Offset: 0x00E76960
		public void HideWithAnim()
		{
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x0603C614 RID: 247316 RVA: 0x00E78773 File Offset: 0x00E76973
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.Hide(null);
			}
		}

		// Token: 0x0603C615 RID: 247317 RVA: 0x00E78780 File Offset: 0x00E76980
		private void OnPlayVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.PlaySequencePurely(visible ? "ShowView" : "CloseView", false, false, null, null, false);
		}

		// Token: 0x0603C616 RID: 247318 RVA: 0x00E787B4 File Offset: 0x00E769B4
		private void OnStopVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x0603C617 RID: 247319 RVA: 0x00E787C3 File Offset: 0x00E769C3
		[NullableContext(1)]
		public string GetResourceId()
		{
			return "UiItem_BossState_Prefab";
		}

		// Token: 0x0401F745 RID: 128837
		[StaticVariableRuleIgnore]
		private static readonly FName RgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401F746 RID: 128838
		private const float SHOW_VIEW_ANIM_TIME = 667f;

		// Token: 0x0401F747 RID: 128839
		private const float CLOSE_VIEW_ANIM_TIME = 167f;

		// Token: 0x0401F748 RID: 128840
		public TowerMergeHeadStateInfo Info;

		// Token: 0x0401F749 RID: 128841
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F74A RID: 128842
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401F74B RID: 128843
		private float HitLargePercent;

		// Token: 0x0401F74C RID: 128844
		private float CurrentBarPercent = 1f;

		// Token: 0x0401F74D RID: 128845
		[Nullable(1)]
		private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

		// Token: 0x0401F74E RID: 128846
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401F74F RID: 128847
		private float HitEffectCountdown = -1f;

		// Token: 0x0401F750 RID: 128848
		private float HitEffectDuration;

		// Token: 0x0401F751 RID: 128849
		private float HpParentWidth;

		// Token: 0x0401F752 RID: 128850
		private bool IsPlayingHpBarAnim;

		// Token: 0x0401F753 RID: 128851
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200BF88 RID: 49032
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039C60 RID: 236640
			BossLevelText,
			// Token: 0x04039C61 RID: 236641
			BossNameText,
			// Token: 0x04039C62 RID: 236642
			RageItem,
			// Token: 0x04039C63 RID: 236643
			ToughBg,
			// Token: 0x04039C64 RID: 236644
			RageBar,
			// Token: 0x04039C65 RID: 236645
			HpShieldBarItem,
			// Token: 0x04039C66 RID: 236646
			HpBarItem,
			// Token: 0x04039C67 RID: 236647
			NormalHpBarSprite,
			// Token: 0x04039C68 RID: 236648
			BarBufferCanvas,
			// Token: 0x04039C69 RID: 236649
			BarBufferSprite,
			// Token: 0x04039C6A RID: 236650
			ShieldBarSprite,
			// Token: 0x04039C6B RID: 236651
			ToughItem,
			// Token: 0x04039C6C RID: 236652
			MaxHardnessEffect,
			// Token: 0x04039C6D RID: 236653
			BuffHorizontalItem,
			// Token: 0x04039C6E RID: 236654
			HpLight,
			// Token: 0x04039C6F RID: 236655
			HardnessNormal,
			// Token: 0x04039C70 RID: 236656
			HardnessBreak,
			// Token: 0x04039C71 RID: 236657
			FallDownItem,
			// Token: 0x04039C72 RID: 236658
			FallDownBar,
			// Token: 0x04039C73 RID: 236659
			FallDownBarSign,
			// Token: 0x04039C74 RID: 236660
			RageReduceLittle,
			// Token: 0x04039C75 RID: 236661
			HpFlicker,
			// Token: 0x04039C76 RID: 236662
			RageReduceLargeCanvas,
			// Token: 0x04039C77 RID: 236663
			RageReduceLarge,
			// Token: 0x04039C78 RID: 236664
			RageEmpty,
			// Token: 0x04039C79 RID: 236665
			AnimSmallHit,
			// Token: 0x04039C7A RID: 236666
			AnimBigHit,
			// Token: 0x04039C7B RID: 236667
			AnimToughStart,
			// Token: 0x04039C7C RID: 236668
			AnimToughHit,
			// Token: 0x04039C7D RID: 236669
			AnimToughFlick,
			// Token: 0x04039C7E RID: 236670
			AnimToughClose,
			// Token: 0x04039C7F RID: 236671
			AnimBreak,
			// Token: 0x04039C80 RID: 236672
			MoraleLevelItem,
			// Token: 0x04039C81 RID: 236673
			BloodModeIcon,
			// Token: 0x04039C82 RID: 236674
			WeaknessContainer,
			// Token: 0x04039C83 RID: 236675
			HpWeaknessNode,
			// Token: 0x04039C84 RID: 236676
			HpWeaknessSprite1,
			// Token: 0x04039C85 RID: 236677
			HpWeaknessSprite2,
			// Token: 0x04039C86 RID: 236678
			HpWeaknessSprite3,
			// Token: 0x04039C87 RID: 236679
			HpWeaknessEffect,
			// Token: 0x04039C88 RID: 236680
			AniHpWeaknessFull,
			// Token: 0x04039C89 RID: 236681
			AniHpWeaknessBreak
		}
	}
}
