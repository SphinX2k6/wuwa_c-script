using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CEF RID: 19695
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeMonsterHeadStateView : BattleChildView
	{
		// Token: 0x06031536 RID: 202038 RVA: 0x00DC777C File Offset: 0x00DC597C
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

		// Token: 0x06031537 RID: 202039 RVA: 0x00DC7C5C File Offset: 0x00DC5E5C
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
			this.BuffItemContainer.Init(item, 12, false);
		}

		// Token: 0x06031538 RID: 202040 RVA: 0x00DC7D28 File Offset: 0x00DC5F28
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

		// Token: 0x06031539 RID: 202041 RVA: 0x00DC7D84 File Offset: 0x00DC5F84
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.VisibleMachine.Reset();
			this.VisibleMachine = null;
			this.BuffItemContainer.ClearAll();
			if (this.HitEffectCountdown >= 0f)
			{
				this.PlayHitEffect(0f);
			}
		}

		// Token: 0x0603153A RID: 202042 RVA: 0x00DC7DD8 File Offset: 0x00DC5FD8
		protected override void OnBeforeShow()
		{
			this.RefreshInner();
			this.VisibleMachine.SetVisible(true, 667f);
		}

		// Token: 0x0603153B RID: 202043 RVA: 0x00DC7DF1 File Offset: 0x00DC5FF1
		public void Refresh(MergeHeadStateInfo info)
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

		// Token: 0x0603153C RID: 202044 RVA: 0x00DC7E13 File Offset: 0x00DC6013
		private void RefreshInner()
		{
			this.RefreshBossLevel();
			this.RefreshBossName();
			this.RefreshHp(false);
			this.RefreshBuff();
			this.RefreshExtraItem();
		}

		// Token: 0x0603153D RID: 202045 RVA: 0x00DC7E34 File Offset: 0x00DC6034
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.HpParentWidth = base.GetItem(8).GetParentAsUIItem().GetWidth();
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/LGUI/MPC_UIShader.MPC_UIShader", delegate([Nullable(2)] UMaterialParameterCollection collection, string _)
			{
				this.GlobalShaderCollection = collection;
			}, 103, "js_undefined");
		}

		// Token: 0x0603153E RID: 202046 RVA: 0x00DC7E82 File Offset: 0x00DC6082
		public void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x0603153F RID: 202047 RVA: 0x00DC7E8B File Offset: 0x00DC608B
		public void OnLanguageChange()
		{
			this.RefreshBossName();
		}

		// Token: 0x06031540 RID: 202048 RVA: 0x00DC7E94 File Offset: 0x00DC6094
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
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x06031541 RID: 202049 RVA: 0x00DC7F2C File Offset: 0x00DC612C
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

		// Token: 0x06031542 RID: 202050 RVA: 0x00DC7F84 File Offset: 0x00DC6184
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

		// Token: 0x06031543 RID: 202051 RVA: 0x00DC8010 File Offset: 0x00DC6210
		private void PlayHitEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, MergeMonsterHeadStateView.RgbSplitProgress, param);
			}
		}

		// Token: 0x06031544 RID: 202052 RVA: 0x00DC8035 File Offset: 0x00DC6235
		private void StopBarLerpAnimation()
		{
			base.GetItem(8).SetUIActive(false);
			this.HpStateMachine.Reset();
			this.IsPlayingHpBarAnim = false;
		}

		// Token: 0x06031545 RID: 202053 RVA: 0x00DC8056 File Offset: 0x00DC6256
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(7).SetFillAmount(percent);
		}

		// Token: 0x06031546 RID: 202054 RVA: 0x00DC8068 File Offset: 0x00DC6268
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

		// Token: 0x06031547 RID: 202055 RVA: 0x00DC80C9 File Offset: 0x00DC62C9
		private void RefreshBossLevel()
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x06031548 RID: 202056 RVA: 0x00DC80E0 File Offset: 0x00DC62E0
		private void RefreshBossName()
		{
			string monsterGroupName = this.Info.MonsterGroupName;
			base.GetText(1).SetText((!string.IsNullOrEmpty(monsterGroupName)) ? PublicUtil.Instance.GetConfigTextByKey(monsterGroupName) : string.Empty, true);
		}

		// Token: 0x06031549 RID: 202057 RVA: 0x00DC8120 File Offset: 0x00DC6320
		private void RefreshBuff()
		{
			IMonsterMergedHpBarSettings monsterMergedHpBarSettings = this.Info.MonsterMergedHpBarSettings;
			List<long> list = (monsterMergedHpBarSettings != null) ? monsterMergedHpBarSettings.DisplayBuffIds : null;
			if (list == null)
			{
				this.BuffItemContainer.ClearAll();
				return;
			}
			this.BuffItemContainer.RefreshBuff(list);
		}

		// Token: 0x0603154A RID: 202058 RVA: 0x00DC8160 File Offset: 0x00DC6360
		private void RefreshExtraItem()
		{
			UUIItem item = base.GetItem(32);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603154B RID: 202059 RVA: 0x00DC8175 File Offset: 0x00DC6375
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x0603154C RID: 202060 RVA: 0x00DC8188 File Offset: 0x00DC6388
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

		// Token: 0x0603154D RID: 202061 RVA: 0x00DC8210 File Offset: 0x00DC6410
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

		// Token: 0x0603154E RID: 202062 RVA: 0x00DC826C File Offset: 0x00DC646C
		public void HideWithAnim()
		{
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x0603154F RID: 202063 RVA: 0x00DC827F File Offset: 0x00DC647F
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.Hide(null);
			}
		}

		// Token: 0x06031550 RID: 202064 RVA: 0x00DC828C File Offset: 0x00DC648C
		private void OnPlayVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.PlaySequencePurely(visible ? "ShowView" : "CloseView", false, false, null, null, false);
		}

		// Token: 0x06031551 RID: 202065 RVA: 0x00DC82C0 File Offset: 0x00DC64C0
		private void OnStopVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x06031552 RID: 202066 RVA: 0x00DC82CF File Offset: 0x00DC64CF
		[NullableContext(1)]
		public string GetResourceId()
		{
			return "UiItem_BossState_Prefab";
		}

		// Token: 0x0401A1ED RID: 106989
		[StaticVariableRuleIgnore]
		private static readonly FName RgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401A1EE RID: 106990
		private const float SHOW_VIEW_ANIM_TIME = 667f;

		// Token: 0x0401A1EF RID: 106991
		private const float CLOSE_VIEW_ANIM_TIME = 167f;

		// Token: 0x0401A1F0 RID: 106992
		private const int MAX_BUFF_ITEM_COUNT = 12;

		// Token: 0x0401A1F1 RID: 106993
		public MergeHeadStateInfo Info;

		// Token: 0x0401A1F2 RID: 106994
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A1F3 RID: 106995
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401A1F4 RID: 106996
		private float HitLargePercent;

		// Token: 0x0401A1F5 RID: 106997
		private float CurrentBarPercent = 1f;

		// Token: 0x0401A1F6 RID: 106998
		[Nullable(1)]
		private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

		// Token: 0x0401A1F7 RID: 106999
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401A1F8 RID: 107000
		private float HitEffectCountdown = -1f;

		// Token: 0x0401A1F9 RID: 107001
		private float HitEffectDuration;

		// Token: 0x0401A1FA RID: 107002
		private float HpParentWidth;

		// Token: 0x0401A1FB RID: 107003
		private bool IsPlayingHpBarAnim;

		// Token: 0x0401A1FC RID: 107004
		[Nullable(1)]
		private readonly BuffItemSimpleContainer BuffItemContainer = new BuffItemSimpleContainer();

		// Token: 0x0401A1FD RID: 107005
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200A98D RID: 43405
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x040345F7 RID: 214519
			BossLevelText,
			// Token: 0x040345F8 RID: 214520
			BossNameText,
			// Token: 0x040345F9 RID: 214521
			RageItem,
			// Token: 0x040345FA RID: 214522
			ToughBg,
			// Token: 0x040345FB RID: 214523
			RageBar,
			// Token: 0x040345FC RID: 214524
			HpShieldBarItem,
			// Token: 0x040345FD RID: 214525
			HpBarItem,
			// Token: 0x040345FE RID: 214526
			NormalHpBarSprite,
			// Token: 0x040345FF RID: 214527
			BarBufferCanvas,
			// Token: 0x04034600 RID: 214528
			BarBufferSprite,
			// Token: 0x04034601 RID: 214529
			ShieldBarSprite,
			// Token: 0x04034602 RID: 214530
			ToughItem,
			// Token: 0x04034603 RID: 214531
			MaxHardnessEffect,
			// Token: 0x04034604 RID: 214532
			BuffHorizontalItem,
			// Token: 0x04034605 RID: 214533
			HpLight,
			// Token: 0x04034606 RID: 214534
			HardnessNormal,
			// Token: 0x04034607 RID: 214535
			HardnessBreak,
			// Token: 0x04034608 RID: 214536
			FallDownItem,
			// Token: 0x04034609 RID: 214537
			FallDownBar,
			// Token: 0x0403460A RID: 214538
			FallDownBarSign,
			// Token: 0x0403460B RID: 214539
			RageReduceLittle,
			// Token: 0x0403460C RID: 214540
			HpFlicker,
			// Token: 0x0403460D RID: 214541
			RageReduceLargeCanvas,
			// Token: 0x0403460E RID: 214542
			RageReduceLarge,
			// Token: 0x0403460F RID: 214543
			RageEmpty,
			// Token: 0x04034610 RID: 214544
			AnimSmallHit,
			// Token: 0x04034611 RID: 214545
			AnimBigHit,
			// Token: 0x04034612 RID: 214546
			AnimToughStart,
			// Token: 0x04034613 RID: 214547
			AnimToughHit,
			// Token: 0x04034614 RID: 214548
			AnimToughFlick,
			// Token: 0x04034615 RID: 214549
			AnimToughClose,
			// Token: 0x04034616 RID: 214550
			AnimBreak,
			// Token: 0x04034617 RID: 214551
			MoraleLevelItem,
			// Token: 0x04034618 RID: 214552
			BloodModeIcon,
			// Token: 0x04034619 RID: 214553
			WeaknessContainer,
			// Token: 0x0403461A RID: 214554
			HpWeaknessNode,
			// Token: 0x0403461B RID: 214555
			HpWeaknessSprite1,
			// Token: 0x0403461C RID: 214556
			HpWeaknessSprite2,
			// Token: 0x0403461D RID: 214557
			HpWeaknessSprite3,
			// Token: 0x0403461E RID: 214558
			HpWeaknessEffect,
			// Token: 0x0403461F RID: 214559
			AniHpWeaknessFull,
			// Token: 0x04034620 RID: 214560
			AniHpWeaknessBreak
		}
	}
}
