using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.QuestNew.Model;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02003EEB RID: 16107
	[NullableContext(2)]
	[Nullable(0)]
	public class RecallQuestTrackProxy : IQuestTrackSlot
	{
		// Token: 0x06028D96 RID: 167318 RVA: 0x00B7685C File Offset: 0x00B74A5C
		public global::Quest GetTrack()
		{
			return this.RecallTrackQuest;
		}

		// Token: 0x06028D97 RID: 167319 RVA: 0x00B76864 File Offset: 0x00B74A64
		public void SetTrack(global::Quest quest)
		{
			this.RecallTrackQuest = quest;
		}

		// Token: 0x06028D98 RID: 167320 RVA: 0x00B76870 File Offset: 0x00B74A70
		[NullableContext(1)]
		public unsafe bool Accept(global::Quest quest)
		{
			if (quest.Type != EQuest.Recall)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "[Recall] 拒收非 Recall 任务的追踪请求";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("任务Id", quest.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", quest.Type);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return true;
		}

		// Token: 0x0401636C RID: 90988
		private global::Quest RecallTrackQuest;
	}
}
