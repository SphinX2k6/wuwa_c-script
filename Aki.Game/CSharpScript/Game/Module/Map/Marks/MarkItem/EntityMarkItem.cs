using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E2 RID: 21730
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityMarkItem : ConfigMarkItem
	{
		// Token: 0x060377BC RID: 227260 RVA: 0x00D2DA47 File Offset: 0x00D2BC47
		public EntityMarkItem(int markId, MapMark markConfig, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(ETrackSource.MapMark))
		{
			base.TrackTarget = trackTarget;
		}

		// Token: 0x060377BD RID: 227261 RVA: 0x00D2DA64 File Offset: 0x00D2BC64
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EntityMarkItemView;
		}

		// Token: 0x060377BE RID: 227262 RVA: 0x00D2DA68 File Offset: 0x00D2BC68
		protected override MarkItemView CreateView()
		{
			return new EntityMarkItemView(this);
		}

		// Token: 0x060377BF RID: 227263 RVA: 0x00D2DA70 File Offset: 0x00D2BC70
		protected override void InitPosition()
		{
			if (base.TrackTarget == null)
			{
				base.SetTrackData(MapModel.Instance.GetConfigMarkTrackTarget(this.MarkId));
			}
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377C0 RID: 227264 RVA: 0x00D2DA96 File Offset: 0x00D2BC96
		public override bool CheckCanShowView()
		{
			if (!(base.TrackTarget is TTrackTarget_Int))
			{
				return base.CheckCanShowView();
			}
			return CreatureModel.Instance.CheckEntityVisible((TTrackTarget_Int)base.TrackTarget) && base.CheckCanShowView();
		}

		// Token: 0x17008539 RID: 34105
		// (get) Token: 0x060377C1 RID: 227265 RVA: 0x00D2DAD0 File Offset: 0x00D2BCD0
		public override int MapId
		{
			get
			{
				if (this.MarkType != EMarkType.SoundBox)
				{
					return this.MarkConfig.Value.MapId;
				}
				return MapModel.Instance.CurrentMapConfigId;
			}
		}
	}
}
