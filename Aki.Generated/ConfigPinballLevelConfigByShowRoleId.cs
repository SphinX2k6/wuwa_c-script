using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000735 RID: 1845
	public class ConfigPinballLevelConfigByShowRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B4E RID: 11086 RVA: 0x00151A20 File Offset: 0x0014FC20
		static ConfigPinballLevelConfigByShowRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelConfigByShowRoleId.CreateStaticDefaultValue), new Action(ConfigPinballLevelConfigByShowRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00151A40 File Offset: 0x0014FC40
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

		// Token: 0x06002B50 RID: 11088 RVA: 0x00151ABF File Offset: 0x0014FCBF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelConfigByShowRoleId.LogPair = null;
			ConfigPinballLevelConfigByShowRoleId.HandleId = 0;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00151ACD File Offset: 0x0014FCCD
		public static void Init()
		{
			ConfigPinballLevelConfigByShowRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelConfigByShowRoleId.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelConfig` where ShowRoleId=?");
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00151AE8 File Offset: 0x0014FCE8
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

		// Token: 0x04003259 RID: 12889
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400325A RID: 12890
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x0400325B RID: 12891
		private const string TABLE = "PinballLevelConfig";

		// Token: 0x0400325C RID: 12892
		private const string COMMAND = "select BinData from `PinballLevelConfig` where ShowRoleId=?";

		// Token: 0x0400325D RID: 12893
		private const string KEY_PREFIX = "PinballLevelConfigByShowRoleId";

		// Token: 0x0400325E RID: 12894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400325F RID: 12895
		private static int HandleId;
	}
}
