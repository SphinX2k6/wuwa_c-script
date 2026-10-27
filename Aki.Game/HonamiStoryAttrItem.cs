using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E98 RID: 7832
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryAttrItem : GridProxyAbstract<IHonamiStoryAttrData>
{
	// Token: 0x0600F07F RID: 61567 RVA: 0x0039AE64 File Offset: 0x00399064
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

	// Token: 0x0600F080 RID: 61568 RVA: 0x0039AF00 File Offset: 0x00399100
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

	// Token: 0x04006F44 RID: 28484
	private FColor? OriginColor;

	// Token: 0x0200845F RID: 33887
	private enum EDefine
	{
		// Token: 0x0402B15A RID: 176474
		TexIcon,
		// Token: 0x0402B15B RID: 176475
		TxtName,
		// Token: 0x0402B15C RID: 176476
		TxtOldValue,
		// Token: 0x0402B15D RID: 176477
		PnlNew,
		// Token: 0x0402B15E RID: 176478
		TxtNewValue,
		// Token: 0x0402B15F RID: 176479
		SprLine
	}
}
