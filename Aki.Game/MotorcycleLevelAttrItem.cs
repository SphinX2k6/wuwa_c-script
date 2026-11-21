using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200171B RID: 5915
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleLevelAttrItem : GridProxyAbstract<IMotorLevelAttrData>
{
	// Token: 0x0600E60C RID: 58892 RVA: 0x004378E8 File Offset: 0x00435AE8
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

	// Token: 0x0600E60D RID: 58893 RVA: 0x0043796E File Offset: 0x00435B6E
	private string GetEnoughColorStr(bool isEnough, string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(isEnough ? "<color=#97ff86>" : "<color=#c25757>");
		stringBuilder.Append(value);
		stringBuilder.Append("</color>");
		return stringBuilder.ToString();
	}

	// Token: 0x0600E60E RID: 58894 RVA: 0x004379A4 File Offset: 0x00435BA4
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

	// Token: 0x020078F4 RID: 30964
	[NullableContext(0)]
	private class EMotorLevelAttrItemComponent
	{
		// Token: 0x04027358 RID: 160600
		public const int BgItem = 0;

		// Token: 0x04027359 RID: 160601
		public const int TexIcon = 1;

		// Token: 0x0402735A RID: 160602
		public const int TxtAttrName = 2;

		// Token: 0x0402735B RID: 160603
		public const int TxtAttrValue = 3;

		// Token: 0x0402735C RID: 160604
		public const int SprAdditionBg = 4;
	}
}
