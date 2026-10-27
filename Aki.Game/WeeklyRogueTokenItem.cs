using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D48 RID: 11592
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueTokenItem : GridProxyAbstract<RogueWeeklyEntry>
{
	// Token: 0x060185BB RID: 99771 RVA: 0x00633988 File Offset: 0x00631B88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x060185BC RID: 99772 RVA: 0x00633ACE File Offset: 0x00631CCE
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(9), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
		base.GetItem(11).SetUIActive(false);
	}

	// Token: 0x060185BD RID: 99773 RVA: 0x00633B00 File Offset: 0x00631D00
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x060185BE RID: 99774 RVA: 0x00633B1E File Offset: 0x00631D1E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueDescModeChange, new Action(this.OnDescModeChange));
	}

	// Token: 0x060185BF RID: 99775 RVA: 0x00633B3C File Offset: 0x00631D3C
	public override void Refresh(RogueWeeklyEntry data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateByConfigId(data.ConfigId);
		base.GetItem(11).SetUIActive(data.IsRecommend);
	}

	// Token: 0x060185C0 RID: 99776 RVA: 0x00633B64 File Offset: 0x00631D64
	private void OnClick(EToggleState toggleState)
	{
		int? obj = (base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked) ? new int?(base.GridIndex) : null;
		Action<int?> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(obj);
	}

	// Token: 0x060185C1 RID: 99777 RVA: 0x00633BA8 File Offset: 0x00631DA8
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = this.Data;
	}

	// Token: 0x060185C2 RID: 99778 RVA: 0x00633BCB File Offset: 0x00631DCB
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}

	// Token: 0x060185C3 RID: 99779 RVA: 0x00633BEC File Offset: 0x00631DEC
	private void OnDescModeChange()
	{
		if (this.ConfigId == 0)
		{
			return;
		}
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ConfigId);
		if (rogueWeeklyBuffPool == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "刷新周常肉鸽信物格子失败，找不到对应的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", this.ConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDescSimple, Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, rogueWeeklyBuffPool.Value.BuffDescParam());
	}

	// Token: 0x060185C4 RID: 99780 RVA: 0x00633CB4 File Offset: 0x00631EB4
	public void UpdateByConfigId(int configId)
	{
		this.ConfigId = configId;
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(configId);
		if (rogueWeeklyBuffPool == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "刷新周常肉鸽信物格子失败，找不到对应的配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		base.GetItem(5).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
		if (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDescSimple, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, rogueWeeklyBuffPool.Value.BuffDescParam());
		}
		base.SetTextureByPath(rogueWeeklyBuffPool.Value.BuffIcon, base.GetTexture(1), null, null);
		RogueWeekQualityConfig? rogueWeeklyQualityConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyQualityConfig(rogueWeeklyBuffPool.Value.Quality);
		if (rogueWeeklyQualityConfig != null)
		{
			base.SetTextureByPath(rogueWeeklyQualityConfig.Value.TokenBgNew, base.GetTexture(0), null, null);
		}
		base.GetSprite(6).SetColor(FColor.FromHex(rogueWeeklyQualityConfig.Value.TokenColor));
		base.GetItem(7).SetUIActive(rogueWeeklyBuffPool.Value.Quality == 6);
		base.GetItem(8).SetUIActive(rogueWeeklyBuffPool.Value.Quality == 5);
		this.TagLayout.RefreshByData(WeeklyRogueModel.Instance.GetRogueWeeklyBuffTagIdList(configId), null, false);
	}

	// Token: 0x060185C5 RID: 99781 RVA: 0x00633E88 File Offset: 0x00632088
	public void SetInteractive(bool bActive)
	{
		base.GetExtendToggle(4).SetSelfInteractive(bActive);
	}

	// Token: 0x060185C6 RID: 99782 RVA: 0x00633E97 File Offset: 0x00632097
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B4CB RID: 46283
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x0400B4CC RID: 46284
	[Nullable(2)]
	private RogueWeeklyEntry Data;

	// Token: 0x0400B4CD RID: 46285
	private int ConfigId;

	// Token: 0x0400B4CE RID: 46286
	[Nullable(2)]
	public Action<int?> OnSelectedChange;

	// Token: 0x020092D9 RID: 37593
	[NullableContext(0)]
	private enum EWeeklyRogueTokenItem
	{
		// Token: 0x0402F76B RID: 194411
		QualityBgTexture,
		// Token: 0x0402F76C RID: 194412
		IconTexture,
		// Token: 0x0402F76D RID: 194413
		NameText,
		// Token: 0x0402F76E RID: 194414
		DescText,
		// Token: 0x0402F76F RID: 194415
		SelfToggle,
		// Token: 0x0402F770 RID: 194416
		NewItem,
		// Token: 0x0402F771 RID: 194417
		QualityLineSprite,
		// Token: 0x0402F772 RID: 194418
		GoldItem,
		// Token: 0x0402F773 RID: 194419
		YellowItem,
		// Token: 0x0402F774 RID: 194420
		TagLayout,
		// Token: 0x0402F775 RID: 194421
		TagItem,
		// Token: 0x0402F776 RID: 194422
		ItemRecommend
	}
}
