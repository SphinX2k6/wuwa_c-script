using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200248A RID: 9354
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleAttrScrollItem : GridProxyAbstract<VisionAssembleAttrData>
{
	// Token: 0x06012C69 RID: 76905 RVA: 0x004A1808 File Offset: 0x0049FA08
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
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x06012C6A RID: 76906 RVA: 0x004A192B File Offset: 0x0049FB2B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06012C6B RID: 76907 RVA: 0x004A1940 File Offset: 0x0049FB40
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

	// Token: 0x06012C6C RID: 76908 RVA: 0x004A197C File Offset: 0x0049FB7C
	public void SetLeftItemAlpha(float alpha)
	{
		base.GetItem(0).SetAlpha(alpha);
	}

	// Token: 0x06012C6D RID: 76909 RVA: 0x004A198B File Offset: 0x0049FB8B
	public void SetRightItemAlpha(float alpha)
	{
		base.GetItem(11).SetAlpha(alpha);
	}

	// Token: 0x06012C6E RID: 76910 RVA: 0x004A199C File Offset: 0x0049FB9C
	private void RefreshBg(int gridIndex)
	{
		bool uiactive = gridIndex % 2 == 0;
		base.GetItem(1).SetUIActive(uiactive);
		base.GetItem(5).SetUIActive(uiactive);
	}

	// Token: 0x06012C6F RID: 76911 RVA: 0x004A19CC File Offset: 0x0049FBCC
	public override void Refresh(VisionAssembleAttrData data, bool isSelected, int gridIndex)
	{
		this.RefreshBg(gridIndex);
		bool compareMode = data.CompareMode;
		base.GetItem(0).SetUIActive(compareMode);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.AttrId);
		if (compareMode)
		{
			base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(2), null, null);
			base.GetText(3).ShowTextNew(propertyIndexInfo.Value.Name);
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)data.CompareValue, data.IfPercentage);
			string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(data.AttrId, propRatioValue, data.IfPercentage);
			base.GetText(4).SetText(formatAttributeValueString, true);
			bool flag = data.CompareValue == data.CurrentValue;
			bool flag2 = data.CompareValue < data.CurrentValue;
			base.GetItem(9).SetUIActive(flag2 && !flag);
			base.GetItem(10).SetUIActive(!flag2 && !flag);
		}
		else
		{
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(6), null, null);
		base.GetText(7).ShowTextNew(propertyIndexInfo.Value.Name);
		double propRatioValue2 = TipsDataTool.GetPropRatioValue((double)data.CurrentValue, data.IfPercentage);
		string formatAttributeValueString2 = AttributeModel.Instance.GetFormatAttributeValueString(data.AttrId, propRatioValue2, data.IfPercentage);
		base.GetText(8).SetText(formatAttributeValueString2, true);
	}

	// Token: 0x04008D65 RID: 36197
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008A01 RID: 35329
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD0D RID: 183565
		LeftItem,
		// Token: 0x0402CD0E RID: 183566
		LeftSpriteBg,
		// Token: 0x0402CD0F RID: 183567
		LeftTextureIcon,
		// Token: 0x0402CD10 RID: 183568
		LeftAttributeText,
		// Token: 0x0402CD11 RID: 183569
		LeftNumText,
		// Token: 0x0402CD12 RID: 183570
		RightSpriteBg,
		// Token: 0x0402CD13 RID: 183571
		RightTextureIcon,
		// Token: 0x0402CD14 RID: 183572
		RightAttributeText,
		// Token: 0x0402CD15 RID: 183573
		RightNumText,
		// Token: 0x0402CD16 RID: 183574
		UpItem,
		// Token: 0x0402CD17 RID: 183575
		DownItem,
		// Token: 0x0402CD18 RID: 183576
		RightItem
	}
}
