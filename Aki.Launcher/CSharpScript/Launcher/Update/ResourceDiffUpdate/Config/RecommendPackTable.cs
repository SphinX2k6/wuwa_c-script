using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BE RID: 190
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecommendPackTable : TableReader<RecommendPackRow>
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x00036FE5 File Offset: 0x000351E5
		protected override string GetTableName()
		{
			return "RecommendPack";
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00036FEC File Offset: 0x000351EC
		protected override string GetDbFile()
		{
			return "db_download.db";
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00036FF3 File Offset: 0x000351F3
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00036FFC File Offset: 0x000351FC
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
