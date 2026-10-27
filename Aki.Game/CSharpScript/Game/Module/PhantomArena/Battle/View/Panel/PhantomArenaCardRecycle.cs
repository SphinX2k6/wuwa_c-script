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
	// Token: 0x02005257 RID: 21079
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardRecycle : UiPanelBase
	{
		// Token: 0x06035DED RID: 220653 RVA: 0x00CBF814 File Offset: 0x00CBDA14
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

		// Token: 0x06035DEE RID: 220654 RVA: 0x00CBF89C File Offset: 0x00CBDA9C
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

		// Token: 0x06035DEF RID: 220655 RVA: 0x00CBF98D File Offset: 0x00CBDB8D
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.LightSequence.Clear();
			this.SealLightSequence.Clear();
		}

		// Token: 0x06035DF0 RID: 220656 RVA: 0x00CBF9B0 File Offset: 0x00CBDBB0
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

		// Token: 0x06035DF1 RID: 220657 RVA: 0x00CBFA0C File Offset: 0x00CBDC0C
		public bool CheckCardInRecycleArea(PhantomArenaCard card)
		{
			this.TempCardPos.FromUeVector(card.GetWorldLocation());
			this.ItemWorldTrans.InverseTransformPosition(this.TempCardPos, this.TempCardPos);
			return this.TempCardPos.X >= -this.Pivot.X * (double)this.TotalWidth;
		}

		// Token: 0x06035DF2 RID: 220658 RVA: 0x00CBFA68 File Offset: 0x00CBDC68
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

		// Token: 0x06035DF3 RID: 220659 RVA: 0x00CBFB58 File Offset: 0x00CBDD58
		protected bool CheckSettingGuideCondition(int cardId)
		{
			int handIndexByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandIndexByCardId(cardId);
			return this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbRecycleHandCard, new object[]
			{
				handIndexByCardId
			});
		}

		// Token: 0x06035DF4 RID: 220660 RVA: 0x00CBFB96 File Offset: 0x00CBDD96
		protected bool CheckEvolveGuideCondition(int index)
		{
			return this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbRecycleBoardCard, new object[]
			{
				index
			});
		}

		// Token: 0x06035DF5 RID: 220661 RVA: 0x00CBFBB8 File Offset: 0x00CBDDB8
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

		// Token: 0x06035DF6 RID: 220662 RVA: 0x00CBFC58 File Offset: 0x00CBDE58
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

		// Token: 0x06035DF7 RID: 220663 RVA: 0x00CBFCAC File Offset: 0x00CBDEAC
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

		// Token: 0x06035DF8 RID: 220664 RVA: 0x00CBFD08 File Offset: 0x00CBDF08
		public void RefreshCostNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			base.GetText(0).SetText(battleStatusValue.ToString() + "/" + phantomBattleChallenge.RecoverCostPoint.ToString(), true);
		}

		// Token: 0x06035DF9 RID: 220665 RVA: 0x00CBFD6A File Offset: 0x00CBDF6A
		public EPhantomCardSettingFailReason GetSettingFailReason()
		{
			return this.SettingFailReason;
		}

		// Token: 0x06035DFA RID: 220666 RVA: 0x00CBFD72 File Offset: 0x00CBDF72
		public void ResetSettingFailReason()
		{
			this.SettingFailReason = EPhantomCardSettingFailReason.None;
		}

		// Token: 0x06035DFB RID: 220667 RVA: 0x00CBFD7F File Offset: 0x00CBDF7F
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x0401C8C0 RID: 116928
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C8C1 RID: 116929
		protected readonly global::Vector TempCardPos = global::Vector.Create();

		// Token: 0x0401C8C2 RID: 116930
		protected readonly global::Transform ItemWorldTrans = global::Transform.Create();

		// Token: 0x0401C8C3 RID: 116931
		protected float TotalWidth;

		// Token: 0x0401C8C4 RID: 116932
		protected float TotalHeight;

		// Token: 0x0401C8C5 RID: 116933
		protected Vector2D Pivot = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401C8C6 RID: 116934
		protected UUIItem EffectItem;

		// Token: 0x0401C8C7 RID: 116935
		protected UUIItem SealEffectItem;

		// Token: 0x0401C8C8 RID: 116936
		protected bool EffectItemActive;

		// Token: 0x0401C8C9 RID: 116937
		protected EPhantomCardSettingFailReason SettingFailReason = EPhantomCardSettingFailReason.None;

		// Token: 0x0401C8CA RID: 116938
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8CB RID: 116939
		protected UiSequencePlayer LightSequence;

		// Token: 0x0401C8CC RID: 116940
		protected UiSequencePlayer SealLightSequence;

		// Token: 0x0401C8CD RID: 116941
		protected string LightSequenceName = "RecycleLightClose";

		// Token: 0x0401C8CE RID: 116942
		protected string SealLightSequenceName = "RecycleLightRedClose";

		// Token: 0x0200B413 RID: 46099
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036902 RID: 223490
			public const int CostNum = 0;

			// Token: 0x04036903 RID: 223491
			public const int EffectItem = 1;

			// Token: 0x04036904 RID: 223492
			public const int AddNum = 2;

			// Token: 0x04036905 RID: 223493
			public const int SealCount = 3;

			// Token: 0x04036906 RID: 223494
			public const int SealEffectItem = 4;
		}
	}
}
