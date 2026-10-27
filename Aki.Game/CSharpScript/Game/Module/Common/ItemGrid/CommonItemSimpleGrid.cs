using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.ItemGrid
{
	// Token: 0x02005B70 RID: 23408
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonItemSimpleGrid : GridProxyAbstract<TItem>
	{
		// Token: 0x0603B397 RID: 242583 RVA: 0x00E1ED97 File Offset: 0x00E1CF97
		public int GetItemId()
		{
			return this.ItemConfigId;
		}

		// Token: 0x0603B398 RID: 242584 RVA: 0x00E1ED9F File Offset: 0x00E1CF9F
		public CommonItemSimpleGrid()
		{
			this.ClickCallback = delegate(int itemConfigId)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null);
			};
		}

		// Token: 0x0603B399 RID: 242585 RVA: 0x00E1EDD8 File Offset: 0x00E1CFD8
		public CommonItemSimpleGrid(AActor commonItemActor = null)
		{
			this.ClickCallback = delegate(int itemConfigId)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null);
			};
			if (commonItemActor != null)
			{
				this.CreateThenShowByActor(commonItemActor);
			}
		}

		// Token: 0x0603B39A RID: 242586 RVA: 0x00E1EE28 File Offset: 0x00E1D028
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B39B RID: 242587 RVA: 0x00E1EF94 File Offset: 0x00E1D194
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int, int>(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
		}

		// Token: 0x0603B39C RID: 242588 RVA: 0x00E1EFB2 File Offset: 0x00E1D1B2
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
		}

		// Token: 0x0603B39D RID: 242589 RVA: 0x00E1EFD0 File Offset: 0x00E1D1D0
		private void OnCloseItemTips(int itemId, int i)
		{
			if (itemId != this.ItemConfigId)
			{
				return;
			}
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603B39E RID: 242590 RVA: 0x00E1EFED File Offset: 0x00E1D1ED
		private void OnToggleClick(EToggleState state)
		{
			if (this.ClickCallback == null)
			{
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				this.ClickCallback(this.ItemConfigId);
			}
		}

		// Token: 0x0603B39F RID: 242591 RVA: 0x00E1F00D File Offset: 0x00E1D20D
		public void ResetToggleClick()
		{
			base.GetExtendToggle(4).OnStateChange.Clear();
			base.GetExtendToggle(4).OnStateChange.Add(new Action<EToggleState>(this.OnToggleClick));
		}

		// Token: 0x0603B3A0 RID: 242592 RVA: 0x00E1F040 File Offset: 0x00E1D240
		private void UpdateView()
		{
			UUITexture texture = base.GetTexture(1);
			base.SetItemIcon(texture, this.ItemConfigId, this.BelongViewName, null);
			UUISprite sprite = base.GetSprite(0);
			base.SetItemQualityIcon(sprite, this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0603B3A1 RID: 242593 RVA: 0x00E1F088 File Offset: 0x00E1D288
		public override void Refresh(TItem data, bool isSelect, int gridIndex)
		{
			InventoryDefine.IGetItemData itemData = data.ItemData;
			int count = data.Count;
			this.RefreshItem(itemData.ItemId, count);
		}

		// Token: 0x0603B3A2 RID: 242594 RVA: 0x00E1F0B0 File Offset: 0x00E1D2B0
		public void SetQualityActive(bool isShow)
		{
			base.GetSprite(0).SetUIActive(isShow);
		}

		// Token: 0x0603B3A3 RID: 242595 RVA: 0x00E1F0BF File Offset: 0x00E1D2BF
		public void SetCanReceiveActive(bool isShow)
		{
			base.GetSprite(5).SetUIActive(false);
		}

		// Token: 0x0603B3A4 RID: 242596 RVA: 0x00E1F0CE File Offset: 0x00E1D2CE
		public void SetLockReceiveActive(bool isShow)
		{
			base.GetSprite(6).SetUIActive(isShow);
		}

		// Token: 0x0603B3A5 RID: 242597 RVA: 0x00E1F0DD File Offset: 0x00E1D2DD
		public void SetReceivedActive(bool isShow)
		{
			base.GetItem(7).SetUIActive(isShow);
		}

		// Token: 0x0603B3A6 RID: 242598 RVA: 0x00E1F0EC File Offset: 0x00E1D2EC
		public void SetBelongViewName(EUiViewName viewName)
		{
			this.BelongViewName = new EUiViewName?(viewName);
		}

		// Token: 0x0603B3A7 RID: 242599 RVA: 0x00E1F0FA File Offset: 0x00E1D2FA
		public void RefreshItem(int itemConfigId, int itemCount = 0)
		{
			this.ItemConfigId = itemConfigId;
			this.UpdateView();
			this.SetCount(itemCount);
		}

		// Token: 0x0603B3A8 RID: 242600 RVA: 0x00E1F110 File Offset: 0x00E1D310
		[NullableContext(1)]
		public void BindClickCallback(Action<int> clickCallback)
		{
			this.ClickCallback = clickCallback;
		}

		// Token: 0x0603B3A9 RID: 242601 RVA: 0x00E1F119 File Offset: 0x00E1D319
		private void SetCount(int count = 0)
		{
			if (count == 0)
			{
				this.GetCountItem().SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalText(this.GetCountText(), this.CountTextId, new <>z__ReadOnlySingleElementList<object>(count));
			this.GetCountItem().SetUIActive(true);
		}

		// Token: 0x0603B3AA RID: 242602 RVA: 0x00E1F158 File Offset: 0x00E1D358
		private UUIText GetCountText()
		{
			return base.GetText(2);
		}

		// Token: 0x0603B3AB RID: 242603 RVA: 0x00E1F161 File Offset: 0x00E1D361
		private UUIItem GetCountItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x0603B3AC RID: 242604 RVA: 0x00E1F16A File Offset: 0x00E1D36A
		[NullableContext(1)]
		public void SetCountTextId(string textId)
		{
			this.CountTextId = textId;
		}

		// Token: 0x0603B3AD RID: 242605 RVA: 0x00E1F174 File Offset: 0x00E1D374
		public UniTask RefreshItemAsync(int itemConfigId, int itemCount = 0)
		{
			CommonItemSimpleGrid.<RefreshItemAsync>d__27 <RefreshItemAsync>d__;
			<RefreshItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemAsync>d__.<>4__this = this;
			<RefreshItemAsync>d__.itemConfigId = itemConfigId;
			<RefreshItemAsync>d__.itemCount = itemCount;
			<RefreshItemAsync>d__.<>1__state = -1;
			<RefreshItemAsync>d__.<>t__builder.Start<CommonItemSimpleGrid.<RefreshItemAsync>d__27>(ref <RefreshItemAsync>d__);
			return <RefreshItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3AE RID: 242606 RVA: 0x00E1F1C8 File Offset: 0x00E1D3C8
		private UniTask UpdateViewAsync()
		{
			CommonItemSimpleGrid.<UpdateViewAsync>d__28 <UpdateViewAsync>d__;
			<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateViewAsync>d__.<>4__this = this;
			<UpdateViewAsync>d__.<>1__state = -1;
			<UpdateViewAsync>d__.<>t__builder.Start<CommonItemSimpleGrid.<UpdateViewAsync>d__28>(ref <UpdateViewAsync>d__);
			return <UpdateViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401EE35 RID: 126517
		private int ItemConfigId;

		// Token: 0x0401EE36 RID: 126518
		[Nullable(1)]
		private string CountTextId = "ShowCount";

		// Token: 0x0401EE37 RID: 126519
		private EUiViewName? BelongViewName;

		// Token: 0x0401EE38 RID: 126520
		private Action<int> ClickCallback;

		// Token: 0x0200BD7D RID: 48509
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039290 RID: 234128
			SpriteQuality,
			// Token: 0x04039291 RID: 234129
			TextureIcon,
			// Token: 0x04039292 RID: 234130
			TextCount,
			// Token: 0x04039293 RID: 234131
			NumItem,
			// Token: 0x04039294 RID: 234132
			ToggleClick,
			// Token: 0x04039295 RID: 234133
			CanReceiveSprite,
			// Token: 0x04039296 RID: 234134
			LockSprite,
			// Token: 0x04039297 RID: 234135
			ReceivedItem
		}
	}
}
