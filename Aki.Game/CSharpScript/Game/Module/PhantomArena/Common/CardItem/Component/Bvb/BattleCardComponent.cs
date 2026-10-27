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
	// Token: 0x020051FA RID: 20986
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BattleCardComponent : CardComponentBase<PhantomCardData>, IBattleCardComponent
	{
		// Token: 0x170081F2 RID: 33266
		// (get) Token: 0x06035AF2 RID: 219890 RVA: 0x00CB6587 File Offset: 0x00CB4787
		// (set) Token: 0x06035AF3 RID: 219891 RVA: 0x00CB658F File Offset: 0x00CB478F
		public Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x170081F3 RID: 33267
		// (get) Token: 0x06035AF4 RID: 219892 RVA: 0x00CB6598 File Offset: 0x00CB4798
		// (set) Token: 0x06035AF5 RID: 219893 RVA: 0x00CB65A0 File Offset: 0x00CB47A0
		public UiSequencePlayer RootUiSequencePlayer { get; set; }

		// Token: 0x06035AF6 RID: 219894 RVA: 0x00CB65AC File Offset: 0x00CB47AC
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

		// Token: 0x06035AF7 RID: 219895 RVA: 0x00CB67C1 File Offset: 0x00CB49C1
		private void CardClick(EToggleState state)
		{
			Action<EToggleState> cardClickCallback = this.CardClickCallback;
			if (cardClickCallback == null)
			{
				return;
			}
			cardClickCallback(state);
		}

		// Token: 0x06035AF8 RID: 219896 RVA: 0x00CB67D4 File Offset: 0x00CB49D4
		protected UniTask InitElement()
		{
			BattleCardComponent.<InitElement>d__19 <InitElement>d__;
			<InitElement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitElement>d__.<>4__this = this;
			<InitElement>d__.<>1__state = -1;
			<InitElement>d__.<>t__builder.Start<BattleCardComponent.<InitElement>d__19>(ref <InitElement>d__);
			return <InitElement>d__.<>t__builder.Task;
		}

		// Token: 0x06035AF9 RID: 219897 RVA: 0x00CB6818 File Offset: 0x00CB4A18
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardComponent.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardComponent.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035AFA RID: 219898 RVA: 0x00CB685B File Offset: 0x00CB4A5B
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(base.GetItem(2));
		}

		// Token: 0x06035AFB RID: 219899 RVA: 0x00CB686F File Offset: 0x00CB4A6F
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035AFC RID: 219900 RVA: 0x00CB687C File Offset: 0x00CB4A7C
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

		// Token: 0x06035AFD RID: 219901 RVA: 0x00CB68F0 File Offset: 0x00CB4AF0
		private void RefreshAttack()
		{
			UUIText text = base.GetText(1);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.AttackAbility, text);
		}

		// Token: 0x06035AFE RID: 219902 RVA: 0x00CB6910 File Offset: 0x00CB4B10
		private void RefreshHealth()
		{
			UUIText text = base.GetText(3);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.LifeAbility, text);
		}

		// Token: 0x06035AFF RID: 219903 RVA: 0x00CB6930 File Offset: 0x00CB4B30
		private void RefreshCost()
		{
			UUIText text = base.GetText(4);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.CostAbility, text);
		}

		// Token: 0x06035B00 RID: 219904 RVA: 0x00CB6950 File Offset: 0x00CB4B50
		private void RefreshElement()
		{
			int element = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId).Element;
			this.ElementItem.Refresh((ECardElement)element, false, 0);
		}

		// Token: 0x06035B01 RID: 219905 RVA: 0x00CB6989 File Offset: 0x00CB4B89
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

		// Token: 0x06035B02 RID: 219906 RVA: 0x00CB69CC File Offset: 0x00CB4BCC
		private void RefreshElementFrame()
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.ConfigId);
			bool flag = this.IsOutlookUnlocked();
			base.GetItem(10).SetUIActive(phantomBattleCardConfig.Element != 0 && !flag);
			base.GetItem(17).SetUIActive(phantomBattleCardConfig.Element != 0 && flag);
		}

		// Token: 0x06035B03 RID: 219907 RVA: 0x00CB6A2C File Offset: 0x00CB4C2C
		private void RefreshCardFrame()
		{
			bool flag = this.IsOutlookUnlocked();
			base.GetItem(15).SetUIActive(!flag);
			base.GetItem(16).SetUIActive(flag);
		}

		// Token: 0x06035B04 RID: 219908 RVA: 0x00CB6A60 File Offset: 0x00CB4C60
		private UniTask RefreshCardFaceAsync()
		{
			BattleCardComponent.<RefreshCardFaceAsync>d__31 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<BattleCardComponent.<RefreshCardFaceAsync>d__31>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B05 RID: 219909 RVA: 0x00CB6AA4 File Offset: 0x00CB4CA4
		private UniTask RefreshGoldEvolveItem()
		{
			BattleCardComponent.<RefreshGoldEvolveItem>d__32 <RefreshGoldEvolveItem>d__;
			<RefreshGoldEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshGoldEvolveItem>d__.<>4__this = this;
			<RefreshGoldEvolveItem>d__.<>1__state = -1;
			<RefreshGoldEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshGoldEvolveItem>d__32>(ref <RefreshGoldEvolveItem>d__);
			return <RefreshGoldEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035B06 RID: 219910 RVA: 0x00CB6AE8 File Offset: 0x00CB4CE8
		private UniTask RefreshNormalEvolveItem()
		{
			BattleCardComponent.<RefreshNormalEvolveItem>d__33 <RefreshNormalEvolveItem>d__;
			<RefreshNormalEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNormalEvolveItem>d__.<>4__this = this;
			<RefreshNormalEvolveItem>d__.<>1__state = -1;
			<RefreshNormalEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshNormalEvolveItem>d__33>(ref <RefreshNormalEvolveItem>d__);
			return <RefreshNormalEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035B07 RID: 219911 RVA: 0x00CB6B2C File Offset: 0x00CB4D2C
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

		// Token: 0x06035B08 RID: 219912 RVA: 0x00CB6BC4 File Offset: 0x00CB4DC4
		private UniTask RefreshEvolveItem()
		{
			BattleCardComponent.<RefreshEvolveItem>d__35 <RefreshEvolveItem>d__;
			<RefreshEvolveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEvolveItem>d__.<>4__this = this;
			<RefreshEvolveItem>d__.<>1__state = -1;
			<RefreshEvolveItem>d__.<>t__builder.Start<BattleCardComponent.<RefreshEvolveItem>d__35>(ref <RefreshEvolveItem>d__);
			return <RefreshEvolveItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035B09 RID: 219913 RVA: 0x00CB6C07 File Offset: 0x00CB4E07
		public void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x06035B0A RID: 219914 RVA: 0x00CB6C10 File Offset: 0x00CB4E10
		private bool IsOutlookUnlocked()
		{
			return !this.Data.IsNpcCard && PhantomArenaModel.Instance.IsCardOutlookUnlock(this.Data.ConfigId);
		}

		// Token: 0x06035B0B RID: 219915 RVA: 0x00CB6C38 File Offset: 0x00CB4E38
		private UniTask InitLoopEffect()
		{
			BattleCardComponent.<InitLoopEffect>d__38 <InitLoopEffect>d__;
			<InitLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopEffect>d__.<>4__this = this;
			<InitLoopEffect>d__.<>1__state = -1;
			<InitLoopEffect>d__.<>t__builder.Start<BattleCardComponent.<InitLoopEffect>d__38>(ref <InitLoopEffect>d__);
			return <InitLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B0C RID: 219916 RVA: 0x00CB6C7C File Offset: 0x00CB4E7C
		private UniTask InitStartEffect()
		{
			BattleCardComponent.<InitStartEffect>d__39 <InitStartEffect>d__;
			<InitStartEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStartEffect>d__.<>4__this = this;
			<InitStartEffect>d__.<>1__state = -1;
			<InitStartEffect>d__.<>t__builder.Start<BattleCardComponent.<InitStartEffect>d__39>(ref <InitStartEffect>d__);
			return <InitStartEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B0D RID: 219917 RVA: 0x00CB6CC0 File Offset: 0x00CB4EC0
		public UniTask InitEffect()
		{
			BattleCardComponent.<InitEffect>d__40 <InitEffect>d__;
			<InitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEffect>d__.<>4__this = this;
			<InitEffect>d__.<>1__state = -1;
			<InitEffect>d__.<>t__builder.Start<BattleCardComponent.<InitEffect>d__40>(ref <InitEffect>d__);
			return <InitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B0E RID: 219918 RVA: 0x00CB6D04 File Offset: 0x00CB4F04
		public UniTask InitSpine()
		{
			BattleCardComponent.<InitSpine>d__41 <InitSpine>d__;
			<InitSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSpine>d__.<>4__this = this;
			<InitSpine>d__.<>1__state = -1;
			<InitSpine>d__.<>t__builder.Start<BattleCardComponent.<InitSpine>d__41>(ref <InitSpine>d__);
			return <InitSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06035B0F RID: 219919 RVA: 0x00CB6D48 File Offset: 0x00CB4F48
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

		// Token: 0x06035B10 RID: 219920 RVA: 0x00CB6EAC File Offset: 0x00CB50AC
		public void PlaySpineAnim(string animName, bool isLoop)
		{
			BattleCardSpineItem spineItem = this.SpineItem;
			if (spineItem == null)
			{
				return;
			}
			spineItem.PlaySpineAnim(animName, isLoop);
		}

		// Token: 0x06035B11 RID: 219921 RVA: 0x00CB6EC0 File Offset: 0x00CB50C0
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x06035B12 RID: 219922 RVA: 0x00CB6ED0 File Offset: 0x00CB50D0
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

		// Token: 0x06035B13 RID: 219923 RVA: 0x00CB6F1B File Offset: 0x00CB511B
		public UUIExtendToggle GetCardToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035B14 RID: 219924 RVA: 0x00CB6F24 File Offset: 0x00CB5124
		public UUIItem GetTweenItem()
		{
			return base.GetItem(12);
		}

		// Token: 0x06035B15 RID: 219925 RVA: 0x00CB6F2E File Offset: 0x00CB512E
		public void PlaySequence(string name)
		{
			if (this.Sequence.IsSequenceInPlaying(name))
			{
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(name, false, false);
		}

		// Token: 0x06035B16 RID: 219926 RVA: 0x00CB6F5A File Offset: 0x00CB515A
		public void PlayEffect()
		{
			BattleCardEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.PlayStartEffect();
		}

		// Token: 0x170081F4 RID: 33268
		// (get) Token: 0x06035B17 RID: 219927 RVA: 0x00CB6F6C File Offset: 0x00CB516C
		// (set) Token: 0x06035B18 RID: 219928 RVA: 0x00CB6F74 File Offset: 0x00CB5174
		public Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x0401C78D RID: 116621
		private CardElementItem ElementItem;

		// Token: 0x0401C78E RID: 116622
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C790 RID: 116624
		protected PhantomCardData Data;

		// Token: 0x0401C791 RID: 116625
		protected BattleCardLoopEffectItem LoopEffectItem;

		// Token: 0x0401C792 RID: 116626
		protected BattleCardEffectItem EffectItem;

		// Token: 0x0401C793 RID: 116627
		protected BattleCardSpineItem SpineItem;

		// Token: 0x0401C794 RID: 116628
		protected EvolveProxy NormalEvolveItem;

		// Token: 0x0401C795 RID: 116629
		protected EvolveProxy GoldEvolveItem;

		// Token: 0x0200B382 RID: 45954
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x0403667F RID: 222847
			public const int Toggle = 0;

			// Token: 0x04036680 RID: 222848
			public const int AttackText = 1;

			// Token: 0x04036681 RID: 222849
			public const int ContentItem = 2;

			// Token: 0x04036682 RID: 222850
			public const int HealthText = 3;

			// Token: 0x04036683 RID: 222851
			public const int CostText = 4;

			// Token: 0x04036684 RID: 222852
			public const int MiddleHighLightItem = 5;

			// Token: 0x04036685 RID: 222853
			public const int LeftHighLightItem = 6;

			// Token: 0x04036686 RID: 222854
			public const int ElementItem = 7;

			// Token: 0x04036687 RID: 222855
			public const int CardFaceTexture = 8;

			// Token: 0x04036688 RID: 222856
			public const int DebugText = 9;

			// Token: 0x04036689 RID: 222857
			public const int NormalElementFrameItem = 10;

			// Token: 0x0403668A RID: 222858
			public const int AttachItem = 11;

			// Token: 0x0403668B RID: 222859
			public const int TweenItem = 12;

			// Token: 0x0403668C RID: 222860
			public const int GreenItem = 13;

			// Token: 0x0403668D RID: 222861
			public const int RedItem = 14;

			// Token: 0x0403668E RID: 222862
			public const int NormalCardFrameItem = 15;

			// Token: 0x0403668F RID: 222863
			public const int GoldCardFrameItem = 16;

			// Token: 0x04036690 RID: 222864
			public const int GoldElementFrameItem = 17;

			// Token: 0x04036691 RID: 222865
			public const int SpineAttachItem = 18;

			// Token: 0x04036692 RID: 222866
			public const int LightBgItem = 19;

			// Token: 0x04036693 RID: 222867
			public const int RightHighLightItem = 20;
		}
	}
}
