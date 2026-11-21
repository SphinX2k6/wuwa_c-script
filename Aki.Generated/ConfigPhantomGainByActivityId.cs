using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B0 RID: 1712
	public class ConfigPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x0014055C File Offset: 0x0013E75C
		static ConfigPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0014057C File Offset: 0x0013E77C
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

		// Token: 0x06002832 RID: 10290 RVA: 0x001405FB File Offset: 0x0013E7FB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGainByActivityId.LogPair = null;
			ConfigPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00140609 File Offset: 0x0013E809
		public static void Init()
		{
			ConfigPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGainByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `PhantomGain` where ActivityId=?");
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00140624 File Offset: 0x0013E824
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

		// Token: 0x04002EB6 RID: 11958
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002EB7 RID: 11959
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002EB8 RID: 11960
		private const string TABLE = "PhantomGain";

		// Token: 0x04002EB9 RID: 11961
		private const string COMMAND = "select BinData from `PhantomGain` where ActivityId=?";

		// Token: 0x04002EBA RID: 11962
		private const string KEY_PREFIX = "PhantomGainByActivityId";

		// Token: 0x04002EBB RID: 11963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EBC RID: 11964
		private static int HandleId;
	}
}
