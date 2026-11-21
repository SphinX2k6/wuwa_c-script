using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054D5 RID: 21717
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LinkageRewardRewardItem : GridProxyAbstract<TimePointRewardData>
	{
		// Token: 0x06035CEE RID: 220398 RVA: 0x00F08490 File Offset: 0x00F06690
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035CEF RID: 220399 RVA: 0x00F08640 File Offset: 0x00F06840
		protected override UniTask OnBeforeStartAsync()
		{
			LinkageRewardRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LinkageRewardRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035CF0 RID: 220400 RVA: 0x00F08684 File Offset: 0x00F06884
		[NullableContext(1)]
		public override void Refresh(TimePointRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GridIndex = gridIndex;
			this.ClearRewardVisual();
			if (data == null)
			{
				return;
			}
			LinkageReward? byId = LinkageRewardActivityConfig.Instance.GetById(data.Id);
			int num = (byId != null) ? byId.GetValueOrDefault().DropId : 0;
			if (num <= 0)
			{
				return;
			}
			ETimePointRewardState rewardState = data.RewardState;
			this.ApplyRewardState(rewardState, gridIndex);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(num);
			if (dropPackagePreviewItemList.Count <= 0 || this.RewardItemGrid == null)
			{
				return;
			}
			TItem titem = dropPackagePreviewItemList[0];
			this.TipItemConfigId = titem.ItemData.ItemId;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = this.Data,
				ItemConfigId = new int?(titem.ItemData.ItemId),
				BottomText = titem.Count.ToString(),
				IsLockVisible = new bool?(rewardState == ETimePointRewardState.Lock),
				IsReceivableVisible = new bool?(false),
				IsReceivedVisible = new bool?(rewardState == ETimePointRewardState.UnlockAndClaimed)
			};
			this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x06035CF1 RID: 220401 RVA: 0x00F08798 File Offset: 0x00F06998
		public UUIItem GetNavigationFocusItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
			if (uuiitem != null && uuiitem.IsValid())
			{
				return uuiitem;
			}
			SmallItemGrid rewardItemGrid = this.RewardItemGrid;
			UUIItem uuiitem2;
			if (rewardItemGrid == null)
			{
				uuiitem2 = null;
			}
			else
			{
				UUIExtendToggle itemGridExtendToggle = rewardItemGrid.GetItemGridExtendToggle();
				uuiitem2 = ((itemGridExtendToggle != null) ? itemGridExtendToggle.RootUIComp.Get() : null);
			}
			UUIItem uuiitem3 = uuiitem2;
			if (uuiitem3 != null && uuiitem3.IsValid())
			{
				return uuiitem3;
			}
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null || !rootItem.IsValid())
			{
				return null;
			}
			return rootItem;
		}

		// Token: 0x06035CF2 RID: 220402 RVA: 0x00F08818 File Offset: 0x00F06A18
		private void ClearRewardVisual()
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUISprite sprite3 = base.GetSprite(4);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(9);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
		}

		// Token: 0x06035CF3 RID: 220403 RVA: 0x00F088C0 File Offset: 0x00F06AC0
		private void ApplyRewardState(ETimePointRewardState state, int gridIndex)
		{
			bool uiactive = state == ETimePointRewardState.Lock;
			bool uiactive2 = state == ETimePointRewardState.UnlockAndUnClaimed;
			bool uiactive3 = state == ETimePointRewardState.UnlockAndClaimed;
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				TimePointRewardData data = this.Data;
				long num = (data != null) ? data.RewardTime : 0L;
				text.SetUIActive(num > 0L);
				if (num > 0L)
				{
					string item2 = num.ToString().PadLeft(2, '0');
					LguiUtil.Instance.SetLocalTextNew(text, "Dreamchasers_SignDay", new <>z__ReadOnlySingleElementList<object>(item2));
					LinkageRewardDayTextUtil.ApplyLinkageRewardDayTextStyle(text, state);
				}
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive2);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(uiactive2);
			}
			UUIItem item4 = base.GetItem(9);
			if (item4 != null)
			{
				item4.SetUIActive(uiactive2);
			}
			UUIItem item5 = base.GetItem(8);
			if (item5 != null)
			{
				item5.SetUIActive(uiactive3);
			}
			UUISprite sprite3 = base.GetSprite(4);
			if (sprite3 == null)
			{
				return;
			}
			sprite3.SetUIActive(uiactive3);
		}

		// Token: 0x06035CF4 RID: 220404 RVA: 0x00F089C2 File Offset: 0x00F06BC2
		private void OnClickedButton()
		{
			this.TryHandleRewardClick();
		}

		// Token: 0x06035CF5 RID: 220405 RVA: 0x00F089CA File Offset: 0x00F06BCA
		private void OnClickedGrid()
		{
			this.TryHandleRewardClick();
		}

		// Token: 0x06035CF6 RID: 220406 RVA: 0x00F089D4 File Offset: 0x00F06BD4
		private void TryHandleRewardClick()
		{
			TimePointRewardData data = this.Data;
			if (data == null || data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
			{
				if (this.TipItemConfigId > 0)
				{
					ItemController.Instance.OpenItemTipsByItemId(this.TipItemConfigId, true, null, false);
				}
				return;
			}
			Action<int, int, bool> onClickToGet = this.OnClickToGet;
			if (onClickToGet == null)
			{
				return;
			}
			onClickToGet(this.Data.Id, base.GridIndex, false);
		}

		// Token: 0x0401C78A RID: 116618
		private TimePointRewardData Data;

		// Token: 0x0401C78B RID: 116619
		private SmallItemGrid RewardItemGrid;

		// Token: 0x0401C78C RID: 116620
		private int TipItemConfigId;

		// Token: 0x0401C78D RID: 116621
		public Action<int, int, bool> OnClickToGet;

		// Token: 0x0200B130 RID: 45360
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036CB5 RID: 224437
			public const int BtnReward = 0;

			// Token: 0x04036CB6 RID: 224438
			public const int TxtDay = 1;

			// Token: 0x04036CB7 RID: 224439
			public const int SprBgLock = 2;

			// Token: 0x04036CB8 RID: 224440
			public const int SprBgSelect = 3;

			// Token: 0x04036CB9 RID: 224441
			public const int SprBgFinish = 4;

			// Token: 0x04036CBA RID: 224442
			public const int UiItemItemBaseB = 5;

			// Token: 0x04036CBB RID: 224443
			public const int PnlRectLock = 6;

			// Token: 0x04036CBC RID: 224444
			public const int PnlRectSelect = 7;

			// Token: 0x04036CBD RID: 224445
			public const int PnlRectFinish = 8;

			// Token: 0x04036CBE RID: 224446
			public const int ItemRedDot = 9;
		}
	}
}
