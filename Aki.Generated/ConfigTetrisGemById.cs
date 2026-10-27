using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D6 RID: 2518
	public class ConfigTetrisGemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B18 RID: 15128 RVA: 0x001A7F84 File Offset: 0x001A6184
		static ConfigTetrisGemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisGemById.CreateStaticDefaultValue), new Action(ConfigTetrisGemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001A7FA4 File Offset: 0x001A61A4
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisGemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisGemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisGem"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisGem` where Id=?")
			});
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x001A8023 File Offset: 0x001A6223
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisGemById.LogPair = null;
			ConfigTetrisGemById.HandleId = 0;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001A8031 File Offset: 0x001A6231
		public static void Init()
		{
			ConfigTetrisGemById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisGemById.HandleId, "db_tetris.db", "select BinData from `TetrisGem` where Id=?");
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x001A804C File Offset: 0x001A624C
		public static TetrisGem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisGemById.HandleId, ConfigTetrisGemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisGemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TetrisGem?(TetrisGem.GetRootAsTetrisGem(configBuffer));
				}
			}
			ConfigTetrisGemById.LogPair.Clear();
			ConfigTetrisGemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisGemById.HandleId, 1, p0Id, ConfigTetrisGemById.LogPair) || ConfigCommon.Step(ConfigTetrisGemById.HandleId, true, ConfigTetrisGemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisGemById.HandleId, ConfigTetrisGemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisGemById.HandleId, 0, ConfigTetrisGemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisGemById.HandleId, ConfigTetrisGemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisGem rootAsTetrisGem = TetrisGem.GetRootAsTetrisGem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisGemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisGemById.HandleId, ConfigTetrisGemById.LogPair);
			return new TetrisGem?(rootAsTetrisGem);
		}

		// Token: 0x040044C0 RID: 17600
		private const string DB = "db_tetris.db";

		// Token: 0x040044C1 RID: 17601
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044C2 RID: 17602
		private const string TABLE = "TetrisGem";

		// Token: 0x040044C3 RID: 17603
		private const string COMMAND = "select BinData from `TetrisGem` where Id=?";

		// Token: 0x040044C4 RID: 17604
		private const string KEY_PREFIX = "TetrisGemById";

		// Token: 0x040044C5 RID: 17605
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044C6 RID: 17606
		private static int HandleId;
	}
}
