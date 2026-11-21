using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450A RID: 17674
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemSelectHandle : MarkItemComponentHandle<MarkSelectComponent>
	{
		// Token: 0x0602C9DE RID: 182750 RVA: 0x00C84F8D File Offset: 0x00C8318D
		public MarkItemSelectHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9DF RID: 182751 RVA: 0x00C84F98 File Offset: 0x00C83198
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

		// Token: 0x0602C9E0 RID: 182752 RVA: 0x00C84FDB File Offset: 0x00C831DB
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

		// Token: 0x0602C9E1 RID: 182753 RVA: 0x00C85004 File Offset: 0x00C83204
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				MarkSelectComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkSelectComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}
	}
}
