using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005527 RID: 21799
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxDetectorMarkItemView : ServerMarkItemView
	{
		// Token: 0x06037A95 RID: 227989 RVA: 0x00D365D7 File Offset: 0x00D347D7
		public TreasureBoxDetectorMarkItemView(TreasureBoxDetectorMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A96 RID: 227990 RVA: 0x00D365EB File Offset: 0x00D347EB
		protected override void OnViewRefresh()
		{
			this.TreasureBoxDetectorItemRangeHandle.SetVisible(true);
		}

		// Token: 0x06037A97 RID: 227991 RVA: 0x00D365F9 File Offset: 0x00D347F9
		protected override void CreateComponentHandles()
		{
			base.CreateComponentHandles();
			this.TreasureBoxDetectorItemRangeHandle = this.CreateDetectorRangeHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Range] = this.TreasureBoxDetectorItemRangeHandle;
		}

		// Token: 0x06037A98 RID: 227992 RVA: 0x00D36625 File Offset: 0x00D34825
		private TreasureBoxDetectorItemRangeHandle CreateDetectorRangeHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TreasureBoxDetectorItemRangeHandle(markComponentContext);
		}

		// Token: 0x06037A99 RID: 227993 RVA: 0x00D36630 File Offset: 0x00D34830
		public override void SetScale(float scale)
		{
			if (!base.IsHolderValid())
			{
				return;
			}
			this.TempRangeScale.Set((double)scale, (double)scale, (double)scale);
			this.RootItem.D_SetWorldScale3D(this.TempRangeScale.ToUeVector(false));
			TreasureBoxDetectorItemRangeHandle treasureBoxDetectorItemRangeHandle = this.TreasureBoxDetectorItemRangeHandle;
			if (treasureBoxDetectorItemRangeHandle == null)
			{
				return;
			}
			treasureBoxDetectorItemRangeHandle.UpdateRangeScale();
		}

		// Token: 0x0401D431 RID: 119857
		private readonly Vector TempRangeScale = Vector.Create();

		// Token: 0x0401D432 RID: 119858
		private TreasureBoxDetectorItemRangeHandle TreasureBoxDetectorItemRangeHandle;
	}
}
