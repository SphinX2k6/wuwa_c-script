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
	// Token: 0x02004B50 RID: 19280
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonItemSimpleGrid : GridProxyAbstract<TItem>
	{
		// Token: 0x060302E4 RID: 197348 RVA: 0x00D6F30B File Offset: 0x00D6D50B
		public int GetItemId()
		{
			return this.ItemConfigId;
		}

		// Token: 0x060302E5 RID: 197349 RVA: 0x00D6F313 File Offset: 0x00D6D513
		public CommonItemSimpleGrid()
		{
			this.ClickCallback = delegate(int itemConfigId)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null, false);
			};
		}

		// Token: 0x060302E6 RID: 197350 RVA: 0x00D6F34C File Offset: 0x00D6D54C
		public CommonItemSimpleGrid(AActor commonItemActor = null)
		{
			this.ClickCallback = delegate(int itemConfigId)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null, false);
			};
			if (commonItemActor != null)
			{
				this.CreateThenShowByActor(commonItemActor);
			}
		}

		// Token: 0x060302E7 RID: 197351 RVA: 0x00D6F39C File Offset: 0x00D6D59C
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

		// Token: 0x060302E8 RID: 197352 RVA: 0x00D6F508 File Offset: 0x00D6D708
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int, int>(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
		}

		// Token: 0x060302E9 RID: 197353 RVA: 0x00D6F526 File Offset: 0x00D6D726
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
		}

		// Token: 0x060302EA RID: 197354 RVA: 0x00D6F544 File Offset: 0x00D6D744
		private void OnCloseItemTips(int itemId, int i)
		{
			if (itemId != this.ItemConfigId)
			{
				return;
			}
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060302EB RID: 197355 RVA: 0x00D6F561 File Offset: 0x00D6D761
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

		// Token: 0x060302EC RID: 197356 RVA: 0x00D6F581 File Offset: 0x00D6D781
		public void ResetToggleClick()
		{
			base.GetExtendToggle(4).OnStateChange.Clear();
			base.GetExtendToggle(4).OnStateChange.Add(new Action<EToggleState>(this.OnToggleClick));
		}

		// Token: 0x060302ED RID: 197357 RVA: 0x00D6F5B4 File Offset: 0x00D6D7B4
		private void UpdateView()
		{
			UUITexture texture = base.GetTexture(1);
			base.SetItemIcon(texture, this.ItemConfigId, this.BelongViewName, null);
			UUISprite sprite = base.GetSprite(0);
			base.SetItemQualityIcon(sprite, this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x060302EE RID: 197358 RVA: 0x00D6F5FC File Offset: 0x00D6D7FC
		public override void Refresh(TItem data, bool isSelect, int gridIndex)
		{
			InventoryDefine.IGetItemData itemData = data.ItemData;
			int count = data.Count;
			this.RefreshItem(itemData.ItemId, count);
		}

		// Token: 0x060302EF RID: 197359 RVA: 0x00D6F624 File Offset: 0x00D6D824
		public void SetQualityActive(bool isShow)
		{
			base.GetSprite(0).SetUIActive(isShow);
		}

		// Token: 0x060302F0 RID: 197360 RVA: 0x00D6F633 File Offset: 0x00D6D833
		public void SetCanReceiveActive(bool isShow)
		{
			base.GetSprite(5).SetUIActive(false);
		}

		// Token: 0x060302F1 RID: 197361 RVA: 0x00D6F642 File Offset: 0x00D6D842
		public void SetLockReceiveActive(bool isShow)
		{
			base.GetSprite(6).SetUIActive(isShow);
		}

		// Token: 0x060302F2 RID: 197362 RVA: 0x00D6F651 File Offset: 0x00D6D851
		public void SetReceivedActive(bool isShow)
		{
			base.GetItem(7).SetUIActive(isShow);
		}

		// Token: 0x060302F3 RID: 197363 RVA: 0x00D6F660 File Offset: 0x00D6D860
		public void SetBelongViewName(EUiViewName viewName)
		{
			this.BelongViewName = new EUiViewName?(viewName);
		}

		// Token: 0x060302F4 RID: 197364 RVA: 0x00D6F66E File Offset: 0x00D6D86E
		public void RefreshItem(int itemConfigId, int itemCount = 0)
		{
			this.ItemConfigId = itemConfigId;
			this.UpdateView();
			this.SetCount(itemCount);
		}

		// Token: 0x060302F5 RID: 197365 RVA: 0x00D6F684 File Offset: 0x00D6D884
		[NullableContext(1)]
		public void BindClickCallback(Action<int> clickCallback)
		{
			this.ClickCallback = clickCallback;
		}

		// Token: 0x060302F6 RID: 197366 RVA: 0x00D6F68D File Offset: 0x00D6D88D
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

		// Token: 0x060302F7 RID: 197367 RVA: 0x00D6F6CC File Offset: 0x00D6D8CC
		private UUIText GetCountText()
		{
			return base.GetText(2);
		}

		// Token: 0x060302F8 RID: 197368 RVA: 0x00D6F6D5 File Offset: 0x00D6D8D5
		private UUIItem GetCountItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x060302F9 RID: 197369 RVA: 0x00D6F6DE File Offset: 0x00D6D8DE
		[NullableContext(1)]
		public void SetCountTextId(string textId)
		{
			this.CountTextId = textId;
		}

		// Token: 0x060302FA RID: 197370 RVA: 0x00D6F6E8 File Offset: 0x00D6D8E8
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

		// Token: 0x060302FB RID: 197371 RVA: 0x00D6F73C File Offset: 0x00D6D93C
		private UniTask UpdateViewAsync()
		{
			CommonItemSimpleGrid.<UpdateViewAsync>d__28 <UpdateViewAsync>d__;
			<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateViewAsync>d__.<>4__this = this;
			<UpdateViewAsync>d__.<>1__state = -1;
			<UpdateViewAsync>d__.<>t__builder.Start<CommonItemSimpleGrid.<UpdateViewAsync>d__28>(ref <UpdateViewAsync>d__);
			return <UpdateViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040198E6 RID: 104678
		private int ItemConfigId;

		// Token: 0x040198E7 RID: 104679
		[Nullable(1)]
		private string CountTextId = "ShowCount";

		// Token: 0x040198E8 RID: 104680
		private EUiViewName? BelongViewName;

		// Token: 0x040198E9 RID: 104681
		private Action<int> ClickCallback;

		// Token: 0x0200A787 RID: 42887
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04033C5E RID: 212062
			SpriteQuality,
			// Token: 0x04033C5F RID: 212063
			TextureIcon,
			// Token: 0x04033C60 RID: 212064
			TextCount,
			// Token: 0x04033C61 RID: 212065
			NumItem,
			// Token: 0x04033C62 RID: 212066
			ToggleClick,
			// Token: 0x04033C63 RID: 212067
			CanReceiveSprite,
			// Token: 0x04033C64 RID: 212068
			LockSprite,
			// Token: 0x04033C65 RID: 212069
			ReceivedItem
		}
	}
}
