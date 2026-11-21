using System;
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
	public class MapBlockInfoTable : TableReader<MapBlockInfoRow>
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x0003854E File Offset: 0x0003674E
		protected override string GetTableName()
		{
			return "MapBlockInfo";
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00038555 File Offset: 0x00036755
		protected override string GetDbFile()
		{
			return "db_download.db";
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0003855C File Offset: 0x0003675C
		protected override string GetIdString()
		{
			return "BlockId";
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00038564 File Offset: 0x00036764
		public override MapBlockInfoRow Parse(ByteBuffer byteBuffer)
		{
			MapBlockInfoRow mapBlockInfoRow = new MapBlockInfoRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			mapBlockInfoRow.BlockId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			mapBlockInfoRow.MapId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(8);
			mapBlockInfoRow.PackName = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			num2 = table.__offset(14);
			int num3 = (num2 != 0) ? table.__vector_len(num2) : 0;
			for (int i = 0; i < num3; i++)
			{
				int num4 = table.__indirect(table.__vector(num2) + i * 4);
				Table table2 = new Table(num4, byteBuffer);
				int num5 = table2.__offset(4);
				int num6 = table2.__offset(6);
				int num7 = (num5 != 0) ? byteBuffer.GetInt(num4 + num5) : 0;
				int num8 = (num6 != 0) ? byteBuffer.GetInt(num4 + num6) : 0;
				mapBlockInfoRow.RegionBoxes.Add(new Vector2D((float)num7, (float)num8));
			}
			return mapBlockInfoRow;
		}
	}
}
