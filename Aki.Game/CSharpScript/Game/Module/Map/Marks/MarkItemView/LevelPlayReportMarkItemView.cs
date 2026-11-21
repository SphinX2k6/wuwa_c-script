using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E9 RID: 17641
	public class LevelPlayReportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C8AD RID: 182445 RVA: 0x00C81DF5 File Offset: 0x00C7FFF5
		[NullableContext(1)]
		public LevelPlayReportMarkItemView(LevelPlayReportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C8AE RID: 182446 RVA: 0x00C81DFE File Offset: 0x00C7FFFE
		public override void RefreshGamePlayStateView()
		{
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}

		// Token: 0x0602C8AF RID: 182447 RVA: 0x00C81E16 File Offset: 0x00C80016
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x0602C8B0 RID: 182448 RVA: 0x00C81E1E File Offset: 0x00C8001E
		public override void UpdateIcon()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			base.MarkItemTopRightIconHandle.Update();
		}
	}
}
