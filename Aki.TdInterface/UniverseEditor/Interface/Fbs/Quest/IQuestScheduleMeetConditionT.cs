using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446A RID: 17514
	public class IQuestScheduleMeetConditionT
	{
		// Token: 0x1700798F RID: 31119
		// (get) Token: 0x0601929D RID: 103069 RVA: 0x003971C9 File Offset: 0x003953C9
		// (set) Token: 0x0601929E RID: 103070 RVA: 0x003971D1 File Offset: 0x003953D1
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007990 RID: 31120
		// (get) Token: 0x0601929F RID: 103071 RVA: 0x003971DA File Offset: 0x003953DA
		// (set) Token: 0x060192A0 RID: 103072 RVA: 0x003971E2 File Offset: 0x003953E2
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007991 RID: 31121
		// (get) Token: 0x060192A1 RID: 103073 RVA: 0x003971EB File Offset: 0x003953EB
		// (set) Token: 0x060192A2 RID: 103074 RVA: 0x003971F3 File Offset: 0x003953F3
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x17007992 RID: 31122
		// (get) Token: 0x060192A3 RID: 103075 RVA: 0x003971FC File Offset: 0x003953FC
		// (set) Token: 0x060192A4 RID: 103076 RVA: 0x00397204 File Offset: 0x00395404
		public ETimeLeftIconType IconType { get; set; }

		// Token: 0x17007993 RID: 31123
		// (get) Token: 0x060192A5 RID: 103077 RVA: 0x0039720D File Offset: 0x0039540D
		// (set) Token: 0x060192A6 RID: 103078 RVA: 0x00397215 File Offset: 0x00395415
		public byte NullMask { get; set; }

		// Token: 0x060192A7 RID: 103079 RVA: 0x0039721E File Offset: 0x0039541E
		public IQuestScheduleMeetConditionT()
		{
			this.Type = EQuestScheduleType.None;
			this.Condition = null;
			this.Vars = null;
			this.IconType = ETimeLeftIconType.AkiWorld;
			this.NullMask = 0;
		}
	}
}
