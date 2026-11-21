using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200135A RID: 4954
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryAttrItem : GridProxyAbstract<IHonamiStoryAttrData>
{
	// Token: 0x0600C49E RID: 50334 RVA: 0x003A6A20 File Offset: 0x003A4C20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600C49F RID: 50335 RVA: 0x003A6ABC File Offset: 0x003A4CBC
	[NullableContext(1)]
	public override void Refresh(IHonamiStoryAttrData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
		bool flag = data.NewValue != data.OldValue;
		string newText = data.OldValue.ToString();
		string newText2 = data.NewValue.ToString();
		if (data.IsPercent)
		{
			int value = (data.OldValue != 0) ? 1 : 0;
			double num = (double)data.OldValue / 100.0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("F");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			newText = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear()) + "%";
			value = ((data.NewValue != 0) ? 1 : 0);
			num = (double)data.NewValue / 100.0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("F");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			newText2 = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear()) + "%";
		}
		base.GetText(2).SetText(newText, true);
		UUIText text = base.GetText(4);
		text.SetText(newText2, true);
		if (this.OriginColor == null)
		{
			this.OriginColor = new FColor?(text.Color);
		}
		if (flag)
		{
			FColor? fcolor = (data.NewValue < data.OldValue) ? new FColor?(text.changeColor) : this.OriginColor;
			text.SetColor(fcolor ?? FColor.FromHex("#ffffff"));
			return;
		}
		text.SetColor(FColor.FromHex("#ffffff"));
	}

	// Token: 0x04007025 RID: 28709
	private FColor? OriginColor;

	// Token: 0x020075E4 RID: 30180
	private enum EDefine
	{
		// Token: 0x0402647E RID: 156798
		TexIcon,
		// Token: 0x0402647F RID: 156799
		TxtName,
		// Token: 0x04026480 RID: 156800
		TxtOldValue,
		// Token: 0x04026481 RID: 156801
		PnlNew,
		// Token: 0x04026482 RID: 156802
		TxtNewValue,
		// Token: 0x04026483 RID: 156803
		SprLine
	}
}
