using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041CA RID: 16842
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BattleCardComponent : CardComponentBase<PhantomCardData>, IBattleCardComponent
	{
		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x0602A9ED RID: 174573 RVA: 0x00C03BC3 File Offset: 0x00C01DC3
		// (set) Token: 0x0602A9EE RID: 174574 RVA: 0x00C03BCB File Offset: 0x00C01DCB
		public Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x0602A9EF RID: 174575 RVA: 0x00C03BD4 File Offset: 0x00C01DD4
		// (set) Token: 0x0602A9F0 RID: 174576 RVA: 0x00C03BDC File Offset: 0x00C01DDC
		public UiSequencePlayer RootUiSequencePlayer { get; set; }

		// Token: 0x0602A9F1 RID: 174577 RVA: 0x00C03BE8 File Offset: 0x00C01DE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.CardClick))
			};
		}

		// Token: 0x0602A9F2 RID: 174578 RVA: 0x00C03DFD File Offset: 0x00C01FFD
		private void CardClick(EToggleState state)
		{
			Action<EToggleState> cardClickCallback = this.CardClickCallback;
			if (cardClickCallback == null)
			{
				return;
			}
			cardClickCallback(state);
		}

		// Token: 0x0602A9F3 RID: 174579 RVA: 0x00C03E10 File Offset: 0x00C02010
		protected UniTask InitElement()
		{
			BattleCardComponent.<InitElement>d__19 <InitElement>d__;
			<InitElement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitElement>d__.<>4__this = this;
			<InitElement>d__.<>1__state = -1;
			<InitElement>d__.<>t__builder.Start<BattleCardComponent.<InitElement>d__19>(ref <InitElement>d__);
			return <InitElement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A9F4 RID: 174580 RVA: 0x00C03E54 File Offset: 0x00C02054
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardComponent.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardComponent.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A9F5 RID: 174581 RVA: 0x00C03E97 File Offset: 0x00C02097
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(base.GetItem(2));
		}

		// Token: 0x0602A9F6 RID: 174582 RVA: 0x00C03EAB File Offset: 0x00C020AB
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602A9F7 RID: 174583 RVA: 0x00C03EB8 File Offset: 0x00C020B8
		private void RefreshCardAttrLogic(PhantomBattleCardAttr type, UUIText text)
		{
			int fightValueByAttr = this.Data.GetFightValueByAttr(type);
			EPhantomArenaCardValueChangeType ephantomArenaCardValueChangeType = this.Data.ValueChangeTypeByBuff(type);
			if (ephantomArenaCardValueChangeType == EPhantomArenaCardValueChangeType.None)
			{
				text.SetText(fightValueByAttr.ToString(), true);
				return;
			}
			if (ephantomArenaCardValueChangeType == EPhantomArenaCardValueChangeType.Add)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1101", new <>z__ReadOnlySingleElementList<object>(fightValueByAttr));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1102", new <>z__ReadOnlySingleElementList<object>(fightValueByAttr));
		}

		// Token: 0x0602A9F8 RID: 174584 RVA: 0x00C03F2C File Offset: 0x00C0212C
		private void RefreshAttack()
		{
			UUIText text = base.GetText(1);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.AttackAbility, text);
		}

		// Token: 0x0602A9F9 RID: 174585 RVA: 0x00C03F4C File Offset: 0x00C0214C
		private void RefreshHealth()
		{
			UUIText text = base.GetText(3);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.LifeAbility, text);
		}

		// Token: 0x0602A9FA RID: 174586 RVA: 0x00C03F6C File Offset: 0x00C0216C
		private void RefreshCost()
		{
			UUIText text = base.GetText(4);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.CostAbility, text);
		}

		// Token: 0x0602A9FB RID: 174587 RVA: 0x00C03F8C File Offset: 0x00C0218C
		private void RefreshElement()
		{
			int element = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId).Element;
			this.ElementItem.Refresh((ECardElement)element, false, 0);
		}

		// Token: 0x0602A9FC RID: 174588 RVA: 0x00C03FC5 File Offset: 0x00C021C5
		private void RefreshItem()
		{
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(!this.Data.IsFourCost);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.Data.IsFourCost);
		}

		// Token: 0x0602A9FD RID: 174589 RVA: 0x00C04008 File Offset: 0x00C02208
		private void RefreshElementFrame()
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId);
			bool flag = this.IsOutlookUnlocked();
			base.GetItem(10).SetUIActive(phantomBattleCardConfig.Element != 0 && !flag);
			base.GetItem(17).SetUIActive(phantomBattleCardConfig.Element != 0 && flag);
		}

		// Token: 0x0602A9FE RID: 174590 RVA: 0x00C04068 File Offset: 0x00C02268
		private void RefreshCardFrame()
		{
			bool flag = this.IsOutlookUnlocked();
			base.GetItem(15).SetUIActive(!flag);
			base.GetItem(16).SetUIActive(flag);
		}

		// Token: 0x0602A9FF RID: 174591 RVA: 0x00C0409C File Offset: 0x00C0229C
		private UniTask RefreshCardFaceAsync()
		{
			BattleCardComponent.<RefreshCardFaceAsync>d__31 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<BattleCardComponent.<RefreshCardFaceAsync>d__31>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA00 RID: 174592 RVA: 0x00C040E0 File Offset: 0x00C022E0
		private UniTask RefreshGoldEvolveItem()
		{
			BattleCardComponent.<RefreshGoldEvolveItem>d__32 <RefreshGoldEvolveItem>d__;
			<RefreshGoldEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshGoldEvolveItem>d__.<>4__this = this;
			<RefreshGoldEvolveItem>d__.<>1__state = -1;
			<RefreshGoldEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshGoldEvolveItem>d__32>(ref <RefreshGoldEvolveItem>d__);
			return <RefreshGoldEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA01 RID: 174593 RVA: 0x00C04124 File Offset: 0x00C02324
		private UniTask RefreshNormalEvolveItem()
		{
			BattleCardComponent.<RefreshNormalEvolveItem>d__33 <RefreshNormalEvolveItem>d__;
			<RefreshNormalEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNormalEvolveItem>d__.<>4__this = this;
			<RefreshNormalEvolveItem>d__.<>1__state = -1;
			<RefreshNormalEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshNormalEvolveItem>d__33>(ref <RefreshNormalEvolveItem>d__);
			return <RefreshNormalEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA02 RID: 174594 RVA: 0x00C04168 File Offset: 0x00C02368
		private void RefreshLightItem()
		{
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(this.Data.UseCost != 0);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(this.Data.UseCost >= 1);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(this.Data.UseCost >= 3);
			}
			UUIItem item4 = base.GetItem(20);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(this.Data.UseCost >= 3);
		}

		// Token: 0x0602AA03 RID: 174595 RVA: 0x00C04200 File Offset: 0x00C02400
		private UniTask RefreshEvolveItem()
		{
			BattleCardComponent.<RefreshEvolveItem>d__35 <RefreshEvolveItem>d__;
			<RefreshEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEvolveItem>d__.<>4__this = this;
			<RefreshEvolveItem>d__.<>1__state = -1;
			<RefreshEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshEvolveItem>d__35>(ref <RefreshEvolveItem>d__);
			return <RefreshEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA04 RID: 174596 RVA: 0x00C04243 File Offset: 0x00C02443
		public void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x0602AA05 RID: 174597 RVA: 0x00C0424C File Offset: 0x00C0244C
		private bool IsOutlookUnlocked()
		{
			return !this.Data.IsNpcCard && PhantomArenaModel.Instance.IsCardOutlookUnlock(this.Data.ConfigId);
		}

		// Token: 0x0602AA06 RID: 174598 RVA: 0x00C04274 File Offset: 0x00C02474
		private UniTask InitLoopEffect()
		{
			BattleCardComponent.<InitLoopEffect>d__38 <InitLoopEffect>d__;
			<InitLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopEffect>d__.<>4__this = this;
			<InitLoopEffect>d__.<>1__state = -1;
			<InitLoopEffect>d__.<>t__builder.Start<BattleCardComponent.<InitLoopEffect>d__38>(ref <InitLoopEffect>d__);
			return <InitLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA07 RID: 174599 RVA: 0x00C042B8 File Offset: 0x00C024B8
		private UniTask InitStartEffect()
		{
			BattleCardComponent.<InitStartEffect>d__39 <InitStartEffect>d__;
			<InitStartEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStartEffect>d__.<>4__this = this;
			<InitStartEffect>d__.<>1__state = -1;
			<InitStartEffect>d__.<>t__builder.Start<BattleCardComponent.<InitStartEffect>d__39>(ref <InitStartEffect>d__);
			return <InitStartEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA08 RID: 174600 RVA: 0x00C042FC File Offset: 0x00C024FC
		public UniTask InitEffect()
		{
			BattleCardComponent.<InitEffect>d__40 <InitEffect>d__;
			<InitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEffect>d__.<>4__this = this;
			<InitEffect>d__.<>1__state = -1;
			<InitEffect>d__.<>t__builder.Start<BattleCardComponent.<InitEffect>d__40>(ref <InitEffect>d__);
			return <InitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA09 RID: 174601 RVA: 0x00C04340 File Offset: 0x00C02540
		public UniTask InitSpine()
		{
			BattleCardComponent.<InitSpine>d__41 <InitSpine>d__;
			<InitSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSpine>d__.<>4__this = this;
			<InitSpine>d__.<>1__state = -1;
			<InitSpine>d__.<>t__builder.Start<BattleCardComponent.<InitSpine>d__41>(ref <InitSpine>d__);
			return <InitSpine>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA0A RID: 174602 RVA: 0x00C04384 File Offset: 0x00C02584
		public void SetDebugText()
		{
			UUIText text = base.GetText(9);
			if (!GlobalData.IsPlayInEditor)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			List<int> list = new List<int>(phantomBattleCardConfig.CardFactorId());
			list.AddRange(this.Data.ExtraFactors);
			if (text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 8);
				defaultInterpolatedStringHandler.AppendLiteral("卡牌ID:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.CardId);
				defaultInterpolatedStringHandler.AppendLiteral("\n配置ID:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.ConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("\n进化次数:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.EvolveNum);
				defaultInterpolatedStringHandler.AppendLiteral("\n被动技能Id:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int[]>(phantomBattleCardConfig.GetPassiveSkillIdArray());
				defaultInterpolatedStringHandler.AppendLiteral("\n主动技能Id:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomBattleCardConfig.ActiveSkillId);
				defaultInterpolatedStringHandler.AppendLiteral("\n卡牌因子:  ");
				defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(", ", list));
				defaultInterpolatedStringHandler.AppendLiteral("\n实体配置Id:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomBattleCardConfig.EntityConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("\n卡牌上阵倾向:  ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomBattleCardConfig.SlotTendency);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x0602AA0B RID: 174603 RVA: 0x00C044E8 File Offset: 0x00C026E8
		public void PlaySpineAnim(string animName, bool isLoop)
		{
			BattleCardSpineItem spineItem = this.SpineItem;
			if (spineItem == null)
			{
				return;
			}
			spineItem.PlaySpineAnim(animName, isLoop);
		}

		// Token: 0x0602AA0C RID: 174604 RVA: 0x00C044FC File Offset: 0x00C026FC
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x0602AA0D RID: 174605 RVA: 0x00C0450C File Offset: 0x00C0270C
		public UniTask RefreshAsync(PhantomCardData data)
		{
			BattleCardComponent.<RefreshAsync>d__45 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<BattleCardComponent.<RefreshAsync>d__45>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA0E RID: 174606 RVA: 0x00C04557 File Offset: 0x00C02757
		public UUIExtendToggle GetCardToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602AA0F RID: 174607 RVA: 0x00C04560 File Offset: 0x00C02760
		public UUIItem GetTweenItem()
		{
			return base.GetItem(12);
		}

		// Token: 0x0602AA10 RID: 174608 RVA: 0x00C0456A File Offset: 0x00C0276A
		public void PlaySequence(string name)
		{
			if (this.Sequence.IsSequenceInPlaying(name))
			{
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(name, false, false);
		}

		// Token: 0x0602AA11 RID: 174609 RVA: 0x00C04596 File Offset: 0x00C02796
		public void PlayEffect()
		{
			BattleCardEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.PlayStartEffect();
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x0602AA12 RID: 174610 RVA: 0x00C045A8 File Offset: 0x00C027A8
		// (set) Token: 0x0602AA13 RID: 174611 RVA: 0x00C045B0 File Offset: 0x00C027B0
		public Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x040171C2 RID: 94658
		private CardElementItem ElementItem;

		// Token: 0x040171C3 RID: 94659
		protected UiSequencePlayer Sequence;

		// Token: 0x040171C5 RID: 94661
		protected PhantomCardData Data;

		// Token: 0x040171C6 RID: 94662
		protected BattleCardLoopEffectItem LoopEffectItem;

		// Token: 0x040171C7 RID: 94663
		protected BattleCardEffectItem EffectItem;

		// Token: 0x040171C8 RID: 94664
		protected BattleCardSpineItem SpineItem;

		// Token: 0x040171C9 RID: 94665
		protected EvolveProxy NormalEvolveItem;

		// Token: 0x040171CA RID: 94666
		protected EvolveProxy GoldEvolveItem;

		// Token: 0x02009DBA RID: 40378
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x040310D2 RID: 200914
			public const int Toggle = 0;

			// Token: 0x040310D3 RID: 200915
			public const int AttackText = 1;

			// Token: 0x040310D4 RID: 200916
			public const int ContentItem = 2;

			// Token: 0x040310D5 RID: 200917
			public const int HealthText = 3;

			// Token: 0x040310D6 RID: 200918
			public const int CostText = 4;

			// Token: 0x040310D7 RID: 200919
			public const int MiddleHighLightItem = 5;

			// Token: 0x040310D8 RID: 200920
			public const int LeftHighLightItem = 6;

			// Token: 0x040310D9 RID: 200921
			public const int ElementItem = 7;

			// Token: 0x040310DA RID: 200922
			public const int CardFaceTexture = 8;

			// Token: 0x040310DB RID: 200923
			public const int DebugText = 9;

			// Token: 0x040310DC RID: 200924
			public const int NormalElementFrameItem = 10;

			// Token: 0x040310DD RID: 200925
			public const int AttachItem = 11;

			// Token: 0x040310DE RID: 200926
			public const int TweenItem = 12;

			// Token: 0x040310DF RID: 200927
			public const int GreenItem = 13;

			// Token: 0x040310E0 RID: 200928
			public const int RedItem = 14;

			// Token: 0x040310E1 RID: 200929
			public const int NormalCardFrameItem = 15;

			// Token: 0x040310E2 RID: 200930
			public const int GoldCardFrameItem = 16;

			// Token: 0x040310E3 RID: 200931
			public const int GoldElementFrameItem = 17;

			// Token: 0x040310E4 RID: 200932
			public const int SpineAttachItem = 18;

			// Token: 0x040310E5 RID: 200933
			public const int LightBgItem = 19;

			// Token: 0x040310E6 RID: 200934
			public const int RightHighLightItem = 20;
		}
	}
}
