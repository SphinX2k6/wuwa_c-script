using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000922 RID: 2338
	public class ConfigSheriffZoneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036DF RID: 14047 RVA: 0x0018F903 File Offset: 0x0018DB03
		static ConfigSheriffZoneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffZoneById.CreateStaticDefaultValue), new Action(ConfigSheriffZoneById.ResetStaticDefaultValue));
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0018F924 File Offset: 0x0018DB24
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

		// Token: 0x060036E1 RID: 14049 RVA: 0x0018F9A3 File Offset: 0x0018DBA3
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffZoneById.LogPair = null;
			ConfigSheriffZoneById.HandleId = 0;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0018F9B1 File Offset: 0x0018DBB1
		public static void Init()
		{
			ConfigSheriffZoneById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffZoneById.HandleId, "db_sheriff.db", "select BinData from `SheriffZone` where Id=?");
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x0018F9CC File Offset: 0x0018DBCC
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

		// Token: 0x04003FD4 RID: 16340
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FD5 RID: 16341
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FD6 RID: 16342
		private const string TABLE = "SheriffZone";

		// Token: 0x04003FD7 RID: 16343
		private const string COMMAND = "select BinData from `SheriffZone` where Id=?";

		// Token: 0x04003FD8 RID: 16344
		private const string KEY_PREFIX = "SheriffZoneById";

		// Token: 0x04003FD9 RID: 16345
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FDA RID: 16346
		private static int HandleId;
	}
}
