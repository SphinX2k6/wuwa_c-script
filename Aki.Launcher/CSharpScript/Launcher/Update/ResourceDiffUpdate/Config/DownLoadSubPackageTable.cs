using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000AF RID: 175
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DownLoadSubPackageTable : TableReader<DownLoadSubPackageRow>
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00036764 File Offset: 0x00034964
		protected override string GetTableName()
		{
			return "DownLoadSubPackage";
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0003676B File Offset: 0x0003496B
		protected override string GetDbFile()
		{
			return "db_download.db";
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00036772 File Offset: 0x00034972
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0003677C File Offset: 0x0003497C
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
			downLoadSubPackageRow.Type = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(10);
			downLoadSubPackageRow.BelongBranch = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 1);
			downLoadSubPackageRow.Area = new List<int>(TableReaderUtil.ReadArray<int>(12, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			num2 = table.__offset(14);
			downLoadSubPackageRow.BelongKey = (num2 != 0 && byteBuffer.Get(num + num2) > 0);
			num2 = table.__offset(16);
			downLoadSubPackageRow.Title = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			return downLoadSubPackageRow;
		}
	}
}
