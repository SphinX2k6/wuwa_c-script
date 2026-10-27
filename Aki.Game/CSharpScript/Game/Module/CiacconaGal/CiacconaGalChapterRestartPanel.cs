using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BEA RID: 23530
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterRestartPanel : UiPanelBase
	{
		// Token: 0x0603B79A RID: 243610 RVA: 0x00E2ED6D File Offset: 0x00E2CF6D
		public CiacconaGalChapterRestartPanel(CiacconaGalChapterData chapterData)
		{
			this.ChapterData = chapterData;
		}

		// Token: 0x0603B79B RID: 243611 RVA: 0x00E2ED7C File Offset: 0x00E2CF7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B79C RID: 243612 RVA: 0x00E2EE08 File Offset: 0x00E2D008
		protected unsafe override void OnStart()
		{
			this.Layout = new GenericLayout<CiacconaGalChapterRestartChoiceItem, ICiacconaGalChapterRestartChoiceParam>(base.GetVerticalLayout(1), new Func<CiacconaGalChapterRestartChoiceItem>(this.GetChoiceGrid), null, false, true);
			CiacconaGalChapterRestartChoiceParam ciacconaGalChapterRestartChoiceParam = new CiacconaGalChapterRestartChoiceParam
			{
				Type = ECiacconaGalChapterRestartChoiceType.FromBeginning,
				Desc = "Xkjsx_Chapter_Start",
				ChapterData = this.ChapterData
			};
			CiacconaGalChapterRestartChoiceParam ciacconaGalChapterRestartChoiceParam2 = new CiacconaGalChapterRestartChoiceParam
			{
				Type = ECiacconaGalChapterRestartChoiceType.FromBranching,
				Desc = "Xkjsx_Chapter_Begin",
				ChapterData = this.ChapterData
			};
			int num = 2;
			List<ICiacconaGalChapterRestartChoiceParam> list = new List<ICiacconaGalChapterRestartChoiceParam>(num);
			CollectionsMarshal.SetCount<ICiacconaGalChapterRestartChoiceParam>(list, num);
			Span<ICiacconaGalChapterRestartChoiceParam> span = CollectionsMarshal.AsSpan<ICiacconaGalChapterRestartChoiceParam>(list);
			int num2 = 0;
			*span[num2] = ciacconaGalChapterRestartChoiceParam2;
			num2++;
			*span[num2] = ciacconaGalChapterRestartChoiceParam;
			List<ICiacconaGalChapterRestartChoiceParam> data = list;
			this.Layout.RefreshByData(data, null, false);
			string textId = CiacconaGalTextConfig.GetTextId(1002);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0603B79D RID: 243613 RVA: 0x00E2EEE8 File Offset: 0x00E2D0E8
		private CiacconaGalChapterRestartChoiceItem GetChoiceGrid()
		{
			return new CiacconaGalChapterRestartChoiceItem();
		}

		// Token: 0x0401EFC4 RID: 126916
		private GenericLayout<CiacconaGalChapterRestartChoiceItem, ICiacconaGalChapterRestartChoiceParam> Layout;

		// Token: 0x0401EFC5 RID: 126917
		private CiacconaGalChapterData ChapterData;

		// Token: 0x0200BDCE RID: 48590
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393B4 RID: 234420
			public const int TextTitle = 0;

			// Token: 0x040393B5 RID: 234421
			public const int LayoutChoices = 1;

			// Token: 0x040393B6 RID: 234422
			public const int ItemChoice = 2;
		}
	}
}
