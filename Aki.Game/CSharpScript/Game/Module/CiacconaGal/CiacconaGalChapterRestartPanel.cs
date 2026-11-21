using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BCA RID: 19402
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterRestartPanel : UiPanelBase
	{
		// Token: 0x060306E5 RID: 198373 RVA: 0x00D7F07D File Offset: 0x00D7D27D
		public CiacconaGalChapterRestartPanel(CiacconaGalChapterData chapterData)
		{
			this.ChapterData = chapterData;
		}

		// Token: 0x060306E6 RID: 198374 RVA: 0x00D7F08C File Offset: 0x00D7D28C
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

		// Token: 0x060306E7 RID: 198375 RVA: 0x00D7F118 File Offset: 0x00D7D318
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

		// Token: 0x060306E8 RID: 198376 RVA: 0x00D7F1F8 File Offset: 0x00D7D3F8
		private CiacconaGalChapterRestartChoiceItem GetChoiceGrid()
		{
			return new CiacconaGalChapterRestartChoiceItem();
		}

		// Token: 0x04019A75 RID: 105077
		private GenericLayout<CiacconaGalChapterRestartChoiceItem, ICiacconaGalChapterRestartChoiceParam> Layout;

		// Token: 0x04019A76 RID: 105078
		private CiacconaGalChapterData ChapterData;

		// Token: 0x0200A7D6 RID: 42966
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D77 RID: 212343
			public const int TextTitle = 0;

			// Token: 0x04033D78 RID: 212344
			public const int LayoutChoices = 1;

			// Token: 0x04033D79 RID: 212345
			public const int ItemChoice = 2;
		}
	}
}
