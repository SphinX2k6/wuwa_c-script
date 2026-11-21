using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041D1 RID: 16849
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewBattleCardComponent : CardComponentBase<PhantomCardData>, IBattleCardComponent
	{
		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x0602AA45 RID: 174661 RVA: 0x00C04B66 File Offset: 0x00C02D66
		// (set) Token: 0x0602AA46 RID: 174662 RVA: 0x00C04B6E File Offset: 0x00C02D6E
		public Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x0602AA47 RID: 174663 RVA: 0x00C04B77 File Offset: 0x00C02D77
		// (set) Token: 0x0602AA48 RID: 174664 RVA: 0x00C04B7F File Offset: 0x00C02D7F
		public UiSequencePlayer RootUiSequencePlayer { get; set; }

		// Token: 0x0602AA49 RID: 174665 RVA: 0x00C04B88 File Offset: 0x00C02D88
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
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIText)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.CardClick))
			};
		}

		// Token: 0x0602AA4A RID: 174666 RVA: 0x00C04DE2 File Offset: 0x00C02FE2
		private void CardClick(EToggleState state)
		{
			Action<EToggleState> cardClickCallback = this.CardClickCallback;
			if (cardClickCallback == null)
			{
				return;
			}
			cardClickCallback(state);
		}

		// Token: 0x0602AA4B RID: 174667 RVA: 0x00C04DF8 File Offset: 0x00C02FF8
		protected UniTask InitElement()
		{
			NewBattleCardComponent.<InitElement>d__20 <InitElement>d__;
			<InitElement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitElement>d__.<>4__this = this;
			<InitElement>d__.<>1__state = -1;
			<InitElement>d__.<>t__builder.Start<NewBattleCardComponent.<InitElement>d__20>(ref <InitElement>d__);
			return <InitElement>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA4C RID: 174668 RVA: 0x00C04E3C File Offset: 0x00C0303C
		private UniTask InitLoopEffect()
		{
			NewBattleCardComponent.<InitLoopEffect>d__21 <InitLoopEffect>d__;
			<InitLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopEffect>d__.<>4__this = this;
			<InitLoopEffect>d__.<>1__state = -1;
			<InitLoopEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitLoopEffect>d__21>(ref <InitLoopEffect>d__);
			return <InitLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA4D RID: 174669 RVA: 0x00C04E80 File Offset: 0x00C03080
		private UniTask InitStartEffect()
		{
			NewBattleCardComponent.<InitStartEffect>d__22 <InitStartEffect>d__;
			<InitStartEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStartEffect>d__.<>4__this = this;
			<InitStartEffect>d__.<>1__state = -1;
			<InitStartEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitStartEffect>d__22>(ref <InitStartEffect>d__);
			return <InitStartEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA4E RID: 174670 RVA: 0x00C04EC4 File Offset: 0x00C030C4
		private UniTask InitHitLocationCurveX()
		{
			NewBattleCardComponent.<InitHitLocationCurveX>d__23 <InitHitLocationCurveX>d__;
			<InitHitLocationCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHitLocationCurveX>d__.<>4__this = this;
			<InitHitLocationCurveX>d__.<>1__state = -1;
			<InitHitLocationCurveX>d__.<>t__builder.Start<NewBattleCardComponent.<InitHitLocationCurveX>d__23>(ref <InitHitLocationCurveX>d__);
			return <InitHitLocationCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA4F RID: 174671 RVA: 0x00C04F08 File Offset: 0x00C03108
		private UniTask InitHitLocationCurveY()
		{
			NewBattleCardComponent.<InitHitLocationCurveY>d__24 <InitHitLocationCurveY>d__;
			<InitHitLocationCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHitLocationCurveY>d__.<>4__this = this;
			<InitHitLocationCurveY>d__.<>1__state = -1;
			<InitHitLocationCurveY>d__.<>t__builder.Start<NewBattleCardComponent.<InitHitLocationCurveY>d__24>(ref <InitHitLocationCurveY>d__);
			return <InitHitLocationCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA50 RID: 174672 RVA: 0x00C04F4C File Offset: 0x00C0314C
		protected override UniTask OnBeforeStartAsync()
		{
			NewBattleCardComponent.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewBattleCardComponent.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA51 RID: 174673 RVA: 0x00C04F90 File Offset: 0x00C03190
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(base.GetItem(2));
			UUIItem item = base.GetItem(22);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.TweenLogic = new PhantomArenaCardTweenLogic();
			this.TweenLogic.Init(base.GetItem(23));
			this.PlayHitEffect = new Func<UUIItem, UniTask>(this.PlayHitEffectInternal);
		}

		// Token: 0x0602AA52 RID: 174674 RVA: 0x00C04FF3 File Offset: 0x00C031F3
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.TweenLogic.Destroy();
		}

		// Token: 0x0602AA53 RID: 174675 RVA: 0x00C0500C File Offset: 0x00C0320C
		private void RefreshCardAttrLogic(PhantomBattleCardAttr type, UUIText text, [Nullable(2)] string sequenceName = null)
		{
			int fightValueByAttr = this.Data.GetFightValueByAttr(type);
			EPhantomArenaCardValueChangeType ephantomArenaCardValueChangeType = this.Data.ValueChangeTypeByBuff(type);
			if (ephantomArenaCardValueChangeType == EPhantomArenaCardValueChangeType.None)
			{
				text.SetText(fightValueByAttr.ToString(), true);
				return;
			}
			if (sequenceName != null)
			{
				this.RootUiSequencePlayer.PlaySequence(sequenceName, false, null);
			}
			if (ephantomArenaCardValueChangeType == EPhantomArenaCardValueChangeType.Add)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1101", new <>z__ReadOnlySingleElementList<object>(fightValueByAttr));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1102", new <>z__ReadOnlySingleElementList<object>(fightValueByAttr));
		}

		// Token: 0x0602AA54 RID: 174676 RVA: 0x00C0509C File Offset: 0x00C0329C
		private void RefreshAttack()
		{
			UUIText text = base.GetText(1);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.AttackAbility, text, "NumUpChange");
		}

		// Token: 0x0602AA55 RID: 174677 RVA: 0x00C050C0 File Offset: 0x00C032C0
		private void RefreshHealth()
		{
			UUIText text = base.GetText(3);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.LifeAbility, text, "NumDownChange");
		}

		// Token: 0x0602AA56 RID: 174678 RVA: 0x00C050E4 File Offset: 0x00C032E4
		private void RefreshCost()
		{
			UUIText text = base.GetText(4);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.CostAbility, text, "NumDamageChange");
		}

		// Token: 0x0602AA57 RID: 174679 RVA: 0x00C05108 File Offset: 0x00C03308
		private void RefreshElement()
		{
			if (this.Data.IsInFight && this.Data.HasClickActiveSkill)
			{
				UUIItem item = base.GetItem(8);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				ECardElement element = (ECardElement)PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId).Element;
				if (element != ECardElement.Physical)
				{
					UUIItem item2 = base.GetItem(8);
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
					this.ElementItem.Refresh(element, false, 0);
					return;
				}
				UUIItem item3 = base.GetItem(8);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0602AA58 RID: 174680 RVA: 0x00C05197 File Offset: 0x00C03397
		private void RefreshItem()
		{
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(!this.Data.IsFourCost);
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.Data.IsFourCost);
		}

		// Token: 0x0602AA59 RID: 174681 RVA: 0x00C051D8 File Offset: 0x00C033D8
		private void RefreshCostItem()
		{
			bool isField = this.Data.IsField;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(!isField);
			}
			if (!isField)
			{
				this.RefreshLightItem();
			}
		}

		// Token: 0x0602AA5A RID: 174682 RVA: 0x00C05214 File Offset: 0x00C03414
		private void RefreshLightItem()
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(this.Data.UseCost >= 1);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(this.Data.UseCost >= 3);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(this.Data.UseCost >= 3);
		}

		// Token: 0x0602AA5B RID: 174683 RVA: 0x00C0528C File Offset: 0x00C0348C
		private void RefreshCardItem()
		{
			bool isNormal = this.Data.IsNormal;
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(isNormal);
			}
			if (!isNormal)
			{
				return;
			}
			this.RefreshAttack();
			this.RefreshHealth();
			this.RefreshCost();
		}

		// Token: 0x0602AA5C RID: 174684 RVA: 0x00C052D0 File Offset: 0x00C034D0
		private void RefreshFieldItem()
		{
			bool isField = this.Data.IsField;
			UUIItem item = base.GetItem(19);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isField);
		}

		// Token: 0x0602AA5D RID: 174685 RVA: 0x00C052FC File Offset: 0x00C034FC
		private void RefreshToolItem()
		{
			bool isTool = this.Data.IsTool;
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(isTool);
			}
			if (isTool)
			{
				UUIText text = base.GetText(21);
				if (text == null)
				{
					return;
				}
				text.SetText(this.Data.Durable.ToString(), true);
			}
		}

		// Token: 0x0602AA5E RID: 174686 RVA: 0x00C05354 File Offset: 0x00C03554
		private UniTask RefreshCardFaceAsync()
		{
			NewBattleCardComponent.<RefreshCardFaceAsync>d__39 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<NewBattleCardComponent.<RefreshCardFaceAsync>d__39>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA5F RID: 174687 RVA: 0x00C05398 File Offset: 0x00C03598
		private void RefreshEvolveItem()
		{
			int evolveNum = this.Data.EvolveNum;
			UUIItem item = base.GetItem(22);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(evolveNum != 0);
		}

		// Token: 0x0602AA60 RID: 174688 RVA: 0x00C053C7 File Offset: 0x00C035C7
		public void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x0602AA61 RID: 174689 RVA: 0x00C053D0 File Offset: 0x00C035D0
		public UniTask InitEffect()
		{
			NewBattleCardComponent.<InitEffect>d__42 <InitEffect>d__;
			<InitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEffect>d__.<>4__this = this;
			<InitEffect>d__.<>1__state = -1;
			<InitEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitEffect>d__42>(ref <InitEffect>d__);
			return <InitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA62 RID: 174690 RVA: 0x00C05414 File Offset: 0x00C03614
		public UniTask InitSpine()
		{
			NewBattleCardComponent.<InitSpine>d__43 <InitSpine>d__;
			<InitSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSpine>d__.<>4__this = this;
			<InitSpine>d__.<>1__state = -1;
			<InitSpine>d__.<>t__builder.Start<NewBattleCardComponent.<InitSpine>d__43>(ref <InitSpine>d__);
			return <InitSpine>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA63 RID: 174691 RVA: 0x00C05458 File Offset: 0x00C03658
		public void SetDebugText()
		{
			UUIText text = base.GetText(12);
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

		// Token: 0x0602AA64 RID: 174692 RVA: 0x00C055BC File Offset: 0x00C037BC
		public void PlaySpineAnim(string animName, bool isLoop)
		{
			BattleCardSpineItem spineItem = this.SpineItem;
			if (spineItem == null)
			{
				return;
			}
			spineItem.PlaySpineAnim(animName, isLoop);
		}

		// Token: 0x0602AA65 RID: 174693 RVA: 0x00C055D0 File Offset: 0x00C037D0
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x0602AA66 RID: 174694 RVA: 0x00C055E0 File Offset: 0x00C037E0
		public UniTask RefreshAsync(PhantomCardData data)
		{
			NewBattleCardComponent.<RefreshAsync>d__47 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<NewBattleCardComponent.<RefreshAsync>d__47>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA67 RID: 174695 RVA: 0x00C0562B File Offset: 0x00C0382B
		public UUIExtendToggle GetCardToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602AA68 RID: 174696 RVA: 0x00C05634 File Offset: 0x00C03834
		public UUIItem GetTweenItem()
		{
			return base.GetItem(14);
		}

		// Token: 0x0602AA69 RID: 174697 RVA: 0x00C0563E File Offset: 0x00C0383E
		public void PlaySequence(string name)
		{
			if (this.Sequence.IsSequenceInPlaying(name))
			{
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(name, false, false);
		}

		// Token: 0x0602AA6A RID: 174698 RVA: 0x00C0566A File Offset: 0x00C0386A
		public void PlayEffect()
		{
			BattleCardEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.PlayStartEffect();
		}

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x0602AA6B RID: 174699 RVA: 0x00C0567C File Offset: 0x00C0387C
		// (set) Token: 0x0602AA6C RID: 174700 RVA: 0x00C05684 File Offset: 0x00C03884
		public Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x0602AA6D RID: 174701 RVA: 0x00C05690 File Offset: 0x00C03890
		private UniTask PlayHitEffectInternal(UUIItem toItem)
		{
			NewBattleCardComponent.<PlayHitEffectInternal>d__56 <PlayHitEffectInternal>d__;
			<PlayHitEffectInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHitEffectInternal>d__.<>4__this = this;
			<PlayHitEffectInternal>d__.toItem = toItem;
			<PlayHitEffectInternal>d__.<>1__state = -1;
			<PlayHitEffectInternal>d__.<>t__builder.Start<NewBattleCardComponent.<PlayHitEffectInternal>d__56>(ref <PlayHitEffectInternal>d__);
			return <PlayHitEffectInternal>d__.<>t__builder.Task;
		}

		// Token: 0x040171D2 RID: 94674
		private CardElementItem ElementItem;

		// Token: 0x040171D3 RID: 94675
		protected UiSequencePlayer Sequence;

		// Token: 0x040171D5 RID: 94677
		protected PhantomCardData Data;

		// Token: 0x040171D6 RID: 94678
		protected BattleCardLoopEffectItem LoopEffectItem;

		// Token: 0x040171D7 RID: 94679
		protected BattleCardEffectItem EffectItem;

		// Token: 0x040171D8 RID: 94680
		protected BattleCardSpineItem SpineItem;

		// Token: 0x040171D9 RID: 94681
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x040171DA RID: 94682
		protected UCurveFloat HitLocationCurveX;

		// Token: 0x040171DB RID: 94683
		protected UCurveFloat HitLocationCurveY;

		// Token: 0x02009DD6 RID: 40406
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04031157 RID: 201047
			public const int Toggle = 0;

			// Token: 0x04031158 RID: 201048
			public const int AttackText = 1;

			// Token: 0x04031159 RID: 201049
			public const int ContentItem = 2;

			// Token: 0x0403115A RID: 201050
			public const int HealthText = 3;

			// Token: 0x0403115B RID: 201051
			public const int CostText = 4;

			// Token: 0x0403115C RID: 201052
			public const int MiddleHighLightItem = 5;

			// Token: 0x0403115D RID: 201053
			public const int LeftHighLightItem = 6;

			// Token: 0x0403115E RID: 201054
			public const int RightHighLightItem = 7;

			// Token: 0x0403115F RID: 201055
			public const int ElementItem = 8;

			// Token: 0x04031160 RID: 201056
			public const int ElementIconItem = 9;

			// Token: 0x04031161 RID: 201057
			public const int CostItem = 10;

			// Token: 0x04031162 RID: 201058
			public const int CardFaceTexture = 11;

			// Token: 0x04031163 RID: 201059
			public const int DebugText = 12;

			// Token: 0x04031164 RID: 201060
			public const int AttachItem = 13;

			// Token: 0x04031165 RID: 201061
			public const int TweenItem = 14;

			// Token: 0x04031166 RID: 201062
			public const int GreenItem = 15;

			// Token: 0x04031167 RID: 201063
			public const int RedItem = 16;

			// Token: 0x04031168 RID: 201064
			public const int SpineAttachItem = 17;

			// Token: 0x04031169 RID: 201065
			public const int NormalCardItem = 18;

			// Token: 0x0403116A RID: 201066
			public const int FieldCardItem = 19;

			// Token: 0x0403116B RID: 201067
			public const int ToolCardItem = 20;

			// Token: 0x0403116C RID: 201068
			public const int ToolCount = 21;

			// Token: 0x0403116D RID: 201069
			public const int EvolveItem = 22;

			// Token: 0x0403116E RID: 201070
			public const int HitItem = 23;
		}
	}
}
