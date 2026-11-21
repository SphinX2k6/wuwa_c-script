using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x0200429A RID: 17050
	public class PhantomArenaHandAreaItem : UiPanelBase
	{
		// Token: 0x0602B297 RID: 176791 RVA: 0x00C21C90 File Offset: 0x00C1FE90
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0602B298 RID: 176792 RVA: 0x00C21CA3 File Offset: 0x00C1FEA3
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602B299 RID: 176793 RVA: 0x00C21CB0 File Offset: 0x00C1FEB0
		public UniTask PlayMoveOutSequence()
		{
			PhantomArenaHandAreaItem.<PlayMoveOutSequence>d__3 <PlayMoveOutSequence>d__;
			<PlayMoveOutSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveOutSequence>d__.<>4__this = this;
			<PlayMoveOutSequence>d__.<>1__state = -1;
			<PlayMoveOutSequence>d__.<>t__builder.Start<PhantomArenaHandAreaItem.<PlayMoveOutSequence>d__3>(ref <PlayMoveOutSequence>d__);
			return <PlayMoveOutSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602B29A RID: 176794 RVA: 0x00C21CF4 File Offset: 0x00C1FEF4
		public UniTask PlayMoveInSequence()
		{
			PhantomArenaHandAreaItem.<PlayMoveInSequence>d__4 <PlayMoveInSequence>d__;
			<PlayMoveInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveInSequence>d__.<>4__this = this;
			<PlayMoveInSequence>d__.<>1__state = -1;
			<PlayMoveInSequence>d__.<>t__builder.Start<PhantomArenaHandAreaItem.<PlayMoveInSequence>d__4>(ref <PlayMoveInSequence>d__);
			return <PlayMoveInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x040174FE RID: 95486
		[Nullable(1)]
		protected UiSequencePlayer Sequence;
	}
}
