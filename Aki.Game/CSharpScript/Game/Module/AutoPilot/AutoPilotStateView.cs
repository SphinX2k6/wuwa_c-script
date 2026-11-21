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
	// Token: 0x02004E5B RID: 20059
	public class AutoPilotStateView : UiPanelBase
	{
		// Token: 0x0603279E RID: 206750 RVA: 0x00E290C4 File Offset: 0x00E272C4
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

		// Token: 0x0603279F RID: 206751 RVA: 0x00E2914E File Offset: 0x00E2734E
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(base.GetRootItem());
			this.SetState();
		}

		// Token: 0x060327A0 RID: 206752 RVA: 0x00E29168 File Offset: 0x00E27368
		protected override void OnBeforeShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x060327A1 RID: 206753 RVA: 0x00E29194 File Offset: 0x00E27394
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

		// Token: 0x060327A2 RID: 206754 RVA: 0x00E29224 File Offset: 0x00E27424
		protected override UniTask OnBeforeHideAsync()
		{
			AutoPilotStateView.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<AutoPilotStateView.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060327A3 RID: 206755 RVA: 0x00E29267 File Offset: 0x00E27467
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x0401AC57 RID: 109655
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200AC06 RID: 44038
		private enum EComponents
		{
			// Token: 0x040353DD RID: 218077
			DestState,
			// Token: 0x040353DE RID: 218078
			LoopState,
			// Token: 0x040353DF RID: 218079
			TextState
		}
	}
}
