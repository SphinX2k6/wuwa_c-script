using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020005A4 RID: 1444
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ArtemisDaysItem : GridProxyAbstract<IArtemisDayItemData>
{
	// Token: 0x0600449C RID: 17564 RVA: 0x00179CEC File Offset: 0x00177EEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIArtText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
		};
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x00179DAC File Offset: 0x00177FAC
	public override void Refresh(IArtemisDayItemData data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		this.Day = data.Index;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Index + 1);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIArtText artText = base.GetArtText(3);
		if (artText != null)
		{
			artText.SetText(text);
		}
		UUIArtText artText2 = base.GetArtText(5);
		if (artText2 != null)
		{
			artText2.SetText(text);
		}
		this.UpdateState(data.State);
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x00179E27 File Offset: 0x00178027
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x00179E30 File Offset: 0x00178030
	public void UpdateState(EArtemisState? state)
	{
		EArtemisState? eartemisState = state;
		EArtemisState eartemisState2 = EArtemisState.Lock;
		this.LockState = (eartemisState.GetValueOrDefault() == eartemisState2 & eartemisState != null);
		bool flag = !this.LockState && this.Day == ArtemisActivityController.Instance.CurrentDayIndex;
		base.GetExtendToggle(0).bLockStateOnSelect = !this.LockState;
		base.GetItem(4).SetUIActive(this.LockState);
		this.SetDayCountColor(flag, state.GetValueOrDefault());
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		this.LoadMaterial(state.GetValueOrDefault() == EArtemisState.Unlock);
	}

	// Token: 0x060044A0 RID: 17568 RVA: 0x00179EDC File Offset: 0x001780DC
	private void SetDayCountColor(bool isSelected, EArtemisState state)
	{
		bool flag = state == EArtemisState.Rewarded;
		bool flag2 = isSelected && state == EArtemisState.Unlock;
		UUIArtText artText = base.GetArtText(3);
		if (artText != null)
		{
			artText.SetUIActive(!flag2);
		}
		UUIArtText artText2 = base.GetArtText(5);
		if (artText2 != null)
		{
			artText2.SetUIActive(flag2);
		}
		base.GetTexture(2).SetUIActive(flag);
		FColor color = this.UnlockColor;
		if (isSelected)
		{
			color = this.ChoseColor;
		}
		else if (flag)
		{
			color = this.RewardColor;
		}
		else if (state == EArtemisState.Lock)
		{
			color = this.LockColor;
		}
		base.GetArtText(3).SetColor(color);
		base.GetArtText(5).SetColor(color);
		if (flag)
		{
			base.GetTexture(2).SetColor(color);
		}
	}

	// Token: 0x060044A1 RID: 17569 RVA: 0x00179F82 File Offset: 0x00178182
	private void OnClicked(EToggleState toggleState)
	{
		if (this.LockState)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.ClickCallback(this.Day);
	}

	// Token: 0x060044A2 RID: 17570 RVA: 0x00179FB4 File Offset: 0x001781B4
	public void LoadMaterial(bool loadMaterial)
	{
		if (loadMaterial)
		{
			UiResourceConfig instance = UiResourceConfig.Instance;
			string text = (instance != null) ? instance.GetResourcePath("MI_GlitchAimis") : null;
			if (text == null)
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<UMaterialInterface>(text, delegate([Nullable(2)] UMaterialInterface material, string _)
			{
				UUIArtText artText3 = base.GetArtText(3);
				if (artText3 != null)
				{
					artText3.SetCustomUIMaterial(material);
				}
				UUIArtText artText4 = base.GetArtText(5);
				if (artText4 == null)
				{
					return;
				}
				artText4.SetCustomUIMaterial(material);
			}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
			return;
		}
		else
		{
			UUIArtText artText = base.GetArtText(3);
			if (artText != null)
			{
				artText.SetCustomUIMaterial(null);
			}
			UUIArtText artText2 = base.GetArtText(5);
			if (artText2 == null)
			{
				return;
			}
			artText2.SetCustomUIMaterial(null);
			return;
		}
	}

	// Token: 0x040034F0 RID: 13552
	private int Day;

	// Token: 0x040034F1 RID: 13553
	private bool LockState;

	// Token: 0x040034F2 RID: 13554
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x040034F3 RID: 13555
	private readonly FColor RewardColor = FColor.FromHex("838383");

	// Token: 0x040034F4 RID: 13556
	private readonly FColor UnlockColor = FColor.FromHex("FFFFFF");

	// Token: 0x040034F5 RID: 13557
	private readonly FColor ChoseColor = FColor.FromHex("212224");

	// Token: 0x040034F6 RID: 13558
	private readonly FColor LockColor = FColor.FromHex("838383");

	// Token: 0x02006847 RID: 26695
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022617 RID: 140823
		public const int ToggleNode = 0;

		// Token: 0x04022618 RID: 140824
		public const int MainContentNode = 1;

		// Token: 0x04022619 RID: 140825
		public const int Completion = 2;

		// Token: 0x0402261A RID: 140826
		public const int DayCountText = 3;

		// Token: 0x0402261B RID: 140827
		public const int LockedState = 4;

		// Token: 0x0402261C RID: 140828
		public const int DayCountTextBlack = 5;
	}
}
