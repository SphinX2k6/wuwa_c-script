using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071D RID: 1821
	public class ConfigPinballLevelConfigByShowRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ABE RID: 10942 RVA: 0x0014AFA4 File Offset: 0x001491A4
		static ConfigPinballLevelConfigByShowRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelConfigByShowRoleId.CreateStaticDefaultValue), new Action(ConfigPinballLevelConfigByShowRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0014AFC4 File Offset: 0x001491C4
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballLevelConfigByShowRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballLevelConfigByShowRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballLevelConfig` where ShowRoleId=?")
			});
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x0014B043 File Offset: 0x00149243
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelConfigByShowRoleId.LogPair = null;
			ConfigPinballLevelConfigByShowRoleId.HandleId = 0;
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x0014B051 File Offset: 0x00149251
		public static void Init()
		{
			ConfigPinballLevelConfigByShowRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelConfigByShowRoleId.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelConfig` where ShowRoleId=?");
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0014B06C File Offset: 0x0014926C
		public static PinballLevelConfig? GetConfig(int p0ShowRoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballLevelConfigByShowRoleId.HandleId, ConfigPinballLevelConfigByShowRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigByShowRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShowRoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballLevelConfig?(PinballLevelConfig.GetRootAsPinballLevelConfig(configBuffer));
				}
			}
			ConfigPinballLevelConfigByShowRoleId.LogPair.Clear();
			ConfigPinballLevelConfigByShowRoleId.LogPair.Add(new ValueTuple<string, object>("ShowRoleId", p0ShowRoleId));
			if (!ConfigCommon.BindInt(ConfigPinballLevelConfigByShowRoleId.HandleId, 1, p0ShowRoleId, ConfigPinballLevelConfigByShowRoleId.LogPair) || ConfigCommon.Step(ConfigPinballLevelConfigByShowRoleId.HandleId, true, ConfigPinballLevelConfigByShowRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigByShowRoleId.HandleId, ConfigPinballLevelConfigByShowRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballLevelConfigByShowRoleId.HandleId, 0, ConfigPinballLevelConfigByShowRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigByShowRoleId.HandleId, ConfigPinballLevelConfigByShowRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballLevelConfig rootAsPinballLevelConfig = PinballLevelConfig.GetRootAsPinballLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigByShowRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShowRoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballLevelConfigByShowRoleId.HandleId, ConfigPinballLevelConfigByShowRoleId.LogPair);
			return new PinballLevelConfig?(rootAsPinballLevelConfig);
		}

		// Token: 0x040031B1 RID: 12721
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031B2 RID: 12722
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031B3 RID: 12723
		private const string TABLE = "PinballLevelConfig";

		// Token: 0x040031B4 RID: 12724
		private const string COMMAND = "select BinData from `PinballLevelConfig` where ShowRoleId=?";

		// Token: 0x040031B5 RID: 12725
		private const string KEY_PREFIX = "PinballLevelConfigByShowRoleId";

		// Token: 0x040031B6 RID: 12726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031B7 RID: 12727
		private static int HandleId;
	}
}
