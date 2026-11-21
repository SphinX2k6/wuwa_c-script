using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC9 RID: 19401
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalChapterRestartChoiceItem : GridProxyAbstract<ICiacconaGalChapterRestartChoiceParam>
	{
		// Token: 0x060306E1 RID: 198369 RVA: 0x00D7EEE4 File Offset: 0x00D7D0E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060306E2 RID: 198370 RVA: 0x00D7EFAC File Offset: 0x00D7D1AC
		public override void Refresh(ICiacconaGalChapterRestartChoiceParam data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetSprite(1).SetUIActive(this.Data.Type == ECiacconaGalChapterRestartChoiceType.FromBranching);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.Desc, Array.Empty<object>());
		}

		// Token: 0x060306E3 RID: 198371 RVA: 0x00D7EFFC File Offset: 0x00D7D1FC
		private void OnClick()
		{
			if (this.Data.Type == ECiacconaGalChapterRestartChoiceType.FromBranching)
			{
				CiacconaGalController.Instance.OpenGalViewByStepId(this.Data.ChapterData.BranchingStepId, new int?(this.Data.ChapterData.Id), new EUiViewName?(EUiViewName.CiacconaGalChapterView));
				return;
			}
			CiacconaGalController.Instance.OpenGalViewByChapterId(this.Data.ChapterData.Id, new EUiViewName?(EUiViewName.CiacconaGalChapterView));
		}

		// Token: 0x04019A74 RID: 105076
		private ICiacconaGalChapterRestartChoiceParam Data;

		// Token: 0x0200A7D5 RID: 42965
		[NullableContext(0)]
		private class EChoiceItemComponentDefine
		{
			// Token: 0x04033D74 RID: 212340
			public const int BtnSelect = 0;

			// Token: 0x04033D75 RID: 212341
			public const int SpriteRecommend = 1;

			// Token: 0x04033D76 RID: 212342
			public const int TextDesc = 2;
		}
	}
}
