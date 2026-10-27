using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE9 RID: 23529
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalChapterRestartChoiceItem : GridProxyAbstract<ICiacconaGalChapterRestartChoiceParam>
	{
		// Token: 0x0603B796 RID: 243606 RVA: 0x00E2EBD4 File Offset: 0x00E2CDD4
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

		// Token: 0x0603B797 RID: 243607 RVA: 0x00E2EC9C File Offset: 0x00E2CE9C
		public override void Refresh(ICiacconaGalChapterRestartChoiceParam data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetSprite(1).SetUIActive(this.Data.Type == ECiacconaGalChapterRestartChoiceType.FromBranching);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.Desc, Array.Empty<object>());
		}

		// Token: 0x0603B798 RID: 243608 RVA: 0x00E2ECEC File Offset: 0x00E2CEEC
		private void OnClick()
		{
			if (this.Data.Type == ECiacconaGalChapterRestartChoiceType.FromBranching)
			{
				CiacconaGalController.Instance.OpenGalViewByStepId(this.Data.ChapterData.BranchingStepId, new int?(this.Data.ChapterData.Id), new EUiViewName?(EUiViewName.CiacconaGalChapterView));
				return;
			}
			CiacconaGalController.Instance.OpenGalViewByChapterId(this.Data.ChapterData.Id, new EUiViewName?(EUiViewName.CiacconaGalChapterView));
		}

		// Token: 0x0401EFC3 RID: 126915
		private ICiacconaGalChapterRestartChoiceParam Data;

		// Token: 0x0200BDCD RID: 48589
		[NullableContext(0)]
		private class EChoiceItemComponentDefine
		{
			// Token: 0x040393B1 RID: 234417
			public const int BtnSelect = 0;

			// Token: 0x040393B2 RID: 234418
			public const int SpriteRecommend = 1;

			// Token: 0x040393B3 RID: 234419
			public const int TextDesc = 2;
		}
	}
}
