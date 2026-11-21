using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200208D RID: 8333
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntryItem : GridProxyAbstract<IEntryItemData>
{
	// Token: 0x060148CE RID: 84174 RVA: 0x005FD324 File Offset: 0x005FB524
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060148CF RID: 84175 RVA: 0x005FD380 File Offset: 0x005FB580
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

	// Token: 0x060148D0 RID: 84176 RVA: 0x005FD3BB File Offset: 0x005FB5BB
	public override void Refresh(IEntryItemData data, bool isSelected, int gridIndex)
	{
		this.SetTextById(data.Text, data.Args);
		this.SetColorFromHex(data.Color);
	}

	// Token: 0x060148D1 RID: 84177 RVA: 0x005FD3DC File Offset: 0x005FB5DC
	public void SetTextById(string text, string[] args)
	{
		List<object> list = new List<object>();
		foreach (string item in args)
		{
			list.Add(item);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), text, list.ToArray());
	}

	// Token: 0x060148D2 RID: 84178 RVA: 0x005FD424 File Offset: 0x005FB624
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

	// Token: 0x02008359 RID: 33625
	[NullableContext(0)]
	private static class EEntry
	{
		// Token: 0x0402A6E4 RID: 173796
		public const int SprBg = 0;

		// Token: 0x0402A6E5 RID: 173797
		public const int SprPoint = 1;

		// Token: 0x0402A6E6 RID: 173798
		public const int TxtContent = 2;
	}
}
