using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007208 RID: 29192
	public class IModifySelfSceneItemAttributeTagT
	{
		// Token: 0x1700D5A6 RID: 54694
		// (get) Token: 0x06032C94 RID: 208020 RVA: 0x006DBF7D File Offset: 0x006DA17D
		// (set) Token: 0x06032C95 RID: 208021 RVA: 0x006DBF85 File Offset: 0x006DA185
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700D5A7 RID: 54695
		// (get) Token: 0x06032C96 RID: 208022 RVA: 0x006DBF8E File Offset: 0x006DA18E
		// (set) Token: 0x06032C97 RID: 208023 RVA: 0x006DBF96 File Offset: 0x006DA196
		public bool IsAddTag { get; set; }

		// Token: 0x1700D5A8 RID: 54696
		// (get) Token: 0x06032C98 RID: 208024 RVA: 0x006DBF9F File Offset: 0x006DA19F
		// (set) Token: 0x06032C99 RID: 208025 RVA: 0x006DBFA7 File Offset: 0x006DA1A7
		public List<int> PerformanceTag { get; set; }

		// Token: 0x06032C9A RID: 208026 RVA: 0x006DBFB0 File Offset: 0x006DA1B0
		public IModifySelfSceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
		}
	}
}
