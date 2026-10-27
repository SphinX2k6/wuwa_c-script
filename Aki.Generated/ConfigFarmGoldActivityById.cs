using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AC RID: 684
	public class ConfigFarmGoldActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x000B42AB File Offset: 0x000B24AB
		static ConfigFarmGoldActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityById.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000B42CC File Offset: 0x000B24CC
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldActivity` where Id=?")
			});
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000B434B File Offset: 0x000B254B
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityById.LogPair = null;
			ConfigFarmGoldActivityById.HandleId = 0;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000B4359 File Offset: 0x000B2559
		public static void Init()
		{
			ConfigFarmGoldActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity` where Id=?");
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000B4374 File Offset: 0x000B2574
		public static FarmGoldActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldActivityById.HandleId, ConfigFarmGoldActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FarmGoldActivity?(FarmGoldActivity.GetRootAsFarmGoldActivity(configBuffer));
				}
			}
			ConfigFarmGoldActivityById.LogPair.Clear();
			ConfigFarmGoldActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFarmGoldActivityById.HandleId, 1, p0Id, ConfigFarmGoldActivityById.LogPair) || ConfigCommon.Step(ConfigFarmGoldActivityById.HandleId, true, ConfigFarmGoldActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFarmGoldActivityById.HandleId, ConfigFarmGoldActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldActivityById.HandleId, 0, ConfigFarmGoldActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFarmGoldActivityById.HandleId, ConfigFarmGoldActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FarmGoldActivity rootAsFarmGoldActivity = FarmGoldActivity.GetRootAsFarmGoldActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFarmGoldActivityById.HandleId, ConfigFarmGoldActivityById.LogPair);
			return new FarmGoldActivity?(rootAsFarmGoldActivity);
		}

		// Token: 0x04001298 RID: 4760
		private const string DB = "db_farmgold.db";

		// Token: 0x04001299 RID: 4761
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400129A RID: 4762
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x0400129B RID: 4763
		private const string COMMAND = "select BinData from `FarmGoldActivity` where Id=?";

		// Token: 0x0400129C RID: 4764
		private const string KEY_PREFIX = "FarmGoldActivityById";

		// Token: 0x0400129D RID: 4765
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400129E RID: 4766
		private static int HandleId;
	}
}
