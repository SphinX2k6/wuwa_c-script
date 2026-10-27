using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B8 RID: 184
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestRefVideoConfigTable : TableReader<QuestRefVideoConfigRow>
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00036D6D File Offset: 0x00034F6D
		protected override string GetTableName()
		{
			return "QuestRefVideoConfig";
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00036D74 File Offset: 0x00034F74
		protected override string GetDbFile()
		{
			return "db_questrefvideo.db";
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00036D7B File Offset: 0x00034F7B
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00036D84 File Offset: 0x00034F84
		public override QuestRefVideoConfigRow Parse(ByteBuffer byteBuffer)
		{
			QuestRefVideoConfigRow questRefVideoConfigRow = new QuestRefVideoConfigRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			questRefVideoConfigRow.Id = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			questRefVideoConfigRow.QuestId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(8);
			questRefVideoConfigRow.GirlOrBoy = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(10);
			questRefVideoConfigRow.PakName = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			return questRefVideoConfigRow;
		}
	}
}
