using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000626 RID: 1574
	public class ConfigOnlineMotorBroadcastByBroadcastGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x0012AA1C File Offset: 0x00128C1C
		static ConfigOnlineMotorBroadcastByBroadcastGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorBroadcastByBroadcastGroup.CreateStaticDefaultValue), new Action(ConfigOnlineMotorBroadcastByBroadcastGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0012AA3C File Offset: 0x00128C3C
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

		// Token: 0x060024F6 RID: 9462 RVA: 0x0012AABB File Offset: 0x00128CBB
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastByBroadcastGroup.LogPair = null;
			ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId = 0;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x0012AAC9 File Offset: 0x00128CC9
		public static void Init()
		{
			ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorBroadcastByBroadcastGroup.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorBroadcast` where BroadcastGroup=?");
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0012AAE4 File Offset: 0x00128CE4
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

		// Token: 0x04002AF0 RID: 10992
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002AF1 RID: 10993
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002AF2 RID: 10994
		private const string TABLE = "OnlineMotorBroadcast";

		// Token: 0x04002AF3 RID: 10995
		private const string COMMAND = "select BinData from `OnlineMotorBroadcast` where BroadcastGroup=?";

		// Token: 0x04002AF4 RID: 10996
		private const string KEY_PREFIX = "OnlineMotorBroadcastByBroadcastGroup";

		// Token: 0x04002AF5 RID: 10997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AF6 RID: 10998
		private static int HandleId;
	}
}
