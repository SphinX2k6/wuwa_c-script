using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000566 RID: 1382
	public class ConfigMoraleKeepLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x00110C73 File Offset: 0x0010EE73
		static ConfigMoraleKeepLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleKeepLevelById.CreateStaticDefaultValue), new Action(ConfigMoraleKeepLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00110C94 File Offset: 0x0010EE94
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleKeepLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleKeepLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleKeepLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleKeepLevel` where Level=?")
			});
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00110D13 File Offset: 0x0010EF13
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleKeepLevelById.LogPair = null;
			ConfigMoraleKeepLevelById.HandleId = 0;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00110D21 File Offset: 0x0010EF21
		public static void Init()
		{
			ConfigMoraleKeepLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleKeepLevelById.HandleId, "db_moraleplay.db", "select BinData from `MoraleKeepLevel` where Level=?");
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00110D3C File Offset: 0x0010EF3C
		public static MoraleKeepLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleKeepLevelById.HandleId, ConfigMoraleKeepLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleKeepLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleKeepLevel?(MoraleKeepLevel.GetRootAsMoraleKeepLevel(configBuffer));
				}
			}
			ConfigMoraleKeepLevelById.LogPair.Clear();
			ConfigMoraleKeepLevelById.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMoraleKeepLevelById.HandleId, 1, p0Level, ConfigMoraleKeepLevelById.LogPair) || ConfigCommon.Step(ConfigMoraleKeepLevelById.HandleId, true, ConfigMoraleKeepLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleKeepLevelById.HandleId, ConfigMoraleKeepLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleKeepLevelById.HandleId, 0, ConfigMoraleKeepLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleKeepLevelById.HandleId, ConfigMoraleKeepLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleKeepLevel rootAsMoraleKeepLevel = MoraleKeepLevel.GetRootAsMoraleKeepLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleKeepLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleKeepLevelById.HandleId, ConfigMoraleKeepLevelById.LogPair);
			return new MoraleKeepLevel?(rootAsMoraleKeepLevel);
		}

		// Token: 0x040025AE RID: 9646
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025AF RID: 9647
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025B0 RID: 9648
		private const string TABLE = "MoraleKeepLevel";

		// Token: 0x040025B1 RID: 9649
		private const string COMMAND = "select BinData from `MoraleKeepLevel` where Level=?";

		// Token: 0x040025B2 RID: 9650
		private const string KEY_PREFIX = "MoraleKeepLevelById";

		// Token: 0x040025B3 RID: 9651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025B4 RID: 9652
		private static int HandleId;
	}
}
