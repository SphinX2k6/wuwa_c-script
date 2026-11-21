using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B2 RID: 17586
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicEntityMarkItem : DynamicConfigMarkItem
	{
		// Token: 0x0602C65B RID: 181851 RVA: 0x00C7B5C1 File Offset: 0x00C797C1
		public DynamicEntityMarkItem(int markId, DynamicMapMark markConfig, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale) : base(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark)
		{
			base.TrackTarget = trackTarget;
		}

		// Token: 0x0602C65C RID: 181852 RVA: 0x00C7B5DC File Offset: 0x00C797DC
		protected override void OnInitialize()
		{
			if (this.MarkConfig != null && this.MarkConfig.Value.Scale != 0f)
			{
				base.SetConfigScale(this.MarkConfig.Value.Scale);
			}
			base.InitShowCondition();
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C65D RID: 181853 RVA: 0x00C7B635 File Offset: 0x00C79835
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DynamicEntityMarkItemView;
		}

		// Token: 0x0602C65E RID: 181854 RVA: 0x00C7B638 File Offset: 0x00C79838
		[PreserveBaseOverrides]
		protected new virtual DynamicEntityMarkItemView CreateView()
		{
			return new DynamicEntityMarkItemView(this);
		}

		// Token: 0x0602C65F RID: 181855 RVA: 0x00C7B640 File Offset: 0x00C79840
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
