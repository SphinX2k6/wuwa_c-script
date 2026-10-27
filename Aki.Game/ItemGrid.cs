using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018BA RID: 6330
[NullableContext(1)]
[Nullable(0)]
public class ItemGrid : ItemGridAbstract, IItemGrid
{
	// Token: 0x0600B985 RID: 47493 RVA: 0x002A1770 File Offset: 0x0029F970
	[NullableContext(2)]
	public ItemGrid(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F5B RID: 3931
	// (get) Token: 0x0600B986 RID: 47494 RVA: 0x002A1782 File Offset: 0x0029F982
	public bool IsItemGrid { get; } = 1;

	// Token: 0x0600B987 RID: 47495 RVA: 0x002A178C File Offset: 0x0029F98C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.ClickToggle))
		};
	}

	// Token: 0x0600B988 RID: 47496 RVA: 0x002A18D4 File Offset: 0x0029FAD4
	private void ClickToggle(EToggleState toggleState)
	{
		if (this.ToggleClickCall == null && this.ToggleClickStateCall == null)
		{
			ItemController.Instance.OpenItemTipsByItemId(base.GetItemId(), true, null);
			return;
		}
		EToggleState toggleState2 = this.GetClickToggle().ToggleState;
		Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> toggleClickCall = this.ToggleClickCall;
		if (toggleClickCall != null)
		{
			toggleClickCall(base.GetItemId(), base.GetItemConfig());
		}
		Action<EToggleState> toggleClickStateCall = this.ToggleClickStateCall;
		if (toggleClickStateCall == null)
		{
			return;
		}
		toggleClickStateCall(toggleState2);
	}

	// Token: 0x0600B989 RID: 47497 RVA: 0x002A193E File Offset: 0x0029FB3E
	[NullableContext(2)]
	public UUIExtendToggle GetClickToggle()
	{
		return base.GetExtendToggle(4);
	}

	// Token: 0x0600B98A RID: 47498 RVA: 0x002A1947 File Offset: 0x0029FB47
	[NullableContext(2)]
	public UUIText GetDownText()
	{
		return base.GetText(2);
	}

	// Token: 0x0600B98B RID: 47499 RVA: 0x002A1950 File Offset: 0x0029FB50
	public void RefreshQualitySprite()
	{
		string backgroundSprite = ConfigQualityInfoById.GetConfig(base.GetItemConfig().QualityId, true).Value.BackgroundSprite;
		this.SetSpriteByPath(backgroundSprite, base.GetSprite(0), false, new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x0600B98C RID: 47500 RVA: 0x002A199A File Offset: 0x0029FB9A
	public void RefreshTextureByPath(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x0600B98D RID: 47501 RVA: 0x002A19B6 File Offset: 0x0029FBB6
	public void RefreshTextureIcon()
	{
		base.SetTextureByPath(base.GetItemConfig().Icon, base.GetTexture(1), new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x0600B98E RID: 47502 RVA: 0x002A19DC File Offset: 0x0029FBDC
	public void RefreshTextDown(bool showState, string text)
	{
		base.GetItem(3).SetUIActive(showState);
		if (showState)
		{
			base.GetText(2).SetText(text, true);
		}
	}

	// Token: 0x0600B98F RID: 47503 RVA: 0x002A19FC File Offset: 0x0029FBFC
	public void RefreshTextDownByTextId(bool showState, string textId, params object[] args)
	{
		base.GetItem(3).SetUIActive(showState);
		if (showState)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}
	}

	// Token: 0x0600B990 RID: 47504 RVA: 0x002A1A21 File Offset: 0x0029FC21
	public void SetToggleClickEvent(Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> call)
	{
		this.ToggleClickCall = call;
	}

	// Token: 0x0600B991 RID: 47505 RVA: 0x002A1A2A File Offset: 0x0029FC2A
	public void RefreshNewItem(bool state)
	{
		base.GetItem(5).SetUIActive(state);
	}

	// Token: 0x0600B992 RID: 47506 RVA: 0x002A1A39 File Offset: 0x0029FC39
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ToggleClickStateCall = call;
	}

	// Token: 0x0600B993 RID: 47507 RVA: 0x002A1A42 File Offset: 0x0029FC42
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ClearCurrentRedDot();
		this.CurrentRedDotEventName = new ERedDotName?(name);
		this.CurrentRedDotUid = uid;
		RedDotController.Instance.BindRedDot(name, base.GetItem(6), null, uid);
	}

	// Token: 0x0600B994 RID: 47508 RVA: 0x002A1A71 File Offset: 0x0029FC71
	private void ClearCurrentRedDot()
	{
		if (this.CurrentRedDotEventName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.CurrentRedDotEventName.Value, base.GetItem(6), this.CurrentRedDotUid);
		}
	}

	// Token: 0x0600B995 RID: 47509 RVA: 0x002A1AA2 File Offset: 0x0029FCA2
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		base.GetItem(7).SetUIActive(showState);
		if (showState)
		{
			base.GetSprite(8).SetFillAmount(cdFillAmount);
			base.GetText(9).SetText(cdText, true);
		}
	}

	// Token: 0x0600B996 RID: 47510 RVA: 0x002A1AD0 File Offset: 0x0029FCD0
	public void RefreshDarkSprite(bool showState)
	{
		base.GetSprite(10).SetUIActive(showState);
	}

	// Token: 0x0600B997 RID: 47511 RVA: 0x002A1AE0 File Offset: 0x0029FCE0
	public void RefreshLockSprite(bool showState)
	{
		base.GetSprite(11).SetUIActive(showState);
	}

	// Token: 0x0600B998 RID: 47512 RVA: 0x002A1AF0 File Offset: 0x0029FCF0
	protected override void OnBeforeDestroy()
	{
		this.ClearCurrentRedDot();
	}

	// Token: 0x0400542B RID: 21547
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> ToggleClickCall;

	// Token: 0x0400542C RID: 21548
	[Nullable(2)]
	private Action<EToggleState> ToggleClickStateCall;

	// Token: 0x0400542D RID: 21549
	private ERedDotName? CurrentRedDotEventName;

	// Token: 0x0400542E RID: 21550
	private int CurrentRedDotUid;

	// Token: 0x02007E4A RID: 32330
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402953B RID: 169275
		SpriteQuality,
		// Token: 0x0402953C RID: 169276
		TextureIcon,
		// Token: 0x0402953D RID: 169277
		TextDown,
		// Token: 0x0402953E RID: 169278
		TextPanel,
		// Token: 0x0402953F RID: 169279
		ToggleClick,
		// Token: 0x04029540 RID: 169280
		NewItem,
		// Token: 0x04029541 RID: 169281
		RedPointItem,
		// Token: 0x04029542 RID: 169282
		CdPanel,
		// Token: 0x04029543 RID: 169283
		CdBar,
		// Token: 0x04029544 RID: 169284
		CdText,
		// Token: 0x04029545 RID: 169285
		DarkSprite,
		// Token: 0x04029546 RID: 169286
		LockSprite
	}
}
