using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C8 RID: 2504
	public class ConfigTeleportInterceptByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AC4 RID: 15044 RVA: 0x001A6174 File Offset: 0x001A4374
		static ConfigTeleportInterceptByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleportInterceptByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigTeleportInterceptByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x001A6194 File Offset: 0x001A4394
		public static void CreateStaticDefaultValue()
		{
			ConfigTeleportInterceptByEntityConfigId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeleportInterceptByEntityConfigId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "TeleportIntercept"),
				new ValueTuple<string, object>("语句", "select BinData from `TeleportIntercept` where EntityConfigId = ?")
			});
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x001A6213 File Offset: 0x001A4413
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleportInterceptByEntityConfigId.LogPair = null;
			ConfigTeleportInterceptByEntityConfigId.HandleId = 0;
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x001A6221 File Offset: 0x001A4421
		public static void Init()
		{
			ConfigTeleportInterceptByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigTeleportInterceptByEntityConfigId.HandleId, "db_download.db", "select BinData from `TeleportIntercept` where EntityConfigId = ?");
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001A623C File Offset: 0x001A443C
		[NullableContext(2)]
		public static IReadOnlyList<TeleportIntercept> GetConfigList(int p0EntityConfigId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeleportInterceptByEntityConfigId.HandleId, ConfigTeleportInterceptByEntityConfigId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleportInterceptByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				IReadOnlyList<TeleportIntercept> readOnlyList = (IReadOnlyList<TeleportIntercept>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTeleportInterceptByEntityConfigId.LogPair.Clear();
			ConfigTeleportInterceptByEntityConfigId.LogPair.Add(new ValueTuple<string, object>("EntityConfigId", p0EntityConfigId));
			if (!ConfigCommon.BindInt(ConfigTeleportInterceptByEntityConfigId.HandleId, 1, p0EntityConfigId, ConfigTeleportInterceptByEntityConfigId.LogPair))
			{
				ConfigCommon.Reset(ConfigTeleportInterceptByEntityConfigId.HandleId, ConfigTeleportInterceptByEntityConfigId.LogPair);
				return null;
			}
			List<TeleportIntercept> list = new List<TeleportIntercept>();
			while (ConfigCommon.Step(ConfigTeleportInterceptByEntityConfigId.HandleId, false, ConfigTeleportInterceptByEntityConfigId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeleportInterceptByEntityConfigId.HandleId, 0, ConfigTeleportInterceptByEntityConfigId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTeleportInterceptByEntityConfigId.HandleId, ConfigTeleportInterceptByEntityConfigId.LogPair);
					return null;
				}
				TeleportIntercept rootAsTeleportIntercept = TeleportIntercept.GetRootAsTeleportIntercept(new ByteBuffer(item2));
				list.Add(rootAsTeleportIntercept);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleportInterceptByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTeleportInterceptByEntityConfigId.HandleId, ConfigTeleportInterceptByEntityConfigId.LogPair);
			return list;
		}

		// Token: 0x0400445E RID: 17502
		private const string DB = "db_download.db";

		// Token: 0x0400445F RID: 17503
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04004460 RID: 17504
		private const string TABLE = "TeleportIntercept";

		// Token: 0x04004461 RID: 17505
		private const string COMMAND = "select BinData from `TeleportIntercept` where EntityConfigId = ?";

		// Token: 0x04004462 RID: 17506
		private const string KEY_PREFIX = "TeleportInterceptByEntityConfigId";

		// Token: 0x04004463 RID: 17507
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004464 RID: 17508
		private static int HandleId;
	}
}
