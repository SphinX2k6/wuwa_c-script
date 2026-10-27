using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005538 RID: 21816
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemSelectHandle : MarkItemComponentHandle<MarkSelectComponent>
	{
		// Token: 0x06037B0D RID: 228109 RVA: 0x00D3740C File Offset: 0x00D3560C
		public MarkItemSelectHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B0E RID: 228110 RVA: 0x00D37418 File Offset: 0x00D35618
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkSelectComponent> LoadComponentAsync()
		{
			MarkItemSelectHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkSelectComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemSelectHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B0F RID: 228111 RVA: 0x00D3745B File Offset: 0x00D3565B
		protected override MarkSelectComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkSelectComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037B10 RID: 228112 RVA: 0x00D37483 File Offset: 0x00D35683
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.Select, active);
		}

		// Token: 0x06037B11 RID: 228113 RVA: 0x00D3749C File Offset: 0x00D3569C
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Select))
			{
				MarkSelectComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Select, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.Select);
				MarkItemComponentHandle<MarkSelectComponent>.SetComponentActive(orCreateComponent, active);
			}
		}
	}
}
