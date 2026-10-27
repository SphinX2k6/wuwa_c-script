using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E76 RID: 24182
	public class AutoPilotStateView : UiPanelBase
	{
		// Token: 0x0603D80E RID: 251918 RVA: 0x00ED7B38 File Offset: 0x00ED5D38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D80F RID: 251919 RVA: 0x00ED7BC2 File Offset: 0x00ED5DC2
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(base.GetRootItem());
			this.SetState();
		}

		// Token: 0x0603D810 RID: 251920 RVA: 0x00ED7BDC File Offset: 0x00ED5DDC
		protected override void OnBeforeShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x0603D811 RID: 251921 RVA: 0x00ED7C08 File Offset: 0x00ED5E08
		private void SetState()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			AutoPilotDefine.EAutoPilotState? eautoPilotState = (instance != null) ? new AutoPilotDefine.EAutoPilotState?(instance.GetAutoPilotState()) : null;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(eautoPilotState.GetValueOrDefault() == AutoPilotDefine.EAutoPilotState.Dest);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(eautoPilotState.GetValueOrDefault() == AutoPilotDefine.EAutoPilotState.Loop);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), (eautoPilotState.GetValueOrDefault() == AutoPilotDefine.EAutoPilotState.Dest) ? AutoPilotDefine.EAutoPilotTextId.TextDestState : AutoPilotDefine.EAutoPilotTextId.TextLoopState, Array.Empty<object>());
		}

		// Token: 0x0603D812 RID: 251922 RVA: 0x00ED7C98 File Offset: 0x00ED5E98
		protected override UniTask OnBeforeHideAsync()
		{
			AutoPilotStateView.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<AutoPilotStateView.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D813 RID: 251923 RVA: 0x00ED7CDB File Offset: 0x00ED5EDB
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x04020190 RID: 131472
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C1F7 RID: 49655
		private enum EComponents
		{
			// Token: 0x0403A9EB RID: 240107
			DestState,
			// Token: 0x0403A9EC RID: 240108
			LoopState,
			// Token: 0x0403A9ED RID: 240109
			TextState
		}
	}
}
