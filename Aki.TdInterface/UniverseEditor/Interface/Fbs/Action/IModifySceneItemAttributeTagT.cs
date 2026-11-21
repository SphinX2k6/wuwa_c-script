using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FF RID: 29183
	public class IModifySceneItemAttributeTagT
	{
		// Token: 0x1700D59A RID: 54682
		// (get) Token: 0x06032C4E RID: 207950 RVA: 0x006DB785 File Offset: 0x006D9985
		// (set) Token: 0x06032C4F RID: 207951 RVA: 0x006DB78D File Offset: 0x006D998D
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700D59B RID: 54683
		// (get) Token: 0x06032C50 RID: 207952 RVA: 0x006DB796 File Offset: 0x006D9996
		// (set) Token: 0x06032C51 RID: 207953 RVA: 0x006DB79E File Offset: 0x006D999E
		public bool IsAddTag { get; set; }

		// Token: 0x1700D59C RID: 54684
		// (get) Token: 0x06032C52 RID: 207954 RVA: 0x006DB7A7 File Offset: 0x006D99A7
		// (set) Token: 0x06032C53 RID: 207955 RVA: 0x006DB7AF File Offset: 0x006D99AF
		public List<int> PerformanceTag { get; set; }

		// Token: 0x06032C54 RID: 207956 RVA: 0x006DB7B8 File Offset: 0x006D99B8
		public IModifySceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
		}
	}
}
