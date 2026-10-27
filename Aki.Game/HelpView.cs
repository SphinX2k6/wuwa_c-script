using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E54 RID: 7764
public class HelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x0600EC10 RID: 60432 RVA: 0x003808FF File Offset: 0x0037EAFF
	[NullableContext(1)]
	public HelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC11 RID: 60433 RVA: 0x00380914 File Offset: 0x0037EB14
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

	// Token: 0x0600EC12 RID: 60434 RVA: 0x0038099E File Offset: 0x0037EB9E
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		this.Init();
	}

	// Token: 0x0600EC13 RID: 60435 RVA: 0x003809B4 File Offset: 0x0037EBB4
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

	// Token: 0x0600EC14 RID: 60436 RVA: 0x00380A04 File Offset: 0x0037EC04
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

	// Token: 0x04006D76 RID: 28022
	[Nullable(1)]
	private readonly List<Paragraph> Paragraphs = new List<Paragraph>();

	// Token: 0x02008407 RID: 33799
	private enum EHelpViewComponents
	{
		// Token: 0x0402AF9A RID: 176026
		Title,
		// Token: 0x0402AF9B RID: 176027
		Content,
		// Token: 0x0402AF9C RID: 176028
		ParagraphItem
	}
}
