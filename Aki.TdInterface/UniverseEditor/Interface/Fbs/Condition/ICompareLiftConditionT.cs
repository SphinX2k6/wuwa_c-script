using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB1 RID: 19377
	public class ICompareLiftConditionT
	{
		// Token: 0x17008CB0 RID: 36016
		// (get) Token: 0x0601E906 RID: 125190 RVA: 0x004468A8 File Offset: 0x00444AA8
		// (set) Token: 0x0601E907 RID: 125191 RVA: 0x004468B0 File Offset: 0x00444AB0
		public ECondition Type { get; set; }

		// Token: 0x17008CB1 RID: 36017
		// (get) Token: 0x0601E908 RID: 125192 RVA: 0x004468B9 File Offset: 0x00444AB9
		// (set) Token: 0x0601E909 RID: 125193 RVA: 0x004468C1 File Offset: 0x00444AC1
		public bool IsSelf { get; set; }

		// Token: 0x17008CB2 RID: 36018
		// (get) Token: 0x0601E90A RID: 125194 RVA: 0x004468CA File Offset: 0x00444ACA
		// (set) Token: 0x0601E90B RID: 125195 RVA: 0x004468D2 File Offset: 0x00444AD2
		public int EntityId { get; set; }

		// Token: 0x17008CB3 RID: 36019
		// (get) Token: 0x0601E90C RID: 125196 RVA: 0x004468DB File Offset: 0x00444ADB
		// (set) Token: 0x0601E90D RID: 125197 RVA: 0x004468E3 File Offset: 0x00444AE3
		public ECompare Compare { get; set; }

		// Token: 0x17008CB4 RID: 36020
		// (get) Token: 0x0601E90E RID: 125198 RVA: 0x004468EC File Offset: 0x00444AEC
		// (set) Token: 0x0601E90F RID: 125199 RVA: 0x004468F4 File Offset: 0x00444AF4
		public int Location { get; set; }

		// Token: 0x17008CB5 RID: 36021
		// (get) Token: 0x0601E910 RID: 125200 RVA: 0x004468FD File Offset: 0x00444AFD
		// (set) Token: 0x0601E911 RID: 125201 RVA: 0x00446905 File Offset: 0x00444B05
		public byte NullMask { get; set; }

		// Token: 0x0601E912 RID: 125202 RVA: 0x0044690E File Offset: 0x00444B0E
		public ICompareLiftConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSelf = false;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.Location = 0;
			this.NullMask = 0;
		}
	}
}
