using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A5D RID: 6749
[NullableContext(1)]
[Nullable(0)]
public class PhotoCameraTempItem : GridProxyAbstract<PhotoTemplate>
{
	// Token: 0x06010A8D RID: 68237 RVA: 0x004DF814 File Offset: 0x004DDA14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChanged))
		};
	}

	// Token: 0x06010A8E RID: 68238 RVA: 0x004DF8A7 File Offset: 0x004DDAA7
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06010A8F RID: 68239 RVA: 0x004DF8B0 File Offset: 0x004DDAB0
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnSwitchingModeChanged = (Action<bool>)Delegate.Combine(viewModel.OnSwitchingModeChanged, new Action<bool>(this.OnSwitchingModeChanged));
		this.ApplyInteractive();
	}

	// Token: 0x06010A90 RID: 68240 RVA: 0x004DF8EC File Offset: 0x004DDAEC
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnSwitchingModeChanged = (Action<bool>)Delegate.Remove(viewModel.OnSwitchingModeChanged, new Action<bool>(this.OnSwitchingModeChanged));
	}

	// Token: 0x06010A91 RID: 68241 RVA: 0x004DF915 File Offset: 0x004DDB15
	private void OnSwitchingModeChanged(bool switching)
	{
		this.ApplyInteractive();
	}

	// Token: 0x06010A92 RID: 68242 RVA: 0x004DF920 File Offset: 0x004DDB20
	public override void Refresh(PhotoTemplate data, bool isSelected, int gridIndex)
	{
		this.SetToggleSelected(isSelected);
		if (!data.IsDefault)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			base.SetTextureByPath((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? data.TextureFemale : data.TextureMale, base.GetTexture(3), null, null);
			return;
		}
		UUIItem item3 = base.GetItem(1);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(2);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x06010A93 RID: 68243 RVA: 0x004DF9C1 File Offset: 0x004DDBC1
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleSelected(true);
	}

	// Token: 0x06010A94 RID: 68244 RVA: 0x004DF9CA File Offset: 0x004DDBCA
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleSelected(false);
	}

	// Token: 0x06010A95 RID: 68245 RVA: 0x004DF9D3 File Offset: 0x004DDBD3
	private void ApplyInteractive()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(!this.ViewModel.IsSwitchingMode);
	}

	// Token: 0x06010A96 RID: 68246 RVA: 0x004DF9F4 File Offset: 0x004DDBF4
	private void SetToggleSelected(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010A97 RID: 68247 RVA: 0x004DFA11 File Offset: 0x004DDC11
	public override object GetKey(PhotoTemplate data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010A98 RID: 68248 RVA: 0x004DFA1F File Offset: 0x004DDC1F
	private void OnToggleStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnTemplateClick(base.GridIndex);
	}

	// Token: 0x04009330 RID: 37680
	public Action<int> OnTemplateClick = delegate(int gridIndex)
	{
	};

	// Token: 0x04009331 RID: 37681
	private PhotoMainViewModel ViewModel;

	// Token: 0x02007CE0 RID: 31968
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028706 RID: 165638
		ToggleItem,
		// Token: 0x04028707 RID: 165639
		ItemNormalState,
		// Token: 0x04028708 RID: 165640
		ItemTemp,
		// Token: 0x04028709 RID: 165641
		TextureBg
	}
}
