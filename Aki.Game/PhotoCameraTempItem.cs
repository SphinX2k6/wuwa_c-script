using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002572 RID: 9586
[NullableContext(1)]
[Nullable(0)]
public class PhotoCameraTempItem : GridProxyAbstract<PhotoTemplate>
{
	// Token: 0x060135AA RID: 79274 RVA: 0x004D0BAC File Offset: 0x004CEDAC
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

	// Token: 0x060135AB RID: 79275 RVA: 0x004D0C3F File Offset: 0x004CEE3F
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x060135AC RID: 79276 RVA: 0x004D0C48 File Offset: 0x004CEE48
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnSwitchingModeChanged = (Action<bool>)Delegate.Combine(viewModel.OnSwitchingModeChanged, new Action<bool>(this.OnSwitchingModeChanged));
		this.ApplyInteractive();
	}

	// Token: 0x060135AD RID: 79277 RVA: 0x004D0C84 File Offset: 0x004CEE84
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnSwitchingModeChanged = (Action<bool>)Delegate.Remove(viewModel.OnSwitchingModeChanged, new Action<bool>(this.OnSwitchingModeChanged));
	}

	// Token: 0x060135AE RID: 79278 RVA: 0x004D0CAD File Offset: 0x004CEEAD
	private void OnSwitchingModeChanged(bool switching)
	{
		this.ApplyInteractive();
	}

	// Token: 0x060135AF RID: 79279 RVA: 0x004D0CB8 File Offset: 0x004CEEB8
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

	// Token: 0x060135B0 RID: 79280 RVA: 0x004D0D59 File Offset: 0x004CEF59
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleSelected(true);
	}

	// Token: 0x060135B1 RID: 79281 RVA: 0x004D0D62 File Offset: 0x004CEF62
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleSelected(false);
	}

	// Token: 0x060135B2 RID: 79282 RVA: 0x004D0D6B File Offset: 0x004CEF6B
	private void ApplyInteractive()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(!this.ViewModel.IsSwitchingMode);
	}

	// Token: 0x060135B3 RID: 79283 RVA: 0x004D0D8C File Offset: 0x004CEF8C
	private void SetToggleSelected(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060135B4 RID: 79284 RVA: 0x004D0DA9 File Offset: 0x004CEFA9
	public override object GetKey(PhotoTemplate data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060135B5 RID: 79285 RVA: 0x004D0DB7 File Offset: 0x004CEFB7
	private void OnToggleStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnTemplateClick(base.GridIndex);
	}

	// Token: 0x040091D7 RID: 37335
	public Action<int> OnTemplateClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040091D8 RID: 37336
	private PhotoMainViewModel ViewModel;

	// Token: 0x02008B5A RID: 35674
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D3F9 RID: 185337
		ToggleItem,
		// Token: 0x0402D3FA RID: 185338
		ItemNormalState,
		// Token: 0x0402D3FB RID: 185339
		ItemTemp,
		// Token: 0x0402D3FC RID: 185340
		TextureBg
	}
}
