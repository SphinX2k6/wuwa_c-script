using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004510 RID: 17680
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TaskMarkItemRangeHandle : MarkItemRangeHandle<MarkRangeImageComponent>
	{
		// Token: 0x0602C9FF RID: 182783 RVA: 0x00C85692 File Offset: 0x00C83892
		public TaskMarkItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602CA00 RID: 182784 RVA: 0x00C8569C File Offset: 0x00C8389C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkRangeImageComponent> LoadComponentAsync()
		{
			TaskMarkItemRangeHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkRangeImageComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<TaskMarkItemRangeHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CA01 RID: 182785 RVA: 0x00C856E0 File Offset: 0x00C838E0
		protected override void OnResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
			base.OnResetRangeComponent(rangeComponent);
			Vector2D vector2D = Vector2D.Create(this.Context.MarkItem.UiPosition.X, this.Context.MarkItem.UiPosition.Y);
			rangeComponent.GetRootItem().SetAnchorOffset(vector2D.ToUeVector2D(false));
			rangeComponent.GetRootItem().SetAsFirstHierarchy();
		}
	}
}
