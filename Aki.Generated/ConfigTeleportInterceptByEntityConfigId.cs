using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9D RID: 2717
	public class ConfigTeleportInterceptByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x001C5508 File Offset: 0x001C3708
		static ConfigTeleportInterceptByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleportInterceptByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigTeleportInterceptByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x001C5528 File Offset: 0x001C3728
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

		// Token: 0x06003FC4 RID: 16324 RVA: 0x001C55A7 File Offset: 0x001C37A7
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleportInterceptByEntityConfigId.LogPair = null;
			ConfigTeleportInterceptByEntityConfigId.HandleId = 0;
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x001C55B5 File Offset: 0x001C37B5
		public static void Init()
		{
			ConfigTeleportInterceptByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigTeleportInterceptByEntityConfigId.HandleId, "db_download.db", "select BinData from `TeleportIntercept` where EntityConfigId = ?");
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x001C55D0 File Offset: 0x001C37D0
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

		// Token: 0x04004A31 RID: 18993
		private const string DB = "db_download.db";

		// Token: 0x04004A32 RID: 18994
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04004A33 RID: 18995
		private const string TABLE = "TeleportIntercept";

		// Token: 0x04004A34 RID: 18996
		private const string COMMAND = "select BinData from `TeleportIntercept` where EntityConfigId = ?";

		// Token: 0x04004A35 RID: 18997
		private const string KEY_PREFIX = "TeleportInterceptByEntityConfigId";

		// Token: 0x04004A36 RID: 18998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A37 RID: 18999
		private static int HandleId;
	}
}
