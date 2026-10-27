using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005537 RID: 21815
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemRangeHandle<[Nullable(0)] T> : MarkItemComponentHandle<T> where T : MarkPanelBase, new()
	{
		// Token: 0x06037B05 RID: 228101 RVA: 0x00D37284 File Offset: 0x00D35484
		public MarkItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B06 RID: 228102 RVA: 0x00D37290 File Offset: 0x00D35490
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

		// Token: 0x06037B07 RID: 228103 RVA: 0x00D372D3 File Offset: 0x00D354D3
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

		// Token: 0x06037B08 RID: 228104 RVA: 0x00D37300 File Offset: 0x00D35500
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.Range, active);
		}

		// Token: 0x06037B09 RID: 228105 RVA: 0x00D3731C File Offset: 0x00D3551C
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Range))
			{
				MarkRangeImageComponent markRangeImageComponent = this.GetOrCreateComponent() as MarkRangeImageComponent;
				if (!this.IsComponentValid(markRangeImageComponent as T))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Range, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.Range);
				this.ResetRangeComponent(markRangeImageComponent);
				MarkItemComponentHandle<T>.SetComponentActive(markRangeImageComponent, active);
			}
		}

		// Token: 0x06037B0A RID: 228106 RVA: 0x00D37388 File Offset: 0x00D35588
		protected void ResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
			float num = this.Context.MarkItemEntity.GetComponent<MarkResourceComponent>(EMapComponent.MarkResource).RangeSize * 2f;
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

		// Token: 0x06037B0B RID: 228107 RVA: 0x00D37402 File Offset: 0x00D35602
		protected virtual void OnResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
		}
	}
}
