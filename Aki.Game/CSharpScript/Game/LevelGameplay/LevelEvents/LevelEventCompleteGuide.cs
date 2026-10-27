using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B0D RID: 27405
	public class LevelEventCompleteGuide : LevelEventBase
	{
		// Token: 0x06044080 RID: 278656 RVA: 0x010B86FC File Offset: 0x010B68FC
		public LevelEventCompleteGuide(int id) : base(id)
		{
		}

		// Token: 0x06044081 RID: 278657 RVA: 0x010B8708 File Offset: 0x010B6908
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, [Nullable(2)] GeneralContext context = null, int? actionId = null)
		{
			CompleteGuide completeGuide = inParams as CompleteGuide;
			if (completeGuide == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "行为缺少参数";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionIndex", this.ActionIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, false, true);
				return;
			}
			this.FinishGuide(completeGuide.GuideId);
		}

		// Token: 0x06044082 RID: 278658 RVA: 0x010B8768 File Offset: 0x010B6968
		private void FinishGuide(int groupId)
		{
			if (!GuideController.Instance.TryFinishGuide(groupId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "行为完成的引导组执行完毕 [执行前已经完成]";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", groupId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(true, false, true);
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TZJ;
			string message2 = "行为完成的引导组执行完毕 [成功完成]";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("组Id", groupId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.GuideGroupId = groupId;
			EventSystem.Instance.Add(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideFinish));
			EventSystem.Instance.Add(EEventName.GuideGroupBreak, new Action<int>(this.OnGuideFinish));
			EventSystem.Instance.Add(EEventName.GuideGroupRest, new Action<int>(this.OnGuideFinish));
		}

		// Token: 0x06044083 RID: 278659 RVA: 0x010B8840 File Offset: 0x010B6A40
		private void OnGuideFinish(int groupId)
		{
			if (groupId != this.GuideGroupId)
			{
				return;
			}
			this.GuideGroupId = 0;
			EventSystem.Instance.Remove(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideFinish));
			EventSystem.Instance.Remove(EEventName.GuideGroupBreak, new Action<int>(this.OnGuideFinish));
			EventSystem.Instance.Remove(EEventName.GuideGroupRest, new Action<int>(this.OnGuideFinish));
			base.FinishExecute(true, false, true);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "行为完成的引导组执行完毕[成功完成]";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", groupId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x040238D5 RID: 145621
		private int GuideGroupId;
	}
}
