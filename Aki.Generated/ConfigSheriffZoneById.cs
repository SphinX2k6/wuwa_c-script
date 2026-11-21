using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096D RID: 2413
	public class ConfigSheriffZoneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038A1 RID: 14497 RVA: 0x0019CB23 File Offset: 0x0019AD23
		static ConfigSheriffZoneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffZoneById.CreateStaticDefaultValue), new Action(ConfigSheriffZoneById.ResetStaticDefaultValue));
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0019CB44 File Offset: 0x0019AD44
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffZoneById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffZoneById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffZone"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffZone` where Id=?")
			});
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x0019CBC3 File Offset: 0x0019ADC3
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffZoneById.LogPair = null;
			ConfigSheriffZoneById.HandleId = 0;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x0019CBD1 File Offset: 0x0019ADD1
		public static void Init()
		{
			ConfigSheriffZoneById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffZoneById.HandleId, "db_sheriff.db", "select BinData from `SheriffZone` where Id=?");
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0019CBEC File Offset: 0x0019ADEC
		public static SheriffZone? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffZoneById.HandleId, ConfigSheriffZoneById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffZoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffZone?(SheriffZone.GetRootAsSheriffZone(configBuffer));
				}
			}
			ConfigSheriffZoneById.LogPair.Clear();
			ConfigSheriffZoneById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffZoneById.HandleId, 1, p0Id, ConfigSheriffZoneById.LogPair) || ConfigCommon.Step(ConfigSheriffZoneById.HandleId, true, ConfigSheriffZoneById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffZoneById.HandleId, ConfigSheriffZoneById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffZoneById.HandleId, 0, ConfigSheriffZoneById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffZoneById.HandleId, ConfigSheriffZoneById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffZone rootAsSheriffZone = SheriffZone.GetRootAsSheriffZone(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffZoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffZoneById.HandleId, ConfigSheriffZoneById.LogPair);
			return new SheriffZone?(rootAsSheriffZone);
		}

		// Token: 0x040041E1 RID: 16865
		private const string DB = "db_sheriff.db";

		// Token: 0x040041E2 RID: 16866
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041E3 RID: 16867
		private const string TABLE = "SheriffZone";

		// Token: 0x040041E4 RID: 16868
		private const string COMMAND = "select BinData from `SheriffZone` where Id=?";

		// Token: 0x040041E5 RID: 16869
		private const string KEY_PREFIX = "SheriffZoneById";

		// Token: 0x040041E6 RID: 16870
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041E7 RID: 16871
		private static int HandleId;
	}
}
