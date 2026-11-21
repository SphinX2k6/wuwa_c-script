using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000CAE RID: 3246
public class CommonItemGrid : GridProxyAbstract<TItem>
{
	// Token: 0x0600877F RID: 34687 RVA: 0x00293D62 File Offset: 0x00291F62
	[NullableContext(2)]
	public CommonItemGrid(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x06008780 RID: 34688 RVA: 0x00293D9C File Offset: 0x00291F9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x06008781 RID: 34689 RVA: 0x00293F10 File Offset: 0x00292110
	protected override void OnStart()
	{
		this.InitView();
		EventSystem.Instance.Add<int, int>(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
	}

	// Token: 0x06008782 RID: 34690 RVA: 0x00293F34 File Offset: 0x00292134
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
	}

	// Token: 0x06008783 RID: 34691 RVA: 0x00293F52 File Offset: 0x00292152
	private void OnCloseItemTips(int itemId, int i)
	{
		if (itemId != this.ItemConfigId)
		{
			return;
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008784 RID: 34692 RVA: 0x00293F6F File Offset: 0x0029216F
	private void ToggleClick(EToggleState state)
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

	// Token: 0x06008785 RID: 34693 RVA: 0x00293F8F File Offset: 0x0029218F
	private void InitView()
	{
		this.SetEmpty(false);
		this.SetLock(false);
		this.SetRoleHead(null);
		this.SetLevel(0);
	}

	// Token: 0x06008786 RID: 34694 RVA: 0x00293FAD File Offset: 0x002921AD
	private void UpdateView()
	{
		base.SetItemIcon(base.GetTexture(3), this.ItemConfigId, this.BelongViewName, null);
		base.SetItemQualityIcon(base.GetSprite(4), this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x06008787 RID: 34695 RVA: 0x00293FE4 File Offset: 0x002921E4
	public override void Refresh(TItem data, bool isSelect, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.RefreshItem(itemData.ItemId, count);
	}

	// Token: 0x06008788 RID: 34696 RVA: 0x0029400C File Offset: 0x0029220C
	public void SetQualityActive(bool isShow)
	{
		base.GetSprite(4).SetUIActive(isShow);
	}

	// Token: 0x06008789 RID: 34697 RVA: 0x0029401B File Offset: 0x0029221B
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600878A RID: 34698 RVA: 0x00294029 File Offset: 0x00292229
	public void RefreshItem(int itemConfigId, int itemCount = 0)
	{
		this.ItemConfigId = itemConfigId;
		this.UpdateView();
		this.SetCount(itemCount);
	}

	// Token: 0x0600878B RID: 34699 RVA: 0x0029403F File Offset: 0x0029223F
	[NullableContext(1)]
	public void BindClickCallback(Action<int> clickCallback)
	{
		this.ClickCallback = clickCallback;
	}

	// Token: 0x0600878C RID: 34700 RVA: 0x00294048 File Offset: 0x00292248
	private void SetCount(int count = 0)
	{
		if (count == 0)
		{
			base.GetItem(12).SetUIActive(false);
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(10), "ShowCount", new <>z__ReadOnlySingleElementList<object>(count));
		base.GetItem(12).SetUIActive(true);
	}

	// Token: 0x0600878D RID: 34701 RVA: 0x00294098 File Offset: 0x00292298
	[NullableContext(2)]
	public void SetRoleHead(string texturePath = null)
	{
		UUITexture texture = base.GetTexture(6);
		UUISprite sprite = base.GetSprite(7);
		if (!StringUtils.IsEmpty(texturePath))
		{
			texture.SetUIActive(true);
			sprite.SetUIActive(true);
			base.SetTextureByPath(texturePath, texture, null, null);
			return;
		}
		texture.SetUIActive(false);
		sprite.SetUIActive(false);
	}

	// Token: 0x0600878E RID: 34702 RVA: 0x002940EC File Offset: 0x002922EC
	private void SetLevel(int level = 0)
	{
		if (level == 0)
		{
			base.GetItem(9).SetUIActive(false);
			return;
		}
		base.GetText(8).SetText(level.ToString("F0"), true);
		base.GetItem(9).SetUIActive(true);
	}

	// Token: 0x0600878F RID: 34703 RVA: 0x00294127 File Offset: 0x00292327
	public void SetMask(bool value)
	{
		base.GetTexture(11).SetUIActive(value);
	}

	// Token: 0x06008790 RID: 34704 RVA: 0x00294137 File Offset: 0x00292337
	public void SetEmpty(bool value)
	{
		base.GetItem(2).SetUIActive(value);
		base.GetItem(1).SetUIActive(!value);
	}

	// Token: 0x06008791 RID: 34705 RVA: 0x00294156 File Offset: 0x00292356
	public void SetLock(bool value)
	{
		base.GetItem(5).SetUIActive(value);
	}

	// Token: 0x06008792 RID: 34706 RVA: 0x00294165 File Offset: 0x00292365
	public void SetReceived(bool value)
	{
		base.GetItem(13).SetUIActive(value);
	}

	// Token: 0x06008793 RID: 34707 RVA: 0x00294175 File Offset: 0x00292375
	public void SetCountTextVisible(bool value)
	{
		base.GetItem(12).SetUIActive(value);
	}

	// Token: 0x06008794 RID: 34708 RVA: 0x00294188 File Offset: 0x00292388
	public UniTask RefreshItemAsync(int itemConfigId, int itemCount = 0)
	{
		CommonItemGrid.<RefreshItemAsync>d__25 <RefreshItemAsync>d__;
		<RefreshItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItemAsync>d__.<>4__this = this;
		<RefreshItemAsync>d__.itemConfigId = itemConfigId;
		<RefreshItemAsync>d__.itemCount = itemCount;
		<RefreshItemAsync>d__.<>1__state = -1;
		<RefreshItemAsync>d__.<>t__builder.Start<CommonItemGrid.<RefreshItemAsync>d__25>(ref <RefreshItemAsync>d__);
		return <RefreshItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008795 RID: 34709 RVA: 0x002941DC File Offset: 0x002923DC
	private UniTask UpdateViewAsync()
	{
		CommonItemGrid.<UpdateViewAsync>d__26 <UpdateViewAsync>d__;
		<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewAsync>d__.<>4__this = this;
		<UpdateViewAsync>d__.<>1__state = -1;
		<UpdateViewAsync>d__.<>t__builder.Start<CommonItemGrid.<UpdateViewAsync>d__26>(ref <UpdateViewAsync>d__);
		return <UpdateViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040051FB RID: 20987
	private int ItemConfigId;

	// Token: 0x040051FC RID: 20988
	private EUiViewName? BelongViewName;

	// Token: 0x040051FD RID: 20989
	[Nullable(1)]
	private Action<int> ClickCallback = delegate(int itemConfigId)
	{
		ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null, false);
	};

	// Token: 0x02006F74 RID: 28532
	private enum EChildComponentType
	{
		// Token: 0x04024692 RID: 149138
		ToggleClick,
		// Token: 0x04024693 RID: 149139
		PanelItem,
		// Token: 0x04024694 RID: 149140
		PanelEmpty,
		// Token: 0x04024695 RID: 149141
		TextureIcon,
		// Token: 0x04024696 RID: 149142
		SpriteQuality,
		// Token: 0x04024697 RID: 149143
		PanelLock,
		// Token: 0x04024698 RID: 149144
		TextureRole,
		// Token: 0x04024699 RID: 149145
		SpriteRoleBg,
		// Token: 0x0402469A RID: 149146
		TextLevel,
		// Token: 0x0402469B RID: 149147
		PanelLevel,
		// Token: 0x0402469C RID: 149148
		TextCount,
		// Token: 0x0402469D RID: 149149
		TextureMask,
		// Token: 0x0402469E RID: 149150
		PanelCount,
		// Token: 0x0402469F RID: 149151
		ReceivedItem
	}
}
