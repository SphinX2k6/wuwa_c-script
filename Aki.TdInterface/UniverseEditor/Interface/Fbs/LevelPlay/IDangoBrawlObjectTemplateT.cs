using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004462 RID: 17506
	public class IDangoBrawlObjectTemplateT
	{
		// Token: 0x17007B89 RID: 31625
		// (get) Token: 0x0601A162 RID: 106850 RVA: 0x003BA470 File Offset: 0x003B8670
		// (set) Token: 0x0601A163 RID: 106851 RVA: 0x003BA478 File Offset: 0x003B8678
		public int Id { get; set; }

		// Token: 0x17007B8A RID: 31626
		// (get) Token: 0x0601A164 RID: 106852 RVA: 0x003BA481 File Offset: 0x003B8681
		// (set) Token: 0x0601A165 RID: 106853 RVA: 0x003BA489 File Offset: 0x003B8689
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x17007B8B RID: 31627
		// (get) Token: 0x0601A166 RID: 106854 RVA: 0x003BA492 File Offset: 0x003B8692
		// (set) Token: 0x0601A167 RID: 106855 RVA: 0x003BA49A File Offset: 0x003B869A
		public int DataId { get; set; }

		// Token: 0x17007B8C RID: 31628
		// (get) Token: 0x0601A168 RID: 106856 RVA: 0x003BA4A3 File Offset: 0x003B86A3
		// (set) Token: 0x0601A169 RID: 106857 RVA: 0x003BA4AB File Offset: 0x003B86AB
		public IVector2T LinkCenterOffset { get; set; }

		// Token: 0x17007B8D RID: 31629
		// (get) Token: 0x0601A16A RID: 106858 RVA: 0x003BA4B4 File Offset: 0x003B86B4
		// (set) Token: 0x0601A16B RID: 106859 RVA: 0x003BA4BC File Offset: 0x003B86BC
		public List<IIntVector2T> ShapeCells { get; set; }

		// Token: 0x17007B8E RID: 31630
		// (get) Token: 0x0601A16C RID: 106860 RVA: 0x003BA4C5 File Offset: 0x003B86C5
		// (set) Token: 0x0601A16D RID: 106861 RVA: 0x003BA4CD File Offset: 0x003B86CD
		public List<IIntVector2T> StarCells { get; set; }

		// Token: 0x17007B8F RID: 31631
		// (get) Token: 0x0601A16E RID: 106862 RVA: 0x003BA4D6 File Offset: 0x003B86D6
		// (set) Token: 0x0601A16F RID: 106863 RVA: 0x003BA4DE File Offset: 0x003B86DE
		public byte NullMask { get; set; }

		// Token: 0x0601A170 RID: 106864 RVA: 0x003BA4E7 File Offset: 0x003B86E7
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
