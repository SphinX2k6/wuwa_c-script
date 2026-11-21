using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02003F64 RID: 16228
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestStateUpdateData
	{
		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x0602915F RID: 168287 RVA: 0x00B89D9F File Offset: 0x00B87F9F
		// (set) Token: 0x06029160 RID: 168288 RVA: 0x00B89DA7 File Offset: 0x00B87FA7
		public int QuestId { get; set; }

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x06029161 RID: 168289 RVA: 0x00B89DB0 File Offset: 0x00B87FB0
		// (set) Token: 0x06029162 RID: 168290 RVA: 0x00B89DB8 File Offset: 0x00B87FB8
		public QuestState State { get; set; }

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x06029163 RID: 168291 RVA: 0x00B89DC1 File Offset: 0x00B87FC1
		// (set) Token: 0x06029164 RID: 168292 RVA: 0x00B89DC9 File Offset: 0x00B87FC9
		public EQuestStatusUpdateReason UpdateReason { get; set; }

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x06029165 RID: 168293 RVA: 0x00B89DD2 File Offset: 0x00B87FD2
		// (set) Token: 0x06029166 RID: 168294 RVA: 0x00B89DDA File Offset: 0x00B87FDA
		public Action OnAfterUpdate { get; set; }
	}
}
