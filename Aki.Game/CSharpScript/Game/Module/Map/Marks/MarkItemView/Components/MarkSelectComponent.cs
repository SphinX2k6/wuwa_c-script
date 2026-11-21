using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451D RID: 17693
	public class MarkSelectComponent : MarkPanelBase
	{
		// Token: 0x0602CA4B RID: 182859 RVA: 0x00C86148 File Offset: 0x00C84348
		[NullableContext(1)]
		protected virtual string GetSelectSequenceName()
		{
			return "xuanzhong";
		}

		// Token: 0x0602CA4C RID: 182860 RVA: 0x00C8614F File Offset: 0x00C8434F
		[NullableContext(1)]
		protected virtual string GetUnSelectSequenceName()
		{
			return "Close";
		}

		// Token: 0x0602CA4D RID: 182861 RVA: 0x00C86156 File Offset: 0x00C84356
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602CA4E RID: 182862 RVA: 0x00C86169 File Offset: 0x00C84369
		public override void SetActive(bool visibility)
		{
			this.PlaySequenceAndSetActive(visibility);
		}

		// Token: 0x0602CA4F RID: 182863 RVA: 0x00C86174 File Offset: 0x00C84374
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

		// Token: 0x04017ED5 RID: 98005
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04017ED6 RID: 98006
		protected bool LastVisibility;
	}
}
