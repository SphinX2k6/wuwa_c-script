using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DF RID: 21727
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicEntityMarkItem : DynamicConfigMarkItem
	{
		// Token: 0x060377A0 RID: 227232 RVA: 0x00D2D4D5 File Offset: 0x00D2B6D5
		public DynamicEntityMarkItem(int markId, DynamicMapMark markConfig, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale) : base(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark)
		{
			base.TrackTarget = trackTarget;
		}

		// Token: 0x060377A1 RID: 227233 RVA: 0x00D2D4F0 File Offset: 0x00D2B6F0
		protected override void OnInitialize()
		{
			if (this.MarkConfig != null && this.MarkConfig.Value.Scale != 0f)
			{
				base.SetConfigScale(this.MarkConfig.Value.Scale);
			}
			base.InitShowCondition();
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377A2 RID: 227234 RVA: 0x00D2D549 File Offset: 0x00D2B749
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DynamicEntityMarkItemView;
		}

		// Token: 0x060377A3 RID: 227235 RVA: 0x00D2D54C File Offset: 0x00D2B74C
		[PreserveBaseOverrides]
		protected new virtual DynamicEntityMarkItemView CreateView()
		{
			return new DynamicEntityMarkItemView(this);
		}

		// Token: 0x060377A4 RID: 227236 RVA: 0x00D2D554 File Offset: 0x00D2B754
		public override bool CheckCanShowView()
		{
			if (!(base.TrackTarget is TTrackTarget_Int))
			{
				return base.CheckCanShowView();
			}
			return CreatureModel.Instance.CheckEntityVisible((TTrackTarget_Int)base.TrackTarget) && base.CheckCanShowView();
		}
	}
}
