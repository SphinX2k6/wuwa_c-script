using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000964 RID: 2404
	public class ConfigSheriffMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600386B RID: 14443 RVA: 0x0019B76F File Offset: 0x0019996F
		static ConfigSheriffMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffMapById.CreateStaticDefaultValue), new Action(ConfigSheriffMapById.ResetStaticDefaultValue));
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x0019B790 File Offset: 0x00199990
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffMap"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffMap` where Id=?")
			});
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x0019B80F File Offset: 0x00199A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffMapById.LogPair = null;
			ConfigSheriffMapById.HandleId = 0;
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x0019B81D File Offset: 0x00199A1D
		public static void Init()
		{
			ConfigSheriffMapById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffMapById.HandleId, "db_sheriff.db", "select BinData from `SheriffMap` where Id=?");
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x0019B838 File Offset: 0x00199A38
		public static SheriffMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffMap?(SheriffMap.GetRootAsSheriffMap(configBuffer));
				}
			}
			ConfigSheriffMapById.LogPair.Clear();
			ConfigSheriffMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffMapById.HandleId, 1, p0Id, ConfigSheriffMapById.LogPair) || ConfigCommon.Step(ConfigSheriffMapById.HandleId, true, ConfigSheriffMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffMapById.HandleId, 0, ConfigSheriffMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffMap rootAsSheriffMap = SheriffMap.GetRootAsSheriffMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
			return new SheriffMap?(rootAsSheriffMap);
		}

		// Token: 0x040041A2 RID: 16802
		private const string DB = "db_sheriff.db";

		// Token: 0x040041A3 RID: 16803
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041A4 RID: 16804
		private const string TABLE = "SheriffMap";

		// Token: 0x040041A5 RID: 16805
		private const string COMMAND = "select BinData from `SheriffMap` where Id=?";

		// Token: 0x040041A6 RID: 16806
		private const string KEY_PREFIX = "SheriffMapById";

		// Token: 0x040041A7 RID: 16807
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041A8 RID: 16808
		private static int HandleId;
	}
}
