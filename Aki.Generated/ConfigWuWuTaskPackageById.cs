using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA4 RID: 2724
	public class ConfigWuWuTaskPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FED RID: 16365 RVA: 0x001C3CCF File Offset: 0x001C1ECF
		static ConfigWuWuTaskPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuTaskPackageById.CreateStaticDefaultValue), new Action(ConfigWuWuTaskPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x001C3CF0 File Offset: 0x001C1EF0
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

		// Token: 0x06003FEF RID: 16367 RVA: 0x001C3D6F File Offset: 0x001C1F6F
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuTaskPackageById.LogPair = null;
			ConfigWuWuTaskPackageById.HandleId = 0;
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x001C3D7D File Offset: 0x001C1F7D
		public static void Init()
		{
			ConfigWuWuTaskPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuTaskPackageById.HandleId, "db_wuwutask.db", "select BinData from `WuWuTaskPackage` where Id=?");
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x001C3D98 File Offset: 0x001C1F98
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

		// Token: 0x04004A62 RID: 19042
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A63 RID: 19043
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A64 RID: 19044
		private const string TABLE = "WuWuTaskPackage";

		// Token: 0x04004A65 RID: 19045
		private const string COMMAND = "select BinData from `WuWuTaskPackage` where Id=?";

		// Token: 0x04004A66 RID: 19046
		private const string KEY_PREFIX = "WuWuTaskPackageById";

		// Token: 0x04004A67 RID: 19047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A68 RID: 19048
		private static int HandleId;
	}
}
