using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge
{
	// Token: 0x020054F5 RID: 21749
	public class ActivityFlagChallengeData : ActivityBaseData
	{
		// Token: 0x06035E68 RID: 220776 RVA: 0x00F0E2D4 File Offset: 0x00F0C4D4
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

		// Token: 0x06035E69 RID: 220777 RVA: 0x00F0E370 File Offset: 0x00F0C570
		public override bool GetExDataRedPointShowState()
		{
			return FlagChallengeModel.Instance.CheckActivityTabRedoDotState(base.Id);
		}

		// Token: 0x06035E6A RID: 220778 RVA: 0x00F0E384 File Offset: 0x00F0C584
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
