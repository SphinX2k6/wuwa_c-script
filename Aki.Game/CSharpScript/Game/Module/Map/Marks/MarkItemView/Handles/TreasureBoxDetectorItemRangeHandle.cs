using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004513 RID: 17683
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TreasureBoxDetectorItemRangeHandle : MarkItemComponentHandle<MarkDetectorRangeImageComponent>
	{
		// Token: 0x0602CA06 RID: 182790 RVA: 0x00C857F0 File Offset: 0x00C839F0
		public TreasureBoxDetectorItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602CA07 RID: 182791 RVA: 0x00C857FC File Offset: 0x00C839FC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkDetectorRangeImageComponent> LoadComponentAsync()
		{
			TreasureBoxDetectorItemRangeHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkDetectorRangeImageComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<TreasureBoxDetectorItemRangeHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CA08 RID: 182792 RVA: 0x00C8583F File Offset: 0x00C83A3F
		protected override MarkDetectorRangeImageComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkDetectorRangeImageComponent _)
				{
					if (this.ComponentInternal == null)
					{
						return;
					}
					MarkDetectorRangeImageComponent componentInternal = this.ComponentInternal;
					Vector2D vector2D = Vector2D.Create(this.Context.MarkItem.UiPosition.X, this.Context.MarkItem.UiPosition.Y);
					UUIItem rootItem = componentInternal.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
					}
					float num = (float)ConfigCommonParamById.GetIntConfig("TreasureBoxDetectionMaxDistance").Value / 100f * 2f;
					componentInternal.RangeImage.SetWidth(num);
					componentInternal.RangeImage.SetHeight(num);
					UUIItem rootItem2 = componentInternal.GetRootItem();
					if (rootItem2 != null)
					{
						rootItem2.SetHierarchyIndex(0);
					}
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602CA09 RID: 182793 RVA: 0x00C85868 File Offset: 0x00C83A68
		public void UpdateRangeScale()
		{
			if (base.Visible)
			{
				MarkDetectorRangeImageComponent orCreateComponent = this.GetOrCreateComponent();
				orCreateComponent.SetRangeScale(1.0, 1.0, 1.0);
				Vector2D vector2D = Vector2D.Create(this.Context.MarkItem.UiPosition.X, this.Context.MarkItem.UiPosition.Y);
				UUIItem rootItem = orCreateComponent.GetRootItem();
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
			}
		}

		// Token: 0x0602CA0A RID: 182794 RVA: 0x00C858EC File Offset: 0x00C83AEC
		protected override void OnApplyModified()
		{
			if (!base.VisibleDirty)
			{
				return;
			}
			MarkDetectorRangeImageComponent orCreateComponent = this.GetOrCreateComponent();
			if (!this.IsComponentValid(orCreateComponent))
			{
				return;
			}
			bool visible = base.Visible;
			base.CleanVisibleDirty();
			this.UpdateRangeScale();
			MarkItemComponentHandle<MarkDetectorRangeImageComponent>.SetComponentActive(orCreateComponent, visible);
		}
	}
}
