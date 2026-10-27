using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B11 RID: 11025
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntryItem : GridProxyAbstract<IEntryItemData>
{
	// Token: 0x06016E9D RID: 93853 RVA: 0x005D07A4 File Offset: 0x005CE9A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06016E9E RID: 93854 RVA: 0x005D0800 File Offset: 0x005CEA00
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(2),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.SurvivorsRogue
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x06016E9F RID: 93855 RVA: 0x005D083B File Offset: 0x005CEA3B
	public override void Refresh(IEntryItemData data, bool isSelected, int gridIndex)
	{
		this.SetTextById(data.Text, data.Args);
		this.SetColorFromHex(data.Color);
	}

	// Token: 0x06016EA0 RID: 93856 RVA: 0x005D085C File Offset: 0x005CEA5C
	public void SetTextById(string text, string[] args)
	{
		List<object> list = new List<object>();
		foreach (string item in args)
		{
			list.Add(item);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), text, list.ToArray());
	}

	// Token: 0x06016EA1 RID: 93857 RVA: 0x005D08A4 File Offset: 0x005CEAA4
	public void SetColorFromHex(string hex)
	{
		FColor color = FColor.FromHex(hex);
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetColor(color);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetColor(color);
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetColor(color);
	}

	// Token: 0x02009116 RID: 37142
	[NullableContext(0)]
	private static class EEntry
	{
		// Token: 0x0402EFDF RID: 192479
		public const int SprBg = 0;

		// Token: 0x0402EFE0 RID: 192480
		public const int SprPoint = 1;

		// Token: 0x0402EFE1 RID: 192481
		public const int TxtContent = 2;
	}
}
