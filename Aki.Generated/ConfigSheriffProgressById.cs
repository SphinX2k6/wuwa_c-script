using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000965 RID: 2405
	public class ConfigSheriffProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003871 RID: 14449 RVA: 0x0019B9B8 File Offset: 0x00199BB8
		static ConfigSheriffProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffProgressById.CreateStaticDefaultValue), new Action(ConfigSheriffProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x0019B9D8 File Offset: 0x00199BD8
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffProgressById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffProgressById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffProgress` where Id=?")
			});
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0019BA57 File Offset: 0x00199C57
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffProgressById.LogPair = null;
			ConfigSheriffProgressById.HandleId = 0;
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x0019BA65 File Offset: 0x00199C65
		public static void Init()
		{
			ConfigSheriffProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffProgressById.HandleId, "db_sheriff.db", "select BinData from `SheriffProgress` where Id=?");
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0019BA80 File Offset: 0x00199C80
		public static SheriffProgress? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffProgress?(SheriffProgress.GetRootAsSheriffProgress(configBuffer));
				}
			}
			ConfigSheriffProgressById.LogPair.Clear();
			ConfigSheriffProgressById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffProgressById.HandleId, 1, p0Id, ConfigSheriffProgressById.LogPair) || ConfigCommon.Step(ConfigSheriffProgressById.HandleId, true, ConfigSheriffProgressById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffProgressById.HandleId, 0, ConfigSheriffProgressById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffProgress rootAsSheriffProgress = SheriffProgress.GetRootAsSheriffProgress(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
			return new SheriffProgress?(rootAsSheriffProgress);
		}

		// Token: 0x040041A9 RID: 16809
		private const string DB = "db_sheriff.db";

		// Token: 0x040041AA RID: 16810
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041AB RID: 16811
		private const string TABLE = "SheriffProgress";

		// Token: 0x040041AC RID: 16812
		private const string COMMAND = "select BinData from `SheriffProgress` where Id=?";

		// Token: 0x040041AD RID: 16813
		private const string KEY_PREFIX = "SheriffProgressById";

		// Token: 0x040041AE RID: 16814
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041AF RID: 16815
		private static int HandleId;
	}
}
