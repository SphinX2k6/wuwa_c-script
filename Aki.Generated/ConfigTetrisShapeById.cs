using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DB RID: 2523
	public class ConfigTetrisShapeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B36 RID: 15158 RVA: 0x001A8A1F File Offset: 0x001A6C1F
		static ConfigTetrisShapeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeById.CreateStaticDefaultValue), new Action(ConfigTetrisShapeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x001A8A40 File Offset: 0x001A6C40
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisShapeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisShapeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisShape"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisShape` where Id=?")
			});
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x001A8ABF File Offset: 0x001A6CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeById.LogPair = null;
			ConfigTetrisShapeById.HandleId = 0;
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x001A8ACD File Offset: 0x001A6CCD
		public static void Init()
		{
			ConfigTetrisShapeById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeById.HandleId, "db_tetris.db", "select BinData from `TetrisShape` where Id=?");
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x001A8AE8 File Offset: 0x001A6CE8
		public static TetrisShape? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TetrisShape?(TetrisShape.GetRootAsTetrisShape(configBuffer));
				}
			}
			ConfigTetrisShapeById.LogPair.Clear();
			ConfigTetrisShapeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisShapeById.HandleId, 1, p0Id, ConfigTetrisShapeById.LogPair) || ConfigCommon.Step(ConfigTetrisShapeById.HandleId, true, ConfigTetrisShapeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisShapeById.HandleId, 0, ConfigTetrisShapeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisShape rootAsTetrisShape = TetrisShape.GetRootAsTetrisShape(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
			return new TetrisShape?(rootAsTetrisShape);
		}

		// Token: 0x040044E3 RID: 17635
		private const string DB = "db_tetris.db";

		// Token: 0x040044E4 RID: 17636
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044E5 RID: 17637
		private const string TABLE = "TetrisShape";

		// Token: 0x040044E6 RID: 17638
		private const string COMMAND = "select BinData from `TetrisShape` where Id=?";

		// Token: 0x040044E7 RID: 17639
		private const string KEY_PREFIX = "TetrisShapeById";

		// Token: 0x040044E8 RID: 17640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044E9 RID: 17641
		private static int HandleId;
	}
}
