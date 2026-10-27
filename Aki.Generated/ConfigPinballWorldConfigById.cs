using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073C RID: 1852
	public class ConfigPinballWorldConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B78 RID: 11128 RVA: 0x0014F3B0 File Offset: 0x0014D5B0
		static ConfigPinballWorldConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWorldConfigById.CreateStaticDefaultValue), new Action(ConfigPinballWorldConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x0014F3D0 File Offset: 0x0014D5D0
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x0014F44F File Offset: 0x0014D64F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWorldConfigById.LogPair = null;
			ConfigPinballWorldConfigById.HandleId = 0;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x0014F45D File Offset: 0x0014D65D
		public static void Init()
		{
			ConfigPinballWorldConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWorldConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWorldConfig` where Id=?");
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0014F478 File Offset: 0x0014D678
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

		// Token: 0x0400328A RID: 12938
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400328B RID: 12939
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x0400328C RID: 12940
		private const string TABLE = "PinballWorldConfig";

		// Token: 0x0400328D RID: 12941
		private const string COMMAND = "select BinData from `PinballWorldConfig` where Id=?";

		// Token: 0x0400328E RID: 12942
		private const string KEY_PREFIX = "PinballWorldConfigById";

		// Token: 0x0400328F RID: 12943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003290 RID: 12944
		private static int HandleId;
	}
}
