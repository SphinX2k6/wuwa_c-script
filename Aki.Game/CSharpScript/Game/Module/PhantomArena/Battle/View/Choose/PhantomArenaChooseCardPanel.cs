using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x0200423C RID: 16956
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChooseCardPanel : UiPanelBase
	{
		// Token: 0x0602AE2D RID: 175661 RVA: 0x00C10D38 File Offset: 0x00C0EF38
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmBtnClick)),
				new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnVisibleToggleClick)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnEmptyClick))
			};
		}

		// Token: 0x0602AE2E RID: 175662 RVA: 0x00C10E3D File Offset: 0x00C0F03D
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<PhantomArenaChooseCardItem, PhantomCardData>(base.GetLayoutBase(0), new Func<PhantomArenaChooseCardItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0602AE2F RID: 175663 RVA: 0x00C10E70 File Offset: 0x00C0F070
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaChooseCardPanel.<OnBeforeShowAsyncImplement>d__10 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaChooseCardPanel.<OnBeforeShowAsyncImplement>d__10>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE30 RID: 175664 RVA: 0x00C10EB4 File Offset: 0x00C0F0B4
		protected override void OnAfterHide()
		{
			base.GetItem(2).SetUIActive(true);
			this.ViewProxy.HideCardTips();
			this.ViewProxy.SetCaptionItemActive(true);
			this.ViewProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.ChooseCardSkillInteract);
			this.ViewProxy.SetIsMainInVisible(true);
			this.ViewProxy.SetInPanelInteractType(EPhantomArenaBattlePanelInteractType.MainView);
		}

		// Token: 0x0602AE31 RID: 175665 RVA: 0x00C10F09 File Offset: 0x00C0F109
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChooseCardPanelShow);
		}

		// Token: 0x0602AE32 RID: 175666 RVA: 0x00C10F1B File Offset: 0x00C0F11B
		private PhantomArenaChooseCardItem InitItem()
		{
			return new PhantomArenaChooseCardItem
			{
				ClickCallback = new Action<PhantomCardData, bool>(this.CardClick)
			};
		}

		// Token: 0x0602AE33 RID: 175667 RVA: 0x00C10F34 File Offset: 0x00C0F134
		private void OnVisibleToggleClick(EToggleState state)
		{
			bool flag = state != EToggleState.ETT_Checked;
			this.ViewProxy.SetIsMainInVisible(!flag);
			this.ViewProxy.HideCardTips();
			base.GetItem(2).SetUIActive(flag);
		}

		// Token: 0x0602AE34 RID: 175668 RVA: 0x00C10F70 File Offset: 0x00C0F170
		private void OnConfirmBtnClick()
		{
			this.Data.ConfirmFunc(new List<int>(this.SelectedIdSet)).ContinueWith(delegate()
			{
				if (this.Data.GuideType != null)
				{
					this.ViewProxy.GuideManager.TryFinishGuideByType(this.Data.GuideType.Value, Array.Empty<object>());
				}
			});
		}

		// Token: 0x0602AE35 RID: 175669 RVA: 0x00C10F9F File Offset: 0x00C0F19F
		private void OnEmptyClick()
		{
			this.CancelSelectState();
		}

		// Token: 0x0602AE36 RID: 175670 RVA: 0x00C10FA8 File Offset: 0x00C0F1A8
		private void CardClick(PhantomCardData data, bool isSelected)
		{
			this.HandleSelectState(data.CardId);
			if (isSelected && this.Data.GuideType != null && !this.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(this.Data.GuideType.Value, new object[]
			{
				data.ConfigId
			}))
			{
				return;
			}
			if (isSelected && this.SelectedIdSet.Count >= this.LimitCount)
			{
				if (this.LimitCount > 1)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1079", Array.Empty<object>());
					return;
				}
				this.CancelChooseLastState();
			}
			this.HandleChooseState(data.CardId, isSelected);
			this.RefreshConfirmInteractive();
			this.RefreshTitle();
		}

		// Token: 0x0602AE37 RID: 175671 RVA: 0x00C11068 File Offset: 0x00C0F268
		private void HandleChooseState(int selectId, bool isSelected)
		{
			PhantomArenaChooseCardItem layoutItemByKey = this.Layout.GetLayoutItemByKey(selectId);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetChooseState(isSelected);
			}
			if (isSelected)
			{
				this.SelectedIdSet.Add(selectId);
				return;
			}
			this.SelectedIdSet.Remove(selectId);
		}

		// Token: 0x0602AE38 RID: 175672 RVA: 0x00C110B0 File Offset: 0x00C0F2B0
		private void CancelChooseLastState()
		{
			if (this.SelectedIdSet.Count <= 0)
			{
				return;
			}
			int num = 0;
			using (HashSet<int>.Enumerator enumerator = this.SelectedIdSet.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
			if (num != 0)
			{
				this.HandleChooseState(num, false);
				this.ResetToggleState(num);
			}
		}

		// Token: 0x0602AE39 RID: 175673 RVA: 0x00C11124 File Offset: 0x00C0F324
		private void HandleSelectState(int selectId)
		{
			if (this.CurrentSelectId == selectId)
			{
				return;
			}
			if (this.CurrentSelectId != -1)
			{
				PhantomArenaChooseCardItem layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentSelectId);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetSelectState(false);
				}
			}
			PhantomArenaChooseCardItem layoutItemByKey2 = this.Layout.GetLayoutItemByKey(selectId);
			if (layoutItemByKey2 != null)
			{
				layoutItemByKey2.SetSelectState(true);
				this.ViewProxy.ShowCardTips(layoutItemByKey2.Card.Data, false);
			}
			this.CurrentSelectId = selectId;
		}

		// Token: 0x0602AE3A RID: 175674 RVA: 0x00C111A0 File Offset: 0x00C0F3A0
		private void CancelSelectState()
		{
			if (this.CurrentSelectId == -1)
			{
				return;
			}
			PhantomArenaChooseCardItem layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentSelectId);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetSelectState(false);
			}
			this.CurrentSelectId = -1;
			this.ViewProxy.HideCardTips();
		}

		// Token: 0x0602AE3B RID: 175675 RVA: 0x00C111E0 File Offset: 0x00C0F3E0
		private void ResetToggleState(int selectId)
		{
			PhantomArenaChooseCardItem layoutItemByKey = this.Layout.GetLayoutItemByKey(selectId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x0602AE3C RID: 175676 RVA: 0x00C11204 File Offset: 0x00C0F404
		private void RefreshConfirmInteractive()
		{
			base.GetButton(3).SetSelfInteractive(this.SelectedIdSet.Count >= this.LimitCount);
		}

		// Token: 0x0602AE3D RID: 175677 RVA: 0x00C11228 File Offset: 0x00C0F428
		private void RefreshTitle()
		{
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1124", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.SelectedIdSet.Count,
				this.LimitCount
			}));
		}

		// Token: 0x0602AE3E RID: 175678 RVA: 0x00C11279 File Offset: 0x00C0F479
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x0602AE3F RID: 175679 RVA: 0x00C11282 File Offset: 0x00C0F482
		public void SetChooseCardData(IChooseCardPanelData data)
		{
			this.Data = data;
		}

		// Token: 0x0602AE40 RID: 175680 RVA: 0x00C1128C File Offset: 0x00C0F48C
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "BattleCardChooseById")
			{
				int num = int.Parse(configParams[1]);
				foreach (PhantomArenaChooseCardItem phantomArenaChooseCardItem in this.Layout.GetLayoutItemList())
				{
					if (phantomArenaChooseCardItem.Card.Data.ConfigId == num)
					{
						UUIItem rootItem = phantomArenaChooseCardItem.Card.GetRootItem();
						if (rootItem != null)
						{
							return new UUIItem[]
							{
								rootItem,
								rootItem
							};
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0401734D RID: 95053
		protected IChooseCardPanelData Data;

		// Token: 0x0401734E RID: 95054
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401734F RID: 95055
		protected HashSet<int> SelectedIdSet = new HashSet<int>();

		// Token: 0x04017350 RID: 95056
		protected int LimitCount;

		// Token: 0x04017351 RID: 95057
		protected GenericLayout<PhantomArenaChooseCardItem, PhantomCardData> Layout;

		// Token: 0x04017352 RID: 95058
		protected int CurrentSelectId = -1;

		// Token: 0x04017353 RID: 95059
		public Action ConfirmFunc;

		// Token: 0x02009E8D RID: 40589
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031489 RID: 201865
			public const int Layout = 0;

			// Token: 0x0403148A RID: 201866
			public const int LayoutItem = 1;

			// Token: 0x0403148B RID: 201867
			public const int ContentItem = 2;

			// Token: 0x0403148C RID: 201868
			public const int ConfirmBtn = 3;

			// Token: 0x0403148D RID: 201869
			public const int VisibleToggle = 4;

			// Token: 0x0403148E RID: 201870
			public const int EmptyBtn = 5;

			// Token: 0x0403148F RID: 201871
			public const int Title = 6;
		}
	}
}
