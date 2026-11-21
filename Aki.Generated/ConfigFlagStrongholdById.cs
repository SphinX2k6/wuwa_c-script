using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031A RID: 794
	public class ConfigFlagStrongholdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x000C6714 File Offset: 0x000C4914
		static ConfigFlagStrongholdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagStrongholdById.CreateStaticDefaultValue), new Action(ConfigFlagStrongholdById.ResetStaticDefaultValue));
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000C6734 File Offset: 0x000C4934
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagStrongholdById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagStrongholdById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagStronghold"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagStronghold` where Id=?")
			});
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000C67B3 File Offset: 0x000C49B3
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagStrongholdById.LogPair = null;
			ConfigFlagStrongholdById.HandleId = 0;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000C67C1 File Offset: 0x000C49C1
		public static void Init()
		{
			ConfigFlagStrongholdById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagStrongholdById.HandleId, "db_flagchallenge.db", "select BinData from `FlagStronghold` where Id=?");
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000C67DC File Offset: 0x000C49DC
		public static FlagStronghold? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagStrongholdById.HandleId, ConfigFlagStrongholdById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagStrongholdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagStronghold?(FlagStronghold.GetRootAsFlagStronghold(configBuffer));
				}
			}
			ConfigFlagStrongholdById.LogPair.Clear();
			ConfigFlagStrongholdById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagStrongholdById.HandleId, 1, p0Id, ConfigFlagStrongholdById.LogPair) || ConfigCommon.Step(ConfigFlagStrongholdById.HandleId, true, ConfigFlagStrongholdById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagStrongholdById.HandleId, ConfigFlagStrongholdById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagStrongholdById.HandleId, 0, ConfigFlagStrongholdById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagStrongholdById.HandleId, ConfigFlagStrongholdById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagStronghold rootAsFlagStronghold = FlagStronghold.GetRootAsFlagStronghold(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagStrongholdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagStrongholdById.HandleId, ConfigFlagStrongholdById.LogPair);
			return new FlagStronghold?(rootAsFlagStronghold);
		}

		// Token: 0x0400159A RID: 5530
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400159B RID: 5531
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x0400159C RID: 5532
		private const string TABLE = "FlagStronghold";

		// Token: 0x0400159D RID: 5533
		private const string COMMAND = "select BinData from `FlagStronghold` where Id=?";

		// Token: 0x0400159E RID: 5534
		private const string KEY_PREFIX = "FlagStrongholdById";

		// Token: 0x0400159F RID: 5535
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015A0 RID: 5536
		private static int HandleId;
	}
}
