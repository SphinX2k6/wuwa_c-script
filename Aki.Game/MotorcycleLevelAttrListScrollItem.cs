using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200171C RID: 5916
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleLevelAttrListScrollItem : GridProxyAbstract<IMotorLevelAttrData>
{
	// Token: 0x0600E610 RID: 58896 RVA: 0x00437CB0 File Offset: 0x00435EB0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleEvent))
		};
	}

	// Token: 0x0600E611 RID: 58897 RVA: 0x00437DB4 File Offset: 0x00435FB4
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.RootUIComp.Get().SetUIActive(true);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x0600E612 RID: 58898 RVA: 0x00437E1B File Offset: 0x0043601B
	protected override void OnBeforeDestroy()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}
	}

	// Token: 0x0600E613 RID: 58899 RVA: 0x00437E38 File Offset: 0x00436038
	public override void Refresh(IMotorLevelAttrData data, bool isSelected, int gridIndex)
	{
		MotorAttr? motorAttrConfig = MotorConfig.Instance.GetMotorAttrConfig(data.AttrId);
		if (motorAttrConfig == null)
		{
			return;
		}
		base.GetSprite(1).useChangeColor = !data.IsShowBg;
		this.AttrDesc = motorAttrConfig.Value.Desc;
		if (!StringUtils.IsBlank(this.AttrDesc))
		{
			base.GetItem(6).SetUIActive(true);
			base.GetText(8).ShowTextNew(this.AttrDesc);
		}
		else
		{
			base.GetItem(6).SetUIActive(false);
		}
		int curLevel = MotorcycleDevelopModel.Instance.GetCurLevel();
		bool isNumber = motorAttrConfig.Value.IsNumber;
		float num = MotorcycleDevelopModel.Instance.GetAttrValueByType(data.AttrId, data.Level);
		float num2 = MotorcycleDevelopModel.Instance.GetAttrValueByType(data.AttrId, curLevel);
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
		text3 = (motorAttrConfig.Value.IsPercent ? StringUtils.Format("{0}%", new string[]
		{
			text3
		}) : text3);
		text2 = (motorAttrConfig.Value.IsPercent ? StringUtils.Format("{0}%", new string[]
		{
			text2
		}) : text2);
		if (!StringUtils.IsBlank(motorAttrConfig.Value.Suffix))
		{
			string text4 = ConfigMultiTextLang.GetLocalTextNew(motorAttrConfig.Value.Suffix, null) ?? "";
			text = StringUtils.Format("{0}{1}", new string[]
			{
				text,
				text4
			});
			text3 = StringUtils.Format("{0}{1}", new string[]
			{
				text3,
				text4
			});
			text2 = StringUtils.Format("{0}{1}", new string[]
			{
				text2,
				text4
			});
		}
		FColor fcolor = FColor.FromHex("97ff86");
		FColor fcolor2 = FColor.FromHex("c25757");
		if (!isNumber)
		{
			string text5 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MotorBike_Status_Speed_Lv", null), new string[]
			{
				num.ToString()
			});
			text2 = ((num3 > 0f) ? "" : text5);
			text3 = ((num3 > 0f) ? "" : text5);
			text5 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MotorBike_Status_Speed_LvUp", null), new string[]
			{
				num2.ToString(),
				num.ToString()
			});
			text = text5;
		}
		base.GetText(4).SetText((data.Level > curLevel) ? text2 : text3, true);
		base.GetText(5).SetText(text, true);
		base.GetText(5).SetColor((data.Level > curLevel) ? fcolor : fcolor2);
		base.GetText(5).SetUIActive(data.Level > curLevel && num3 != 0f);
		base.GetText(3).ShowTextNew(motorAttrConfig.Value.Name);
		base.SetTextureByPath(motorAttrConfig.Value.Icon, base.GetTexture(2), null, null);
	}

	// Token: 0x0600E614 RID: 58900 RVA: 0x004381E5 File Offset: 0x004363E5
	private bool CanClickLikeToggle()
	{
		return !StringUtils.IsBlank(this.AttrDesc);
	}

	// Token: 0x0600E615 RID: 58901 RVA: 0x004381F8 File Offset: 0x004363F8
	protected void ToggleEvent(EToggleState bState)
	{
		bool flag = bState == EToggleState.ETT_Checked;
		base.GetText(8).SetUIActive(flag);
		base.GetItem(7).SetUIActive(flag);
		string sequenceName = flag ? "Show" : "Hide";
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}
	}

	// Token: 0x0400836F RID: 33647
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008370 RID: 33648
	private string AttrDesc = "";

	// Token: 0x020078F5 RID: 30965
	[NullableContext(0)]
	private class EAttrItemDefine
	{
		// Token: 0x0402735D RID: 160605
		public const int ToggleBase = 0;

		// Token: 0x0402735E RID: 160606
		public const int SpriteBase = 1;

		// Token: 0x0402735F RID: 160607
		public const int AttrIconTexture = 2;

		// Token: 0x04027360 RID: 160608
		public const int AttrNameText = 3;

		// Token: 0x04027361 RID: 160609
		public const int AttrBaseValue = 4;

		// Token: 0x04027362 RID: 160610
		public const int AttrAddValue = 5;

		// Token: 0x04027363 RID: 160611
		public const int Arrow = 6;

		// Token: 0x04027364 RID: 160612
		public const int PanelDescription = 7;

		// Token: 0x04027365 RID: 160613
		public const int TextDescription = 8;
	}
}
