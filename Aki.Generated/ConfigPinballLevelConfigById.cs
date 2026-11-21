using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000734 RID: 1844
	public class ConfigPinballLevelConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B48 RID: 11080 RVA: 0x001517D7 File Offset: 0x0014F9D7
		static ConfigPinballLevelConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelConfigById.CreateStaticDefaultValue), new Action(ConfigPinballLevelConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x001517F8 File Offset: 0x0014F9F8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballLevelConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballLevelConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballLevelConfig` where Id=?")
			});
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00151877 File Offset: 0x0014FA77
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelConfigById.LogPair = null;
			ConfigPinballLevelConfigById.HandleId = 0;
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00151885 File Offset: 0x0014FA85
		public static void Init()
		{
			ConfigPinballLevelConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelConfig` where Id=?");
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x001518A0 File Offset: 0x0014FAA0
		public static PinballLevelConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballLevelConfig?(PinballLevelConfig.GetRootAsPinballLevelConfig(configBuffer));
				}
			}
			ConfigPinballLevelConfigById.LogPair.Clear();
			ConfigPinballLevelConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballLevelConfigById.HandleId, 1, p0Id, ConfigPinballLevelConfigById.LogPair) || ConfigCommon.Step(ConfigPinballLevelConfigById.HandleId, true, ConfigPinballLevelConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballLevelConfigById.HandleId, 0, ConfigPinballLevelConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballLevelConfig rootAsPinballLevelConfig = PinballLevelConfig.GetRootAsPinballLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
			return new PinballLevelConfig?(rootAsPinballLevelConfig);
		}

		// Token: 0x04003252 RID: 12882
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003253 RID: 12883
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003254 RID: 12884
		private const string TABLE = "PinballLevelConfig";

		// Token: 0x04003255 RID: 12885
		private const string COMMAND = "select BinData from `PinballLevelConfig` where Id=?";

		// Token: 0x04003256 RID: 12886
		private const string KEY_PREFIX = "PinballLevelConfigById";

		// Token: 0x04003257 RID: 12887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003258 RID: 12888
		private static int HandleId;
	}
}
