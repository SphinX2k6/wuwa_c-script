using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BC RID: 188
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecallConfigTable : TableReader<RecallConfigRow>
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00036F24 File Offset: 0x00035124
		protected override string GetTableName()
		{
			return "RecallConfig";
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00036F2B File Offset: 0x0003512B
		protected override string GetDbFile()
		{
			return "db_questrecall.db";
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00036F32 File Offset: 0x00035132
		protected override string GetIdString()
		{
			return "RecallId";
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00036F3C File Offset: 0x0003513C
		public override RecallConfigRow Parse(ByteBuffer byteBuffer)
		{
			RecallConfigRow recallConfigRow = new RecallConfigRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			recallConfigRow.RecallId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			recallConfigRow.QuestIds = new List<int>(TableReaderUtil.ReadArray<int>(8, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			return recallConfigRow;
		}
	}
}
