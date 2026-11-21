using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044FD RID: 17661
	public class VillageInfrTreeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C96D RID: 182637 RVA: 0x00C843BF File Offset: 0x00C825BF
		[NullableContext(1)]
		public VillageInfrTreeMarkItemView(VillageInfrTreeMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C96E RID: 182638 RVA: 0x00C843C8 File Offset: 0x00C825C8
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataChange));
		}

		// Token: 0x0602C96F RID: 182639 RVA: 0x00C843E6 File Offset: 0x00C825E6
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataChange));
		}

		// Token: 0x0602C970 RID: 182640 RVA: 0x00C84404 File Offset: 0x00C82604
		private void OnTreeDataChange()
		{
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}
	}
}
