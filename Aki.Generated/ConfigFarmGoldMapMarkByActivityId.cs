using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AF RID: 687
	public class ConfigFarmGoldMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x000B48D0 File Offset: 0x000B2AD0
		static ConfigFarmGoldMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigFarmGoldMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000B48F0 File Offset: 0x000B2AF0
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldMapMarkByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldMapMarkByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldMapMark` where ActivityId=?")
			});
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000B496F File Offset: 0x000B2B6F
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldMapMarkByActivityId.LogPair = null;
			ConfigFarmGoldMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000B497D File Offset: 0x000B2B7D
		public static void Init()
		{
			ConfigFarmGoldMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldMapMarkByActivityId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldMapMark` where ActivityId=?");
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000B4998 File Offset: 0x000B2B98
		public static FarmGoldMapMark? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldMapMarkByActivityId.HandleId, ConfigFarmGoldMapMarkByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FarmGoldMapMark?(FarmGoldMapMark.GetRootAsFarmGoldMapMark(configBuffer));
				}
			}
			ConfigFarmGoldMapMarkByActivityId.LogPair.Clear();
			ConfigFarmGoldMapMarkByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFarmGoldMapMarkByActivityId.HandleId, 1, p0ActivityId, ConfigFarmGoldMapMarkByActivityId.LogPair) || ConfigCommon.Step(ConfigFarmGoldMapMarkByActivityId.HandleId, true, ConfigFarmGoldMapMarkByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFarmGoldMapMarkByActivityId.HandleId, ConfigFarmGoldMapMarkByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldMapMarkByActivityId.HandleId, 0, ConfigFarmGoldMapMarkByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFarmGoldMapMarkByActivityId.HandleId, ConfigFarmGoldMapMarkByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FarmGoldMapMark rootAsFarmGoldMapMark = FarmGoldMapMark.GetRootAsFarmGoldMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFarmGoldMapMarkByActivityId.HandleId, ConfigFarmGoldMapMarkByActivityId.LogPair);
			return new FarmGoldMapMark?(rootAsFarmGoldMapMark);
		}

		// Token: 0x040012AD RID: 4781
		private const string DB = "db_farmgold.db";

		// Token: 0x040012AE RID: 4782
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012AF RID: 4783
		private const string TABLE = "FarmGoldMapMark";

		// Token: 0x040012B0 RID: 4784
		private const string COMMAND = "select BinData from `FarmGoldMapMark` where ActivityId=?";

		// Token: 0x040012B1 RID: 4785
		private const string KEY_PREFIX = "FarmGoldMapMarkByActivityId";

		// Token: 0x040012B2 RID: 4786
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012B3 RID: 4787
		private static int HandleId;
	}
}
