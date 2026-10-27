using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000698 RID: 1688
	public class ConfigPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027A0 RID: 10144 RVA: 0x00139AE0 File Offset: 0x00137CE0
		static ConfigPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00139B00 File Offset: 0x00137D00
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomGainByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomGainByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomGain` where ActivityId=?")
			});
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00139B7F File Offset: 0x00137D7F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGainByActivityId.LogPair = null;
			ConfigPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00139B8D File Offset: 0x00137D8D
		public static void Init()
		{
			ConfigPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGainByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `PhantomGain` where ActivityId=?");
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00139BA8 File Offset: 0x00137DA8
		[NullableContext(2)]
		public static IReadOnlyList<PhantomGain> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomGainByActivityId.HandleId, ConfigPhantomGainByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomGain> readOnlyList = (IReadOnlyList<PhantomGain>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomGainByActivityId.LogPair.Clear();
			ConfigPhantomGainByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomGainByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomGainByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomGainByActivityId.HandleId, ConfigPhantomGainByActivityId.LogPair);
				return null;
			}
			List<PhantomGain> list = new List<PhantomGain>();
			while (ConfigCommon.Step(ConfigPhantomGainByActivityId.HandleId, false, ConfigPhantomGainByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomGainByActivityId.HandleId, 0, ConfigPhantomGainByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomGainByActivityId.HandleId, ConfigPhantomGainByActivityId.LogPair);
					return null;
				}
				PhantomGain rootAsPhantomGain = PhantomGain.GetRootAsPhantomGain(new ByteBuffer(item2));
				list.Add(rootAsPhantomGain);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomGainByActivityId.HandleId, ConfigPhantomGainByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002E0E RID: 11790
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002E0F RID: 11791
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002E10 RID: 11792
		private const string TABLE = "PhantomGain";

		// Token: 0x04002E11 RID: 11793
		private const string COMMAND = "select BinData from `PhantomGain` where ActivityId=?";

		// Token: 0x04002E12 RID: 11794
		private const string KEY_PREFIX = "PhantomGainByActivityId";

		// Token: 0x04002E13 RID: 11795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E14 RID: 11796
		private static int HandleId;
	}
}
