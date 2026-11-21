using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009FA RID: 2554
[NullableContext(2)]
[Nullable(0)]
public class ActivityTurntableToggleItem : UiPanelBase
{
	// Token: 0x06006F72 RID: 28530 RVA: 0x00224B70 File Offset: 0x00222D70
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

	// Token: 0x06006F73 RID: 28531 RVA: 0x00224C38 File Offset: 0x00222E38
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
		if (this.Toggle != null)
		{
			this.Toggle.CanExecuteChange.Unbind();
			this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
		}
	}

	// Token: 0x06006F74 RID: 28532 RVA: 0x00224C86 File Offset: 0x00222E86
	public void Refresh(int roundId)
	{
		this.RoundId = roundId;
		this.RefreshIndex();
	}

	// Token: 0x06006F75 RID: 28533 RVA: 0x00224C98 File Offset: 0x00222E98
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

	// Token: 0x06006F76 RID: 28534 RVA: 0x00224D48 File Offset: 0x00222F48
	public EToggleState GetToggleState()
	{
		return this.Toggle.GetToggleState();
	}

	// Token: 0x06006F77 RID: 28535 RVA: 0x00224D55 File Offset: 0x00222F55
	public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
	{
		this.Toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06006F78 RID: 28536 RVA: 0x00224D6D File Offset: 0x00222F6D
	private bool CanToggleExecuteChangeInternal()
	{
		return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoundId);
	}

	// Token: 0x06006F79 RID: 28537 RVA: 0x00224D8A File Offset: 0x00222F8A
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		Action<int, bool> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(this.RoundId, this.Toggle.GetToggleState() == EToggleState.ETT_Checked);
	}

	// Token: 0x04004502 RID: 17666
	public int RoundId;

	// Token: 0x04004503 RID: 17667
	protected UUIExtendToggle Toggle;

	// Token: 0x04004504 RID: 17668
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x04004505 RID: 17669
	public Action<int, bool> ToggleCallBack;

	// Token: 0x02006D03 RID: 27907
	[NullableContext(0)]
	internal class EToggleComponents
	{
		// Token: 0x04023CC8 RID: 146632
		public const int Toggle = 0;

		// Token: 0x04023CC9 RID: 146633
		public const int SpriteNormal = 1;

		// Token: 0x04023CCA RID: 146634
		public const int SpriteSelect = 2;
	}
}
