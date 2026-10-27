using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B1 RID: 177
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DungeonPackInfoTable : TableReader<DungeonPackInfoRow>
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x000368E2 File Offset: 0x00034AE2
		protected override string GetTableName()
		{
			return "DungeonPackInfo";
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000368E9 File Offset: 0x00034AE9
		protected override string GetDbFile()
		{
			return "db_dungeonpackinfo.db";
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000368F0 File Offset: 0x00034AF0
		protected override string GetIdString()
		{
			return "DungeonId";
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000368F8 File Offset: 0x00034AF8
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
