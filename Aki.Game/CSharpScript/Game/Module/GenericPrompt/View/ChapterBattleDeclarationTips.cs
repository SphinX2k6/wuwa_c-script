using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004978 RID: 18808
	public class ChapterBattleDeclarationTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F284 RID: 193156 RVA: 0x00D24B98 File Offset: 0x00D22D98
		[NullableContext(1)]
		public ChapterBattleDeclarationTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F285 RID: 193157 RVA: 0x00D24BA1 File Offset: 0x00D22DA1
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUITexture)));
		}

		// Token: 0x0602F286 RID: 193158 RVA: 0x00D24BC4 File Offset: 0x00D22DC4
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

		// Token: 0x0602F287 RID: 193159 RVA: 0x00D24C18 File Offset: 0x00D22E18
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

		// Token: 0x0401907C RID: 102524
		private QuestChapter? CurrentChapterConf;

		// Token: 0x0200A621 RID: 42529
		private class EChapterBattleDeclarationTips
		{
			// Token: 0x04033623 RID: 210467
			public const int ChapterIcon = 2;
		}
	}
}
