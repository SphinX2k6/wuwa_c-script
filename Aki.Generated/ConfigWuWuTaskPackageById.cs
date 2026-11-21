using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B79 RID: 2937
	public class ConfigWuWuTaskPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x001E3063 File Offset: 0x001E1263
		static ConfigWuWuTaskPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuTaskPackageById.CreateStaticDefaultValue), new Action(ConfigWuWuTaskPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001E3084 File Offset: 0x001E1284
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuTaskPackageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuTaskPackageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuTaskPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuTaskPackage` where Id=?")
			});
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001E3103 File Offset: 0x001E1303
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuTaskPackageById.LogPair = null;
			ConfigWuWuTaskPackageById.HandleId = 0;
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x001E3111 File Offset: 0x001E1311
		public static void Init()
		{
			ConfigWuWuTaskPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuTaskPackageById.HandleId, "db_wuwutask.db", "select BinData from `WuWuTaskPackage` where Id=?");
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x001E312C File Offset: 0x001E132C
		public static WuWuTaskPackage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuTaskPackageById.HandleId, ConfigWuWuTaskPackageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuTaskPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WuWuTaskPackage?(WuWuTaskPackage.GetRootAsWuWuTaskPackage(configBuffer));
				}
			}
			ConfigWuWuTaskPackageById.LogPair.Clear();
			ConfigWuWuTaskPackageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWuWuTaskPackageById.HandleId, 1, p0Id, ConfigWuWuTaskPackageById.LogPair) || ConfigCommon.Step(ConfigWuWuTaskPackageById.HandleId, true, ConfigWuWuTaskPackageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWuWuTaskPackageById.HandleId, ConfigWuWuTaskPackageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuTaskPackageById.HandleId, 0, ConfigWuWuTaskPackageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWuWuTaskPackageById.HandleId, ConfigWuWuTaskPackageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WuWuTaskPackage rootAsWuWuTaskPackage = WuWuTaskPackage.GetRootAsWuWuTaskPackage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuTaskPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWuWuTaskPackageById.HandleId, ConfigWuWuTaskPackageById.LogPair);
			return new WuWuTaskPackage?(rootAsWuWuTaskPackage);
		}

		// Token: 0x04005035 RID: 20533
		private const string DB = "db_wuwutask.db";

		// Token: 0x04005036 RID: 20534
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04005037 RID: 20535
		private const string TABLE = "WuWuTaskPackage";

		// Token: 0x04005038 RID: 20536
		private const string COMMAND = "select BinData from `WuWuTaskPackage` where Id=?";

		// Token: 0x04005039 RID: 20537
		private const string KEY_PREFIX = "WuWuTaskPackageById";

		// Token: 0x0400503A RID: 20538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400503B RID: 20539
		private static int HandleId;
	}
}
