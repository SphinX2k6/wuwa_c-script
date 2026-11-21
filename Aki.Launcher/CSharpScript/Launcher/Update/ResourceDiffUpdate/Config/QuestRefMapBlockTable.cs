using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B9 RID: 185
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestRefMapBlockTable : TableReader<QuestRefMapBlockRow>
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x000387AE File Offset: 0x000369AE
		protected override string GetTableName()
		{
			return "QuestRefMapBlockConfig";
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000387B5 File Offset: 0x000369B5
		protected override string GetDbFile()
		{
			return "db_questrefmapblock.db";
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000387BC File Offset: 0x000369BC
		protected override string GetIdString()
		{
			return "QuestId";
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000387C4 File Offset: 0x000369C4
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
