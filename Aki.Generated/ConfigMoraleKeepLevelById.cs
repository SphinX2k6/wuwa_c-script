using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057C RID: 1404
	public class ConfigMoraleKeepLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x001173C7 File Offset: 0x001155C7
		static ConfigMoraleKeepLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleKeepLevelById.CreateStaticDefaultValue), new Action(ConfigMoraleKeepLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x001173E8 File Offset: 0x001155E8
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

		// Token: 0x060020F7 RID: 8439 RVA: 0x00117467 File Offset: 0x00115667
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleKeepLevelById.LogPair = null;
			ConfigMoraleKeepLevelById.HandleId = 0;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00117475 File Offset: 0x00115675
		public static void Init()
		{
			ConfigMoraleKeepLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleKeepLevelById.HandleId, "db_moraleplay.db", "select BinData from `MoraleKeepLevel` where Level=?");
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00117490 File Offset: 0x00115690
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

		// Token: 0x04002648 RID: 9800
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002649 RID: 9801
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400264A RID: 9802
		private const string TABLE = "MoraleKeepLevel";

		// Token: 0x0400264B RID: 9803
		private const string COMMAND = "select BinData from `MoraleKeepLevel` where Level=?";

		// Token: 0x0400264C RID: 9804
		private const string KEY_PREFIX = "MoraleKeepLevelById";

		// Token: 0x0400264D RID: 9805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400264E RID: 9806
		private static int HandleId;
	}
}
