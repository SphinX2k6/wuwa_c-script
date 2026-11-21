using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450C RID: 17676
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemTrackHandle : MarkItemComponentHandle<MarkTrackComponent>
	{
		// Token: 0x0602C9E9 RID: 182761 RVA: 0x00C85177 File Offset: 0x00C83377
		public MarkItemTrackHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9EA RID: 182762 RVA: 0x00C85180 File Offset: 0x00C83380
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkTrackComponent> LoadComponentAsync()
		{
			MarkItemTrackHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkTrackComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemTrackHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9EB RID: 182763 RVA: 0x00C851C3 File Offset: 0x00C833C3
		protected override MarkTrackComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkTrackComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602C9EC RID: 182764 RVA: 0x00C851EC File Offset: 0x00C833EC
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				MarkTrackComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkTrackComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}
	}
}
