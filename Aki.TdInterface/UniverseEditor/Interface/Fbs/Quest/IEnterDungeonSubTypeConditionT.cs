using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E01 RID: 15873
	public class IEnterDungeonSubTypeConditionT
	{
		// Token: 0x17006DB3 RID: 28083
		// (get) Token: 0x06016347 RID: 90951 RVA: 0x00334D94 File Offset: 0x00332F94
		// (set) Token: 0x06016348 RID: 90952 RVA: 0x00334D9C File Offset: 0x00332F9C
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17006DB4 RID: 28084
		// (get) Token: 0x06016349 RID: 90953 RVA: 0x00334DA5 File Offset: 0x00332FA5
		// (set) Token: 0x0601634A RID: 90954 RVA: 0x00334DAD File Offset: 0x00332FAD
		public EDungeonSubType DungeonSubType { get; set; }

		// Token: 0x0601634B RID: 90955 RVA: 0x00334DB6 File Offset: 0x00332FB6
		public IEnterDungeonSubTypeConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.DungeonSubType = EDungeonSubType.Test;
		}
	}
}
