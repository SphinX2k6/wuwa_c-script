using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200553A RID: 21818
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemTrackHandle : MarkItemComponentHandle<MarkTrackComponent>
	{
		// Token: 0x06037B18 RID: 228120 RVA: 0x00D37634 File Offset: 0x00D35834
		public MarkItemTrackHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B19 RID: 228121 RVA: 0x00D37640 File Offset: 0x00D35840
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

		// Token: 0x06037B1A RID: 228122 RVA: 0x00D37683 File Offset: 0x00D35883
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

		// Token: 0x06037B1B RID: 228123 RVA: 0x00D376AB File Offset: 0x00D358AB
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.Track, active);
		}

		// Token: 0x06037B1C RID: 228124 RVA: 0x00D376C4 File Offset: 0x00D358C4
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Track))
			{
				MarkTrackComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Track, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.Track);
				MarkItemComponentHandle<MarkTrackComponent>.SetComponentActive(orCreateComponent, active);
			}
		}
	}
}
