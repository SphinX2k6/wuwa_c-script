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
	// Token: 0x0200552C RID: 21804
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EnrichmentAreaItemRangeHandle : MarkItemRangeHandle<MarkBlueRangeImageComponent>
	{
		// Token: 0x06037AA3 RID: 228003 RVA: 0x00D3677D File Offset: 0x00D3497D
		public EnrichmentAreaItemRangeHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AA4 RID: 228004 RVA: 0x00D36788 File Offset: 0x00D34988
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

		// Token: 0x06037AA5 RID: 228005 RVA: 0x00D367CB File Offset: 0x00D349CB
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

		// Token: 0x06037AA6 RID: 228006 RVA: 0x00D367F4 File Offset: 0x00D349F4
		protected override void OnResetRangeComponent(MarkRangeImageComponent rangeComponent)
		{
			EMarkType markType = this.Context.MarkItemEntity.GamePlay.MarkType;
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

		// Token: 0x06037AA7 RID: 228007 RVA: 0x00D368A0 File Offset: 0x00D34AA0
		protected override void DestroyComponent()
		{
			if (this.ComponentInternal != null)
			{
				this.ComponentInternal.RecycleToPool();
				EventSystem.Instance.Emit<EMarkType, EMarkPriorityType>(EEventName.TakeMarkComponentExitContainer, this.Context.MarkItemEntity.GamePlay.MarkType, EMarkPriorityType.OthersLevel);
				this.ComponentInternal = null;
			}
		}
	}
}
