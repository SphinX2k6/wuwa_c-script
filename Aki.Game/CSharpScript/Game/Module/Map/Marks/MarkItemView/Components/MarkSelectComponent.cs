using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200554B RID: 21835
	public class MarkSelectComponent : MarkPanelBase
	{
		// Token: 0x06037B7B RID: 228219 RVA: 0x00D38674 File Offset: 0x00D36874
		[NullableContext(1)]
		protected virtual string GetSelectSequenceName()
		{
			return "xuanzhong";
		}

		// Token: 0x06037B7C RID: 228220 RVA: 0x00D3867B File Offset: 0x00D3687B
		[NullableContext(1)]
		protected virtual string GetUnSelectSequenceName()
		{
			return "Close";
		}

		// Token: 0x06037B7D RID: 228221 RVA: 0x00D38682 File Offset: 0x00D36882
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06037B7E RID: 228222 RVA: 0x00D38695 File Offset: 0x00D36895
		public override void SetActive(bool visibility)
		{
			this.PlaySequenceAndSetActive(visibility);
		}

		// Token: 0x06037B7F RID: 228223 RVA: 0x00D386A0 File Offset: 0x00D368A0
		protected UniTask<bool> PlaySequenceAndSetActive(bool visibility)
		{
			MarkSelectComponent.<PlaySequenceAndSetActive>d__6 <PlaySequenceAndSetActive>d__;
			<PlaySequenceAndSetActive>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlaySequenceAndSetActive>d__.<>4__this = this;
			<PlaySequenceAndSetActive>d__.visibility = visibility;
			<PlaySequenceAndSetActive>d__.<>1__state = -1;
			<PlaySequenceAndSetActive>d__.<>t__builder.Start<MarkSelectComponent.<PlaySequenceAndSetActive>d__6>(ref <PlaySequenceAndSetActive>d__);
			return <PlaySequenceAndSetActive>d__.<>t__builder.Task;
		}

		// Token: 0x0401D44C RID: 119884
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D44D RID: 119885
		protected bool LastVisibility;
	}
}
