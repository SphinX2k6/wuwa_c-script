using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004509 RID: 17673
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemRangeHandle<[Nullable(0)] T> : MarkItemComponentHandle<T> where T : MarkPanelBase, new()
	{
		// Token: 0x0602C9D7 RID: 182743 RVA: 0x00C84E3D File Offset: 0x00C8303D
		public MarkItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9D8 RID: 182744 RVA: 0x00C84E48 File Offset: 0x00C83048
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<T> LoadComponentAsync()
		{
			MarkItemRangeHandle<T>.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemRangeHandle<T>.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9D9 RID: 182745 RVA: 0x00C84E8B File Offset: 0x00C8308B
		protected override T GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(T _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602C9DA RID: 182746 RVA: 0x00C84EB8 File Offset: 0x00C830B8
		protected override void OnApplyModified()
		{
			if (!base.VisibleDirty)
			{
				return;
			}
			MarkRangeImageComponent markRangeImageComponent = this.GetOrCreateComponent() as MarkRangeImageComponent;
			if (!this.IsComponentValid(markRangeImageComponent as T))
			{
				return;
			}
			bool visible = base.Visible;
			base.CleanVisibleDirty();
			this.ResetRangeComponent(markRangeImageComponent);
			MarkItemComponentHandle<T>.SetComponentActive(markRangeImageComponent, visible);
		}

		// Token: 0x0602C9DB RID: 182747 RVA: 0x00C84F10 File Offset: 0x00C83110
		private void ResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
			float num = this.Context.MarkItem.RangeSize * 2f;
			UUIItem rangeArea = rangeComponent.RangeArea;
			if (rangeArea != null)
			{
				rangeArea.SetWidth(num);
			}
			UUIItem rangeArea2 = rangeComponent.RangeArea;
			if (rangeArea2 != null)
			{
				rangeArea2.SetHeight(num);
			}
			UUITexture rangeImage = rangeComponent.RangeImage;
			if (rangeImage != null)
			{
				rangeImage.SetWidth(num);
			}
			UUITexture rangeImage2 = rangeComponent.RangeImage;
			if (rangeImage2 != null)
			{
				rangeImage2.SetHeight(num);
			}
			this.OnResetRangeComponent(rangeComponent);
		}

		// Token: 0x0602C9DC RID: 182748 RVA: 0x00C84F83 File Offset: 0x00C83183
		protected virtual void OnResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
		}
	}
}
