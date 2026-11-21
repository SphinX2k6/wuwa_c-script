using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x020044FF RID: 17663
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EnrichmentAreaItemRangeHandle : MarkItemRangeHandle<MarkBlueRangeImageComponent>
	{
		// Token: 0x0602C973 RID: 182643 RVA: 0x00C8448A File Offset: 0x00C8268A
		public EnrichmentAreaItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C974 RID: 182644 RVA: 0x00C84494 File Offset: 0x00C82694
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkBlueRangeImageComponent> LoadComponentAsync()
		{
			EnrichmentAreaItemRangeHandle.<LoadComponentAsync>d__1 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkBlueRangeImageComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<EnrichmentAreaItemRangeHandle.<LoadComponentAsync>d__1>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C975 RID: 182645 RVA: 0x00C844D7 File Offset: 0x00C826D7
		protected override MarkBlueRangeImageComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkBlueRangeImageComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x0602C976 RID: 182646 RVA: 0x00C84500 File Offset: 0x00C82700
		protected override void OnResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
			EMarkType markType = this.Context.MarkItem.MarkType;
			EventSystem.Instance.Emit<EMarkType, EMarkPriorityType>(EEventName.TakeMarkComponentExitContainer, markType, EMarkPriorityType.OthersLevel);
			MarkBlueRangeImageComponent componentInternal = this.ComponentInternal;
			UUIItem uuiitem = (componentInternal != null) ? componentInternal.GetRootItem() : null;
			if (uuiitem != null)
			{
				EventSystem.Instance.Emit<UUIItem, EMarkType, EMarkPriorityType>(EEventName.TakeMarkComponentEnterContainer, uuiitem, markType, EMarkPriorityType.OthersLevel);
			}
			base.OnResetRangeComponent(rangeComponent);
			Vector2D vector2D = Vector2D.Create(this.Context.MarkItem.UiPosition.X, this.Context.MarkItem.UiPosition.Y);
			UUIItem rootItem = rangeComponent.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}

		// Token: 0x0602C977 RID: 182647 RVA: 0x00C845A7 File Offset: 0x00C827A7
		protected override void DestroyComponent()
		{
			if (this.ComponentInternal != null)
			{
				this.ComponentInternal.RecycleToPool();
				EventSystem.Instance.Emit<EMarkType, EMarkPriorityType>(EEventName.TakeMarkComponentExitContainer, this.Context.MarkItem.MarkType, EMarkPriorityType.OthersLevel);
				this.ComponentInternal = null;
			}
		}
	}
}
