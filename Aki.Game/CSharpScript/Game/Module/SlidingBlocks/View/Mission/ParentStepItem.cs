using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Mission
{
	// Token: 0x02004B9A RID: 19354
	[NullableContext(1)]
	[Nullable(0)]
	public class ParentStepItem : UiPanelBase
	{
		// Token: 0x0603226E RID: 205422 RVA: 0x00BA72B0 File Offset: 0x00BA54B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603226F RID: 205423 RVA: 0x00BA735C File Offset: 0x00BA555C
		protected override UniTask OnBeforeStartAsync()
		{
			ParentStepItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ParentStepItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032270 RID: 205424 RVA: 0x00BA73A0 File Offset: 0x00BA55A0
		public void OnTick(float delta)
		{
			foreach (ChildStepItem childStepItem in this.ChildSteps)
			{
				childStepItem.OnTick(delta);
			}
		}

		// Token: 0x06032271 RID: 205425 RVA: 0x00BA73F4 File Offset: 0x00BA55F4
		private UniTask SetShowInfoOnNormalMode(SlidingBlocksGameServerData serverData)
		{
			ParentStepItem.<SetShowInfoOnNormalMode>d__6 <SetShowInfoOnNormalMode>d__;
			<SetShowInfoOnNormalMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetShowInfoOnNormalMode>d__.<>4__this = this;
			<SetShowInfoOnNormalMode>d__.serverData = serverData;
			<SetShowInfoOnNormalMode>d__.<>1__state = -1;
			<SetShowInfoOnNormalMode>d__.<>t__builder.Start<ParentStepItem.<SetShowInfoOnNormalMode>d__6>(ref <SetShowInfoOnNormalMode>d__);
			return <SetShowInfoOnNormalMode>d__.<>t__builder.Task;
		}

		// Token: 0x06032272 RID: 205426 RVA: 0x00BA7440 File Offset: 0x00BA5640
		private UniTask SetShowInfoOnEndlessMode(SlidingBlocksGameData gameData, SlidingBlocksGameServerData serverData)
		{
			ParentStepItem.<SetShowInfoOnEndlessMode>d__7 <SetShowInfoOnEndlessMode>d__;
			<SetShowInfoOnEndlessMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetShowInfoOnEndlessMode>d__.<>4__this = this;
			<SetShowInfoOnEndlessMode>d__.gameData = gameData;
			<SetShowInfoOnEndlessMode>d__.serverData = serverData;
			<SetShowInfoOnEndlessMode>d__.<>1__state = -1;
			<SetShowInfoOnEndlessMode>d__.<>t__builder.Start<ParentStepItem.<SetShowInfoOnEndlessMode>d__7>(ref <SetShowInfoOnEndlessMode>d__);
			return <SetShowInfoOnEndlessMode>d__.<>t__builder.Task;
		}

		// Token: 0x0401AB6C RID: 109420
		[Nullable(2)]
		protected LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x0401AB6D RID: 109421
		private readonly List<ChildStepItem> ChildSteps = new List<ChildStepItem>();

		// Token: 0x0200ADBC RID: 44476
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034C4D RID: 216141
			StepDescribeText,
			// Token: 0x04034C4E RID: 216142
			StepDistanceText,
			// Token: 0x04034C4F RID: 216143
			ChildStep,
			// Token: 0x04034C50 RID: 216144
			TitleNode
		}
	}
}
