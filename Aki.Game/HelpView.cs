using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001316 RID: 4886
public class HelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x0600C02F RID: 49199 RVA: 0x0038C5AD File Offset: 0x0038A7AD
	[NullableContext(1)]
	public HelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C030 RID: 49200 RVA: 0x0038C5C4 File Offset: 0x0038A7C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C031 RID: 49201 RVA: 0x0038C64E File Offset: 0x0038A84E
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		this.Init();
	}

	// Token: 0x0600C032 RID: 49202 RVA: 0x0038C664 File Offset: 0x0038A864
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		if (param != null)
		{
			IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId((int)param);
			if (helpContentInfoByGroupId != null && helpContentInfoByGroupId.Count > 0)
			{
				return HelpStylizeDefine.helpStylizeType2PopFrameType[(EHelpStylizeType)helpContentInfoByGroupId[0].Style];
			}
		}
		return null;
	}

	// Token: 0x0600C033 RID: 49203 RVA: 0x0038C6B4 File Offset: 0x0038A8B4
	private void Init()
	{
		int groupId = (int)this.OpenParam;
		IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(groupId);
		if (helpContentInfoByGroupId != null && helpContentInfoByGroupId.Count > 0)
		{
			base.GetText(0).ShowTextNew(helpContentInfoByGroupId[0].Title);
			int count = helpContentInfoByGroupId.Count;
			foreach (Paragraph paragraph in this.Paragraphs)
			{
				paragraph.SetActive(false);
			}
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(1);
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				Paragraph paragraph2;
				if (num > this.Paragraphs.Count - 1)
				{
					paragraph2 = new Paragraph(LguiUtil.Instance.CopyItem(item, item2).GetOwner());
					this.Paragraphs.Add(paragraph2);
				}
				else
				{
					paragraph2 = this.Paragraphs[num];
				}
				paragraph2.Refresh(helpContentInfoByGroupId[i]);
				paragraph2.SetActive(true);
				num++;
			}
		}
	}

	// Token: 0x04006E57 RID: 28247
	[Nullable(1)]
	private readonly List<Paragraph> Paragraphs = new List<Paragraph>();

	// Token: 0x0200758C RID: 30092
	private enum EHelpViewComponents
	{
		// Token: 0x040262BE RID: 156350
		Title,
		// Token: 0x040262BF RID: 156351
		Content,
		// Token: 0x040262C0 RID: 156352
		ParagraphItem
	}
}
