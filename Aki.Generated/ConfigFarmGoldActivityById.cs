using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C1 RID: 705
	public class ConfigFarmGoldActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600108B RID: 4235 RVA: 0x000BA7B7 File Offset: 0x000B89B7
		static ConfigFarmGoldActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityById.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000BA7D8 File Offset: 0x000B89D8
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

		// Token: 0x0600108D RID: 4237 RVA: 0x000BA857 File Offset: 0x000B8A57
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityById.LogPair = null;
			ConfigFarmGoldActivityById.HandleId = 0;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000BA865 File Offset: 0x000B8A65
		public static void Init()
		{
			ConfigFarmGoldActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity` where Id=?");
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000BA880 File Offset: 0x000B8A80
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

		// Token: 0x0400132B RID: 4907
		private const string DB = "db_farmgold.db";

		// Token: 0x0400132C RID: 4908
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400132D RID: 4909
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x0400132E RID: 4910
		private const string COMMAND = "select BinData from `FarmGoldActivity` where Id=?";

		// Token: 0x0400132F RID: 4911
		private const string KEY_PREFIX = "FarmGoldActivityById";

		// Token: 0x04001330 RID: 4912
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001331 RID: 4913
		private static int HandleId;
	}
}
