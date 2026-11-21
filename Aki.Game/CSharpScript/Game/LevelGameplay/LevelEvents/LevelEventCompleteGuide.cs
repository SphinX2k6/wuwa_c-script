using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C85 RID: 23685
	public class LevelEventCompleteGuide : LevelEventBase
	{
		// Token: 0x0603A1D2 RID: 238034 RVA: 0x01061F88 File Offset: 0x01060188
		public LevelEventCompleteGuide(int id) : base(id)
		{
		}

		// Token: 0x0603A1D3 RID: 238035 RVA: 0x01061F94 File Offset: 0x01060194
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

		// Token: 0x0603A1D4 RID: 238036 RVA: 0x01061FF4 File Offset: 0x010601F4
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

		// Token: 0x0603A1D5 RID: 238037 RVA: 0x010620CC File Offset: 0x010602CC
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

		// Token: 0x0401EB77 RID: 125815
		private int GuideGroupId;
	}
}
