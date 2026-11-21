using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000754 RID: 1876
	public class ConfigPinballWorldConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x00155E2C File Offset: 0x0015402C
		static ConfigPinballWorldConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWorldConfigById.CreateStaticDefaultValue), new Action(ConfigPinballWorldConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00155E4C File Offset: 0x0015404C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWorldConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWorldConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWorldConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWorldConfig` where Id=?")
			});
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00155ECB File Offset: 0x001540CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWorldConfigById.LogPair = null;
			ConfigPinballWorldConfigById.HandleId = 0;
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00155ED9 File Offset: 0x001540D9
		public static void Init()
		{
			ConfigPinballWorldConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWorldConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWorldConfig` where Id=?");
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00155EF4 File Offset: 0x001540F4
		public static PinballWorldConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWorldConfigById.HandleId, ConfigPinballWorldConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWorldConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWorldConfig?(PinballWorldConfig.GetRootAsPinballWorldConfig(configBuffer));
				}
			}
			ConfigPinballWorldConfigById.LogPair.Clear();
			ConfigPinballWorldConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWorldConfigById.HandleId, 1, p0Id, ConfigPinballWorldConfigById.LogPair) || ConfigCommon.Step(ConfigPinballWorldConfigById.HandleId, true, ConfigPinballWorldConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWorldConfigById.HandleId, ConfigPinballWorldConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWorldConfigById.HandleId, 0, ConfigPinballWorldConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWorldConfigById.HandleId, ConfigPinballWorldConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWorldConfig rootAsPinballWorldConfig = PinballWorldConfig.GetRootAsPinballWorldConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWorldConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWorldConfigById.HandleId, ConfigPinballWorldConfigById.LogPair);
			return new PinballWorldConfig?(rootAsPinballWorldConfig);
		}

		// Token: 0x04003332 RID: 13106
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003333 RID: 13107
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x04003334 RID: 13108
		private const string TABLE = "PinballWorldConfig";

		// Token: 0x04003335 RID: 13109
		private const string COMMAND = "select BinData from `PinballWorldConfig` where Id=?";

		// Token: 0x04003336 RID: 13110
		private const string KEY_PREFIX = "PinballWorldConfigById";

		// Token: 0x04003337 RID: 13111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003338 RID: 13112
		private static int HandleId;
	}
}
