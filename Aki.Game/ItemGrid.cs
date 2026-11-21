using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D73 RID: 3443
[NullableContext(1)]
[Nullable(0)]
public class ItemGrid : ItemGridAbstract, IItemGrid
{
	// Token: 0x06008D6E RID: 36206 RVA: 0x002ABEC5 File Offset: 0x002AA0C5
	[NullableContext(2)]
	public ItemGrid(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F7E RID: 3966
	// (get) Token: 0x06008D6F RID: 36207 RVA: 0x002ABED7 File Offset: 0x002AA0D7
	public bool IsItemGrid { get; } = 1;

	// Token: 0x06008D70 RID: 36208 RVA: 0x002ABEE0 File Offset: 0x002AA0E0
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

	// Token: 0x06008D71 RID: 36209 RVA: 0x002AC028 File Offset: 0x002AA228
	private void ClickToggle(EToggleState toggleState)
	{
		if (this.ToggleClickCall == null && this.ToggleClickStateCall == null)
		{
			ItemController.Instance.OpenItemTipsByItemId(base.GetItemId(), true, null, false);
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

	// Token: 0x06008D72 RID: 36210 RVA: 0x002AC093 File Offset: 0x002AA293
	[NullableContext(2)]
	public UUIExtendToggle GetClickToggle()
	{
		return base.GetExtendToggle(4);
	}

	// Token: 0x06008D73 RID: 36211 RVA: 0x002AC09C File Offset: 0x002AA29C
	[NullableContext(2)]
	public UUIText GetDownText()
	{
		return base.GetText(2);
	}

	// Token: 0x06008D74 RID: 36212 RVA: 0x002AC0A8 File Offset: 0x002AA2A8
	public void RefreshQualitySprite()
	{
		string backgroundSprite = ConfigQualityInfoById.GetConfig(base.GetItemConfig().QualityId, true).Value.BackgroundSprite;
		this.SetSpriteByPath(backgroundSprite, base.GetSprite(0), false, new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x06008D75 RID: 36213 RVA: 0x002AC0F2 File Offset: 0x002AA2F2
	public void RefreshTextureByPath(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x06008D76 RID: 36214 RVA: 0x002AC10E File Offset: 0x002AA30E
	public void RefreshTextureIcon()
	{
		base.SetTextureByPath(base.GetItemConfig().Icon, base.GetTexture(1), new EUiViewName?(base.GetBelongView()), null);
	}

	// Token: 0x06008D77 RID: 36215 RVA: 0x002AC134 File Offset: 0x002AA334
	public void RefreshTextDown(bool showState, string text)
	{
		base.GetItem(3).SetUIActive(showState);
		if (showState)
		{
			base.GetText(2).SetText(text, true);
		}
	}

	// Token: 0x06008D78 RID: 36216 RVA: 0x002AC154 File Offset: 0x002AA354
	public void RefreshTextDownByTextId(bool showState, string textId, params object[] args)
	{
		base.GetItem(3).SetUIActive(showState);
		if (showState)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}
	}

	// Token: 0x06008D79 RID: 36217 RVA: 0x002AC179 File Offset: 0x002AA379
	public void SetToggleClickEvent(Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> call)
	{
		this.ToggleClickCall = call;
	}

	// Token: 0x06008D7A RID: 36218 RVA: 0x002AC182 File Offset: 0x002AA382
	public void RefreshNewItem(bool state)
	{
		base.GetItem(5).SetUIActive(state);
	}

	// Token: 0x06008D7B RID: 36219 RVA: 0x002AC191 File Offset: 0x002AA391
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ToggleClickStateCall = call;
	}

	// Token: 0x06008D7C RID: 36220 RVA: 0x002AC19A File Offset: 0x002AA39A
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ClearCurrentRedDot();
		this.CurrentRedDotEventName = new ERedDotName?(name);
		this.CurrentRedDotUid = uid;
		RedDotController.Instance.BindRedDot(name, base.GetItem(6), null, uid);
	}

	// Token: 0x06008D7D RID: 36221 RVA: 0x002AC1C9 File Offset: 0x002AA3C9
	private void ClearCurrentRedDot()
	{
		if (this.CurrentRedDotEventName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.CurrentRedDotEventName.Value, base.GetItem(6), this.CurrentRedDotUid);
		}
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x002AC1FA File Offset: 0x002AA3FA
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		base.GetItem(7).SetUIActive(showState);
		if (showState)
		{
			base.GetSprite(8).SetFillAmount(cdFillAmount);
			base.GetText(9).SetText(cdText, true);
		}
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x002AC228 File Offset: 0x002AA428
	public void RefreshDarkSprite(bool showState)
	{
		base.GetSprite(10).SetUIActive(showState);
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x002AC238 File Offset: 0x002AA438
	public void RefreshLockSprite(bool showState)
	{
		base.GetSprite(11).SetUIActive(showState);
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x002AC248 File Offset: 0x002AA448
	protected override void OnBeforeDestroy()
	{
		this.ClearCurrentRedDot();
	}

	// Token: 0x040054D6 RID: 21718
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> ToggleClickCall;

	// Token: 0x040054D7 RID: 21719
	[Nullable(2)]
	private Action<EToggleState> ToggleClickStateCall;

	// Token: 0x040054D8 RID: 21720
	private ERedDotName? CurrentRedDotEventName;

	// Token: 0x040054D9 RID: 21721
	private int CurrentRedDotUid;

	// Token: 0x02006FD1 RID: 28625
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024868 RID: 149608
		SpriteQuality,
		// Token: 0x04024869 RID: 149609
		TextureIcon,
		// Token: 0x0402486A RID: 149610
		TextDown,
		// Token: 0x0402486B RID: 149611
		TextPanel,
		// Token: 0x0402486C RID: 149612
		ToggleClick,
		// Token: 0x0402486D RID: 149613
		NewItem,
		// Token: 0x0402486E RID: 149614
		RedPointItem,
		// Token: 0x0402486F RID: 149615
		CdPanel,
		// Token: 0x04024870 RID: 149616
		CdBar,
		// Token: 0x04024871 RID: 149617
		CdText,
		// Token: 0x04024872 RID: 149618
		DarkSprite,
		// Token: 0x04024873 RID: 149619
		LockSprite
	}
}
