using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200175F RID: 5983
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetItem : GridProxyAbstract<MotorcycleDiyPresetData>
{
	// Token: 0x0600E86D RID: 59501 RVA: 0x00441CB4 File Offset: 0x0043FEB4
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

	// Token: 0x0600E86E RID: 59502 RVA: 0x00441D73 File Offset: 0x0043FF73
	protected override void OnStart()
	{
		this.PresetLayout = new GenericLayout<MotorcycleDiyPresetIconItem, string>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyPresetIconItem>(this.InitPresetIconItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600E86F RID: 59503 RVA: 0x00441DA6 File Offset: 0x0043FFA6
	private MotorcycleDiyPresetIconItem InitPresetIconItem()
	{
		return new MotorcycleDiyPresetIconItem();
	}

	// Token: 0x0600E870 RID: 59504 RVA: 0x00441DAD File Offset: 0x0043FFAD
	public override void Refresh(MotorcycleDiyPresetData data, bool isSelected, int gridIndex)
	{
		this.ListIndex = gridIndex;
		this.RefreshPresetInfo(data);
	}

	// Token: 0x0600E871 RID: 59505 RVA: 0x00441DC0 File Offset: 0x0043FFC0
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

	// Token: 0x0600E872 RID: 59506 RVA: 0x00441FA1 File Offset: 0x004401A1
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickItem(EToggleState.ETT_Checked);
	}

	// Token: 0x0600E873 RID: 59507 RVA: 0x00441FAA File Offset: 0x004401AA
	public void SetToggleState(EToggleState state, bool isFireEvent = true)
	{
		base.GetExtendToggle(0).SetToggleState(state, isFireEvent, false, false);
	}

	// Token: 0x0600E874 RID: 59508 RVA: 0x00441FBD File Offset: 0x004401BD
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

	// Token: 0x04008466 RID: 33894
	[Nullable(2)]
	private MotorcycleDiyPresetData Data;

	// Token: 0x04008467 RID: 33895
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorcycleDiyPresetData, int, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x04008468 RID: 33896
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyPresetIconItem, string> PresetLayout;

	// Token: 0x04008469 RID: 33897
	private int ListIndex = -1;

	// Token: 0x02007948 RID: 31048
	[NullableContext(0)]
	private class EMotorDiyPresetItemComponent
	{
		// Token: 0x040274FC RID: 161020
		public const int TogItem = 0;

		// Token: 0x040274FD RID: 161021
		public const int TexIcon = 1;

		// Token: 0x040274FE RID: 161022
		public const int TxtName = 2;

		// Token: 0x040274FF RID: 161023
		public const int PresetLayout = 3;

		// Token: 0x04027500 RID: 161024
		public const int PresetItem = 4;

		// Token: 0x04027501 RID: 161025
		public const int ArtTxtCustomId = 5;
	}

	// Token: 0x02007949 RID: 31049
	[NullableContext(0)]
	private class EMotorDiyPresetIconComponent
	{
		// Token: 0x04027502 RID: 161026
		public const int TexIcon = 0;
	}
}
