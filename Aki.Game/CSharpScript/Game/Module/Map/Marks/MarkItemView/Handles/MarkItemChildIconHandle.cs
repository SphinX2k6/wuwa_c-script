using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Morale.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004504 RID: 17668
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemChildIconHandle : MarkItemComponentHandle<MarkChildIconComponent>
	{
		// Token: 0x0602C9A3 RID: 182691 RVA: 0x00C8473A File Offset: 0x00C8293A
		public MarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9A4 RID: 182692 RVA: 0x00C84744 File Offset: 0x00C82944
		protected override void OnUpdate()
		{
			MarkItem markItem = this.Context.MarkItem;
			if (markItem.ShowSecondaryUiMultiMapIcon())
			{
				base.SetVisible(true);
				markItem.ChildIconPath = UiResourceConfig.Instance.GetResourcePath(markItem.IsSelectThisFloor ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap");
				return;
			}
			IMarkConfig config = markItem.Config;
			if (config != null && !(config.RelativeSubType != EMarkRelativeSubType.MoraleFlag))
			{
				MoraleAreaFlagData flagDataByMarkId = MoraleModel.Instance.GetFlagDataByMarkId(config.MarkId);
				if (flagDataByMarkId != null && flagDataByMarkId.HasBoxCanGet())
				{
					base.SetVisible(true);
					markItem.ChildIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MarkGift");
					return;
				}
			}
			base.SetVisible(false);
		}

		// Token: 0x0602C9A5 RID: 182693 RVA: 0x00C847F8 File Offset: 0x00C829F8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkChildIconComponent> LoadComponentAsync()
		{
			MarkItemChildIconHandle.<LoadComponentAsync>d__2 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkChildIconComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemChildIconHandle.<LoadComponentAsync>d__2>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9A6 RID: 182694 RVA: 0x00C8483B File Offset: 0x00C82A3B
		protected override MarkChildIconComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkChildIconComponent _)
				{
					MarkChildIconComponent componentInternal = this.ComponentInternal;
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

		// Token: 0x0602C9A7 RID: 182695 RVA: 0x00C84863 File Offset: 0x00C82A63
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItem.ShowChildIcon = active;
		}

		// Token: 0x0602C9A8 RID: 182696 RVA: 0x00C84878 File Offset: 0x00C82A78
		protected override void OnApplyModified()
		{
			if (!base.Visible && !base.VisibleDirty)
			{
				return;
			}
			MarkChildIconComponent orCreateComponent = this.GetOrCreateComponent();
			if (!this.IsComponentValid(orCreateComponent))
			{
				return;
			}
			if (base.Visible)
			{
				orCreateComponent.Icon = this.Context.MarkItem.ChildIconPath;
			}
			if (base.VisibleDirty)
			{
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkChildIconComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}
	}
}
