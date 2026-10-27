using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui.Common
{
	// Token: 0x020046EB RID: 18155
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSequenceOncePlayPanel : UiPanelBase
	{
		// Token: 0x0602F7C1 RID: 194497 RVA: 0x00B01DB8 File Offset: 0x00AFFFB8
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new UiSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
		}

		// Token: 0x0602F7C2 RID: 194498 RVA: 0x00B01DE2 File Offset: 0x00AFFFE2
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == this.SequenceType)
			{
				base.Destroy(null);
			}
		}

		// Token: 0x0602F7C3 RID: 194499 RVA: 0x00B01DFC File Offset: 0x00AFFFFC
		protected override void OnAfterShow()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequence(this.SequenceType, false, null);
		}

		// Token: 0x0602F7C4 RID: 194500 RVA: 0x00B01E29 File Offset: 0x00B00029
		protected override void OnBeforeDestroyImplement()
		{
			CustomPromise destroyPromise = this.DestroyPromise;
			if (destroyPromise == null)
			{
				return;
			}
			destroyPromise.SetResult();
		}

		// Token: 0x0602F7C5 RID: 194501 RVA: 0x00B01E3C File Offset: 0x00B0003C
		public static UniTask PlayAsync(string resourceId, UUIItem parentItem, string sequenceType)
		{
			UiSequenceOncePlayPanel.<PlayAsync>d__7 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.resourceId = resourceId;
			<PlayAsync>d__.parentItem = parentItem;
			<PlayAsync>d__.sequenceType = sequenceType;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<UiSequenceOncePlayPanel.<PlayAsync>d__7>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04019A73 RID: 105075
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x04019A74 RID: 105076
		private string SequenceType = "Start";

		// Token: 0x04019A75 RID: 105077
		[Nullable(2)]
		public CustomPromise DestroyPromise;
	}
}
