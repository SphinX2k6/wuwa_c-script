using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E4 RID: 1252
	public class ConfigLevelPlayDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D63 RID: 7523 RVA: 0x00102C89 File Offset: 0x00100E89
		static ConfigLevelPlayDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayDataById.CreateStaticDefaultValue), new Action(ConfigLevelPlayDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00102CA8 File Offset: 0x00100EA8
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelPlayDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelPlayDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelplaydata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/玩法*"),
				new ValueTuple<string, object>("表名", "LevelPlayData"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelPlayData` where LevelPlayId=?")
			});
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00102D27 File Offset: 0x00100F27
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayDataById.LogPair = null;
			ConfigLevelPlayDataById.HandleId = 0;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00102D35 File Offset: 0x00100F35
		public static void Init()
		{
			ConfigLevelPlayDataById.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayDataById.HandleId, "db_levelplaydata.db", "select BinData from `LevelPlayData` where LevelPlayId=?");
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00102D50 File Offset: 0x00100F50
		public static LevelPlayData? GetConfig(int p0LevelPlayId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelPlayDataById.HandleId, ConfigLevelPlayDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelPlayDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelPlayId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LevelPlayData?(LevelPlayData.GetRootAsLevelPlayData(configBuffer));
				}
			}
			ConfigLevelPlayDataById.LogPair.Clear();
			ConfigLevelPlayDataById.LogPair.Add(new ValueTuple<string, object>("LevelPlayId", p0LevelPlayId));
			if (!ConfigCommon.BindInt(ConfigLevelPlayDataById.HandleId, 1, p0LevelPlayId, ConfigLevelPlayDataById.LogPair) || ConfigCommon.Step(ConfigLevelPlayDataById.HandleId, true, ConfigLevelPlayDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLevelPlayDataById.HandleId, ConfigLevelPlayDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelPlayDataById.HandleId, 0, ConfigLevelPlayDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLevelPlayDataById.HandleId, ConfigLevelPlayDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LevelPlayData rootAsLevelPlayData = LevelPlayData.GetRootAsLevelPlayData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelPlayDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelPlayId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLevelPlayDataById.HandleId, ConfigLevelPlayDataById.LogPair);
			return new LevelPlayData?(rootAsLevelPlayData);
		}

		// Token: 0x04002220 RID: 8736
		private const string DB = "db_levelplaydata.db";

		// Token: 0x04002221 RID: 8737
		private const string FILE = "UniverseEditor/LevelPlay/玩法*";

		// Token: 0x04002222 RID: 8738
		private const string TABLE = "LevelPlayData";

		// Token: 0x04002223 RID: 8739
		private const string COMMAND = "select BinData from `LevelPlayData` where LevelPlayId=?";

		// Token: 0x04002224 RID: 8740
		private const string KEY_PREFIX = "LevelPlayDataById";

		// Token: 0x04002225 RID: 8741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002226 RID: 8742
		private static int HandleId;
	}
}
