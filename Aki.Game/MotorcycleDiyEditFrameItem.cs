using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002275 RID: 8821
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyEditFrameItem : GridProxyAbstract<MotorcycleDiyEditFrameItemData>
{
	// Token: 0x060113AA RID: 70570 RVA: 0x00433830 File Offset: 0x00431A30
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

	// Token: 0x060113AB RID: 70571 RVA: 0x00433934 File Offset: 0x00431B34
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

	// Token: 0x060113AC RID: 70572 RVA: 0x00433AA0 File Offset: 0x00431CA0
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickItem(EToggleState.ETT_Checked);
	}

	// Token: 0x060113AD RID: 70573 RVA: 0x00433AA9 File Offset: 0x00431CA9
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

	// Token: 0x0400831B RID: 33563
	private int FrameId;

	// Token: 0x0400831C RID: 33564
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int, UUIExtendToggle, UUIItem> OnClickToggleBack;

	// Token: 0x020087B8 RID: 34744
	private class EEditFrameItemComponent
	{
		// Token: 0x0402C1AE RID: 180654
		public const int TogFrame = 0;

		// Token: 0x0402C1AF RID: 180655
		public const int TexIcon = 1;

		// Token: 0x0402C1B0 RID: 180656
		public const int TexQuality1 = 2;

		// Token: 0x0402C1B1 RID: 180657
		public const int TexQuality2 = 3;

		// Token: 0x0402C1B2 RID: 180658
		public const int PnlSelect = 4;

		// Token: 0x0402C1B3 RID: 180659
		public const int Pnllock = 5;

		// Token: 0x0402C1B4 RID: 180660
		public const int NewItem = 6;

		// Token: 0x0402C1B5 RID: 180661
		public const int BanItem = 7;

		// Token: 0x0402C1B6 RID: 180662
		public const int PreviewItem = 8;
	}
}
