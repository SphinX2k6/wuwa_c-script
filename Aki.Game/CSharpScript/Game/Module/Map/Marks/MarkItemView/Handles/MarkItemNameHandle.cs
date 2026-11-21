using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004507 RID: 17671
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemNameHandle : MarkItemComponentHandle<MarkNameComponent>
	{
		// Token: 0x0602C9CC RID: 182732 RVA: 0x00C84C50 File Offset: 0x00C82E50
		public MarkItemNameHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9CD RID: 182733 RVA: 0x00C84C5C File Offset: 0x00C82E5C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkNameComponent> LoadComponentAsync()
		{
			MarkItemNameHandle.<LoadComponentAsync>d__2 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkNameComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemNameHandle.<LoadComponentAsync>d__2>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9CE RID: 182734 RVA: 0x00C84C9F File Offset: 0x00C82E9F
		protected override MarkNameComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkNameComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602C9CF RID: 182735 RVA: 0x00C84CC7 File Offset: 0x00C82EC7
		public void SetName(IMarkItemParam param)
		{
			this.Param = param;
		}

		// Token: 0x0602C9D0 RID: 182736 RVA: 0x00C84CD0 File Offset: 0x00C82ED0
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				MarkNameComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				if (this.Param != null)
				{
					orCreateComponent.SetNameParam(this.Param);
				}
				MarkItemComponentHandle<MarkNameComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}

		// Token: 0x04017EC0 RID: 97984
		[Nullable(2)]
		private IMarkItemParam Param;
	}
}
