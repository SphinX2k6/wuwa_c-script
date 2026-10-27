using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.QuestNew.Model;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02004F22 RID: 20258
	[NullableContext(2)]
	[Nullable(0)]
	public class RecallQuestTrackProxy : IQuestTrackSlot
	{
		// Token: 0x06033F28 RID: 212776 RVA: 0x00C2D0A0 File Offset: 0x00C2B2A0
		public global::Quest GetTrack()
		{
			return this.RecallTrackQuest;
		}

		// Token: 0x06033F29 RID: 212777 RVA: 0x00C2D0A8 File Offset: 0x00C2B2A8
		public void SetTrack(global::Quest quest)
		{
			this.RecallTrackQuest = quest;
		}

		// Token: 0x06033F2A RID: 212778 RVA: 0x00C2D0B4 File Offset: 0x00C2B2B4
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

		// Token: 0x0401B997 RID: 113047
		private global::Quest RecallTrackQuest;
	}
}
