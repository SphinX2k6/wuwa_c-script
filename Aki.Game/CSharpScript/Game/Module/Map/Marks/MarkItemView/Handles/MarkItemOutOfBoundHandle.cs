using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005536 RID: 21814
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemOutOfBoundHandle : MarkItemComponentHandle<MarkOutOfBoundComponent>
	{
		// Token: 0x06037AFE RID: 228094 RVA: 0x00D370C3 File Offset: 0x00D352C3
		public MarkItemOutOfBoundHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AFF RID: 228095 RVA: 0x00D370CC File Offset: 0x00D352CC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkOutOfBoundComponent> LoadComponentAsync()
		{
			MarkItemOutOfBoundHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkOutOfBoundComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemOutOfBoundHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B00 RID: 228096 RVA: 0x00D3710F File Offset: 0x00D3530F
		protected override MarkOutOfBoundComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkOutOfBoundComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037B01 RID: 228097 RVA: 0x00D37137 File Offset: 0x00D35337
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.OutOfBound, active);
		}

		// Token: 0x06037B02 RID: 228098 RVA: 0x00D37150 File Offset: 0x00D35350
		protected override void OnApplyModified()
		{
			MarkItemEntity markItemEntity = this.Context.MarkItemEntity;
			MarkResourceComponent resource = markItemEntity.Resource;
			MarkViewLifeCircleComponent viewLifeCircle = markItemEntity.ViewLifeCircle;
			bool isOutOfBoundDirectionDirty = resource.IsOutOfBoundDirectionDirty;
			bool flag = viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.OutOfBound);
			if (isOutOfBoundDirectionDirty || flag)
			{
				MarkOutOfBoundComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				if (isOutOfBoundDirectionDirty)
				{
					Vector uiPosition = this.Context.MarkItem.UiPosition;
					Vector2D vector2D = Vector2D.Create(uiPosition.X, uiPosition.Y);
					Vector2D outOfBoundDirection = resource.OutOfBoundDirection;
					vector2D.SubtractionEqual(outOfBoundDirection);
					orCreateComponent.SetOutOfBoundDirection(vector2D);
					resource.SetOutOfBoundDirectionClean();
				}
				if (flag)
				{
					bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.OutOfBound, false);
					viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.OutOfBound);
					MarkItemComponentHandle<MarkOutOfBoundComponent>.SetComponentActive(orCreateComponent, active);
				}
			}
		}

		// Token: 0x06037B03 RID: 228099 RVA: 0x00D37204 File Offset: 0x00D35404
		public void ApplyDirectionModified()
		{
			MarkResourceComponent resource = this.Context.MarkItemEntity.Resource;
			if (resource.IsOutOfBoundDirectionDirty)
			{
				MarkOutOfBoundComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				Vector uiPosition = this.Context.MarkItem.UiPosition;
				Vector2D vector2D = Vector2D.Create(uiPosition.X, uiPosition.Y);
				Vector2D outOfBoundDirection = resource.OutOfBoundDirection;
				vector2D.SubtractionEqual(outOfBoundDirection);
				orCreateComponent.SetOutOfBoundDirection(vector2D);
				resource.SetOutOfBoundDirectionClean();
			}
		}
	}
}
