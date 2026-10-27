using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200552A RID: 21802
	public class VillageInfrTreeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A9D RID: 227997 RVA: 0x00D36693 File Offset: 0x00D34893
		[NullableContext(1)]
		public VillageInfrTreeMarkItemView(VillageInfrTreeMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x06037A9E RID: 227998 RVA: 0x00D3669C File Offset: 0x00D3489C
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataChange));
		}

		// Token: 0x06037A9F RID: 227999 RVA: 0x00D366BA File Offset: 0x00D348BA
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataChange));
		}

		// Token: 0x06037AA0 RID: 228000 RVA: 0x00D366D8 File Offset: 0x00D348D8
		private void OnTreeDataChange()
		{
			(this.Holder as VillageInfrTreeMarkItem).UpdateGamePlayState();
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}
	}
}
