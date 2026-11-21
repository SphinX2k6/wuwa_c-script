using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B4 RID: 180
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DungeonPackInfoTable : TableReader<DungeonPackInfoRow>
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x000383E1 File Offset: 0x000365E1
		protected override string GetTableName()
		{
			return "DungeonPackInfo";
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000383E8 File Offset: 0x000365E8
		protected override string GetDbFile()
		{
			return "db_dungeonpackinfo.db";
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000383EF File Offset: 0x000365EF
		protected override string GetIdString()
		{
			return "DungeonId";
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000383F8 File Offset: 0x000365F8
		public override DungeonPackInfoRow Parse(ByteBuffer byteBuffer)
		{
			DungeonPackInfoRow dungeonPackInfoRow = new DungeonPackInfoRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			dungeonPackInfoRow.DungeonId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			dungeonPackInfoRow.Umap = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			dungeonPackInfoRow.OwnerBlockIds = new List<int>(TableReaderUtil.ReadArray<int>(8, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			num2 = table.__offset(10);
			dungeonPackInfoRow.BlockPakName = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			dungeonPackInfoRow.ReachableBlockIds = new List<int>(TableReaderUtil.ReadArray<int>(12, byteBuffer, num, (ByteBuffer bb, int pos) => bb.GetInt(pos)));
			return dungeonPackInfoRow;
		}
	}
}
