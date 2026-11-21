using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E7 RID: 17639
	public class InfrRoadMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C8A2 RID: 182434 RVA: 0x00C81D07 File Offset: 0x00C7FF07
		[NullableContext(1)]
		public InfrRoadMarkItemView(InfrRoadMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C8A3 RID: 182435 RVA: 0x00C81D10 File Offset: 0x00C7FF10
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnRoadDataChange));
		}

		// Token: 0x0602C8A4 RID: 182436 RVA: 0x00C81D2E File Offset: 0x00C7FF2E
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnRoadDataChange));
		}

		// Token: 0x0602C8A5 RID: 182437 RVA: 0x00C81D4C File Offset: 0x00C7FF4C
		private void OnRoadDataChange()
		{
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}
	}
}
