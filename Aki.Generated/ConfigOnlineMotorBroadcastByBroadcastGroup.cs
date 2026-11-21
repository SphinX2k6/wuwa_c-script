using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063E RID: 1598
	public class ConfigOnlineMotorBroadcastByBroadcastGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00131498 File Offset: 0x0012F698
		static ConfigOnlineMotorBroadcastByBroadcastGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorBroadcastByBroadcastGroup.CreateStaticDefaultValue), new Action(ConfigOnlineMotorBroadcastByBroadcastGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x001314B8 File Offset: 0x0012F6B8
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorBroadcast"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorBroadcast` where BroadcastGroup=?")
			});
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00131537 File Offset: 0x0012F737
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair = null;
			ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId = 0;
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00131545 File Offset: 0x0012F745
		public static void Init()
		{
			ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorBroadcast` where BroadcastGroup=?");
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00131560 File Offset: 0x0012F760
		[NullableContext(2)]
		public static IReadOnlyList<OnlineMotorBroadcast> GetConfigList(int p0BroadcastGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorBroadcastByBroadcastGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BroadcastGroup);
				IReadOnlyList<OnlineMotorBroadcast> readOnlyList = (IReadOnlyList<OnlineMotorBroadcast>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair.Clear();
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair.Add(new ValueTuple<string, object>("BroadcastGroup", p0BroadcastGroup));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, 1, p0BroadcastGroup, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair);
				return null;
			}
			List<OnlineMotorBroadcast> list = new List<OnlineMotorBroadcast>();
			while (ConfigCommon.Step(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, false, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, 0, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair);
					return null;
				}
				OnlineMotorBroadcast rootAsOnlineMotorBroadcast = OnlineMotorBroadcast.GetRootAsOnlineMotorBroadcast(new ByteBuffer(item2));
				list.Add(rootAsOnlineMotorBroadcast);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorBroadcastByBroadcastGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BroadcastGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair);
			return list;
		}

		// Token: 0x04002B98 RID: 11160
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002B99 RID: 11161
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B9A RID: 11162
		private const string TABLE = "OnlineMotorBroadcast";

		// Token: 0x04002B9B RID: 11163
		private const string COMMAND = "select BinData from `OnlineMotorBroadcast` where BroadcastGroup=?";

		// Token: 0x04002B9C RID: 11164
		private const string KEY_PREFIX = "OnlineMotorBroadcastByBroadcastGroup";

		// Token: 0x04002B9D RID: 11165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B9E RID: 11166
		private static int HandleId;
	}
}
