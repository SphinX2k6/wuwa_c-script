using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD0 RID: 27856
	public class IPieceIndexT
	{
		// Token: 0x1700CF65 RID: 53093
		// (get) Token: 0x06031191 RID: 201105 RVA: 0x006A9978 File Offset: 0x006A7B78
		// (set) Token: 0x06031192 RID: 201106 RVA: 0x006A9980 File Offset: 0x006A7B80
		public int RowIndex { get; set; }

		// Token: 0x1700CF66 RID: 53094
		// (get) Token: 0x06031193 RID: 201107 RVA: 0x006A9989 File Offset: 0x006A7B89
		// (set) Token: 0x06031194 RID: 201108 RVA: 0x006A9991 File Offset: 0x006A7B91
		public int ColumnIndex { get; set; }

		// Token: 0x06031195 RID: 201109 RVA: 0x006A999A File Offset: 0x006A7B9A
		public IPieceIndexT()
		{
			this.RowIndex = 0;
			this.ColumnIndex = 0;
		}
	}
}
