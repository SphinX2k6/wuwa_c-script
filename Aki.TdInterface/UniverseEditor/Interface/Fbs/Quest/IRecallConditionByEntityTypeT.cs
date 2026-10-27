using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407A RID: 16506
	public class IRecallConditionByEntityTypeT
	{
		// Token: 0x17007479 RID: 29817
		// (get) Token: 0x06018003 RID: 98307 RVA: 0x0037693A File Offset: 0x00374B3A
		// (set) Token: 0x06018004 RID: 98308 RVA: 0x00376942 File Offset: 0x00374B42
		public ERecallConditionType Type { get; set; }

		// Token: 0x1700747A RID: 29818
		// (get) Token: 0x06018005 RID: 98309 RVA: 0x0037694B File Offset: 0x00374B4B
		// (set) Token: 0x06018006 RID: 98310 RVA: 0x00376953 File Offset: 0x00374B53
		public ERecallOperation Operation { get; set; }

		// Token: 0x1700747B RID: 29819
		// (get) Token: 0x06018007 RID: 98311 RVA: 0x0037695C File Offset: 0x00374B5C
		// (set) Token: 0x06018008 RID: 98312 RVA: 0x00376964 File Offset: 0x00374B64
		public List<string> EntityTypes { get; set; }

		// Token: 0x1700747C RID: 29820
		// (get) Token: 0x06018009 RID: 98313 RVA: 0x0037696D File Offset: 0x00374B6D
		// (set) Token: 0x0601800A RID: 98314 RVA: 0x00376975 File Offset: 0x00374B75
		public List<int> AreaIds { get; set; }

		// Token: 0x0601800B RID: 98315 RVA: 0x0037697E File Offset: 0x00374B7E
		public IRecallConditionByEntityTypeT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.EntityTypes = null;
			this.AreaIds = null;
		}
	}
}
