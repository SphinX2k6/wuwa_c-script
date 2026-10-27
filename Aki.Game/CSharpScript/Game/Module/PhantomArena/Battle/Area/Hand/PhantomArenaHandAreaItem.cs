using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x020052CA RID: 21194
	public class PhantomArenaHandAreaItem : UiPanelBase
	{
		// Token: 0x0603639C RID: 222108 RVA: 0x00CD4568 File Offset: 0x00CD2768
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603639D RID: 222109 RVA: 0x00CD457B File Offset: 0x00CD277B
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0603639E RID: 222110 RVA: 0x00CD4588 File Offset: 0x00CD2788
		public UniTask PlayMoveOutSequence()
		{
			PhantomArenaHandAreaItem.<PlayMoveOutSequence>d__3 <PlayMoveOutSequence>d__;
			<PlayMoveOutSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveOutSequence>d__.<>4__this = this;
			<PlayMoveOutSequence>d__.<>1__state = -1;
			<PlayMoveOutSequence>d__.<>t__builder.Start<PhantomArenaHandAreaItem.<PlayMoveOutSequence>d__3>(ref <PlayMoveOutSequence>d__);
			return <PlayMoveOutSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603639F RID: 222111 RVA: 0x00CD45CC File Offset: 0x00CD27CC
		public UniTask PlayMoveInSequence()
		{
			PhantomArenaHandAreaItem.<PlayMoveInSequence>d__4 <PlayMoveInSequence>d__;
			<PlayMoveInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveInSequence>d__.<>4__this = this;
			<PlayMoveInSequence>d__.<>1__state = -1;
			<PlayMoveInSequence>d__.<>t__builder.Start<PhantomArenaHandAreaItem.<PlayMoveInSequence>d__4>(ref <PlayMoveInSequence>d__);
			return <PlayMoveInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0401CAC9 RID: 117449
		[Nullable(1)]
		protected UiSequencePlayer Sequence;
	}
}
