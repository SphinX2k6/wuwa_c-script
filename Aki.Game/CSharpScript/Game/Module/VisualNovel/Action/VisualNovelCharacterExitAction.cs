using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037CA RID: 14282
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCharacterExitAction : VisualNovelAction
	{
		// Token: 0x060252FC RID: 152316 RVA: 0x00A7D695 File Offset: 0x00A7B895
		public VisualNovelCharacterExitAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceExit)performance;
		}

		// Token: 0x060252FD RID: 152317 RVA: 0x00A7D6B8 File Offset: 0x00A7B8B8
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCharacterExitAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCharacterExitAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252FE RID: 152318 RVA: 0x00A7D6FC File Offset: 0x00A7B8FC
		private UniTask ExitCharacterAsync(VisualNovelScene scene, VisualNovelCharacter character)
		{
			VisualNovelCharacterExitAction.<ExitCharacterAsync>d__7 <ExitCharacterAsync>d__;
			<ExitCharacterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitCharacterAsync>d__.<>4__this = this;
			<ExitCharacterAsync>d__.scene = scene;
			<ExitCharacterAsync>d__.character = character;
			<ExitCharacterAsync>d__.<>1__state = -1;
			<ExitCharacterAsync>d__.<>t__builder.Start<VisualNovelCharacterExitAction.<ExitCharacterAsync>d__7>(ref <ExitCharacterAsync>d__);
			return <ExitCharacterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252FF RID: 152319 RVA: 0x00A7D74F File Offset: 0x00A7B94F
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			this.IsCompletionRequested = true;
			this.FinishPerformance();
			return true;
		}

		// Token: 0x06025300 RID: 152320 RVA: 0x00A7D769 File Offset: 0x00A7B969
		internal override void Release()
		{
			this.IsReleased = true;
			if (base.IsExecuting)
			{
				this.FinishPerformance();
			}
		}

		// Token: 0x06025301 RID: 152321 RVA: 0x00A7D780 File Offset: 0x00A7B980
		private void FinishPerformance()
		{
			foreach (VisualNovelCharacterExitAction.CharacterExit exit in this.CharacterExits)
			{
				VisualNovelCharacterExitAction.FinishPerformance(exit);
			}
		}

		// Token: 0x06025302 RID: 152322 RVA: 0x00A7D7D0 File Offset: 0x00A7B9D0
		private bool CanContinue(VisualNovelScene scene)
		{
			return !this.IsReleased && !base.Context.IsStopped && base.Context.IsReady && base.Context.Scene == scene;
		}

		// Token: 0x06025303 RID: 152323 RVA: 0x00A7D804 File Offset: 0x00A7BA04
		private static void FinishPerformance(VisualNovelCharacterExitAction.CharacterExit exit)
		{
			if (exit.VisibilityVersion == null || exit.HasFinishedOwnHide || exit.Character.VisibilityVersion != exit.VisibilityVersion.Value)
			{
				return;
			}
			exit.HasFinishedOwnHide = true;
			exit.Character.FinishHide(exit.VisibilityVersion.Value);
		}

		// Token: 0x0401491F RID: 84255
		private readonly IVisualNovelPerformanceExit Performance;

		// Token: 0x04014920 RID: 84256
		private readonly List<VisualNovelCharacterExitAction.CharacterExit> CharacterExits = new List<VisualNovelCharacterExitAction.CharacterExit>();

		// Token: 0x04014921 RID: 84257
		private bool IsCompletionRequested;

		// Token: 0x04014922 RID: 84258
		private bool IsReleased;

		// Token: 0x02009543 RID: 38211
		[Nullable(0)]
		private sealed class CharacterExit
		{
			// Token: 0x06043FED RID: 278509 RVA: 0x0142F282 File Offset: 0x0142D482
			public CharacterExit(VisualNovelCharacter character)
			{
				this.Character = character;
			}

			// Token: 0x0402E9DD RID: 190941
			public readonly VisualNovelCharacter Character;

			// Token: 0x0402E9DE RID: 190942
			public int? VisibilityVersion;

			// Token: 0x0402E9DF RID: 190943
			public bool HasFinishedOwnHide;
		}
	}
}
