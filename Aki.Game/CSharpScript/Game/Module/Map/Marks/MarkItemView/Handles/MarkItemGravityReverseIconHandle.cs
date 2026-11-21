using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004506 RID: 17670
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemGravityReverseIconHandle : MarkItemComponentHandle<MarkGravityReverseIconComponent>
	{
		// Token: 0x0602C9C7 RID: 182727 RVA: 0x00C84B36 File Offset: 0x00C82D36
		public MarkItemGravityReverseIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9C8 RID: 182728 RVA: 0x00C84B40 File Offset: 0x00C82D40
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

		// Token: 0x0602C9C9 RID: 182729 RVA: 0x00C84B83 File Offset: 0x00C82D83
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

		// Token: 0x0602C9CA RID: 182730 RVA: 0x00C84BAC File Offset: 0x00C82DAC
		protected override void OnApplyModified()
		{
			if (!base.VisibleDirty)
			{
				return;
			}
			MarkGravityReverseIconComponent orCreateComponent = this.GetOrCreateComponent();
			if (!this.IsComponentValid(orCreateComponent))
			{
				return;
			}
			bool visible = base.Visible;
			base.CleanVisibleDirty();
			orCreateComponent.Gravity = this.Context.MarkItem.Gravity;
			MarkItemComponentHandle<MarkGravityReverseIconComponent>.SetComponentActive(orCreateComponent, visible);
		}
	}
}
