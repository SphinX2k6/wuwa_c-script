using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001D4F RID: 7503
[NullableContext(1)]
[Nullable(0)]
public class GamepadPsFeedbackData
{
	// Token: 0x0600E38F RID: 58255 RVA: 0x00357268 File Offset: 0x00355468
	public unsafe void AddFeedbackReason(EGamepadPsFeedbackReason reason, ETriggerEffectSide mode, string path)
	{
		GamepadPsFeedbackData.FeedbackInfo feedbackInfo;
		if (!this.FeedbackReasonSet.TryGetValue(reason, out feedbackInfo))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PsGamepadFeedback;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加Ps5手柄高级震动";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mode", mode.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("path", path);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			feedbackInfo = new GamepadPsFeedbackData.FeedbackInfo(reason, mode, path);
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PsGamepadFeedback;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "刷新Ps5手柄高级震动";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("reason", reason.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("mode", mode.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("path", path);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			feedbackInfo.Mode = mode;
			feedbackInfo.Path = path;
		}
		this.FeedbackReasonSet[reason] = feedbackInfo;
	}

	// Token: 0x0600E390 RID: 58256 RVA: 0x003573C0 File Offset: 0x003555C0
	public bool RemoveFeedbackReason(EGamepadPsFeedbackReason reason)
	{
		bool flag = this.FeedbackReasonSet.Remove(reason);
		if (flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PsGamepadFeedback;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除Ps5手柄高级震动";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason.ToString());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return flag;
	}

	// Token: 0x0600E391 RID: 58257 RVA: 0x00357414 File Offset: 0x00355614
	public void ClearFeedbackReason()
	{
		Log.Instance.Info(ELogModule.PsGamepadFeedback, ELogAuthor.XXJ, "清除Ps5手柄高级震动", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.FeedbackReasonSet.Clear();
	}

	// Token: 0x0600E392 RID: 58258 RVA: 0x0035744B File Offset: 0x0035564B
	[NullableContext(2)]
	public GamepadPsFeedbackData.FeedbackInfo GetLastFeedbackInfo()
	{
		if (this.FeedbackReasonSet.Count > 0)
		{
			return this.FeedbackReasonSet.Values.LastOrDefault<GamepadPsFeedbackData.FeedbackInfo>();
		}
		return null;
	}

	// Token: 0x0400690C RID: 26892
	private readonly SortedDictionary<EGamepadPsFeedbackReason, GamepadPsFeedbackData.FeedbackInfo> FeedbackReasonSet = new SortedDictionary<EGamepadPsFeedbackReason, GamepadPsFeedbackData.FeedbackInfo>();

	// Token: 0x02008365 RID: 33637
	[Nullable(0)]
	public class FeedbackInfo
	{
		// Token: 0x1700A068 RID: 41064
		// (get) Token: 0x0604A456 RID: 304214 RVA: 0x013550F6 File Offset: 0x013532F6
		// (set) Token: 0x0604A457 RID: 304215 RVA: 0x013550FE File Offset: 0x013532FE
		public EGamepadPsFeedbackReason Reason { get; set; }

		// Token: 0x1700A069 RID: 41065
		// (get) Token: 0x0604A458 RID: 304216 RVA: 0x01355107 File Offset: 0x01353307
		// (set) Token: 0x0604A459 RID: 304217 RVA: 0x0135510F File Offset: 0x0135330F
		public ETriggerEffectSide Mode { get; set; }

		// Token: 0x1700A06A RID: 41066
		// (get) Token: 0x0604A45A RID: 304218 RVA: 0x01355118 File Offset: 0x01353318
		// (set) Token: 0x0604A45B RID: 304219 RVA: 0x01355120 File Offset: 0x01353320
		public string Path { get; set; }

		// Token: 0x0604A45C RID: 304220 RVA: 0x01355129 File Offset: 0x01353329
		public FeedbackInfo(EGamepadPsFeedbackReason reason, ETriggerEffectSide mode, string path)
		{
			this.Reason = reason;
			this.Mode = mode;
			this.Path = path;
		}
	}
}
