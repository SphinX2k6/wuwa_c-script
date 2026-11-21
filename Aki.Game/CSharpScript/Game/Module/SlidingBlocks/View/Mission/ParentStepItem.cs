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
	// Token: 0x02003B44 RID: 15172
	[NullableContext(1)]
	[Nullable(0)]
	public class ParentStepItem : UiPanelBase
	{
		// Token: 0x06026FFE RID: 159742 RVA: 0x00AEB3FC File Offset: 0x00AE95FC
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

		// Token: 0x06026FFF RID: 159743 RVA: 0x00AEB4A8 File Offset: 0x00AE96A8
		protected override UniTask OnBeforeStartAsync()
		{
			ParentStepItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ParentStepItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027000 RID: 159744 RVA: 0x00AEB4EC File Offset: 0x00AE96EC
		public void OnTick(float delta)
		{
			foreach (ChildStepItem childStepItem in this.ChildSteps)
			{
				childStepItem.OnTick(delta);
			}
		}

		// Token: 0x06027001 RID: 159745 RVA: 0x00AEB540 File Offset: 0x00AE9740
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

		// Token: 0x06027002 RID: 159746 RVA: 0x00AEB58C File Offset: 0x00AE978C
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

		// Token: 0x040154C0 RID: 87232
		[Nullable(2)]
		protected LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x040154C1 RID: 87233
		private readonly List<ChildStepItem> ChildSteps = new List<ChildStepItem>();

		// Token: 0x020097DB RID: 38875
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x0402F5F4 RID: 194036
			StepDescribeText,
			// Token: 0x0402F5F5 RID: 194037
			StepDistanceText,
			// Token: 0x0402F5F6 RID: 194038
			ChildStep,
			// Token: 0x0402F5F7 RID: 194039
			TitleNode
		}
	}
}
