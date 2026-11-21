using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D71 RID: 3441
[NullableContext(1)]
[Nullable(0)]
public class CommonItemSimpleGridButton : GridProxyAbstract<TItem>
{
	// Token: 0x17000F7D RID: 3965
	// (get) Token: 0x06008D52 RID: 36178 RVA: 0x002AB582 File Offset: 0x002A9782
	public int ItemId
	{
		get
		{
			return this.ItemConfigId;
		}
	}

	// Token: 0x06008D53 RID: 36179 RVA: 0x002AB58C File Offset: 0x002A978C
	[NullableContext(2)]
	public CommonItemSimpleGridButton(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x06008D54 RID: 36180 RVA: 0x002AB5DC File Offset: 0x002A97DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.ButtonClick))
		};
	}

	// Token: 0x06008D55 RID: 36181 RVA: 0x002AB6DD File Offset: 0x002A98DD
	protected override void OnStart()
	{
	}

	// Token: 0x06008D56 RID: 36182 RVA: 0x002AB6DF File Offset: 0x002A98DF
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06008D57 RID: 36183 RVA: 0x002AB6E1 File Offset: 0x002A98E1
	private void ButtonClick()
	{
		if (this.ClickCallback == null)
		{
			return;
		}
		this.ClickCallback(this.ItemConfigId);
	}

	// Token: 0x06008D58 RID: 36184 RVA: 0x002AB700 File Offset: 0x002A9900
	private void UpdateView()
	{
		UUITexture texture = base.GetTexture(1);
		base.SetItemIcon(texture, this.ItemConfigId, this.BelongViewName, null);
		UUISprite sprite = base.GetSprite(0);
		base.SetItemQualityIcon(sprite, this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x06008D59 RID: 36185 RVA: 0x002AB748 File Offset: 0x002A9948
	public override void Refresh(TItem data, bool isSelect, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.RefreshItem(itemData.ItemId, count);
	}

	// Token: 0x06008D5A RID: 36186 RVA: 0x002AB770 File Offset: 0x002A9970
	public void SetQualityActive(bool isShow)
	{
		base.GetSprite(0).SetUIActive(isShow);
	}

	// Token: 0x06008D5B RID: 36187 RVA: 0x002AB77F File Offset: 0x002A997F
	public void SetCanReceiveActive(bool isShow)
	{
		base.GetSprite(5).SetUIActive(isShow);
	}

	// Token: 0x06008D5C RID: 36188 RVA: 0x002AB78E File Offset: 0x002A998E
	public void SetLockReceiveActive(bool isShow)
	{
		base.GetSprite(6).SetUIActive(isShow);
	}

	// Token: 0x06008D5D RID: 36189 RVA: 0x002AB79D File Offset: 0x002A999D
	public void SetReceivedActive(bool isShow)
	{
		base.GetItem(7).SetUIActive(isShow);
	}

	// Token: 0x06008D5E RID: 36190 RVA: 0x002AB7AC File Offset: 0x002A99AC
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x06008D5F RID: 36191 RVA: 0x002AB7BA File Offset: 0x002A99BA
	public void RefreshItem(int itemConfigId, int itemCount = 0)
	{
		this.ItemConfigId = itemConfigId;
		this.UpdateView();
		this.SetCount(itemCount);
	}

	// Token: 0x06008D60 RID: 36192 RVA: 0x002AB7D0 File Offset: 0x002A99D0
	public void BindClickCallback(Action<int> clickCallback)
	{
		this.ClickCallback = clickCallback;
	}

	// Token: 0x06008D61 RID: 36193 RVA: 0x002AB7D9 File Offset: 0x002A99D9
	protected void SetCount(int count = 0)
	{
		if (count == 0)
		{
			this.GetCountItem().SetUIActive(false);
			return;
		}
		LguiUtil.Instance.SetLocalText(this.GetCountText(), this.CountTextId, new <>z__ReadOnlySingleElementList<object>(count));
		this.GetCountItem().SetUIActive(true);
	}

	// Token: 0x06008D62 RID: 36194 RVA: 0x002AB818 File Offset: 0x002A9A18
	[NullableContext(2)]
	protected UUIText GetCountText()
	{
		return base.GetText(2);
	}

	// Token: 0x06008D63 RID: 36195 RVA: 0x002AB821 File Offset: 0x002A9A21
	[NullableContext(2)]
	protected UUIItem GetCountItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x06008D64 RID: 36196 RVA: 0x002AB82A File Offset: 0x002A9A2A
	public void SetCountTextId(string textId)
	{
		this.CountTextId = textId;
	}

	// Token: 0x06008D65 RID: 36197 RVA: 0x002AB834 File Offset: 0x002A9A34
	public UniTask RefreshItemAsync(int itemConfigId, int itemCount = 0)
	{
		CommonItemSimpleGridButton.<RefreshItemAsync>d__25 <RefreshItemAsync>d__;
		<RefreshItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItemAsync>d__.<>4__this = this;
		<RefreshItemAsync>d__.itemConfigId = itemConfigId;
		<RefreshItemAsync>d__.itemCount = itemCount;
		<RefreshItemAsync>d__.<>1__state = -1;
		<RefreshItemAsync>d__.<>t__builder.Start<CommonItemSimpleGridButton.<RefreshItemAsync>d__25>(ref <RefreshItemAsync>d__);
		return <RefreshItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008D66 RID: 36198 RVA: 0x002AB888 File Offset: 0x002A9A88
	private UniTask UpdateViewAsync()
	{
		CommonItemSimpleGridButton.<UpdateViewAsync>d__26 <UpdateViewAsync>d__;
		<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewAsync>d__.<>4__this = this;
		<UpdateViewAsync>d__.<>1__state = -1;
		<UpdateViewAsync>d__.<>t__builder.Start<CommonItemSimpleGridButton.<UpdateViewAsync>d__26>(ref <UpdateViewAsync>d__);
		return <UpdateViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040054CE RID: 21710
	private int ItemConfigId;

	// Token: 0x040054CF RID: 21711
	private string CountTextId = "ShowCount";

	// Token: 0x040054D0 RID: 21712
	private EUiViewName? BelongViewName;

	// Token: 0x040054D1 RID: 21713
	private Action<int> ClickCallback = delegate(int itemConfigId)
	{
		ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null, false);
	};

	// Token: 0x02006FCC RID: 28620
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x0402484F RID: 149583
		SpriteQuality,
		// Token: 0x04024850 RID: 149584
		TextureIcon,
		// Token: 0x04024851 RID: 149585
		TextCount,
		// Token: 0x04024852 RID: 149586
		NumItem,
		// Token: 0x04024853 RID: 149587
		ButtonClick,
		// Token: 0x04024854 RID: 149588
		CanReceiveSprite,
		// Token: 0x04024855 RID: 149589
		LockSprite,
		// Token: 0x04024856 RID: 149590
		ReceivedItem,
		// Token: 0x04024857 RID: 149591
		AddSprite
	}
}
