using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001116 RID: 4374
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerBuffSelectItem : GridProxyAbstract<IBabelTowerBuffInfo>
{
	// Token: 0x0600726B RID: 29291 RVA: 0x00176C70 File Offset: 0x00174E70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600726C RID: 29292 RVA: 0x00176D79 File Offset: 0x00174F79
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked || this.CanClickCallBack == null || this.CanClickCallBack(this.BuffId));
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
	}

	// Token: 0x0600726D RID: 29293 RVA: 0x00176DB8 File Offset: 0x00174FB8
	[NullableContext(1)]
	public override void Refresh(IBabelTowerBuffInfo data, bool isSelected, int gridIndex)
	{
		this.BuffId = data.Id;
		this.LevelId = data.LevelId.GetValueOrDefault();
		BabelTowerBuff? config = ConfigBabelTowerBuffById.GetConfig(this.BuffId, true);
		if (config == null)
		{
			return;
		}
		BabelTowerBuff value = config.Value;
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, value.NameText, Array.Empty<object>());
		base.SetTextureByPath(value.Texture, base.GetTexture(3), null, null);
		base.GetItem(4).SetUIActive(data.IsRecommend);
		this.RefreshState(data.State);
	}

	// Token: 0x0600726E RID: 29294 RVA: 0x00176E60 File Offset: 0x00175060
	public void RefreshState(EBabelTowerBuffState state)
	{
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(2);
		text2.SetUIActive(state > EBabelTowerBuffState.Normal);
		UUIItem uuiitem = text2;
		bool bUseChangeColor = state > EBabelTowerBuffState.Normal;
		FColor? fcolor = new FColor?(text2.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIItem uuiitem2 = text;
		bool bUseChangeColor2 = state > EBabelTowerBuffState.Normal;
		fcolor = new FColor?(text.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		if (state == EBabelTowerBuffState.Use)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "BabelTowerBuffUse", Array.Empty<object>());
			return;
		}
		if (state == EBabelTowerBuffState.Lock)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "BabelTowerBuffLock", Array.Empty<object>());
		}
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x00176EEA File Offset: 0x001750EA
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.BuffId);
			return;
		}
		else
		{
			Action<int> onCancelClickToggleCallBack = this.OnCancelClickToggleCallBack;
			if (onCancelClickToggleCallBack == null)
			{
				return;
			}
			onCancelClickToggleCallBack(this.BuffId);
			return;
		}
	}

	// Token: 0x06007270 RID: 29296 RVA: 0x00176F1D File Offset: 0x0017511D
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x06007271 RID: 29297 RVA: 0x00176F30 File Offset: 0x00175130
	private void OnUndeterminedClicked()
	{
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = false,
			ConfigId = this.BuffId,
			ShowWays = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x040034FA RID: 13562
	public int BuffId;

	// Token: 0x040034FB RID: 13563
	public int LevelId;

	// Token: 0x040034FC RID: 13564
	public Action<int> OnClickToggleCallBack;

	// Token: 0x040034FD RID: 13565
	public Action<int> OnCancelClickToggleCallBack;

	// Token: 0x040034FE RID: 13566
	public Func<int, bool> CanClickCallBack;

	// Token: 0x020076DA RID: 30426
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027384 RID: 160644
		public const int Toggle = 0;

		// Token: 0x04027385 RID: 160645
		public const int NameText = 1;

		// Token: 0x04027386 RID: 160646
		public const int DesText = 2;

		// Token: 0x04027387 RID: 160647
		public const int IconTexture = 3;

		// Token: 0x04027388 RID: 160648
		public const int RecommendItem = 4;
	}
}
