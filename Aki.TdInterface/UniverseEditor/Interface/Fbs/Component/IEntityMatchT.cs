using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005190 RID: 20880
	public class IEntityMatchT
	{
		// Token: 0x1700988F RID: 39055
		// (get) Token: 0x06021C6D RID: 138349 RVA: 0x004AFC0F File Offset: 0x004ADE0F
		// (set) Token: 0x06021C6E RID: 138350 RVA: 0x004AFC17 File Offset: 0x004ADE17
		public bool AllCharacter { get; set; }

		// Token: 0x17009890 RID: 39056
		// (get) Token: 0x06021C6F RID: 138351 RVA: 0x004AFC20 File Offset: 0x004ADE20
		// (set) Token: 0x06021C70 RID: 138352 RVA: 0x004AFC28 File Offset: 0x004ADE28
		public bool OnlyPlayer { get; set; }

		// Token: 0x17009891 RID: 39057
		// (get) Token: 0x06021C71 RID: 138353 RVA: 0x004AFC31 File Offset: 0x004ADE31
		// (set) Token: 0x06021C72 RID: 138354 RVA: 0x004AFC39 File Offset: 0x004ADE39
		public List<IEntityCategoryT> Categories { get; set; }

		// Token: 0x17009892 RID: 39058
		// (get) Token: 0x06021C73 RID: 138355 RVA: 0x004AFC42 File Offset: 0x004ADE42
		// (set) Token: 0x06021C74 RID: 138356 RVA: 0x004AFC4A File Offset: 0x004ADE4A
		public List<int> EntityIds { get; set; }

		// Token: 0x17009893 RID: 39059
		// (get) Token: 0x06021C75 RID: 138357 RVA: 0x004AFC53 File Offset: 0x004ADE53
		// (set) Token: 0x06021C76 RID: 138358 RVA: 0x004AFC5B File Offset: 0x004ADE5B
		public List<IEntityStateT> States { get; set; }

		// Token: 0x17009894 RID: 39060
		// (get) Token: 0x06021C77 RID: 138359 RVA: 0x004AFC64 File Offset: 0x004ADE64
		// (set) Token: 0x06021C78 RID: 138360 RVA: 0x004AFC6C File Offset: 0x004ADE6C
		public List<string> PerformanceStates { get; set; }

		// Token: 0x17009895 RID: 39061
		// (get) Token: 0x06021C79 RID: 138361 RVA: 0x004AFC75 File Offset: 0x004ADE75
		// (set) Token: 0x06021C7A RID: 138362 RVA: 0x004AFC7D File Offset: 0x004ADE7D
		public byte NullMask { get; set; }

		// Token: 0x06021C7B RID: 138363 RVA: 0x004AFC86 File Offset: 0x004ADE86
		public IEntityMatchT()
		{
			this.AllCharacter = false;
			this.OnlyPlayer = false;
			this.Categories = null;
			this.EntityIds = null;
			this.States = null;
			this.PerformanceStates = null;
			this.NullMask = 0;
		}
	}
}
