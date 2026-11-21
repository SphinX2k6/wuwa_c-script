using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui.Common
{
	// Token: 0x0200361B RID: 13851
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSequenceOncePlayPanel : UiPanelBase
	{
		// Token: 0x06023F8A RID: 147338 RVA: 0x00A31BF6 File Offset: 0x00A2FDF6
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new UiSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
		}

		// Token: 0x06023F8B RID: 147339 RVA: 0x00A31C20 File Offset: 0x00A2FE20
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == this.SequenceType)
			{
				base.Destroy(null);
			}
		}

		// Token: 0x06023F8C RID: 147340 RVA: 0x00A31C38 File Offset: 0x00A2FE38
		protected override void OnAfterShow()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequence(this.SequenceType, false, null);
		}

		// Token: 0x06023F8D RID: 147341 RVA: 0x00A31C65 File Offset: 0x00A2FE65
		protected override void OnBeforeDestroyImplement()
		{
			CustomPromise destroyPromise = this.DestroyPromise;
			if (destroyPromise == null)
			{
				return;
			}
			destroyPromise.SetResult();
		}

		// Token: 0x06023F8E RID: 147342 RVA: 0x00A31C78 File Offset: 0x00A2FE78
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

		// Token: 0x04014122 RID: 82210
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x04014123 RID: 82211
		private string SequenceType = "Start";

		// Token: 0x04014124 RID: 82212
		[Nullable(2)]
		public CustomPromise DestroyPromise;
	}
}
