using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001542 RID: 5442
[NullableContext(2)]
[Nullable(0)]
public class ActivityTurntableToggleItem : UiPanelBase
{
	// Token: 0x06009B94 RID: 39828 RVA: 0x0021ADC0 File Offset: 0x00218FC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009B95 RID: 39829 RVA: 0x0021AE88 File Offset: 0x00219088
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
		if (this.Toggle != null)
		{
			this.Toggle.CanExecuteChange.Unbind();
			this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
		}
	}

	// Token: 0x06009B96 RID: 39830 RVA: 0x0021AED6 File Offset: 0x002190D6
	public void Refresh(int roundId)
	{
		this.RoundId = roundId;
		this.RefreshIndex();
	}

	// Token: 0x06009B97 RID: 39831 RVA: 0x0021AEE8 File Offset: 0x002190E8
	private void RefreshIndex()
	{
		int value = this.RoundId + 1;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_TurntableSelect_Index0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_TurntableNormal_Index0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		string resourceId2 = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
		this.SetSpriteByPath(resourcePath2, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06009B98 RID: 39832 RVA: 0x0021AF98 File Offset: 0x00219198
	public EToggleState GetToggleState()
	{
		return this.Toggle.GetToggleState();
	}

	// Token: 0x06009B99 RID: 39833 RVA: 0x0021AFA5 File Offset: 0x002191A5
	public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
	{
		this.Toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06009B9A RID: 39834 RVA: 0x0021AFBD File Offset: 0x002191BD
	private bool CanToggleExecuteChangeInternal()
	{
		return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoundId);
	}

	// Token: 0x06009B9B RID: 39835 RVA: 0x0021AFDA File Offset: 0x002191DA
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		Action<int, bool> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(this.RoundId, this.Toggle.GetToggleState() == EToggleState.ETT_Checked);
	}

	// Token: 0x0400445C RID: 17500
	public int RoundId;

	// Token: 0x0400445D RID: 17501
	protected UUIExtendToggle Toggle;

	// Token: 0x0400445E RID: 17502
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x0400445F RID: 17503
	public Action<int, bool> ToggleCallBack;

	// Token: 0x02007B78 RID: 31608
	[NullableContext(0)]
	internal class EToggleComponents
	{
		// Token: 0x0402898D RID: 166285
		public const int Toggle = 0;

		// Token: 0x0402898E RID: 166286
		public const int SpriteNormal = 1;

		// Token: 0x0402898F RID: 166287
		public const int SpriteSelect = 2;
	}
}
