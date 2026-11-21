using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019BA RID: 6586
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendPreviewAttrItem : GridProxyAbstract<VisionAssembleAttrData>
{
	// Token: 0x06010413 RID: 66579 RVA: 0x004BF370 File Offset: 0x004BD570
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

	// Token: 0x06010414 RID: 66580 RVA: 0x004BF4C1 File Offset: 0x004BD6C1
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010415 RID: 66581 RVA: 0x004BF4D4 File Offset: 0x004BD6D4
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

	// Token: 0x06010416 RID: 66582 RVA: 0x004BF510 File Offset: 0x004BD710
	public void SetLeftItemAlpha(float alpha)
	{
		base.GetItem(0).SetAlpha(alpha);
	}

	// Token: 0x06010417 RID: 66583 RVA: 0x004BF51F File Offset: 0x004BD71F
	public void SetRightItemAlpha(float alpha)
	{
		base.GetItem(11).SetAlpha(alpha);
	}

	// Token: 0x06010418 RID: 66584 RVA: 0x004BF530 File Offset: 0x004BD730
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

	// Token: 0x06010419 RID: 66585 RVA: 0x004BF5A8 File Offset: 0x004BD7A8
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

	// Token: 0x0400900A RID: 36874
	[Nullable(2)]
	private VisionAssembleAttrData Data;

	// Token: 0x0400900B RID: 36875
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007BEC RID: 31724
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402820E RID: 164366
		LeftItem,
		// Token: 0x0402820F RID: 164367
		LeftSpriteBg,
		// Token: 0x04028210 RID: 164368
		LeftTextureIcon,
		// Token: 0x04028211 RID: 164369
		LeftAttributeText,
		// Token: 0x04028212 RID: 164370
		LeftNumText,
		// Token: 0x04028213 RID: 164371
		RightSpriteBg,
		// Token: 0x04028214 RID: 164372
		RightTextureIcon,
		// Token: 0x04028215 RID: 164373
		RightAttributeText,
		// Token: 0x04028216 RID: 164374
		RightNumText,
		// Token: 0x04028217 RID: 164375
		UpItem,
		// Token: 0x04028218 RID: 164376
		DownItem,
		// Token: 0x04028219 RID: 164377
		RightItem,
		// Token: 0x0402821A RID: 164378
		LeftHighLightBg,
		// Token: 0x0402821B RID: 164379
		RightHighLightBg
	}
}
