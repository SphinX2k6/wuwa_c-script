using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge
{
	// Token: 0x02006577 RID: 25975
	public class ActivityFlagChallengeData : ActivityBaseData
	{
		// Token: 0x060411A3 RID: 266659 RVA: 0x00FC72F0 File Offset: 0x00FC54F0
		[NullableContext(1)]
		protected unsafe override void PhraseEx(ActivityData data)
		{
			FlagChallengeActivityInfo flagChallengeActivityInfo = data.FlagChallengeActivityInfo;
			if (flagChallengeActivityInfo == null)
			{
				return;
			}
			int id = data.Id;
			FlagChallengeModel.Instance.ParseActivityData(id, flagChallengeActivityInfo);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FlagChallenge;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "Activity Data PhraseEx";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", data.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("data", flagChallengeActivityInfo);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060411A4 RID: 266660 RVA: 0x00FC738C File Offset: 0x00FC558C
		public override bool GetExDataRedPointShowState()
		{
			return FlagChallengeModel.Instance.CheckActivityTabRedoDotState(base.Id);
		}

		// Token: 0x060411A5 RID: 266661 RVA: 0x00FC73A0 File Offset: 0x00FC55A0
		protected override bool GetExDataFinishShowState()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(base.Id);
			return flagChallengeData.IsAllTaskReceived() && flagChallengeData.IsAllLevelPass();
		}
	}
}
