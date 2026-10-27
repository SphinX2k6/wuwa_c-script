using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200553B RID: 21819
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemVerticalPointerHandle : MarkItemComponentHandle<MarkVerticalPointerComponent>
	{
		// Token: 0x06037B1E RID: 228126 RVA: 0x00D3771B File Offset: 0x00D3591B
		public MarkItemVerticalPointerHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B1F RID: 228127 RVA: 0x00D37724 File Offset: 0x00D35924
		public void UpdateVerticalPointerType(Vector selfPosition, Vector playerPosition)
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.EnableVerticalPointer)
			{
				EVerticalPointerType verticalPointerType = this.GetVerticalPointerType(selfPosition, playerPosition);
				viewLifeCircle.VerticalPointerType = verticalPointerType;
				base.SetVisible(verticalPointerType > EVerticalPointerType.None);
				return;
			}
			base.SetVisible(false);
		}

		// Token: 0x06037B20 RID: 228128 RVA: 0x00D3776C File Offset: 0x00D3596C
		private EVerticalPointerType GetVerticalPointerType(Vector selfPosition, Vector playerPosition)
		{
			if (this.Context.MarkItem.MapType == EMapType.WorldMap)
			{
				return EVerticalPointerType.None;
			}
			double num = selfPosition.Z - playerPosition.Z;
			if (Math.Abs(num) < 2000.0)
			{
				return EVerticalPointerType.None;
			}
			if (num < 0.0)
			{
				return EVerticalPointerType.Up;
			}
			return EVerticalPointerType.Down;
		}

		// Token: 0x06037B21 RID: 228129 RVA: 0x00D377C0 File Offset: 0x00D359C0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkVerticalPointerComponent> LoadComponentAsync()
		{
			MarkItemVerticalPointerHandle.<LoadComponentAsync>d__4 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkVerticalPointerComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemVerticalPointerHandle.<LoadComponentAsync>d__4>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B22 RID: 228130 RVA: 0x00D37803 File Offset: 0x00D35A03
		protected override MarkVerticalPointerComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkVerticalPointerComponent _)
				{
					if (this.ComponentInternal != null)
					{
						MarkItem markItem = this.Context.MarkItem;
						MarkVerticalPointerComponent componentInternal = this.ComponentInternal;
						if (componentInternal != null)
						{
							UUIItem rootItem = componentInternal.GetRootItem();
							if (rootItem != null)
							{
								FVectorDouble fvectorDouble = markItem.CornerScaleVector.ToUeVector(false);
								FVector fvector = fvectorDouble;
								rootItem.SetUIRelativeScale3D(fvector);
							}
						}
						base.ApplyModified();
					}
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037B23 RID: 228131 RVA: 0x00D3782B File Offset: 0x00D35A2B
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.VerticalPointer, active);
		}

		// Token: 0x06037B24 RID: 228132 RVA: 0x00D37844 File Offset: 0x00D35A44
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			bool flag = viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.VerticalPointer);
			bool isVerticalPointerTypeDirty = viewLifeCircle.IsVerticalPointerTypeDirty;
			if (flag || isVerticalPointerTypeDirty)
			{
				MarkVerticalPointerComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.VerticalPointer, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.VerticalPointer);
				viewLifeCircle.SetVerticalPointerTypeClean();
				orCreateComponent.SetPointerType(viewLifeCircle.VerticalPointerType);
				MarkItemComponentHandle<MarkVerticalPointerComponent>.SetComponentActive(orCreateComponent, active);
			}
		}

		// Token: 0x06037B25 RID: 228133 RVA: 0x00D378AE File Offset: 0x00D35AAE
		protected override void OnDispose()
		{
			this.DestroyComponent();
			base.OnDispose();
		}

		// Token: 0x0401D43D RID: 119869
		private const float POINTER_RANGE = 2000f;
	}
}
