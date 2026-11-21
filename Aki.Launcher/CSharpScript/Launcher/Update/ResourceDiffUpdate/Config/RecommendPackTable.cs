using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C1 RID: 193
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecommendPackTable : TableReader<RecommendPackRow>
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x00038AE5 File Offset: 0x00036CE5
		protected override string GetTableName()
		{
			return "RecommendPack";
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00038AEC File Offset: 0x00036CEC
		protected override string GetDbFile()
		{
			return "db_download.db";
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00038AF3 File Offset: 0x00036CF3
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00038AFC File Offset: 0x00036CFC
		public override RecommendPackRow Parse(ByteBuffer byteBuffer)
		{
			RecommendPackRow recommendPackRow = new RecommendPackRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			recommendPackRow.Id = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			recommendPackRow.FinishQuest = new List<int>(TableReaderUtil.ReadArray<int>(6, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			recommendPackRow.UnfinishQuest = new List<int>(TableReaderUtil.ReadArray<int>(8, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			recommendPackRow.Source = new List<int>(TableReaderUtil.ReadArray<int>(10, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			recommendPackRow.VideoQuestId = new List<int>(TableReaderUtil.ReadArray<int>(12, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			return recommendPackRow;
		}
	}
}
