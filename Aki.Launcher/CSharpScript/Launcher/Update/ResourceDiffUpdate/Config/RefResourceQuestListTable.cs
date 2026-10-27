using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000BA RID: 186
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RefResourceQuestListTable : TableReader<RefResourceQuestListRow>
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00036E64 File Offset: 0x00035064
		protected override string GetTableName()
		{
			return "RefResourceQuestList";
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00036E6B File Offset: 0x0003506B
		protected override string GetDbFile()
		{
			return "db_refresourcequestlist.db";
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00036E72 File Offset: 0x00035072
		protected override string GetIdString()
		{
			return "BitId";
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00036E7C File Offset: 0x0003507C
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
