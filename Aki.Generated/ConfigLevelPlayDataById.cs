using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CE RID: 1230
	public class ConfigLevelPlayDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CDF RID: 7391 RVA: 0x000FC535 File Offset: 0x000FA735
		static ConfigLevelPlayDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayDataById.CreateStaticDefaultValue), new Action(ConfigLevelPlayDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000FC554 File Offset: 0x000FA754
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

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000FC5D3 File Offset: 0x000FA7D3
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayDataById.LogPair = null;
			ConfigLevelPlayDataById.HandleId = 0;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000FC5E1 File Offset: 0x000FA7E1
		public static void Init()
		{
			ConfigLevelPlayDataById.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayDataById.HandleId, "db_levelplaydata.db", "select BinData from `LevelPlayData` where LevelPlayId=?");
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x000FC5FC File Offset: 0x000FA7FC
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

		// Token: 0x04002186 RID: 8582
		private const string DB = "db_levelplaydata.db";

		// Token: 0x04002187 RID: 8583
		private const string FILE = "UniverseEditor/LevelPlay/玩法*";

		// Token: 0x04002188 RID: 8584
		private const string TABLE = "LevelPlayData";

		// Token: 0x04002189 RID: 8585
		private const string COMMAND = "select BinData from `LevelPlayData` where LevelPlayId=?";

		// Token: 0x0400218A RID: 8586
		private const string KEY_PREFIX = "LevelPlayDataById";

		// Token: 0x0400218B RID: 8587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400218C RID: 8588
		private static int HandleId;
	}
}
