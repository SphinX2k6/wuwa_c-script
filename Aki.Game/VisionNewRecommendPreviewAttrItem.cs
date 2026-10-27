using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024D3 RID: 9427
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendPreviewAttrItem : GridProxyAbstract<VisionAssembleAttrData>
{
	// Token: 0x06012F54 RID: 77652 RVA: 0x004B1770 File Offset: 0x004AF970
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUISprite))
		};
	}

	// Token: 0x06012F55 RID: 77653 RVA: 0x004B18C1 File Offset: 0x004AFAC1
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06012F56 RID: 77654 RVA: 0x004B18D4 File Offset: 0x004AFAD4
	public void PlaySequence(string name)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName(name, false, null, false);
	}

	// Token: 0x06012F57 RID: 77655 RVA: 0x004B1910 File Offset: 0x004AFB10
	public void SetLeftItemAlpha(float alpha)
	{
		base.GetItem(0).SetAlpha(alpha);
	}

	// Token: 0x06012F58 RID: 77656 RVA: 0x004B191F File Offset: 0x004AFB1F
	public void SetRightItemAlpha(float alpha)
	{
		base.GetItem(11).SetAlpha(alpha);
	}

	// Token: 0x06012F59 RID: 77657 RVA: 0x004B1930 File Offset: 0x004AFB30
	private void RefreshBg(int gridIndex)
	{
		bool uiactive = gridIndex % 2 == 0;
		base.GetItem(1).SetUIActive(uiactive);
		base.GetItem(5).SetUIActive(uiactive);
		UUISprite sprite = base.GetSprite(12);
		if (sprite != null)
		{
			VisionAssembleAttrData data = this.Data;
			sprite.SetUIActive(data != null && data.IsHighLight);
		}
		UUISprite sprite2 = base.GetSprite(13);
		if (sprite2 == null)
		{
			return;
		}
		VisionAssembleAttrData data2 = this.Data;
		sprite2.SetUIActive(data2 != null && data2.IsHighLight);
	}

	// Token: 0x06012F5A RID: 77658 RVA: 0x004B19A8 File Offset: 0x004AFBA8
	public override void Refresh(VisionAssembleAttrData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshBg(gridIndex);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.AttrId);
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(propertyIndexInfo.Value.Name);
		double propRatioValue = TipsDataTool.GetPropRatioValue((double)data.CompareValue, data.IfPercentage);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(data.AttrId, propRatioValue, data.IfPercentage);
		base.GetText(4).SetText(formatAttributeValueString.ToString(), true);
		bool flag = data.CompareValue == data.CurrentValue;
		bool flag2 = data.CompareValue < data.CurrentValue;
		base.GetItem(9).SetUIActive(flag2 && !flag);
		base.GetItem(10).SetUIActive(!flag2 && !flag);
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(6), null, null);
		base.GetText(7).ShowTextNew(propertyIndexInfo.Value.Name);
		propRatioValue = TipsDataTool.GetPropRatioValue((double)data.CurrentValue, data.IfPercentage);
		formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(data.AttrId, propRatioValue, data.IfPercentage);
		base.GetText(8).SetText(formatAttributeValueString, true);
	}

	// Token: 0x04008EC0 RID: 36544
	[Nullable(2)]
	private VisionAssembleAttrData Data;

	// Token: 0x04008EC1 RID: 36545
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008A63 RID: 35427
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CEF0 RID: 184048
		LeftItem,
		// Token: 0x0402CEF1 RID: 184049
		LeftSpriteBg,
		// Token: 0x0402CEF2 RID: 184050
		LeftTextureIcon,
		// Token: 0x0402CEF3 RID: 184051
		LeftAttributeText,
		// Token: 0x0402CEF4 RID: 184052
		LeftNumText,
		// Token: 0x0402CEF5 RID: 184053
		RightSpriteBg,
		// Token: 0x0402CEF6 RID: 184054
		RightTextureIcon,
		// Token: 0x0402CEF7 RID: 184055
		RightAttributeText,
		// Token: 0x0402CEF8 RID: 184056
		RightNumText,
		// Token: 0x0402CEF9 RID: 184057
		UpItem,
		// Token: 0x0402CEFA RID: 184058
		DownItem,
		// Token: 0x0402CEFB RID: 184059
		RightItem,
		// Token: 0x0402CEFC RID: 184060
		LeftHighLightBg,
		// Token: 0x0402CEFD RID: 184061
		RightHighLightBg
	}
}
