using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010F0 RID: 4336
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ArtemisDaysItem : GridProxyAbstract<IArtemisDayItemData>
{
	// Token: 0x06007106 RID: 28934 RVA: 0x00171330 File Offset: 0x0016F530
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

	// Token: 0x06007107 RID: 28935 RVA: 0x001713F0 File Offset: 0x0016F5F0
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

	// Token: 0x06007108 RID: 28936 RVA: 0x0017146B File Offset: 0x0016F66B
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x00171474 File Offset: 0x0016F674
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

	// Token: 0x0600710A RID: 28938 RVA: 0x00171520 File Offset: 0x0016F720
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

	// Token: 0x0600710B RID: 28939 RVA: 0x001715C6 File Offset: 0x0016F7C6
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

	// Token: 0x0600710C RID: 28940 RVA: 0x001715F8 File Offset: 0x0016F7F8
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

	// Token: 0x04003457 RID: 13399
	private int Day;

	// Token: 0x04003458 RID: 13400
	private bool LockState;

	// Token: 0x04003459 RID: 13401
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x0400345A RID: 13402
	private readonly FColor RewardColor = FColor.FromHex("838383");

	// Token: 0x0400345B RID: 13403
	private readonly FColor UnlockColor = FColor.FromHex("FFFFFF");

	// Token: 0x0400345C RID: 13404
	private readonly FColor ChoseColor = FColor.FromHex("212224");

	// Token: 0x0400345D RID: 13405
	private readonly FColor LockColor = FColor.FromHex("838383");

	// Token: 0x020076B3 RID: 30387
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040272CE RID: 160462
		public const int ToggleNode = 0;

		// Token: 0x040272CF RID: 160463
		public const int MainContentNode = 1;

		// Token: 0x040272D0 RID: 160464
		public const int Completion = 2;

		// Token: 0x040272D1 RID: 160465
		public const int DayCountText = 3;

		// Token: 0x040272D2 RID: 160466
		public const int LockedState = 4;

		// Token: 0x040272D3 RID: 160467
		public const int DayCountTextBlack = 5;
	}
}
