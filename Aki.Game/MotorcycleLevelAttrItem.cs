using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002237 RID: 8759
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleLevelAttrItem : GridProxyAbstract<IMotorLevelAttrData>
{
	// Token: 0x06011176 RID: 70006 RVA: 0x0042AD44 File Offset: 0x00428F44
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x06011177 RID: 70007 RVA: 0x0042ADCA File Offset: 0x00428FCA
	private string GetEnoughColorStr(bool isEnough, string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(isEnough ? "<color=#97ff86>" : "<color=#c25757>");
		stringBuilder.Append(value);
		stringBuilder.Append("</color>");
		return stringBuilder.ToString();
	}

	// Token: 0x06011178 RID: 70008 RVA: 0x0042AE00 File Offset: 0x00429000
	public override void Refresh(IMotorLevelAttrData data, bool isSelected, int gridIndex)
	{
		MotorAttr? motorAttrConfig = MotorConfig.Instance.GetMotorAttrConfig(data.AttrId);
		if (motorAttrConfig == null)
		{
			return;
		}
		int curLevel = MotorcycleDevelopModel.Instance.GetCurLevel();
		bool flag = curLevel < data.Level && data.IsSpecial;
		base.GetSprite(4).SetUIActive(flag);
		base.GetItem(0).SetUIActive(!flag && data.IsShowBg);
		base.SetTextureByPath(motorAttrConfig.Value.Icon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorAttrConfig.Value.Name, Array.Empty<object>());
		bool isNumber = motorAttrConfig.Value.IsNumber;
		float num = MotorcycleDevelopModel.Instance.GetAttrValueByType(data.AttrId, data.Level);
		float num2 = MotorcycleDevelopModel.Instance.GetAttrValueByType(data.AttrId, curLevel);
		if (data.IsSpecial)
		{
			num2 = MotorcycleDevelopModel.Instance.GetAttrValueByType(data.AttrId, data.Level - 1);
		}
		num = (motorAttrConfig.Value.IsPercent ? (num / 100f) : num);
		num2 = (motorAttrConfig.Value.IsPercent ? (num2 / 100f) : num2);
		float num3 = num - num2;
		string text = (num3 > 0f) ? StringUtils.Format("+{0}", new string[]
		{
			num3.ToString()
		}) : num3.ToString();
		string text2 = num2.ToString();
		string text3 = num.ToString();
		text = (motorAttrConfig.Value.IsPercent ? StringUtils.Format("{0}%", new string[]
		{
			text
		}) : text);
		text2 = (motorAttrConfig.Value.IsPercent ? StringUtils.Format("{0}%", new string[]
		{
			text2
		}) : text2);
		text3 = (motorAttrConfig.Value.IsPercent ? StringUtils.Format("{0}%", new string[]
		{
			text3
		}) : text3);
		string newText;
		if (num3 != 0f)
		{
			bool flag2 = data.Level > curLevel;
			if (!isNumber)
			{
				string text4 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MotorBike_Status_Speed_LvUp", null), new string[]
				{
					text2,
					text3
				});
				string text5 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MotorBike_Status_Speed_Lv", null), new string[]
				{
					text3
				});
				text4 = this.GetEnoughColorStr(flag2, text4);
				newText = (flag2 ? text4 : text5);
			}
			else
			{
				text = this.GetEnoughColorStr(flag2, text);
				newText = (flag2 ? StringUtils.Format("{0}{1}", new string[]
				{
					text2,
					text
				}) : text3);
			}
		}
		else if (!isNumber)
		{
			newText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MotorBike_Status_Speed_Lv", null), new string[]
			{
				text3
			});
		}
		else
		{
			newText = text3;
		}
		base.GetText(3).SetText(newText, true);
	}

	// Token: 0x0200876B RID: 34667
	[NullableContext(0)]
	private class EMotorLevelAttrItemComponent
	{
		// Token: 0x0402C040 RID: 180288
		public const int BgItem = 0;

		// Token: 0x0402C041 RID: 180289
		public const int TexIcon = 1;

		// Token: 0x0402C042 RID: 180290
		public const int TxtAttrName = 2;

		// Token: 0x0402C043 RID: 180291
		public const int TxtAttrValue = 3;

		// Token: 0x0402C044 RID: 180292
		public const int SprAdditionBg = 4;
	}
}
