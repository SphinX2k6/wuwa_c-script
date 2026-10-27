using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005514 RID: 21780
	public class InfrRoadMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379D4 RID: 227796 RVA: 0x00D33E37 File Offset: 0x00D32037
		[NullableContext(1)]
		public InfrRoadMarkItemView(InfrRoadMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x060379D5 RID: 227797 RVA: 0x00D33E40 File Offset: 0x00D32040
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnRoadDataChange));
		}

		// Token: 0x060379D6 RID: 227798 RVA: 0x00D33E5E File Offset: 0x00D3205E
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnRoadDataChange));
		}

		// Token: 0x060379D7 RID: 227799 RVA: 0x00D33E7C File Offset: 0x00D3207C
		private void OnRoadDataChange()
		{
			(this.Holder as InfrRoadMarkItem).UpdateGamePlayState();
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}
	}
}
