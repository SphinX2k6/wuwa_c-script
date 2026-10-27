using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D5 RID: 2517
	public class ConfigTetrisById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x001A7D3B File Offset: 0x001A5F3B
		static ConfigTetrisById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisById.CreateStaticDefaultValue), new Action(ConfigTetrisById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x001A7D5C File Offset: 0x001A5F5C
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "Tetris"),
				new ValueTuple<string, object>("语句", "select BinData from `Tetris` where Id=?")
			});
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x001A7DDB File Offset: 0x001A5FDB
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisById.LogPair = null;
			ConfigTetrisById.HandleId = 0;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001A7DE9 File Offset: 0x001A5FE9
		public static void Init()
		{
			ConfigTetrisById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisById.HandleId, "db_tetris.db", "select BinData from `Tetris` where Id=?");
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x001A7E04 File Offset: 0x001A6004
		public static Tetris? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisById.HandleId, ConfigTetrisById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Tetris?(Tetris.GetRootAsTetris(configBuffer));
				}
			}
			ConfigTetrisById.LogPair.Clear();
			ConfigTetrisById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisById.HandleId, 1, p0Id, ConfigTetrisById.LogPair) || ConfigCommon.Step(ConfigTetrisById.HandleId, true, ConfigTetrisById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisById.HandleId, ConfigTetrisById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisById.HandleId, 0, ConfigTetrisById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisById.HandleId, ConfigTetrisById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Tetris rootAsTetris = Tetris.GetRootAsTetris(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisById.HandleId, ConfigTetrisById.LogPair);
			return new Tetris?(rootAsTetris);
		}

		// Token: 0x040044B9 RID: 17593
		private const string DB = "db_tetris.db";

		// Token: 0x040044BA RID: 17594
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044BB RID: 17595
		private const string TABLE = "Tetris";

		// Token: 0x040044BC RID: 17596
		private const string COMMAND = "select BinData from `Tetris` where Id=?";

		// Token: 0x040044BD RID: 17597
		private const string KEY_PREFIX = "TetrisById";

		// Token: 0x040044BE RID: 17598
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044BF RID: 17599
		private static int HandleId;
	}
}
