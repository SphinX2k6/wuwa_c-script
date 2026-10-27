using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C8A RID: 7306
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaTagItem : GridProxyAbstract<GachaPoolData>
{
	// Token: 0x170011EB RID: 4587
	// (get) Token: 0x0600DC78 RID: 56440 RVA: 0x00336C21 File Offset: 0x00334E21
	public int GachaId
	{
		get
		{
			return this.Data.GachaInfo.Id;
		}
	}

	// Token: 0x0600DC79 RID: 56441 RVA: 0x00336C34 File Offset: 0x00334E34
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

	// Token: 0x0600DC7A RID: 56442 RVA: 0x00336D7F File Offset: 0x00334F7F
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(() => this.CanExecuteChange == null || this.CanExecuteChange(base.GridIndex));
	}

	// Token: 0x0600DC7B RID: 56443 RVA: 0x00336D9E File Offset: 0x00334F9E
	private void TagToggle(EToggleState toggleState)
	{
		Action<int> selectCallback = this.SelectCallback;
		if (selectCallback == null)
		{
			return;
		}
		selectCallback(base.GridIndex);
	}

	// Token: 0x0600DC7C RID: 56444 RVA: 0x00336DB8 File Offset: 0x00334FB8
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

	// Token: 0x0600DC7D RID: 56445 RVA: 0x00336E08 File Offset: 0x00335008
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

	// Token: 0x0600DC7E RID: 56446 RVA: 0x00336EC0 File Offset: 0x003350C0
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

	// Token: 0x0600DC7F RID: 56447 RVA: 0x00337043 File Offset: 0x00335243
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

	// Token: 0x0600DC80 RID: 56448 RVA: 0x0033706A File Offset: 0x0033526A
	[NullableContext(1)]
	public override object GetKey(GachaPoolData data, int displayIndex)
	{
		return this.GachaId;
	}

	// Token: 0x0600DC81 RID: 56449 RVA: 0x00337077 File Offset: 0x00335277
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
	}

	// Token: 0x0600DC82 RID: 56450 RVA: 0x00337080 File Offset: 0x00335280
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x0400651F RID: 25887
	public GachaPoolData Data;

	// Token: 0x04006520 RID: 25888
	public Action<int> SelectCallback;

	// Token: 0x04006521 RID: 25889
	public Func<int, bool> CanExecuteChange;

	// Token: 0x02008263 RID: 33379
	[NullableContext(0)]
	private enum EGachaTagCom
	{
		// Token: 0x0402A8AB RID: 174251
		ContentNotSelectedSprite,
		// Token: 0x0402A8AC RID: 174252
		ContentSelectedSprite,
		// Token: 0x0402A8AD RID: 174253
		RedDotItem,
		// Token: 0x0402A8AE RID: 174254
		TagToggle,
		// Token: 0x0402A8AF RID: 174255
		TipItem,
		// Token: 0x0402A8B0 RID: 174256
		TipBgSprite,
		// Token: 0x0402A8B1 RID: 174257
		TipText
	}
}
