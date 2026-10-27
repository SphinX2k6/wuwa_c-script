using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072E RID: 1838
	public class ConfigPinballRoleLevelConfigByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B24 RID: 11044 RVA: 0x0014D42F File Offset: 0x0014B62F
		static ConfigPinballRoleLevelConfigByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x0014D450 File Offset: 0x0014B650
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?")
			});
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0014D4CF File Offset: 0x0014B6CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair = null;
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x0014D4DD File Offset: 0x0014B6DD
		public static void Init()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?");
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0014D4F8 File Offset: 0x0014B6F8
		public static PinballRoleLevelConfig? GetConfig(int p0GroupId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRoleLevelConfig?(PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(configBuffer));
				}
			}
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Clear();
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 1, p0GroupId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 2, p1Level, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) || ConfigCommon.Step(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, true, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 0, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRoleLevelConfig rootAsPinballRoleLevelConfig = PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
			return new PinballRoleLevelConfig?(rootAsPinballRoleLevelConfig);
		}

		// Token: 0x04003228 RID: 12840
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003229 RID: 12841
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x0400322A RID: 12842
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x0400322B RID: 12843
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?";

		// Token: 0x0400322C RID: 12844
		private const string KEY_PREFIX = "PinballRoleLevelConfigByGroupIdAndLevel";

		// Token: 0x0400322D RID: 12845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400322E RID: 12846
		private static int HandleId;
	}
}
