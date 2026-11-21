using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C4 RID: 708
	public class ConfigFarmGoldMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x000BADDC File Offset: 0x000B8FDC
		static ConfigFarmGoldMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigFarmGoldMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000BADFC File Offset: 0x000B8FFC
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

		// Token: 0x0600109F RID: 4255 RVA: 0x000BAE7B File Offset: 0x000B907B
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldMapMarkByActivityId.LogPair = null;
			ConfigFarmGoldMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000BAE89 File Offset: 0x000B9089
		public static void Init()
		{
			ConfigFarmGoldMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldMapMarkByActivityId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldMapMark` where ActivityId=?");
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000BAEA4 File Offset: 0x000B90A4
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

		// Token: 0x04001340 RID: 4928
		private const string DB = "db_farmgold.db";

		// Token: 0x04001341 RID: 4929
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001342 RID: 4930
		private const string TABLE = "FarmGoldMapMark";

		// Token: 0x04001343 RID: 4931
		private const string COMMAND = "select BinData from `FarmGoldMapMark` where ActivityId=?";

		// Token: 0x04001344 RID: 4932
		private const string KEY_PREFIX = "FarmGoldMapMarkByActivityId";

		// Token: 0x04001345 RID: 4933
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001346 RID: 4934
		private static int HandleId;
	}
}
