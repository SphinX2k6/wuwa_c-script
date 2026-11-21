using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004503 RID: 17667
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemAutoPilotTrackHandle : MarkItemComponentHandle<MarkAutoPilotTrackComponent>
	{
		// Token: 0x0602C99E RID: 182686 RVA: 0x00C84680 File Offset: 0x00C82880
		public MarkItemAutoPilotTrackHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C99F RID: 182687 RVA: 0x00C8468C File Offset: 0x00C8288C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkAutoPilotTrackComponent> LoadComponentAsync()
		{
			MarkItemAutoPilotTrackHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkAutoPilotTrackComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemAutoPilotTrackHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9A0 RID: 182688 RVA: 0x00C846CF File Offset: 0x00C828CF
		protected override MarkAutoPilotTrackComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkAutoPilotTrackComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602C9A1 RID: 182689 RVA: 0x00C846F8 File Offset: 0x00C828F8
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				MarkAutoPilotTrackComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkAutoPilotTrackComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}
	}
}
