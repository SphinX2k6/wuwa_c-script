using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200227B RID: 8827
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetItem : GridProxyAbstract<MotorcycleDiyPresetData>
{
	// Token: 0x060113D7 RID: 70615 RVA: 0x004350A8 File Offset: 0x004332A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIArtText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x060113D8 RID: 70616 RVA: 0x00435167 File Offset: 0x00433367
	protected override void OnStart()
	{
		this.PresetLayout = new GenericLayout<MotorcycleDiyPresetIconItem, string>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyPresetIconItem>(this.InitPresetIconItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060113D9 RID: 70617 RVA: 0x0043519A File Offset: 0x0043339A
	private MotorcycleDiyPresetIconItem InitPresetIconItem()
	{
		return new MotorcycleDiyPresetIconItem();
	}

	// Token: 0x060113DA RID: 70618 RVA: 0x004351A1 File Offset: 0x004333A1
	public override void Refresh(MotorcycleDiyPresetData data, bool isSelected, int gridIndex)
	{
		this.ListIndex = gridIndex;
		this.RefreshPresetInfo(data);
	}

	// Token: 0x060113DB RID: 70619 RVA: 0x004351B4 File Offset: 0x004333B4
	public void RefreshPresetInfo(MotorcycleDiyPresetData data)
	{
		this.Data = data;
		UUIText text = base.GetText(2);
		UUIArtText artText = base.GetArtText(5);
		text.SetText(data.Name, true);
		bool flag = !data.IsCurEquipped;
		int value = this.ListIndex + 1;
		UUIArtText uuiartText = artText;
		string text2;
		if (!flag)
		{
			text2 = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		uuiartText.SetText(text2);
		if (data.OfficialId > 0)
		{
			MotorLoadProject? motorPresetConfig = MotorDiyConfig.Instance.GetMotorPresetConfig(data.OfficialId);
			if (motorPresetConfig != null)
			{
				base.SetTextureByPath(motorPresetConfig.Value.Icon, base.GetTexture(1), null, null);
			}
			GenericLayout<MotorcycleDiyPresetIconItem, string> presetLayout = this.PresetLayout;
			if (presetLayout == null)
			{
				return;
			}
			presetLayout.RefreshByData(new List<string>(), null, false);
			return;
		}
		else
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(data.FrameId);
			if (motorFrameConfig != null)
			{
				base.SetTextureByPath(motorFrameConfig.Value.PresetIcon, base.GetTexture(1), null, null);
			}
			List<string> list = new List<string>();
			foreach (int num in data.StickerIds)
			{
				if (num > 0)
				{
					MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
					if (motorStickerConfig != null)
					{
						list.Add(motorStickerConfig.Value.StickerIconPath);
					}
				}
			}
			foreach (int num2 in data.DecorateIds)
			{
				if (num2 > 0)
				{
					MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num2);
					if (motorDecorationConfig != null)
					{
						list.Add(motorDecorationConfig.Value.DecorationsIconPath);
					}
				}
			}
			GenericLayout<MotorcycleDiyPresetIconItem, string> presetLayout2 = this.PresetLayout;
			if (presetLayout2 == null)
			{
				return;
			}
			presetLayout2.RefreshByData(list, null, false);
			return;
		}
	}

	// Token: 0x060113DC RID: 70620 RVA: 0x00435395 File Offset: 0x00433595
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickItem(EToggleState.ETT_Checked);
	}

	// Token: 0x060113DD RID: 70621 RVA: 0x0043539E File Offset: 0x0043359E
	public void SetToggleState(EToggleState state, bool isFireEvent = true)
	{
		base.GetExtendToggle(0).SetToggleState(state, isFireEvent, false, false);
	}

	// Token: 0x060113DE RID: 70622 RVA: 0x004353B1 File Offset: 0x004335B1
	private void OnClickItem(EToggleState toggleState)
	{
		if (this.Data == null)
		{
			return;
		}
		Action<MotorcycleDiyPresetData, int, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Data, this.ListIndex, base.GetExtendToggle(0));
	}

	// Token: 0x04008328 RID: 33576
	[Nullable(2)]
	private MotorcycleDiyPresetData Data;

	// Token: 0x04008329 RID: 33577
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorcycleDiyPresetData, int, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x0400832A RID: 33578
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyPresetIconItem, string> PresetLayout;

	// Token: 0x0400832B RID: 33579
	private int ListIndex = -1;

	// Token: 0x020087BF RID: 34751
	[NullableContext(0)]
	private class EMotorDiyPresetItemComponent
	{
		// Token: 0x0402C1E4 RID: 180708
		public const int TogItem = 0;

		// Token: 0x0402C1E5 RID: 180709
		public const int TexIcon = 1;

		// Token: 0x0402C1E6 RID: 180710
		public const int TxtName = 2;

		// Token: 0x0402C1E7 RID: 180711
		public const int PresetLayout = 3;

		// Token: 0x0402C1E8 RID: 180712
		public const int PresetItem = 4;

		// Token: 0x0402C1E9 RID: 180713
		public const int ArtTxtCustomId = 5;
	}

	// Token: 0x020087C0 RID: 34752
	[NullableContext(0)]
	private class EMotorDiyPresetIconComponent
	{
		// Token: 0x0402C1EA RID: 180714
		public const int TexIcon = 0;
	}
}
