using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAB RID: 2731
	public class ConfigTetrisGemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004016 RID: 16406 RVA: 0x001C7318 File Offset: 0x001C5518
		static ConfigTetrisGemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisGemById.CreateStaticDefaultValue), new Action(ConfigTetrisGemById.ResetStaticDefaultValue));
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x001C7338 File Offset: 0x001C5538
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

		// Token: 0x06004018 RID: 16408 RVA: 0x001C73B7 File Offset: 0x001C55B7
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisGemById.LogPair = null;
			ConfigTetrisGemById.HandleId = 0;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x001C73C5 File Offset: 0x001C55C5
		public static void Init()
		{
			ConfigTetrisGemById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisGemById.HandleId, "db_tetris.db", "select BinData from `TetrisGem` where Id=?");
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x001C73E0 File Offset: 0x001C55E0
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

		// Token: 0x04004A93 RID: 19091
		private const string DB = "db_tetris.db";

		// Token: 0x04004A94 RID: 19092
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004A95 RID: 19093
		private const string TABLE = "TetrisGem";

		// Token: 0x04004A96 RID: 19094
		private const string COMMAND = "select BinData from `TetrisGem` where Id=?";

		// Token: 0x04004A97 RID: 19095
		private const string KEY_PREFIX = "TetrisGemById";

		// Token: 0x04004A98 RID: 19096
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A99 RID: 19097
		private static int HandleId;
	}
}
