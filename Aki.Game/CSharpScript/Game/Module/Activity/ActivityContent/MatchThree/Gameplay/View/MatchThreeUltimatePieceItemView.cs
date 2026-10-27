using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E9 RID: 25833
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeUltimatePieceItemView : MatchThreePieceItemView
	{
		// Token: 0x06040D8F RID: 265615 RVA: 0x00FB5689 File Offset: 0x00FB3889
		protected override void OnStart()
		{
			base.OnStart();
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
		}

		// Token: 0x06040D90 RID: 265616 RVA: 0x00FB56B4 File Offset: 0x00FB38B4
		public UniTask PlayFullAsync(Action onFullUp)
		{
			MatchThreeUltimatePieceItemView.<PlayFullAsync>d__3 <PlayFullAsync>d__;
			<PlayFullAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFullAsync>d__.<>4__this = this;
			<PlayFullAsync>d__.onFullUp = onFullUp;
			<PlayFullAsync>d__.<>1__state = -1;
			<PlayFullAsync>d__.<>t__builder.Start<MatchThreeUltimatePieceItemView.<PlayFullAsync>d__3>(ref <PlayFullAsync>d__);
			return <PlayFullAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D91 RID: 265617 RVA: 0x00FB56FF File Offset: 0x00FB38FF
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName != "Full" || eventName != "Up" || this.FullUpReceived)
			{
				return;
			}
			this.FullUpReceived = true;
			this.ReleaseFullUpCallback();
		}

		// Token: 0x06040D92 RID: 265618 RVA: 0x00FB5731 File Offset: 0x00FB3931
		private void ReleaseFullUpCallback()
		{
			Action fullUpCallback = this.FullUpCallback;
			this.FullUpCallback = null;
			if (fullUpCallback == null)
			{
				return;
			}
			fullUpCallback();
		}

		// Token: 0x06040D93 RID: 265619 RVA: 0x00FB574A File Offset: 0x00FB394A
		protected override void OnBeforeDestroy()
		{
			this.ReleaseFullUpCallback();
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x04021C90 RID: 138384
		[Nullable(2)]
		private Action FullUpCallback;

		// Token: 0x04021C91 RID: 138385
		private bool FullUpReceived;
	}
}
