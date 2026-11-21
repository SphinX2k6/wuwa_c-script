using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450D RID: 17677
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemVerticalPointerHandle : MarkItemComponentHandle<MarkVerticalPointerComponent>
	{
		// Token: 0x0602C9EE RID: 182766 RVA: 0x00C8522E File Offset: 0x00C8342E
		public MarkItemVerticalPointerHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9EF RID: 182767 RVA: 0x00C85238 File Offset: 0x00C83438
		public void UpdateVerticalPointerType(Vector selfPosition, Vector playerPosition)
		{
			if (this.Context.MarkItem.EnableVerticalPointer)
			{
				EVerticalPointerType verticalPointerType = this.GetVerticalPointerType(selfPosition, playerPosition);
				if (this._pointerTypeInner != verticalPointerType)
				{
					this._pointerTypeInner = verticalPointerType;
					this._pointerTypeDirtyInner = true;
				}
				base.SetVisible(verticalPointerType > EVerticalPointerType.None);
				return;
			}
			base.SetVisible(false);
		}

		// Token: 0x0602C9F0 RID: 182768 RVA: 0x00C8528C File Offset: 0x00C8348C
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

		// Token: 0x0602C9F1 RID: 182769 RVA: 0x00C852E0 File Offset: 0x00C834E0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkVerticalPointerComponent> LoadComponentAsync()
		{
			MarkItemVerticalPointerHandle.<LoadComponentAsync>d__6 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkVerticalPointerComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemVerticalPointerHandle.<LoadComponentAsync>d__6>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9F2 RID: 182770 RVA: 0x00C85323 File Offset: 0x00C83523
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

		// Token: 0x0602C9F3 RID: 182771 RVA: 0x00C8534C File Offset: 0x00C8354C
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty || this._pointerTypeDirtyInner)
			{
				MarkVerticalPointerComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				this._pointerTypeDirtyInner = false;
				orCreateComponent.SetPointerType(this._pointerTypeInner);
				MarkItemComponentHandle<MarkVerticalPointerComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}

		// Token: 0x0602C9F4 RID: 182772 RVA: 0x00C853A1 File Offset: 0x00C835A1
		public override void ResetVisibleState()
		{
			base.ResetVisibleState();
			this._pointerTypeInner = EVerticalPointerType.None;
			this._pointerTypeDirtyInner = false;
		}

		// Token: 0x0602C9F5 RID: 182773 RVA: 0x00C853B7 File Offset: 0x00C835B7
		protected override void OnDispose()
		{
			this.DestroyComponent();
			base.OnDispose();
		}

		// Token: 0x04017EC1 RID: 97985
		private const float POINTER_RANGE = 2000f;

		// Token: 0x04017EC2 RID: 97986
		private EVerticalPointerType _pointerTypeInner;

		// Token: 0x04017EC3 RID: 97987
		private bool _pointerTypeDirtyInner;
	}
}
