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

// Token: 0x020017F5 RID: 6133
public class CommonItemGrid : GridProxyAbstract<TItem>
{
	// Token: 0x0600B395 RID: 45973 RVA: 0x00289666 File Offset: 0x00287866
	[NullableContext(2)]
	public CommonItemGrid(AActor commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x0600B396 RID: 45974 RVA: 0x002896A0 File Offset: 0x002878A0
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

	// Token: 0x0600B397 RID: 45975 RVA: 0x00289814 File Offset: 0x00287A14
	protected override void OnStart()
	{
		this.InitView();
		EventSystem.Instance.Add<int, int>(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
	}

	// Token: 0x0600B398 RID: 45976 RVA: 0x00289838 File Offset: 0x00287A38
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.CloseItemTips, new Action<int, int>(this.OnCloseItemTips));
	}

	// Token: 0x0600B399 RID: 45977 RVA: 0x00289856 File Offset: 0x00287A56
	private void OnCloseItemTips(int itemId, int i)
	{
		if (itemId != this.ItemConfigId)
		{
			return;
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600B39A RID: 45978 RVA: 0x00289873 File Offset: 0x00287A73
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

	// Token: 0x0600B39B RID: 45979 RVA: 0x00289893 File Offset: 0x00287A93
	private void InitView()
	{
		this.SetEmpty(false);
		this.SetLock(false);
		this.SetRoleHead(null);
		this.SetLevel(0);
	}

	// Token: 0x0600B39C RID: 45980 RVA: 0x002898B1 File Offset: 0x00287AB1
	private void UpdateView()
	{
		base.SetItemIcon(base.GetTexture(3), this.ItemConfigId, this.BelongViewName, null);
		base.SetItemQualityIcon(base.GetSprite(4), this.ItemConfigId, this.BelongViewName, CommonDefine.EQualityIconType.BackgroundSprite, null);
	}

	// Token: 0x0600B39D RID: 45981 RVA: 0x002898E8 File Offset: 0x00287AE8
	public override void Refresh(TItem data, bool isSelect, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.RefreshItem(itemData.ItemId, count);
	}

	// Token: 0x0600B39E RID: 45982 RVA: 0x00289910 File Offset: 0x00287B10
	public void SetQualityActive(bool isShow)
	{
		base.GetSprite(4).SetUIActive(isShow);
	}

	// Token: 0x0600B39F RID: 45983 RVA: 0x0028991F File Offset: 0x00287B1F
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600B3A0 RID: 45984 RVA: 0x0028992D File Offset: 0x00287B2D
	public void RefreshItem(int itemConfigId, int itemCount = 0)
	{
		this.ItemConfigId = itemConfigId;
		this.UpdateView();
		this.SetCount(itemCount);
	}

	// Token: 0x0600B3A1 RID: 45985 RVA: 0x00289943 File Offset: 0x00287B43
	[NullableContext(1)]
	public void BindClickCallback(Action<int> clickCallback)
	{
		this.ClickCallback = clickCallback;
	}

	// Token: 0x0600B3A2 RID: 45986 RVA: 0x0028994C File Offset: 0x00287B4C
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

	// Token: 0x0600B3A3 RID: 45987 RVA: 0x0028999C File Offset: 0x00287B9C
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

	// Token: 0x0600B3A4 RID: 45988 RVA: 0x002899F0 File Offset: 0x00287BF0
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

	// Token: 0x0600B3A5 RID: 45989 RVA: 0x00289A2B File Offset: 0x00287C2B
	public void SetMask(bool value)
	{
		base.GetTexture(11).SetUIActive(value);
	}

	// Token: 0x0600B3A6 RID: 45990 RVA: 0x00289A3B File Offset: 0x00287C3B
	public void SetEmpty(bool value)
	{
		base.GetItem(2).SetUIActive(value);
		base.GetItem(1).SetUIActive(!value);
	}

	// Token: 0x0600B3A7 RID: 45991 RVA: 0x00289A5A File Offset: 0x00287C5A
	public void SetLock(bool value)
	{
		base.GetItem(5).SetUIActive(value);
	}

	// Token: 0x0600B3A8 RID: 45992 RVA: 0x00289A69 File Offset: 0x00287C69
	public void SetReceived(bool value)
	{
		base.GetItem(13).SetUIActive(value);
	}

	// Token: 0x0600B3A9 RID: 45993 RVA: 0x00289A79 File Offset: 0x00287C79
	public void SetCountTextVisible(bool value)
	{
		base.GetItem(12).SetUIActive(value);
	}

	// Token: 0x0600B3AA RID: 45994 RVA: 0x00289A8C File Offset: 0x00287C8C
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

	// Token: 0x0600B3AB RID: 45995 RVA: 0x00289AE0 File Offset: 0x00287CE0
	private UniTask UpdateViewAsync()
	{
		CommonItemGrid.<UpdateViewAsync>d__26 <UpdateViewAsync>d__;
		<UpdateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewAsync>d__.<>4__this = this;
		<UpdateViewAsync>d__.<>1__state = -1;
		<UpdateViewAsync>d__.<>t__builder.Start<CommonItemGrid.<UpdateViewAsync>d__26>(ref <UpdateViewAsync>d__);
		return <UpdateViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04005150 RID: 20816
	private int ItemConfigId;

	// Token: 0x04005151 RID: 20817
	private EUiViewName? BelongViewName;

	// Token: 0x04005152 RID: 20818
	[Nullable(1)]
	private Action<int> ClickCallback = delegate(int itemConfigId)
	{
		ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null);
	};

	// Token: 0x02007DEE RID: 32238
	private enum EChildComponentType
	{
		// Token: 0x04029367 RID: 168807
		ToggleClick,
		// Token: 0x04029368 RID: 168808
		PanelItem,
		// Token: 0x04029369 RID: 168809
		PanelEmpty,
		// Token: 0x0402936A RID: 168810
		TextureIcon,
		// Token: 0x0402936B RID: 168811
		SpriteQuality,
		// Token: 0x0402936C RID: 168812
		PanelLock,
		// Token: 0x0402936D RID: 168813
		TextureRole,
		// Token: 0x0402936E RID: 168814
		SpriteRoleBg,
		// Token: 0x0402936F RID: 168815
		TextLevel,
		// Token: 0x04029370 RID: 168816
		PanelLevel,
		// Token: 0x04029371 RID: 168817
		TextCount,
		// Token: 0x04029372 RID: 168818
		TextureMask,
		// Token: 0x04029373 RID: 168819
		PanelCount,
		// Token: 0x04029374 RID: 168820
		ReceivedItem
	}
}
