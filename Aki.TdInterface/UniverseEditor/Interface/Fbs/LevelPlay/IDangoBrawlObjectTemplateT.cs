using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048CA RID: 18634
	public class IDangoBrawlObjectTemplateT
	{
		// Token: 0x170081C8 RID: 33224
		// (get) Token: 0x0601B933 RID: 112947 RVA: 0x003E667C File Offset: 0x003E487C
		// (set) Token: 0x0601B934 RID: 112948 RVA: 0x003E6684 File Offset: 0x003E4884
		public int Id { get; set; }

		// Token: 0x170081C9 RID: 33225
		// (get) Token: 0x0601B935 RID: 112949 RVA: 0x003E668D File Offset: 0x003E488D
		// (set) Token: 0x0601B936 RID: 112950 RVA: 0x003E6695 File Offset: 0x003E4895
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x170081CA RID: 33226
		// (get) Token: 0x0601B937 RID: 112951 RVA: 0x003E669E File Offset: 0x003E489E
		// (set) Token: 0x0601B938 RID: 112952 RVA: 0x003E66A6 File Offset: 0x003E48A6
		public int DataId { get; set; }

		// Token: 0x170081CB RID: 33227
		// (get) Token: 0x0601B939 RID: 112953 RVA: 0x003E66AF File Offset: 0x003E48AF
		// (set) Token: 0x0601B93A RID: 112954 RVA: 0x003E66B7 File Offset: 0x003E48B7
		public IVector2T LinkCenterOffset { get; set; }

		// Token: 0x170081CC RID: 33228
		// (get) Token: 0x0601B93B RID: 112955 RVA: 0x003E66C0 File Offset: 0x003E48C0
		// (set) Token: 0x0601B93C RID: 112956 RVA: 0x003E66C8 File Offset: 0x003E48C8
		public List<IIntVector2T> ShapeCells { get; set; }

		// Token: 0x170081CD RID: 33229
		// (get) Token: 0x0601B93D RID: 112957 RVA: 0x003E66D1 File Offset: 0x003E48D1
		// (set) Token: 0x0601B93E RID: 112958 RVA: 0x003E66D9 File Offset: 0x003E48D9
		public List<IIntVector2T> StarCells { get; set; }

		// Token: 0x170081CE RID: 33230
		// (get) Token: 0x0601B93F RID: 112959 RVA: 0x003E66E2 File Offset: 0x003E48E2
		// (set) Token: 0x0601B940 RID: 112960 RVA: 0x003E66EA File Offset: 0x003E48EA
		public byte NullMask { get; set; }

		// Token: 0x0601B941 RID: 112961 RVA: 0x003E66F3 File Offset: 0x003E48F3
		public IDangoBrawlObjectTemplateT()
		{
			this.Id = 0;
			this.SubType = EDangoBrawlObjectType.Bag;
			this.DataId = 0;
			this.LinkCenterOffset = null;
			this.ShapeCells = null;
			this.StarCells = null;
			this.NullMask = 0;
		}
	}
}
