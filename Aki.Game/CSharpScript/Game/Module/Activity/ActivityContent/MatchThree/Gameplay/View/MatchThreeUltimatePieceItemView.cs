using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005467 RID: 21607
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeUltimatePieceItemView : MatchThreePieceItemView
	{
		// Token: 0x06035A53 RID: 219731 RVA: 0x00EFC6B9 File Offset: 0x00EFA8B9
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

		// Token: 0x06035A54 RID: 219732 RVA: 0x00EFC6E4 File Offset: 0x00EFA8E4
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

		// Token: 0x06035A55 RID: 219733 RVA: 0x00EFC72F File Offset: 0x00EFA92F
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName != "Full" || eventName != "Up" || this.FullUpReceived)
			{
				return;
			}
			this.FullUpReceived = true;
			this.ReleaseFullUpCallback();
		}

		// Token: 0x06035A56 RID: 219734 RVA: 0x00EFC761 File Offset: 0x00EFA961
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

		// Token: 0x06035A57 RID: 219735 RVA: 0x00EFC77A File Offset: 0x00EFA97A
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

		// Token: 0x0401C5C1 RID: 116161
		[Nullable(2)]
		private Action FullUpCallback;

		// Token: 0x0401C5C2 RID: 116162
		private bool FullUpReceived;
	}
}
