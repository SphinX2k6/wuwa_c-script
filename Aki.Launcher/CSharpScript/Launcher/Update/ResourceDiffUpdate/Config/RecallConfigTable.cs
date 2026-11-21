using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BF RID: 191
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecallConfigTable : TableReader<RecallConfigRow>
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x00038A24 File Offset: 0x00036C24
		protected override string GetTableName()
		{
			return "RecallConfig";
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00038A2B File Offset: 0x00036C2B
		protected override string GetDbFile()
		{
			return "db_questrecall.db";
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00038A32 File Offset: 0x00036C32
		protected override string GetIdString()
		{
			return "RecallId";
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00038A3C File Offset: 0x00036C3C
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
