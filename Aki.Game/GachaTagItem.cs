using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001149 RID: 4425
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaTagItem : GridProxyAbstract<GachaPoolData>
{
	// Token: 0x17001211 RID: 4625
	// (get) Token: 0x0600B08E RID: 45198 RVA: 0x00342145 File Offset: 0x00340345
	public int GachaId
	{
		get
		{
			return this.Data.GachaInfo.Id;
		}
	}

	// Token: 0x0600B08F RID: 45199 RVA: 0x00342158 File Offset: 0x00340358
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.TagToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B090 RID: 45200 RVA: 0x003422A3 File Offset: 0x003404A3
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(() => this.CanExecuteChange == null || this.CanExecuteChange(base.GridIndex));
	}

	// Token: 0x0600B091 RID: 45201 RVA: 0x003422C2 File Offset: 0x003404C2
	private void TagToggle(EToggleState toggleState)
	{
		Action<int> selectCallback = this.SelectCallback;
		if (selectCallback == null)
		{
			return;
		}
		selectCallback(base.GridIndex);
	}

	// Token: 0x0600B092 RID: 45202 RVA: 0x003422DC File Offset: 0x003404DC
	public void SetSelected(bool selected)
	{
		if (selected)
		{
			base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			OnClickGachaScrollLogEvent onClickGachaScrollLogEvent = new OnClickGachaScrollLogEvent();
			onClickGachaScrollLogEvent.i_gacha_id = this.GachaId;
			LogReportController.Instance.LogReport(onClickGachaScrollLogEvent);
			return;
		}
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600B093 RID: 45203 RVA: 0x0034232C File Offset: 0x0034052C
	public void RefreshRedDot()
	{
		bool flag = GachaModel.Instance.CheckNewGachaPoolById(this.GachaId);
		if (!flag)
		{
			ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(this.GachaId);
			ProtoGachaPoolInfo protoGachaPoolInfo = (gachaInfo != null) ? gachaInfo.GetFirstValidPool() : null;
			if (protoGachaPoolInfo != null && protoGachaPoolInfo.UiType == 5)
			{
				bool flag2 = gachaInfo != null && gachaInfo.UsePoolId == 0;
				bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenCommonWeaponSelect, false);
				flag = (flag2 && !player);
			}
			int accumulateId = (gachaInfo != null) ? gachaInfo.GachaAccumulateId : 0;
			GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(accumulateId);
			if (accumulateData != null && accumulateData.HasClaimable)
			{
				flag = accumulateData.HasClaimable;
			}
		}
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(flag);
	}

	// Token: 0x0600B094 RID: 45204 RVA: 0x003423E4 File Offset: 0x003405E4
	public void InitData()
	{
		if (this.Data == null)
		{
			return;
		}
		int id = this.Data.PoolInfo.Id;
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(id);
		if (gachaViewInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.LPH;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
			defaultInterpolatedStringHandler.AppendLiteral("获取抽卡界面信息失败，请检查GachaViewInfo表，GachaId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.GachaId);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SetSpriteByPath(gachaViewInfo.Value.TagNotSelectedSpritePath, base.GetSprite(0), false, null, null);
		this.SetSpriteByPath(gachaViewInfo.Value.TagSelectedSpritePath, base.GetSprite(1), false, null, null);
		base.GetItem(4).SetUIActive(true);
		int type = gachaViewInfo.Value.Type;
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig(type);
		string tagText = gachaViewTypeConfig.Value.TagText;
		if (tagText != null && !StringUtils.IsBlank(tagText))
		{
			base.GetItem(4).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), gachaViewTypeConfig.Value.TagText, Array.Empty<object>());
			FColor color = FColor.FromHex(gachaViewTypeConfig.Value.TagColor);
			base.GetSprite(5).SetColor(color);
			return;
		}
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x0600B095 RID: 45205 RVA: 0x00342567 File Offset: 0x00340767
	[NullableContext(1)]
	public override void Refresh(GachaPoolData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.InitData();
		this.RefreshRedDot();
		if (isSelected)
		{
			this.OnSelected(false);
			return;
		}
		this.OnDeselected(false);
	}

	// Token: 0x0600B096 RID: 45206 RVA: 0x0034258E File Offset: 0x0034078E
	[NullableContext(1)]
	public override object GetKey(GachaPoolData data, int displayIndex)
	{
		return this.GachaId;
	}

	// Token: 0x0600B097 RID: 45207 RVA: 0x0034259B File Offset: 0x0034079B
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
	}

	// Token: 0x0600B098 RID: 45208 RVA: 0x003425A4 File Offset: 0x003407A4
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x040065F1 RID: 26097
	public GachaPoolData Data;

	// Token: 0x040065F2 RID: 26098
	public Action<int> SelectCallback;

	// Token: 0x040065F3 RID: 26099
	public Func<int, bool> CanExecuteChange;

	// Token: 0x020073EB RID: 29675
	[NullableContext(0)]
	private enum EGachaTagCom
	{
		// Token: 0x04025BCC RID: 154572
		ContentNotSelectedSprite,
		// Token: 0x04025BCD RID: 154573
		ContentSelectedSprite,
		// Token: 0x04025BCE RID: 154574
		RedDotItem,
		// Token: 0x04025BCF RID: 154575
		TagToggle,
		// Token: 0x04025BD0 RID: 154576
		TipItem,
		// Token: 0x04025BD1 RID: 154577
		TipBgSprite,
		// Token: 0x04025BD2 RID: 154578
		TipText
	}
}
