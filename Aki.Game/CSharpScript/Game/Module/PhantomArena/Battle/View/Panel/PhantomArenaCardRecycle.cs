using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004227 RID: 16935
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardRecycle : UiPanelBase
	{
		// Token: 0x0602ACE8 RID: 175336 RVA: 0x00C0CEA4 File Offset: 0x00C0B0A4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x0602ACE9 RID: 175337 RVA: 0x00C0CF2C File Offset: 0x00C0B12C
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
			global::Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = this.RootItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
			this.TotalWidth = this.RootItem.GetWidth();
			this.TotalHeight = this.RootItem.GetHeight();
			this.Pivot.FromUeVector2D(this.RootItem.GetPivot());
			this.EffectItem = base.GetItem(1);
			this.SealEffectItem = base.GetItem(4);
			this.LightSequence = new UiSequencePlayer(this.EffectItem);
			this.SealLightSequence = new UiSequencePlayer(this.SealEffectItem);
			this.EffectItem.SetUIActive(false);
			this.SealEffectItem.SetUIActive(false);
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0602ACEA RID: 175338 RVA: 0x00C0D01D File Offset: 0x00C0B21D
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.LightSequence.Clear();
			this.SealLightSequence.Clear();
		}

		// Token: 0x0602ACEB RID: 175339 RVA: 0x00C0D040 File Offset: 0x00C0B240
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "RecycleDisactive" || sequenceName == "RecycleSuccess")
			{
				this.EffectItem.SetUIActive(false);
				return;
			}
			if (sequenceName == "BanSuccess" || sequenceName == "BanDisactive")
			{
				this.SealEffectItem.SetUIActive(false);
			}
		}

		// Token: 0x0602ACEC RID: 175340 RVA: 0x00C0D09C File Offset: 0x00C0B29C
		public bool CheckCardInRecycleArea(PhantomArenaCard card)
		{
			this.TempCardPos.FromUeVector(card.GetWorldLocation());
			this.ItemWorldTrans.InverseTransformPosition(this.TempCardPos, this.TempCardPos);
			return this.TempCardPos.X >= -this.Pivot.X * (double)this.TotalWidth;
		}

		// Token: 0x0602ACED RID: 175341 RVA: 0x00C0D0F8 File Offset: 0x00C0B2F8
		public void SetEffectActive(ERecycleSequenceType type)
		{
			bool flag = type == ERecycleSequenceType.Active;
			if (this.EffectItemActive == flag)
			{
				return;
			}
			this.EffectItemActive = flag;
			bool recycleIsInSeal = PhantomArenaBattleModel.Instance.OwnData.RecycleIsInSeal;
			if (type == ERecycleSequenceType.Active)
			{
				this.EffectItem.SetUIActive(!recycleIsInSeal);
				this.SealEffectItem.SetUIActive(recycleIsInSeal);
				this.Sequence.StopPrevSequence(false, true);
				string sequenceName = recycleIsInSeal ? "BanActive" : "RecycleActive";
				this.Sequence.PlaySequencePurely(sequenceName, false, false);
				return;
			}
			if (type == ERecycleSequenceType.DisActive)
			{
				this.Sequence.StopPrevSequence(false, true);
				string sequenceName2 = recycleIsInSeal ? "BanDisactive" : "RecycleDisactive";
				this.Sequence.PlaySequencePurely(sequenceName2, false, false);
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			string sequenceName3 = recycleIsInSeal ? "BanSuccess" : "RecycleSuccess";
			this.Sequence.PlaySequencePurely(sequenceName3, false, false);
			this.SealLightSequenceName = "RecycleLightRedClose";
			this.LightSequenceName = "RecycleLightClose";
		}

		// Token: 0x0602ACEE RID: 175342 RVA: 0x00C0D1E8 File Offset: 0x00C0B3E8
		protected bool CheckSettingGuideCondition(int cardId)
		{
			int handIndexByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandIndexByCardId(cardId);
			return this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbRecycleHandCard, new object[]
			{
				handIndexByCardId
			});
		}

		// Token: 0x0602ACEF RID: 175343 RVA: 0x00C0D226 File Offset: 0x00C0B426
		protected bool CheckEvolveGuideCondition(int index)
		{
			return this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbRecycleBoardCard, new object[]
			{
				index
			});
		}

		// Token: 0x0602ACF0 RID: 175344 RVA: 0x00C0D248 File Offset: 0x00C0B448
		public void RefreshCardRecycleArea(PhantomArenaCard card)
		{
			bool flag = this.CheckCardInRecycleArea(card);
			if (PhantomArenaBattleModel.Instance.OwnData.RecycleIsInSeal)
			{
				string text = flag ? "RecycleLightRed" : "RecycleLightRedClose";
				if (this.SealLightSequenceName == text)
				{
					return;
				}
				this.SealLightSequenceName = text;
				this.SealLightSequence.PlaySequence(text, false, null);
				return;
			}
			else
			{
				string text2 = flag ? "RecycleLight" : "RecycleLightClose";
				if (this.LightSequenceName == text2)
				{
					return;
				}
				this.LightSequenceName = text2;
				this.LightSequence.PlaySequence(text2, false, null);
				return;
			}
		}

		// Token: 0x0602ACF1 RID: 175345 RVA: 0x00C0D2E8 File Offset: 0x00C0B4E8
		[NullableContext(0)]
		public UniTask<bool> TrySettingCardByHand([Nullable(1)] PhantomArenaCard card, bool fromGamepad = false)
		{
			PhantomArenaCardRecycle.<TrySettingCardByHand>d__25 <TrySettingCardByHand>d__;
			<TrySettingCardByHand>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySettingCardByHand>d__.<>4__this = this;
			<TrySettingCardByHand>d__.card = card;
			<TrySettingCardByHand>d__.fromGamepad = fromGamepad;
			<TrySettingCardByHand>d__.<>1__state = -1;
			<TrySettingCardByHand>d__.<>t__builder.Start<PhantomArenaCardRecycle.<TrySettingCardByHand>d__25>(ref <TrySettingCardByHand>d__);
			return <TrySettingCardByHand>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACF2 RID: 175346 RVA: 0x00C0D33C File Offset: 0x00C0B53C
		[NullableContext(0)]
		public UniTask<bool> TrySettingCardByFunctional([Nullable(1)] PhantomArenaCard card, int index, bool fromGamepad = false)
		{
			PhantomArenaCardRecycle.<TrySettingCardByFunctional>d__26 <TrySettingCardByFunctional>d__;
			<TrySettingCardByFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySettingCardByFunctional>d__.<>4__this = this;
			<TrySettingCardByFunctional>d__.card = card;
			<TrySettingCardByFunctional>d__.index = index;
			<TrySettingCardByFunctional>d__.fromGamepad = fromGamepad;
			<TrySettingCardByFunctional>d__.<>1__state = -1;
			<TrySettingCardByFunctional>d__.<>t__builder.Start<PhantomArenaCardRecycle.<TrySettingCardByFunctional>d__26>(ref <TrySettingCardByFunctional>d__);
			return <TrySettingCardByFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACF3 RID: 175347 RVA: 0x00C0D398 File Offset: 0x00C0B598
		public void RefreshCostNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			base.GetText(0).SetText(battleStatusValue.ToString() + "/" + phantomBattleChallenge.RecoverCostPoint.ToString(), true);
		}

		// Token: 0x0602ACF4 RID: 175348 RVA: 0x00C0D3FA File Offset: 0x00C0B5FA
		public EPhantomCardSettingFailReason GetSettingFailReason()
		{
			return this.SettingFailReason;
		}

		// Token: 0x0602ACF5 RID: 175349 RVA: 0x00C0D402 File Offset: 0x00C0B602
		public void ResetSettingFailReason()
		{
			this.SettingFailReason = EPhantomCardSettingFailReason.None;
		}

		// Token: 0x0602ACF6 RID: 175350 RVA: 0x00C0D40F File Offset: 0x00C0B60F
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x040172F5 RID: 94965
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x040172F6 RID: 94966
		protected readonly global::Vector TempCardPos = global::Vector.Create();

		// Token: 0x040172F7 RID: 94967
		protected readonly global::Transform ItemWorldTrans = global::Transform.Create();

		// Token: 0x040172F8 RID: 94968
		protected float TotalWidth;

		// Token: 0x040172F9 RID: 94969
		protected float TotalHeight;

		// Token: 0x040172FA RID: 94970
		protected Vector2D Pivot = Vector2D.Create(0.0, 0.0);

		// Token: 0x040172FB RID: 94971
		protected UUIItem EffectItem;

		// Token: 0x040172FC RID: 94972
		protected UUIItem SealEffectItem;

		// Token: 0x040172FD RID: 94973
		protected bool EffectItemActive;

		// Token: 0x040172FE RID: 94974
		protected EPhantomCardSettingFailReason SettingFailReason = EPhantomCardSettingFailReason.None;

		// Token: 0x040172FF RID: 94975
		protected UiSequencePlayer Sequence;

		// Token: 0x04017300 RID: 94976
		protected UiSequencePlayer LightSequence;

		// Token: 0x04017301 RID: 94977
		protected UiSequencePlayer SealLightSequence;

		// Token: 0x04017302 RID: 94978
		protected string LightSequenceName = "RecycleLightClose";

		// Token: 0x04017303 RID: 94979
		protected string SealLightSequenceName = "RecycleLightRedClose";

		// Token: 0x02009E4B RID: 40523
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031355 RID: 201557
			public const int CostNum = 0;

			// Token: 0x04031356 RID: 201558
			public const int EffectItem = 1;

			// Token: 0x04031357 RID: 201559
			public const int AddNum = 2;

			// Token: 0x04031358 RID: 201560
			public const int SealCount = 3;

			// Token: 0x04031359 RID: 201561
			public const int SealEffectItem = 4;
		}
	}
}
