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
	// Token: 0x02005534 RID: 21812
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemGravityReverseIconHandle : MarkItemComponentHandle<MarkGravityReverseIconComponent>
	{
		// Token: 0x06037AF1 RID: 228081 RVA: 0x00D36E70 File Offset: 0x00D35070
		public MarkItemGravityReverseIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AF2 RID: 228082 RVA: 0x00D36E7C File Offset: 0x00D3507C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkGravityReverseIconComponent> LoadComponentAsync()
		{
			MarkItemGravityReverseIconHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkGravityReverseIconComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemGravityReverseIconHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AF3 RID: 228083 RVA: 0x00D36EBF File Offset: 0x00D350BF
		protected override MarkGravityReverseIconComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkGravityReverseIconComponent _)
				{
					MarkGravityReverseIconComponent componentInternal = this.ComponentInternal;
					if (componentInternal != null)
					{
						UUIItem rootItem = componentInternal.GetRootItem();
						if (rootItem != null)
						{
							FVectorDouble fvectorDouble = this.Context.MarkItem.CornerScaleVector.ToUeVector(false);
							FVector fvector = fvectorDouble;
							rootItem.SetUIRelativeScale3D(fvector);
						}
					}
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037AF4 RID: 228084 RVA: 0x00D36EE7 File Offset: 0x00D350E7
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.GravityReverse, active);
		}

		// Token: 0x06037AF5 RID: 228085 RVA: 0x00D36F04 File Offset: 0x00D35104
		protected override void OnApplyModified()
		{
			MarkItemEntity markItemEntity = this.Context.MarkItemEntity;
			MarkViewLifeCircleComponent viewLifeCircle = markItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.GravityReverse))
			{
				MarkGravityReverseIconComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.GravityReverse, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.GravityReverse);
				orCreateComponent.Gravity = markItemEntity.GamePlay.Gravity;
				MarkItemComponentHandle<MarkGravityReverseIconComponent>.SetComponentActive(orCreateComponent, active);
			}
		}
	}
}
