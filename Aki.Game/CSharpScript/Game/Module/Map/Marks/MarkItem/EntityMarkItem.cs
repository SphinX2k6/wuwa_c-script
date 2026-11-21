using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B5 RID: 17589
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C678 RID: 181880 RVA: 0x00C7BB2B File Offset: 0x00C79D2B
		public EntityMarkItem(int markId, MapMark markConfig, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(ETrackSource.MapMark))
		{
			base.TrackTarget = trackTarget;
		}

		// Token: 0x0602C679 RID: 181881 RVA: 0x00C7BB48 File Offset: 0x00C79D48
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EntityMarkItemView;
		}

		// Token: 0x0602C67A RID: 181882 RVA: 0x00C7BB4C File Offset: 0x00C79D4C
		protected override MarkItemView CreateView()
		{
			return new EntityMarkItemView(this);
		}

		// Token: 0x0602C67B RID: 181883 RVA: 0x00C7BB54 File Offset: 0x00C79D54
		protected override void InitPosition()
		{
			if (base.TrackTarget == null)
			{
				base.SetTrackData(MapModel.Instance.GetConfigMarkTrackTarget(this.MarkId));
			}
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C67C RID: 181884 RVA: 0x00C7BB7A File Offset: 0x00C79D7A
		public override bool CheckCanShowView()
		{
			if (!(base.TrackTarget is TTrackTarget_Int))
			{
				return base.CheckCanShowView();
			}
			return CreatureModel.Instance.CheckEntityVisible((TTrackTarget_Int)base.TrackTarget) && base.CheckCanShowView();
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x0602C67D RID: 181885 RVA: 0x00C7BBB4 File Offset: 0x00C79DB4
		public override int MapId
		{
			get
			{
				if (this.MarkType != EMarkType.SoundBox)
				{
					return base.MarkConfig.Value.MapId;
				}
				return MapModel.Instance.CurrentMapConfigId;
			}
		}
	}
}
