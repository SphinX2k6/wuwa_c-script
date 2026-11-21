using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RefResourceQuestListTable : TableReader<RefResourceQuestListRow>
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00038964 File Offset: 0x00036B64
		protected override string GetTableName()
		{
			return "RefResourceQuestList";
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0003896B File Offset: 0x00036B6B
		protected override string GetDbFile()
		{
			return "db_refresourcequestlist.db";
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00038972 File Offset: 0x00036B72
		protected override string GetIdString()
		{
			return "BitId";
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0003897C File Offset: 0x00036B7C
		public override RefResourceQuestListRow Parse(ByteBuffer byteBuffer)
		{
			RefResourceQuestListRow refResourceQuestListRow = new RefResourceQuestListRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			refResourceQuestListRow.BitId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			refResourceQuestListRow.QuestId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(8);
			refResourceQuestListRow.HasRefResource = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			return refResourceQuestListRow;
		}
	}
}
