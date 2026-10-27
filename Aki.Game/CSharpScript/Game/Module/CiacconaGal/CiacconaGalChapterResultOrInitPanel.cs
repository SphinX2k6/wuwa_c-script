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
	// Token: 0x02005BEC RID: 23532
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterResultOrInitPanel : UiPanelBase
	{
		// Token: 0x0603B7A3 RID: 243619 RVA: 0x00E2F237 File Offset: 0x00E2D437
		public CiacconaGalChapterResultOrInitPanel(CiacconaGalChapterData chapterData, Action onConfirm)
		{
			this.ChapterData = chapterData;
			this.OnConfirm = onConfirm;
		}

		// Token: 0x0603B7A4 RID: 243620 RVA: 0x00E2F250 File Offset: 0x00E2D450
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

		// Token: 0x0603B7A5 RID: 243621 RVA: 0x00E2F31C File Offset: 0x00E2D51C
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

		// Token: 0x0603B7A6 RID: 243622 RVA: 0x00E2F38A File Offset: 0x00E2D58A
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnChapterDataUpdate));
		}

		// Token: 0x0603B7A7 RID: 243623 RVA: 0x00E2F3A8 File Offset: 0x00E2D5A8
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnChapterDataUpdate));
		}

		// Token: 0x0603B7A8 RID: 243624 RVA: 0x00E2F3C8 File Offset: 0x00E2D5C8
		private void RefreshCommon()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.ChapterData.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChapterData.Desc, Array.Empty<object>());
		}

		// Token: 0x0603B7A9 RID: 243625 RVA: 0x00E2F418 File Offset: 0x00E2D618
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

		// Token: 0x0603B7AA RID: 243626 RVA: 0x00E2F498 File Offset: 0x00E2D698
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

		// Token: 0x0603B7AB RID: 243627 RVA: 0x00E2F501 File Offset: 0x00E2D701
		private CiacconaGalChapterSubEndingItem GetResultItem()
		{
			return new CiacconaGalChapterSubEndingItem();
		}

		// Token: 0x0603B7AC RID: 243628 RVA: 0x00E2F508 File Offset: 0x00E2D708
		private void OnChapterDataUpdate()
		{
			this.RefreshResults();
		}

		// Token: 0x0401EFC8 RID: 126920
		[Nullable(2)]
		private ButtonAndTextItem ConfirmBtn;

		// Token: 0x0401EFC9 RID: 126921
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaGalChapterSubEndingItem, CiacconaGalSubEndingData> LayoutResults;

		// Token: 0x0401EFCA RID: 126922
		private CiacconaGalChapterData ChapterData;

		// Token: 0x0401EFCB RID: 126923
		private Action OnConfirm;

		// Token: 0x0200BDD1 RID: 48593
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393C1 RID: 234433
			public const int TextTitle = 0;

			// Token: 0x040393C2 RID: 234434
			public const int TextDesc = 1;

			// Token: 0x040393C3 RID: 234435
			public const int LayoutResults = 2;

			// Token: 0x040393C4 RID: 234436
			public const int ItemResult = 3;

			// Token: 0x040393C5 RID: 234437
			public const int BtnConfirm = 4;
		}
	}
}
