using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001970 RID: 6512
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleAttrScrollItem : GridProxyAbstract<VisionAssembleAttrData>
{
	// Token: 0x06010122 RID: 65826 RVA: 0x004AEF70 File Offset: 0x004AD170
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

	// Token: 0x06010123 RID: 65827 RVA: 0x004AF093 File Offset: 0x004AD293
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010124 RID: 65828 RVA: 0x004AF0A8 File Offset: 0x004AD2A8
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

	// Token: 0x06010125 RID: 65829 RVA: 0x004AF0E4 File Offset: 0x004AD2E4
	public void SetLeftItemAlpha(float alpha)
	{
		base.GetItem(0).SetAlpha(alpha);
	}

	// Token: 0x06010126 RID: 65830 RVA: 0x004AF0F3 File Offset: 0x004AD2F3
	public void SetRightItemAlpha(float alpha)
	{
		base.GetItem(11).SetAlpha(alpha);
	}

	// Token: 0x06010127 RID: 65831 RVA: 0x004AF104 File Offset: 0x004AD304
	private void RefreshBg(int gridIndex)
	{
		bool uiactive = gridIndex % 2 == 0;
		base.GetItem(1).SetUIActive(uiactive);
		base.GetItem(5).SetUIActive(uiactive);
	}

	// Token: 0x06010128 RID: 65832 RVA: 0x004AF134 File Offset: 0x004AD334
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

	// Token: 0x04008EAC RID: 36524
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007B88 RID: 31624
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028023 RID: 163875
		LeftItem,
		// Token: 0x04028024 RID: 163876
		LeftSpriteBg,
		// Token: 0x04028025 RID: 163877
		LeftTextureIcon,
		// Token: 0x04028026 RID: 163878
		LeftAttributeText,
		// Token: 0x04028027 RID: 163879
		LeftNumText,
		// Token: 0x04028028 RID: 163880
		RightSpriteBg,
		// Token: 0x04028029 RID: 163881
		RightTextureIcon,
		// Token: 0x0402802A RID: 163882
		RightAttributeText,
		// Token: 0x0402802B RID: 163883
		RightNumText,
		// Token: 0x0402802C RID: 163884
		UpItem,
		// Token: 0x0402802D RID: 163885
		DownItem,
		// Token: 0x0402802E RID: 163886
		RightItem
	}
}
