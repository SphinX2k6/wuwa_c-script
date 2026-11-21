using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001211 RID: 4625
[NullableContext(1)]
[Nullable(0)]
public class GamepadPsFeedbackData
{
	// Token: 0x0600B7AC RID: 47020 RVA: 0x00362C98 File Offset: 0x00360E98
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

	// Token: 0x0600B7AD RID: 47021 RVA: 0x00362DF0 File Offset: 0x00360FF0
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

	// Token: 0x0600B7AE RID: 47022 RVA: 0x00362E44 File Offset: 0x00361044
	public void ClearFeedbackReason()
	{
		Log.Instance.Info(ELogModule.PsGamepadFeedback, ELogAuthor.XXJ, "清除Ps5手柄高级震动", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.FeedbackReasonSet.Clear();
	}

	// Token: 0x0600B7AF RID: 47023 RVA: 0x00362E7C File Offset: 0x0036107C
	[NullableContext(2)]
	public GamepadPsFeedbackData.FeedbackInfo GetLastFeedbackInfo()
	{
		if (this.FeedbackReasonSet.Count <= 0)
		{
			return null;
		}
		GamepadPsFeedbackData.FeedbackInfo result = null;
		using (SortedDictionary<EGamepadPsFeedbackReason, GamepadPsFeedbackData.FeedbackInfo>.ValueCollection.Enumerator enumerator = this.FeedbackReasonSet.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				result = enumerator.Current;
			}
		}
		return result;
	}

	// Token: 0x040069EB RID: 27115
	private readonly SortedDictionary<EGamepadPsFeedbackReason, GamepadPsFeedbackData.FeedbackInfo> FeedbackReasonSet = new SortedDictionary<EGamepadPsFeedbackReason, GamepadPsFeedbackData.FeedbackInfo>();

	// Token: 0x020074EE RID: 29934
	[Nullable(0)]
	public class FeedbackInfo
	{
		// Token: 0x17007806 RID: 30726
		// (get) Token: 0x0604085B RID: 264283 RVA: 0x012F8572 File Offset: 0x012F6772
		// (set) Token: 0x0604085C RID: 264284 RVA: 0x012F857A File Offset: 0x012F677A
		public EGamepadPsFeedbackReason Reason { get; set; }

		// Token: 0x17007807 RID: 30727
		// (get) Token: 0x0604085D RID: 264285 RVA: 0x012F8583 File Offset: 0x012F6783
		// (set) Token: 0x0604085E RID: 264286 RVA: 0x012F858B File Offset: 0x012F678B
		public ETriggerEffectSide Mode { get; set; }

		// Token: 0x17007808 RID: 30728
		// (get) Token: 0x0604085F RID: 264287 RVA: 0x012F8594 File Offset: 0x012F6794
		// (set) Token: 0x06040860 RID: 264288 RVA: 0x012F859C File Offset: 0x012F679C
		public string Path { get; set; }

		// Token: 0x06040861 RID: 264289 RVA: 0x012F85A5 File Offset: 0x012F67A5
		public FeedbackInfo(EGamepadPsFeedbackReason reason, ETriggerEffectSide mode, string path)
		{
			this.Reason = reason;
			this.Mode = mode;
			this.Path = path;
		}
	}
}
