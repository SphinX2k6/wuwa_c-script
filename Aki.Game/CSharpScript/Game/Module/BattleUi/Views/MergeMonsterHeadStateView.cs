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
	// Token: 0x02005D0D RID: 23821
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeMonsterHeadStateView : BattleChildView
	{
		// Token: 0x0603C5DD RID: 247261 RVA: 0x00E7710C File Offset: 0x00E7530C
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

		// Token: 0x0603C5DE RID: 247262 RVA: 0x00E775EC File Offset: 0x00E757EC
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

		// Token: 0x0603C5DF RID: 247263 RVA: 0x00E776B8 File Offset: 0x00E758B8
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

		// Token: 0x0603C5E0 RID: 247264 RVA: 0x00E77714 File Offset: 0x00E75914
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

		// Token: 0x0603C5E1 RID: 247265 RVA: 0x00E77768 File Offset: 0x00E75968
		protected override void OnBeforeShow()
		{
			this.RefreshInner();
			this.VisibleMachine.SetVisible(true, 667f);
		}

		// Token: 0x0603C5E2 RID: 247266 RVA: 0x00E77781 File Offset: 0x00E75981
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

		// Token: 0x0603C5E3 RID: 247267 RVA: 0x00E777A3 File Offset: 0x00E759A3
		private void RefreshInner()
		{
			this.RefreshBossLevel();
			this.RefreshBossName();
			this.RefreshHp(false);
			this.RefreshBuff();
			this.RefreshExtraItem();
		}

		// Token: 0x0603C5E4 RID: 247268 RVA: 0x00E777C4 File Offset: 0x00E759C4
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.HpParentWidth = base.GetItem(8).GetParentAsUIItem().GetWidth();
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/LGUI/MPC_UIShader.MPC_UIShader", delegate([Nullable(2)] UMaterialParameterCollection collection, string _)
			{
				this.GlobalShaderCollection = collection;
			}, 103, "js_undefined");
		}

		// Token: 0x0603C5E5 RID: 247269 RVA: 0x00E77812 File Offset: 0x00E75A12
		public void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x0603C5E6 RID: 247270 RVA: 0x00E7781B File Offset: 0x00E75A1B
		public void OnLanguageChange()
		{
			this.RefreshBossName();
		}

		// Token: 0x0603C5E7 RID: 247271 RVA: 0x00E77824 File Offset: 0x00E75A24
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

		// Token: 0x0603C5E8 RID: 247272 RVA: 0x00E778BC File Offset: 0x00E75ABC
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

		// Token: 0x0603C5E9 RID: 247273 RVA: 0x00E77914 File Offset: 0x00E75B14
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

		// Token: 0x0603C5EA RID: 247274 RVA: 0x00E779A0 File Offset: 0x00E75BA0
		private void PlayHitEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, MergeMonsterHeadStateView.RgbSplitProgress, param);
			}
		}

		// Token: 0x0603C5EB RID: 247275 RVA: 0x00E779C5 File Offset: 0x00E75BC5
		private void StopBarLerpAnimation()
		{
			base.GetItem(8).SetUIActive(false);
			this.HpStateMachine.Reset();
			this.IsPlayingHpBarAnim = false;
		}

		// Token: 0x0603C5EC RID: 247276 RVA: 0x00E779E6 File Offset: 0x00E75BE6
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(7).SetFillAmount(percent);
		}

		// Token: 0x0603C5ED RID: 247277 RVA: 0x00E779F8 File Offset: 0x00E75BF8
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

		// Token: 0x0603C5EE RID: 247278 RVA: 0x00E77A59 File Offset: 0x00E75C59
		private void RefreshBossLevel()
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603C5EF RID: 247279 RVA: 0x00E77A70 File Offset: 0x00E75C70
		private void RefreshBossName()
		{
			string monsterGroupName = this.Info.MonsterGroupName;
			base.GetText(1).SetText((!string.IsNullOrEmpty(monsterGroupName)) ? PublicUtil.Instance.GetConfigTextByKey(monsterGroupName) : string.Empty, true);
		}

		// Token: 0x0603C5F0 RID: 247280 RVA: 0x00E77AB0 File Offset: 0x00E75CB0
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

		// Token: 0x0603C5F1 RID: 247281 RVA: 0x00E77AF0 File Offset: 0x00E75CF0
		private void RefreshExtraItem()
		{
			UUIItem item = base.GetItem(32);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603C5F2 RID: 247282 RVA: 0x00E77B05 File Offset: 0x00E75D05
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x0603C5F3 RID: 247283 RVA: 0x00E77B18 File Offset: 0x00E75D18
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

		// Token: 0x0603C5F4 RID: 247284 RVA: 0x00E77B98 File Offset: 0x00E75D98
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

		// Token: 0x0603C5F5 RID: 247285 RVA: 0x00E77BF4 File Offset: 0x00E75DF4
		public void HideWithAnim()
		{
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x0603C5F6 RID: 247286 RVA: 0x00E77C07 File Offset: 0x00E75E07
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.Hide(null);
			}
		}

		// Token: 0x0603C5F7 RID: 247287 RVA: 0x00E77C14 File Offset: 0x00E75E14
		private void OnPlayVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.PlaySequencePurely(visible ? "ShowView" : "CloseView", false, false, null, null, false);
		}

		// Token: 0x0603C5F8 RID: 247288 RVA: 0x00E77C48 File Offset: 0x00E75E48
		private void OnStopVisibleAnim(bool visible)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x0603C5F9 RID: 247289 RVA: 0x00E77C57 File Offset: 0x00E75E57
		[NullableContext(1)]
		public string GetResourceId()
		{
			return "UiItem_BossState_Prefab";
		}

		// Token: 0x0401F734 RID: 128820
		[StaticVariableRuleIgnore]
		private static readonly FName RgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401F735 RID: 128821
		private const float SHOW_VIEW_ANIM_TIME = 667f;

		// Token: 0x0401F736 RID: 128822
		private const float CLOSE_VIEW_ANIM_TIME = 167f;

		// Token: 0x0401F737 RID: 128823
		private const int MAX_BUFF_ITEM_COUNT = 12;

		// Token: 0x0401F738 RID: 128824
		public MergeHeadStateInfo Info;

		// Token: 0x0401F739 RID: 128825
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F73A RID: 128826
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401F73B RID: 128827
		private float HitLargePercent;

		// Token: 0x0401F73C RID: 128828
		private float CurrentBarPercent = 1f;

		// Token: 0x0401F73D RID: 128829
		[Nullable(1)]
		private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

		// Token: 0x0401F73E RID: 128830
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401F73F RID: 128831
		private float HitEffectCountdown = -1f;

		// Token: 0x0401F740 RID: 128832
		private float HitEffectDuration;

		// Token: 0x0401F741 RID: 128833
		private float HpParentWidth;

		// Token: 0x0401F742 RID: 128834
		private bool IsPlayingHpBarAnim;

		// Token: 0x0401F743 RID: 128835
		[Nullable(1)]
		private readonly BuffItemSimpleContainer BuffItemContainer = new BuffItemSimpleContainer();

		// Token: 0x0401F744 RID: 128836
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200BF87 RID: 49031
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039C35 RID: 236597
			BossLevelText,
			// Token: 0x04039C36 RID: 236598
			BossNameText,
			// Token: 0x04039C37 RID: 236599
			RageItem,
			// Token: 0x04039C38 RID: 236600
			ToughBg,
			// Token: 0x04039C39 RID: 236601
			RageBar,
			// Token: 0x04039C3A RID: 236602
			HpShieldBarItem,
			// Token: 0x04039C3B RID: 236603
			HpBarItem,
			// Token: 0x04039C3C RID: 236604
			NormalHpBarSprite,
			// Token: 0x04039C3D RID: 236605
			BarBufferCanvas,
			// Token: 0x04039C3E RID: 236606
			BarBufferSprite,
			// Token: 0x04039C3F RID: 236607
			ShieldBarSprite,
			// Token: 0x04039C40 RID: 236608
			ToughItem,
			// Token: 0x04039C41 RID: 236609
			MaxHardnessEffect,
			// Token: 0x04039C42 RID: 236610
			BuffHorizontalItem,
			// Token: 0x04039C43 RID: 236611
			HpLight,
			// Token: 0x04039C44 RID: 236612
			HardnessNormal,
			// Token: 0x04039C45 RID: 236613
			HardnessBreak,
			// Token: 0x04039C46 RID: 236614
			FallDownItem,
			// Token: 0x04039C47 RID: 236615
			FallDownBar,
			// Token: 0x04039C48 RID: 236616
			FallDownBarSign,
			// Token: 0x04039C49 RID: 236617
			RageReduceLittle,
			// Token: 0x04039C4A RID: 236618
			HpFlicker,
			// Token: 0x04039C4B RID: 236619
			RageReduceLargeCanvas,
			// Token: 0x04039C4C RID: 236620
			RageReduceLarge,
			// Token: 0x04039C4D RID: 236621
			RageEmpty,
			// Token: 0x04039C4E RID: 236622
			AnimSmallHit,
			// Token: 0x04039C4F RID: 236623
			AnimBigHit,
			// Token: 0x04039C50 RID: 236624
			AnimToughStart,
			// Token: 0x04039C51 RID: 236625
			AnimToughHit,
			// Token: 0x04039C52 RID: 236626
			AnimToughFlick,
			// Token: 0x04039C53 RID: 236627
			AnimToughClose,
			// Token: 0x04039C54 RID: 236628
			AnimBreak,
			// Token: 0x04039C55 RID: 236629
			MoraleLevelItem,
			// Token: 0x04039C56 RID: 236630
			BloodModeIcon,
			// Token: 0x04039C57 RID: 236631
			WeaknessContainer,
			// Token: 0x04039C58 RID: 236632
			HpWeaknessNode,
			// Token: 0x04039C59 RID: 236633
			HpWeaknessSprite1,
			// Token: 0x04039C5A RID: 236634
			HpWeaknessSprite2,
			// Token: 0x04039C5B RID: 236635
			HpWeaknessSprite3,
			// Token: 0x04039C5C RID: 236636
			HpWeaknessEffect,
			// Token: 0x04039C5D RID: 236637
			AniHpWeaknessFull,
			// Token: 0x04039C5E RID: 236638
			AniHpWeaknessBreak
		}
	}
}
