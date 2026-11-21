using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044FA RID: 17658
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxDetectorMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C965 RID: 182629 RVA: 0x00C84303 File Offset: 0x00C82503
		public TreasureBoxDetectorMarkItemView(TreasureBoxDetectorMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C966 RID: 182630 RVA: 0x00C84317 File Offset: 0x00C82517
		protected override void OnViewRefresh()
		{
			this.TreasureBoxDetectorItemRangeHandle.SetVisible(true);
		}

		// Token: 0x0602C967 RID: 182631 RVA: 0x00C84325 File Offset: 0x00C82525
		protected override void CreateComponentHandles()
		{
			base.CreateComponentHandles();
			this.TreasureBoxDetectorItemRangeHandle = this.CreateDetectorRangeHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Range] = this.TreasureBoxDetectorItemRangeHandle;
		}

		// Token: 0x0602C968 RID: 182632 RVA: 0x00C84351 File Offset: 0x00C82551
		private TreasureBoxDetectorItemRangeHandle CreateDetectorRangeHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TreasureBoxDetectorItemRangeHandle(markComponentContext);
		}

		// Token: 0x0602C969 RID: 182633 RVA: 0x00C8435C File Offset: 0x00C8255C
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

		// Token: 0x04017EB4 RID: 97972
		private readonly Vector TempRangeScale = Vector.Create();

		// Token: 0x04017EB5 RID: 97973
		private TreasureBoxDetectorItemRangeHandle TreasureBoxDetectorItemRangeHandle;
	}
}
