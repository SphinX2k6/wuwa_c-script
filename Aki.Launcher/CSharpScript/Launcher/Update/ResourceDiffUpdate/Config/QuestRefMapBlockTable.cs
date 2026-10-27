using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B6 RID: 182
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestRefMapBlockTable : TableReader<QuestRefMapBlockRow>
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00036CAE File Offset: 0x00034EAE
		protected override string GetTableName()
		{
			return "QuestRefMapBlockConfig";
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00036CB5 File Offset: 0x00034EB5
		protected override string GetDbFile()
		{
			return "db_questrefmapblock.db";
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00036CBC File Offset: 0x00034EBC
		protected override string GetIdString()
		{
			return "QuestId";
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00036CC4 File Offset: 0x00034EC4
		public override QuestRefMapBlockRow Parse(ByteBuffer byteBuffer)
		{
			QuestRefMapBlockRow questRefMapBlockRow = new QuestRefMapBlockRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			questRefMapBlockRow.QuestId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			questRefMapBlockRow.MapBlockId = new List<int>(TableReaderUtil.ReadArray<int>(6, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			return questRefMapBlockRow;
		}
	}
}
