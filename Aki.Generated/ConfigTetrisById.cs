using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAA RID: 2730
	public class ConfigTetrisById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x001C70CF File Offset: 0x001C52CF
		static ConfigTetrisById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisById.CreateStaticDefaultValue), new Action(ConfigTetrisById.ResetStaticDefaultValue));
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x001C70F0 File Offset: 0x001C52F0
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

		// Token: 0x06004012 RID: 16402 RVA: 0x001C716F File Offset: 0x001C536F
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisById.LogPair = null;
			ConfigTetrisById.HandleId = 0;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x001C717D File Offset: 0x001C537D
		public static void Init()
		{
			ConfigTetrisById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisById.HandleId, "db_tetris.db", "select BinData from `Tetris` where Id=?");
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x001C7198 File Offset: 0x001C5398
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

		// Token: 0x04004A8C RID: 19084
		private const string DB = "db_tetris.db";

		// Token: 0x04004A8D RID: 19085
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004A8E RID: 19086
		private const string TABLE = "Tetris";

		// Token: 0x04004A8F RID: 19087
		private const string COMMAND = "select BinData from `Tetris` where Id=?";

		// Token: 0x04004A90 RID: 19088
		private const string KEY_PREFIX = "TetrisById";

		// Token: 0x04004A91 RID: 19089
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A92 RID: 19090
		private static int HandleId;
	}
}
