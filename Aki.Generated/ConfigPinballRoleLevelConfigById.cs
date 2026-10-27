using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072F RID: 1839
	public class ConfigPinballRoleLevelConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B2A RID: 11050 RVA: 0x0014D6CD File Offset: 0x0014B8CD
		static ConfigPinballRoleLevelConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigById.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0014D6EC File Offset: 0x0014B8EC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleLevelConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleLevelConfig` where Id=?")
			});
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x0014D76B File Offset: 0x0014B96B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigById.LogPair = null;
			ConfigPinballRoleLevelConfigById.HandleId = 0;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x0014D779 File Offset: 0x0014B979
		public static void Init()
		{
			ConfigPinballRoleLevelConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where Id=?");
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0014D794 File Offset: 0x0014B994
		public static PinballRoleLevelConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRoleLevelConfig?(PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(configBuffer));
				}
			}
			ConfigPinballRoleLevelConfigById.LogPair.Clear();
			ConfigPinballRoleLevelConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballRoleLevelConfigById.HandleId, 1, p0Id, ConfigPinballRoleLevelConfigById.LogPair) || ConfigCommon.Step(ConfigPinballRoleLevelConfigById.HandleId, true, ConfigPinballRoleLevelConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleLevelConfigById.HandleId, 0, ConfigPinballRoleLevelConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRoleLevelConfig rootAsPinballRoleLevelConfig = PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
			return new PinballRoleLevelConfig?(rootAsPinballRoleLevelConfig);
		}

		// Token: 0x0400322F RID: 12847
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003230 RID: 12848
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003231 RID: 12849
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x04003232 RID: 12850
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where Id=?";

		// Token: 0x04003233 RID: 12851
		private const string KEY_PREFIX = "PinballRoleLevelConfigById";

		// Token: 0x04003234 RID: 12852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003235 RID: 12853
		private static int HandleId;
	}
}
