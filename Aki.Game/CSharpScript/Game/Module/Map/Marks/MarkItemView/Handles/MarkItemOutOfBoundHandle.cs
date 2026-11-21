using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004508 RID: 17672
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemOutOfBoundHandle : MarkItemComponentHandle<MarkOutOfBoundComponent>
	{
		// Token: 0x0602C9D2 RID: 182738 RVA: 0x00C84D26 File Offset: 0x00C82F26
		public MarkItemOutOfBoundHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9D3 RID: 182739 RVA: 0x00C84D30 File Offset: 0x00C82F30
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

		// Token: 0x0602C9D4 RID: 182740 RVA: 0x00C84D73 File Offset: 0x00C82F73
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

		// Token: 0x0602C9D5 RID: 182741 RVA: 0x00C84D9C File Offset: 0x00C82F9C
		protected override void OnApplyModified()
		{
			MarkItem markItem = this.Context.MarkItem;
			bool isOutOfBoundDirectionDirty = markItem.IsOutOfBoundDirectionDirty;
			if (!isOutOfBoundDirectionDirty && !base.VisibleDirty)
			{
				return;
			}
			MarkOutOfBoundComponent orCreateComponent = this.GetOrCreateComponent();
			if (!this.IsComponentValid(orCreateComponent))
			{
				return;
			}
			if (isOutOfBoundDirectionDirty)
			{
				Vector uiPosition = markItem.UiPosition;
				Vector2D vector2D = Vector2D.Create(uiPosition.X, uiPosition.Y);
				Vector2D outOfBoundDirection = markItem.OutOfBoundDirection;
				vector2D.SubtractionEqual(outOfBoundDirection);
				orCreateComponent.SetOutOfBoundDirection(vector2D);
				markItem.IsOutOfBoundDirectionDirty = false;
			}
			if (base.VisibleDirty)
			{
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkOutOfBoundComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}
	}
}
