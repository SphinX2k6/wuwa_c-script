using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200526C RID: 21100
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChooseCardPanel : UiPanelBase
	{
		// Token: 0x06035F32 RID: 220978 RVA: 0x00CC3670 File Offset: 0x00CC1870
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

		// Token: 0x06035F33 RID: 220979 RVA: 0x00CC3775 File Offset: 0x00CC1975
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<PhantomArenaChooseCardItem, PhantomCardData>(base.GetLayoutBase(0), new Func<PhantomArenaChooseCardItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06035F34 RID: 220980 RVA: 0x00CC37A8 File Offset: 0x00CC19A8
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaChooseCardPanel.<OnBeforeShowAsyncImplement>d__10 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaChooseCardPanel.<OnBeforeShowAsyncImplement>d__10>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035F35 RID: 220981 RVA: 0x00CC37EC File Offset: 0x00CC19EC
		protected override void OnAfterHide()
		{
			base.GetItem(2).SetUIActive(true);
			this.ViewProxy.HideCardTips();
			this.ViewProxy.SetCaptionItemActive(true);
			this.ViewProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.ChooseCardSkillInteract);
			this.ViewProxy.SetIsMainInVisible(true);
			this.ViewProxy.SetInPanelInteractType(EPhantomArenaBattlePanelInteractType.MainView);
		}

		// Token: 0x06035F36 RID: 220982 RVA: 0x00CC3841 File Offset: 0x00CC1A41
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaChooseCardPanelShow);
		}

		// Token: 0x06035F37 RID: 220983 RVA: 0x00CC3853 File Offset: 0x00CC1A53
		private PhantomArenaChooseCardItem InitItem()
		{
			return new PhantomArenaChooseCardItem
			{
				ClickCallback = new Action<PhantomCardData, bool>(this.CardClick)
			};
		}

		// Token: 0x06035F38 RID: 220984 RVA: 0x00CC386C File Offset: 0x00CC1A6C
		private void OnVisibleToggleClick(EToggleState state)
		{
			bool flag = state != EToggleState.ETT_Checked;
			this.ViewProxy.SetIsMainInVisible(!flag);
			this.ViewProxy.HideCardTips();
			base.GetItem(2).SetUIActive(flag);
		}

		// Token: 0x06035F39 RID: 220985 RVA: 0x00CC38A8 File Offset: 0x00CC1AA8
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

		// Token: 0x06035F3A RID: 220986 RVA: 0x00CC38D7 File Offset: 0x00CC1AD7
		private void OnEmptyClick()
		{
			this.CancelSelectState();
		}

		// Token: 0x06035F3B RID: 220987 RVA: 0x00CC38E0 File Offset: 0x00CC1AE0
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

		// Token: 0x06035F3C RID: 220988 RVA: 0x00CC39A0 File Offset: 0x00CC1BA0
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

		// Token: 0x06035F3D RID: 220989 RVA: 0x00CC39E8 File Offset: 0x00CC1BE8
		private void CancelChooseLastState()
		{
			if (this.SelectedIdSet.Count <= 0)
			{
				return;
			}
			int num = this.SelectedIdSet.First<int>();
			if (num != 0)
			{
				this.HandleChooseState(num, false);
				this.ResetToggleState(num);
			}
		}

		// Token: 0x06035F3E RID: 220990 RVA: 0x00CC3A24 File Offset: 0x00CC1C24
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

		// Token: 0x06035F3F RID: 220991 RVA: 0x00CC3AA0 File Offset: 0x00CC1CA0
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

		// Token: 0x06035F40 RID: 220992 RVA: 0x00CC3AE0 File Offset: 0x00CC1CE0
		private void ResetToggleState(int selectId)
		{
			PhantomArenaChooseCardItem layoutItemByKey = this.Layout.GetLayoutItemByKey(selectId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x06035F41 RID: 220993 RVA: 0x00CC3B04 File Offset: 0x00CC1D04
		private void RefreshConfirmInteractive()
		{
			base.GetButton(3).SetSelfInteractive(this.SelectedIdSet.Count >= this.LimitCount);
		}

		// Token: 0x06035F42 RID: 220994 RVA: 0x00CC3B28 File Offset: 0x00CC1D28
		private void RefreshTitle()
		{
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1124", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.SelectedIdSet.Count,
				this.LimitCount
			}));
		}

		// Token: 0x06035F43 RID: 220995 RVA: 0x00CC3B79 File Offset: 0x00CC1D79
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x06035F44 RID: 220996 RVA: 0x00CC3B82 File Offset: 0x00CC1D82
		public void SetChooseCardData(IChooseCardPanelData data)
		{
			this.Data = data;
		}

		// Token: 0x06035F45 RID: 220997 RVA: 0x00CC3B8C File Offset: 0x00CC1D8C
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

		// Token: 0x0401C918 RID: 117016
		protected IChooseCardPanelData Data;

		// Token: 0x0401C919 RID: 117017
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C91A RID: 117018
		protected HashSet<int> SelectedIdSet = new HashSet<int>();

		// Token: 0x0401C91B RID: 117019
		protected int LimitCount;

		// Token: 0x0401C91C RID: 117020
		protected GenericLayout<PhantomArenaChooseCardItem, PhantomCardData> Layout;

		// Token: 0x0401C91D RID: 117021
		protected int CurrentSelectId = -1;

		// Token: 0x0401C91E RID: 117022
		public Action ConfirmFunc;

		// Token: 0x0200B455 RID: 46165
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036A36 RID: 223798
			public const int Layout = 0;

			// Token: 0x04036A37 RID: 223799
			public const int LayoutItem = 1;

			// Token: 0x04036A38 RID: 223800
			public const int ContentItem = 2;

			// Token: 0x04036A39 RID: 223801
			public const int ConfirmBtn = 3;

			// Token: 0x04036A3A RID: 223802
			public const int VisibleToggle = 4;

			// Token: 0x04036A3B RID: 223803
			public const int EmptyBtn = 5;

			// Token: 0x04036A3C RID: 223804
			public const int Title = 6;
		}
	}
}
