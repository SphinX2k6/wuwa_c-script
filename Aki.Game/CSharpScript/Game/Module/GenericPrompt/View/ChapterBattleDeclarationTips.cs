using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200599F RID: 22943
	public class ChapterBattleDeclarationTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A35E RID: 238430 RVA: 0x00DD5708 File Offset: 0x00DD3908
		[NullableContext(1)]
		public ChapterBattleDeclarationTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A35F RID: 238431 RVA: 0x00DD5711 File Offset: 0x00DD3911
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUITexture)));
		}

		// Token: 0x0603A360 RID: 238432 RVA: 0x00DD5734 File Offset: 0x00DD3934
		private void FetchCurrentChapterConf(int chapterId)
		{
			this.CurrentChapterConf = ConfigQuestChapterById.GetConfig(chapterId, true);
			if (this.CurrentChapterConf == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.JLY;
				string message = "策划的章节Id配错了！！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("错误的章节Id", chapterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0603A361 RID: 238433 RVA: 0x00DD5788 File Offset: 0x00DD3988
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			int chapterId = 0;
			if (param.Count > 0)
			{
				string text = param[0] as string;
				if (text != null)
				{
					int.TryParse(text, out chapterId);
				}
				object obj = param[0];
				if (obj is int)
				{
					int num = (int)obj;
					chapterId = num;
				}
			}
			this.FetchCurrentChapterConf(chapterId);
			if (this.CurrentChapterConf != null)
			{
				base.SetTextureByPath(this.CurrentChapterConf.Value.ChapterIcon, base.GetTexture(2), null, null);
			}
		}

		// Token: 0x0401E5DE RID: 124382
		private QuestChapter? CurrentChapterConf;

		// Token: 0x0200BC16 RID: 48150
		private class EChapterBattleDeclarationTips
		{
			// Token: 0x04038C54 RID: 232532
			public const int ChapterIcon = 2;
		}
	}
}
