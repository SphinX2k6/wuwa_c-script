using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001759 RID: 5977
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyEditFrameItem : GridProxyAbstract<MotorcycleDiyEditFrameItemData>
{
	// Token: 0x0600E840 RID: 59456 RVA: 0x0044043C File Offset: 0x0043E63C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x0600E841 RID: 59457 RVA: 0x00440540 File Offset: 0x0043E740
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiyEditFrameItemData data, bool isSelected, int gridIndex)
	{
		this.FrameId = data.ItemId;
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(2);
		UUITexture texture3 = base.GetTexture(3);
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(5);
		UUIItem item3 = base.GetItem(6);
		UUIItem item4 = base.GetItem(7);
		UUIItem item5 = base.GetItem(8);
		item3.SetUIActive(false);
		item4.SetUIActive(false);
		item5.SetUIActive(false);
		item2.SetUIActive(false);
		bool flag = MotorcycleDiyModel.Instance.GetSelectedFrameId() == data.ItemId;
		item.SetUIActive(flag);
		if (MotorcycleDiyModel.Instance.GetFrameState(data.ItemId) == EOutLookState.IsBan)
		{
			item4.SetUIActive(true);
		}
		MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(data.ItemId);
		if (motorFrameConfig == null)
		{
			return;
		}
		MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(motorFrameConfig.Value.QualityId);
		if (motorQualityConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorFrameConfig.Value.ModelIconPath, texture, null, null);
		base.SetTextureByPath(motorQualityConfig.Value.FramePath, texture2, null, null);
		base.SetTextureByPath(motorQualityConfig.Value.FrameShinePath, texture3, null, null);
		EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E842 RID: 59458 RVA: 0x004406AC File Offset: 0x0043E8AC
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickItem(EToggleState.ETT_Checked);
	}

	// Token: 0x0600E843 RID: 59459 RVA: 0x004406B5 File Offset: 0x0043E8B5
	private void OnClickItem(EToggleState toggleState)
	{
		if (this.FrameId == 0)
		{
			return;
		}
		Action<int, UUIExtendToggle, UUIItem> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.FrameId, base.GetExtendToggle(0), base.GetItem(6));
	}

	// Token: 0x04008459 RID: 33881
	private int FrameId;

	// Token: 0x0400845A RID: 33882
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int, UUIExtendToggle, UUIItem> OnClickToggleBack;

	// Token: 0x02007941 RID: 31041
	private class EEditFrameItemComponent
	{
		// Token: 0x040274C6 RID: 160966
		public const int TogFrame = 0;

		// Token: 0x040274C7 RID: 160967
		public const int TexIcon = 1;

		// Token: 0x040274C8 RID: 160968
		public const int TexQuality1 = 2;

		// Token: 0x040274C9 RID: 160969
		public const int TexQuality2 = 3;

		// Token: 0x040274CA RID: 160970
		public const int PnlSelect = 4;

		// Token: 0x040274CB RID: 160971
		public const int Pnllock = 5;

		// Token: 0x040274CC RID: 160972
		public const int NewItem = 6;

		// Token: 0x040274CD RID: 160973
		public const int BanItem = 7;

		// Token: 0x040274CE RID: 160974
		public const int PreviewItem = 8;
	}
}
