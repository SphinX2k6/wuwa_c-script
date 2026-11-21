using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DownLoadSubPackageTable : TableReader<DownLoadSubPackageRow>
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00038244 File Offset: 0x00036444
		protected override string GetTableName()
		{
			return "DownLoadSubPackage";
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0003824B File Offset: 0x0003644B
		protected override string GetDbFile()
		{
			return "db_download.db";
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00038252 File Offset: 0x00036452
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0003825C File Offset: 0x0003645C
		public override DownLoadSubPackageRow Parse(ByteBuffer byteBuffer)
		{
			DownLoadSubPackageRow downLoadSubPackageRow = new DownLoadSubPackageRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			downLoadSubPackageRow.Id = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			downLoadSubPackageRow.Version = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(8);
			downLoadSubPackageRow.SortId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(10);
			downLoadSubPackageRow.Type = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(12);
			downLoadSubPackageRow.BelongBranch = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 1);
			downLoadSubPackageRow.Area = new List<int>(TableReaderUtil.ReadArray<int>(14, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			num2 = table.__offset(16);
			downLoadSubPackageRow.BelongKey = (num2 != 0 && byteBuffer.Get(num + num2) > 0);
			num2 = table.__offset(18);
			downLoadSubPackageRow.Title = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			return downLoadSubPackageRow;
		}
	}
}
