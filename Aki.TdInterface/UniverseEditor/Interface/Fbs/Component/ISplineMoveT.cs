using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F91 RID: 24465
	public class ISplineMoveT
	{
		// Token: 0x1700B52E RID: 46382
		// (get) Token: 0x06029246 RID: 168518 RVA: 0x0059E4AF File Offset: 0x0059C6AF
		// (set) Token: 0x06029247 RID: 168519 RVA: 0x0059E4B7 File Offset: 0x0059C6B7
		public List<IEntityStateConditionT> StateConditions { get; set; }

		// Token: 0x1700B52F RID: 46383
		// (get) Token: 0x06029248 RID: 168520 RVA: 0x0059E4C0 File Offset: 0x0059C6C0
		// (set) Token: 0x06029249 RID: 168521 RVA: 0x0059E4C8 File Offset: 0x0059C6C8
		public int Speed { get; set; }

		// Token: 0x1700B530 RID: 46384
		// (get) Token: 0x0602924A RID: 168522 RVA: 0x0059E4D1 File Offset: 0x0059C6D1
		// (set) Token: 0x0602924B RID: 168523 RVA: 0x0059E4D9 File Offset: 0x0059C6D9
		public int SplineEntityId { get; set; }

		// Token: 0x1700B531 RID: 46385
		// (get) Token: 0x0602924C RID: 168524 RVA: 0x0059E4E2 File Offset: 0x0059C6E2
		// (set) Token: 0x0602924D RID: 168525 RVA: 0x0059E4EA File Offset: 0x0059C6EA
		public bool IsCircle { get; set; }

		// Token: 0x1700B532 RID: 46386
		// (get) Token: 0x0602924E RID: 168526 RVA: 0x0059E4F3 File Offset: 0x0059C6F3
		// (set) Token: 0x0602924F RID: 168527 RVA: 0x0059E4FB File Offset: 0x0059C6FB
		public bool IsLookDir { get; set; }

		// Token: 0x1700B533 RID: 46387
		// (get) Token: 0x06029250 RID: 168528 RVA: 0x0059E504 File Offset: 0x0059C704
		// (set) Token: 0x06029251 RID: 168529 RVA: 0x0059E50C File Offset: 0x0059C70C
		public byte NullMask { get; set; }

		// Token: 0x06029252 RID: 168530 RVA: 0x0059E515 File Offset: 0x0059C715
		public ISplineMoveT()
		{
			this.StateConditions = null;
			this.Speed = 0;
			this.SplineEntityId = 0;
			this.IsCircle = false;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
