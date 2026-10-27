using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BED RID: 23533
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalChapterView : UiViewBase
	{
		// Token: 0x0603B7AD RID: 243629 RVA: 0x00E2F510 File Offset: 0x00E2D710
		[NullableContext(1)]
		public CiacconaGalChapterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B7AE RID: 243630 RVA: 0x00E2F51C File Offset: 0x00E2D71C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B7AF RID: 243631 RVA: 0x00E2F5E8 File Offset: 0x00E2D7E8
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalChapterView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalChapterView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7B0 RID: 243632 RVA: 0x00E2F62C File Offset: 0x00E2D82C
		private void OnResultOrInitPanelBtnClick()
		{
			if (!this.ChapterData.IsFinished)
			{
				CiacconaGalController.Instance.OpenGalViewByChapterId(this.ChapterData.Id, new EUiViewName?(EUiViewName.CiacconaGalChapterView));
				return;
			}
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x0401EFCC RID: 126924
		private CiacconaGalChapterData ChapterData;

		// Token: 0x0401EFCD RID: 126925
		private CiacconaGalChapterResultOrInitPanel ResultOrInitPanel;

		// Token: 0x0401EFCE RID: 126926
		private CiacconaGalChapterRestartPanel RestartPanel;

		// Token: 0x0401EFCF RID: 126927
		private PopupCaptionItem Caption;

		// Token: 0x0401EFD0 RID: 126928
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x0401EFD1 RID: 126929
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDD2 RID: 48594
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393C6 RID: 234438
			public const int BtnMask = 0;

			// Token: 0x040393C7 RID: 234439
			public const int ItemCaption = 1;

			// Token: 0x040393C8 RID: 234440
			public const int TextureChapterBg = 2;

			// Token: 0x040393C9 RID: 234441
			public const int ItemResultOrInitPanel = 3;

			// Token: 0x040393CA RID: 234442
			public const int ItemRestartPanel = 4;
		}
	}
}
