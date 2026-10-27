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
	// Token: 0x02005201 RID: 20993
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewBattleCardComponent : CardComponentBase<PhantomCardData>, IBattleCardComponent
	{
		// Token: 0x170081F8 RID: 33272
		// (get) Token: 0x06035B4A RID: 219978 RVA: 0x00CB752A File Offset: 0x00CB572A
		// (set) Token: 0x06035B4B RID: 219979 RVA: 0x00CB7532 File Offset: 0x00CB5732
		public Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x170081F9 RID: 33273
		// (get) Token: 0x06035B4C RID: 219980 RVA: 0x00CB753B File Offset: 0x00CB573B
		// (set) Token: 0x06035B4D RID: 219981 RVA: 0x00CB7543 File Offset: 0x00CB5743
		public UiSequencePlayer RootUiSequencePlayer { get; set; }

		// Token: 0x06035B4E RID: 219982 RVA: 0x00CB754C File Offset: 0x00CB574C
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

		// Token: 0x06035B4F RID: 219983 RVA: 0x00CB77A6 File Offset: 0x00CB59A6
		private void CardClick(EToggleState state)
		{
			Action<EToggleState> cardClickCallback = this.CardClickCallback;
			if (cardClickCallback == null)
			{
				return;
			}
			cardClickCallback(state);
		}

		// Token: 0x06035B50 RID: 219984 RVA: 0x00CB77BC File Offset: 0x00CB59BC
		protected UniTask InitElement()
		{
			NewBattleCardComponent.<InitElement>d__20 <InitElement>d__;
			<InitElement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitElement>d__.<>4__this = this;
			<InitElement>d__.<>1__state = -1;
			<InitElement>d__.<>t__builder.Start<NewBattleCardComponent.<InitElement>d__20>(ref <InitElement>d__);
			return <InitElement>d__.<>t__builder.Task;
		}

		// Token: 0x06035B51 RID: 219985 RVA: 0x00CB7800 File Offset: 0x00CB5A00
		private UniTask InitLoopEffect()
		{
			NewBattleCardComponent.<InitLoopEffect>d__21 <InitLoopEffect>d__;
			<InitLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopEffect>d__.<>4__this = this;
			<InitLoopEffect>d__.<>1__state = -1;
			<InitLoopEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitLoopEffect>d__21>(ref <InitLoopEffect>d__);
			return <InitLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B52 RID: 219986 RVA: 0x00CB7844 File Offset: 0x00CB5A44
		private UniTask InitStartEffect()
		{
			NewBattleCardComponent.<InitStartEffect>d__22 <InitStartEffect>d__;
			<InitStartEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStartEffect>d__.<>4__this = this;
			<InitStartEffect>d__.<>1__state = -1;
			<InitStartEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitStartEffect>d__22>(ref <InitStartEffect>d__);
			return <InitStartEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B53 RID: 219987 RVA: 0x00CB7888 File Offset: 0x00CB5A88
		private UniTask InitHitLocationCurveX()
		{
			NewBattleCardComponent.<InitHitLocationCurveX>d__23 <InitHitLocationCurveX>d__;
			<InitHitLocationCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHitLocationCurveX>d__.<>4__this = this;
			<InitHitLocationCurveX>d__.<>1__state = -1;
			<InitHitLocationCurveX>d__.<>t__builder.Start<NewBattleCardComponent.<InitHitLocationCurveX>d__23>(ref <InitHitLocationCurveX>d__);
			return <InitHitLocationCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x06035B54 RID: 219988 RVA: 0x00CB78CC File Offset: 0x00CB5ACC
		private UniTask InitHitLocationCurveY()
		{
			NewBattleCardComponent.<InitHitLocationCurveY>d__24 <InitHitLocationCurveY>d__;
			<InitHitLocationCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHitLocationCurveY>d__.<>4__this = this;
			<InitHitLocationCurveY>d__.<>1__state = -1;
			<InitHitLocationCurveY>d__.<>t__builder.Start<NewBattleCardComponent.<InitHitLocationCurveY>d__24>(ref <InitHitLocationCurveY>d__);
			return <InitHitLocationCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x06035B55 RID: 219989 RVA: 0x00CB7910 File Offset: 0x00CB5B10
		protected override UniTask OnBeforeStartAsync()
		{
			NewBattleCardComponent.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewBattleCardComponent.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B56 RID: 219990 RVA: 0x00CB7954 File Offset: 0x00CB5B54
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

		// Token: 0x06035B57 RID: 219991 RVA: 0x00CB79B7 File Offset: 0x00CB5BB7
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.TweenLogic.Destroy();
		}

		// Token: 0x06035B58 RID: 219992 RVA: 0x00CB79D0 File Offset: 0x00CB5BD0
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

		// Token: 0x06035B59 RID: 219993 RVA: 0x00CB7A60 File Offset: 0x00CB5C60
		private void RefreshAttack()
		{
			UUIText text = base.GetText(1);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.AttackAbility, text, "NumUpChange");
		}

		// Token: 0x06035B5A RID: 219994 RVA: 0x00CB7A84 File Offset: 0x00CB5C84
		private void RefreshHealth()
		{
			UUIText text = base.GetText(3);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.LifeAbility, text, "NumDownChange");
		}

		// Token: 0x06035B5B RID: 219995 RVA: 0x00CB7AA8 File Offset: 0x00CB5CA8
		private void RefreshCost()
		{
			UUIText text = base.GetText(4);
			this.RefreshCardAttrLogic(PhantomBattleCardAttr.CostAbility, text, "NumDamageChange");
		}

		// Token: 0x06035B5C RID: 219996 RVA: 0x00CB7ACC File Offset: 0x00CB5CCC
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

		// Token: 0x06035B5D RID: 219997 RVA: 0x00CB7B5B File Offset: 0x00CB5D5B
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

		// Token: 0x06035B5E RID: 219998 RVA: 0x00CB7B9C File Offset: 0x00CB5D9C
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

		// Token: 0x06035B5F RID: 219999 RVA: 0x00CB7BD8 File Offset: 0x00CB5DD8
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

		// Token: 0x06035B60 RID: 220000 RVA: 0x00CB7C50 File Offset: 0x00CB5E50
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

		// Token: 0x06035B61 RID: 220001 RVA: 0x00CB7C94 File Offset: 0x00CB5E94
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

		// Token: 0x06035B62 RID: 220002 RVA: 0x00CB7CC0 File Offset: 0x00CB5EC0
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

		// Token: 0x06035B63 RID: 220003 RVA: 0x00CB7D18 File Offset: 0x00CB5F18
		private UniTask RefreshCardFaceAsync()
		{
			NewBattleCardComponent.<RefreshCardFaceAsync>d__39 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<NewBattleCardComponent.<RefreshCardFaceAsync>d__39>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B64 RID: 220004 RVA: 0x00CB7D5C File Offset: 0x00CB5F5C
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

		// Token: 0x06035B65 RID: 220005 RVA: 0x00CB7D8B File Offset: 0x00CB5F8B
		public void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x06035B66 RID: 220006 RVA: 0x00CB7D94 File Offset: 0x00CB5F94
		public UniTask InitEffect()
		{
			NewBattleCardComponent.<InitEffect>d__42 <InitEffect>d__;
			<InitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEffect>d__.<>4__this = this;
			<InitEffect>d__.<>1__state = -1;
			<InitEffect>d__.<>t__builder.Start<NewBattleCardComponent.<InitEffect>d__42>(ref <InitEffect>d__);
			return <InitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B67 RID: 220007 RVA: 0x00CB7DD8 File Offset: 0x00CB5FD8
		public UniTask InitSpine()
		{
			NewBattleCardComponent.<InitSpine>d__43 <InitSpine>d__;
			<InitSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSpine>d__.<>4__this = this;
			<InitSpine>d__.<>1__state = -1;
			<InitSpine>d__.<>t__builder.Start<NewBattleCardComponent.<InitSpine>d__43>(ref <InitSpine>d__);
			return <InitSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06035B68 RID: 220008 RVA: 0x00CB7E1C File Offset: 0x00CB601C
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

		// Token: 0x06035B69 RID: 220009 RVA: 0x00CB7F80 File Offset: 0x00CB6180
		public void PlaySpineAnim(string animName, bool isLoop)
		{
			BattleCardSpineItem spineItem = this.SpineItem;
			if (spineItem == null)
			{
				return;
			}
			spineItem.PlaySpineAnim(animName, isLoop);
		}

		// Token: 0x06035B6A RID: 220010 RVA: 0x00CB7F94 File Offset: 0x00CB6194
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x06035B6B RID: 220011 RVA: 0x00CB7FA4 File Offset: 0x00CB61A4
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

		// Token: 0x06035B6C RID: 220012 RVA: 0x00CB7FEF File Offset: 0x00CB61EF
		public UUIExtendToggle GetCardToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035B6D RID: 220013 RVA: 0x00CB7FF8 File Offset: 0x00CB61F8
		public UUIItem GetTweenItem()
		{
			return base.GetItem(14);
		}

		// Token: 0x06035B6E RID: 220014 RVA: 0x00CB8002 File Offset: 0x00CB6202
		public void PlaySequence(string name)
		{
			if (this.Sequence.IsSequenceInPlaying(name))
			{
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(name, false, false);
		}

		// Token: 0x06035B6F RID: 220015 RVA: 0x00CB802E File Offset: 0x00CB622E
		public void PlayEffect()
		{
			BattleCardEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.PlayStartEffect();
		}

		// Token: 0x170081FA RID: 33274
		// (get) Token: 0x06035B70 RID: 220016 RVA: 0x00CB8040 File Offset: 0x00CB6240
		// (set) Token: 0x06035B71 RID: 220017 RVA: 0x00CB8048 File Offset: 0x00CB6248
		public Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x06035B72 RID: 220018 RVA: 0x00CB8054 File Offset: 0x00CB6254
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

		// Token: 0x0401C79D RID: 116637
		private CardElementItem ElementItem;

		// Token: 0x0401C79E RID: 116638
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C7A0 RID: 116640
		protected PhantomCardData Data;

		// Token: 0x0401C7A1 RID: 116641
		protected BattleCardLoopEffectItem LoopEffectItem;

		// Token: 0x0401C7A2 RID: 116642
		protected BattleCardEffectItem EffectItem;

		// Token: 0x0401C7A3 RID: 116643
		protected BattleCardSpineItem SpineItem;

		// Token: 0x0401C7A4 RID: 116644
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x0401C7A5 RID: 116645
		protected UCurveFloat HitLocationCurveX;

		// Token: 0x0401C7A6 RID: 116646
		protected UCurveFloat HitLocationCurveY;

		// Token: 0x0200B39E RID: 45982
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036704 RID: 222980
			public const int Toggle = 0;

			// Token: 0x04036705 RID: 222981
			public const int AttackText = 1;

			// Token: 0x04036706 RID: 222982
			public const int ContentItem = 2;

			// Token: 0x04036707 RID: 222983
			public const int HealthText = 3;

			// Token: 0x04036708 RID: 222984
			public const int CostText = 4;

			// Token: 0x04036709 RID: 222985
			public const int MiddleHighLightItem = 5;

			// Token: 0x0403670A RID: 222986
			public const int LeftHighLightItem = 6;

			// Token: 0x0403670B RID: 222987
			public const int RightHighLightItem = 7;

			// Token: 0x0403670C RID: 222988
			public const int ElementItem = 8;

			// Token: 0x0403670D RID: 222989
			public const int ElementIconItem = 9;

			// Token: 0x0403670E RID: 222990
			public const int CostItem = 10;

			// Token: 0x0403670F RID: 222991
			public const int CardFaceTexture = 11;

			// Token: 0x04036710 RID: 222992
			public const int DebugText = 12;

			// Token: 0x04036711 RID: 222993
			public const int AttachItem = 13;

			// Token: 0x04036712 RID: 222994
			public const int TweenItem = 14;

			// Token: 0x04036713 RID: 222995
			public const int GreenItem = 15;

			// Token: 0x04036714 RID: 222996
			public const int RedItem = 16;

			// Token: 0x04036715 RID: 222997
			public const int SpineAttachItem = 17;

			// Token: 0x04036716 RID: 222998
			public const int NormalCardItem = 18;

			// Token: 0x04036717 RID: 222999
			public const int FieldCardItem = 19;

			// Token: 0x04036718 RID: 223000
			public const int ToolCardItem = 20;

			// Token: 0x04036719 RID: 223001
			public const int ToolCount = 21;

			// Token: 0x0403671A RID: 223002
			public const int EvolveItem = 22;

			// Token: 0x0403671B RID: 223003
			public const int HitItem = 23;
		}
	}
}
