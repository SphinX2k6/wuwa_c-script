using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005531 RID: 21809
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemAutoPilotTrackHandle : MarkItemComponentHandle<MarkAutoPilotTrackComponent>
	{
		// Token: 0x06037ACF RID: 228047 RVA: 0x00D369A4 File Offset: 0x00D34BA4
		public MarkItemAutoPilotTrackHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AD0 RID: 228048 RVA: 0x00D369B0 File Offset: 0x00D34BB0
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

		// Token: 0x06037AD1 RID: 228049 RVA: 0x00D369F3 File Offset: 0x00D34BF3
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

		// Token: 0x06037AD2 RID: 228050 RVA: 0x00D36A1B File Offset: 0x00D34C1B
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.AutoPilotTrack, active);
		}

		// Token: 0x06037AD3 RID: 228051 RVA: 0x00D36A38 File Offset: 0x00D34C38
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.AutoPilotTrack))
			{
				MarkAutoPilotTrackComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.AutoPilotTrack, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.AutoPilotTrack);
				MarkItemComponentHandle<MarkAutoPilotTrackComponent>.SetComponentActive(orCreateComponent, active);
			}
		}
	}
}
