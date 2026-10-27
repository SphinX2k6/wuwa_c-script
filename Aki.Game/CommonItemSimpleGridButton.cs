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

// Token: 0x020018B8 RID: 6328
[NullableContext(1)]
[Nullable(0)]
public class CommonItemSimpleGridButton : GridProxyAbstract<TItem>
{
	// Token: 0x17000F5A RID: 3930
	// (get) Token: 0x0600B969 RID: 47465 RVA: 0x002A0E2E File Offset: 0x0029F02E
	public int ItemId
	{
		get
		{
			return this.ItemConfigId;
		}
	}

	// Token: 0x0600B96A RID: 47466 RVA: 0x002A0E38 File Offset: 0x0029F038
	[NullableContext(2)]
	public CommonItemSimpleGridButton(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x0600B96B RID: 47467 RVA: 0x002A0E88 File Offset: 0x0029F088
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

	// Token: 0x0600B96C RID: 47468 RVA: 0x002A0F89 File Offset: 0x0029F189
	protected override void OnStart()
	{
	}

	// Token: 0x0600B96D RID: 47469 RVA: 0x002A0F8B File Offset: 0x0029F18B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600B96E RID: 47470 RVA: 0x002A0F8D File Offset: 0x0029F18D
	private void ButtonClick()
	{
		if (this.ClickCallback == null)
		{
			return;
		}
		this.ClickCallback(this.ItemConfigId);
	}

	// Token: 0x0600B96F RID: 47471 RVA: 0x002A0FAC File Offset: 0x0029F1AC
	private void UpdateView()
	{
		UUITexture texture = base.GetTexture(1);
		base.SetItemIcon(texture, this.ItemConfigId, this.BelongViewName, null);
		UUISprite sprite = base.GetSprite(0);
		base.SetItemQualityIcon(sprite, this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x0600B970 RID: 47472 RVA: 0x002A0FF4 File Offset: 0x0029F1F4
	public override void Refresh(TItem data, bool isSelect, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.RefreshItem(itemData.ItemId, count);
	}

	// Token: 0x0600B971 RID: 47473 RVA: 0x002A101C File Offset: 0x0029F21C
	public void SetQualityActive(bool isShow)
	{
		base.GetSprite(0).SetUIActive(isShow);
	}

	// Token: 0x0600B972 RID: 47474 RVA: 0x002A102B File Offset: 0x0029F22B
	public void SetCanReceiveActive(bool isShow)
	{
		base.GetSprite(5).SetUIActive(isShow);
	}

	// Token: 0x0600B973 RID: 47475 RVA: 0x002A103A File Offset: 0x0029F23A
	public void SetLockReceiveActive(bool isShow)
	{
		base.GetSprite(6).SetUIActive(isShow);
	}

	// Token: 0x0600B974 RID: 47476 RVA: 0x002A1049 File Offset: 0x0029F249
	public void SetReceivedActive(bool isShow)
	{
		base.GetItem(7).SetUIActive(isShow);
	}

	// Token: 0x0600B975 RID: 47477 RVA: 0x002A1058 File Offset: 0x0029F258
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600B976 RID: 47478 RVA: 0x002A1066 File Offset: 0x0029F266
	public void RefreshItem(int itemConfigId, int itemCount = 0)
	{
		this.ItemConfigId = itemConfigId;
		this.UpdateView();
		this.SetCount(itemCount);
	}

	// Token: 0x0600B977 RID: 47479 RVA: 0x002A107C File Offset: 0x0029F27C
	public void BindClickCallback(Action<int> clickCallback)
	{
		this.ClickCallback = clickCallback;
	}

	// Token: 0x0600B978 RID: 47480 RVA: 0x002A1085 File Offset: 0x0029F285
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

	// Token: 0x0600B979 RID: 47481 RVA: 0x002A10C4 File Offset: 0x0029F2C4
	[NullableContext(2)]
	protected UUIText GetCountText()
	{
		return base.GetText(2);
	}

	// Token: 0x0600B97A RID: 47482 RVA: 0x002A10CD File Offset: 0x0029F2CD
	[NullableContext(2)]
	protected UUIItem GetCountItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x0600B97B RID: 47483 RVA: 0x002A10D6 File Offset: 0x0029F2D6
	public void SetCountTextId(string textId)
	{
		this.CountTextId = textId;
	}

	// Token: 0x0600B97C RID: 47484 RVA: 0x002A10E0 File Offset: 0x0029F2E0
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

	// Token: 0x0600B97D RID: 47485 RVA: 0x002A1134 File Offset: 0x0029F334
	private UniTask UpdateViewAsync()
	{
		CommonItemSimpleGridButton.<UpdateViewAsync>d__26 <UpdateViewAsync>d__;
		<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewAsync>d__.<>4__this = this;
		<UpdateViewAsync>d__.<>1__state = -1;
		<UpdateViewAsync>d__.<>t__builder.Start<CommonItemSimpleGridButton.<UpdateViewAsync>d__26>(ref <UpdateViewAsync>d__);
		return <UpdateViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04005423 RID: 21539
	private int ItemConfigId;

	// Token: 0x04005424 RID: 21540
	private string CountTextId = "ShowCount";

	// Token: 0x04005425 RID: 21541
	private EUiViewName? BelongViewName;

	// Token: 0x04005426 RID: 21542
	private Action<int> ClickCallback = delegate(int itemConfigId)
	{
		ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null);
	};

	// Token: 0x02007E45 RID: 32325
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x04029522 RID: 169250
		SpriteQuality,
		// Token: 0x04029523 RID: 169251
		TextureIcon,
		// Token: 0x04029524 RID: 169252
		TextCount,
		// Token: 0x04029525 RID: 169253
		NumItem,
		// Token: 0x04029526 RID: 169254
		ButtonClick,
		// Token: 0x04029527 RID: 169255
		CanReceiveSprite,
		// Token: 0x04029528 RID: 169256
		LockSprite,
		// Token: 0x04029529 RID: 169257
		ReceivedItem,
		// Token: 0x0402952A RID: 169258
		AddSprite
	}
}
