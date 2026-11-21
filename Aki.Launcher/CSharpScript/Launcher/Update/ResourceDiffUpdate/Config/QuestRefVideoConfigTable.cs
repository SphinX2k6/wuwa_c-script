using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BB RID: 187
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class QuestRefVideoConfigTable : TableReader<QuestRefVideoConfigRow>
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x0003886D File Offset: 0x00036A6D
		protected override string GetTableName()
		{
			return "QuestRefVideoConfig";
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00038874 File Offset: 0x00036A74
		protected override string GetDbFile()
		{
			return "db_questrefvideo.db";
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0003887B File Offset: 0x00036A7B
		protected override string GetIdString()
		{
			return "Id";
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00038884 File Offset: 0x00036A84
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
