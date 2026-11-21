using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BCC RID: 19404
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterResultOrInitPanel : UiPanelBase
	{
		// Token: 0x060306EE RID: 198382 RVA: 0x00D7F547 File Offset: 0x00D7D747
		public CiacconaGalChapterResultOrInitPanel(CiacconaGalChapterData chapterData, Action onConfirm)
		{
			this.ChapterData = chapterData;
			this.OnConfirm = onConfirm;
		}

		// Token: 0x060306EF RID: 198383 RVA: 0x00D7F560 File Offset: 0x00D7D760
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060306F0 RID: 198384 RVA: 0x00D7F62C File Offset: 0x00D7D82C
		protected override void OnStart()
		{
			this.LayoutResults = new GenericLayout<CiacconaGalChapterSubEndingItem, CiacconaGalSubEndingData>(base.GetVerticalLayout(2), new Func<CiacconaGalChapterSubEndingItem>(this.GetResultItem), null, false, true);
			this.RefreshCommon();
			this.RefreshResults();
			this.RefreshBtn();
			if (this.ChapterData.IsFinished)
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaChapterRestart);
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnCiacconaChapterFirstStart);
		}

		// Token: 0x060306F1 RID: 198385 RVA: 0x00D7F69A File Offset: 0x00D7D89A
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnChapterDataUpdate));
		}

		// Token: 0x060306F2 RID: 198386 RVA: 0x00D7F6B8 File Offset: 0x00D7D8B8
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnChapterDataUpdate));
		}

		// Token: 0x060306F3 RID: 198387 RVA: 0x00D7F6D8 File Offset: 0x00D7D8D8
		private void RefreshCommon()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.ChapterData.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChapterData.Desc, Array.Empty<object>());
		}

		// Token: 0x060306F4 RID: 198388 RVA: 0x00D7F728 File Offset: 0x00D7D928
		private void RefreshResults()
		{
			base.GetVerticalLayout(2).SetActive(this.ChapterData.IsFinished, false);
			if (this.ChapterData.IsFinished)
			{
				List<CiacconaGalSubEndingData> list = new List<CiacconaGalSubEndingData>();
				foreach (int id in this.ChapterData.SubEndingIds)
				{
					CiacconaGalSubEndingData subEndingDataById = CiacconaGalModel.Instance.GetSubEndingDataById(id);
					if (subEndingDataById != null)
					{
						list.Add(subEndingDataById);
					}
				}
				this.LayoutResults.RefreshByData(list, null, false);
			}
		}

		// Token: 0x060306F5 RID: 198389 RVA: 0x00D7F7A8 File Offset: 0x00D7D9A8
		private void RefreshBtn()
		{
			this.ConfirmBtn = new ButtonAndTextItem(base.GetItem(4));
			if (this.ChapterData.IsFinished)
			{
				this.ConfirmBtn.RefreshTextNew("Xkjsx_Chapter_Replay", Array.Empty<object>());
			}
			else
			{
				this.ConfirmBtn.RefreshTextNew("Xkjsx_Chapter_First", Array.Empty<object>());
			}
			this.ConfirmBtn.BindCallback(this.OnConfirm);
		}

		// Token: 0x060306F6 RID: 198390 RVA: 0x00D7F811 File Offset: 0x00D7DA11
		private CiacconaGalChapterSubEndingItem GetResultItem()
		{
			return new CiacconaGalChapterSubEndingItem();
		}

		// Token: 0x060306F7 RID: 198391 RVA: 0x00D7F818 File Offset: 0x00D7DA18
		private void OnChapterDataUpdate()
		{
			this.RefreshResults();
		}

		// Token: 0x04019A79 RID: 105081
		[Nullable(2)]
		private ButtonAndTextItem ConfirmBtn;

		// Token: 0x04019A7A RID: 105082
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaGalChapterSubEndingItem, CiacconaGalSubEndingData> LayoutResults;

		// Token: 0x04019A7B RID: 105083
		private CiacconaGalChapterData ChapterData;

		// Token: 0x04019A7C RID: 105084
		private Action OnConfirm;

		// Token: 0x0200A7D9 RID: 42969
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D84 RID: 212356
			public const int TextTitle = 0;

			// Token: 0x04033D85 RID: 212357
			public const int TextDesc = 1;

			// Token: 0x04033D86 RID: 212358
			public const int LayoutResults = 2;

			// Token: 0x04033D87 RID: 212359
			public const int ItemResult = 3;

			// Token: 0x04033D88 RID: 212360
			public const int BtnConfirm = 4;
		}
	}
}
