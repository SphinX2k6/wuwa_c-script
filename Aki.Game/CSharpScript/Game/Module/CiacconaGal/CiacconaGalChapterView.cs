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
	// Token: 0x02004BCD RID: 19405
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalChapterView : UiViewBase
	{
		// Token: 0x060306F8 RID: 198392 RVA: 0x00D7F820 File Offset: 0x00D7DA20
		[NullableContext(1)]
		public CiacconaGalChapterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060306F9 RID: 198393 RVA: 0x00D7F82C File Offset: 0x00D7DA2C
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

		// Token: 0x060306FA RID: 198394 RVA: 0x00D7F8F8 File Offset: 0x00D7DAF8
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalChapterView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalChapterView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060306FB RID: 198395 RVA: 0x00D7F93C File Offset: 0x00D7DB3C
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

		// Token: 0x04019A7D RID: 105085
		private CiacconaGalChapterData ChapterData;

		// Token: 0x04019A7E RID: 105086
		private CiacconaGalChapterResultOrInitPanel ResultOrInitPanel;

		// Token: 0x04019A7F RID: 105087
		private CiacconaGalChapterRestartPanel RestartPanel;

		// Token: 0x04019A80 RID: 105088
		private PopupCaptionItem Caption;

		// Token: 0x04019A81 RID: 105089
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x04019A82 RID: 105090
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7DA RID: 42970
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D89 RID: 212361
			public const int BtnMask = 0;

			// Token: 0x04033D8A RID: 212362
			public const int ItemCaption = 1;

			// Token: 0x04033D8B RID: 212363
			public const int TextureChapterBg = 2;

			// Token: 0x04033D8C RID: 212364
			public const int ItemResultOrInitPanel = 3;

			// Token: 0x04033D8D RID: 212365
			public const int ItemRestartPanel = 4;
		}
	}
}
