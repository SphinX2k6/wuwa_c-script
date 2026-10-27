using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000305 RID: 773
	public class ConfigFlagStrongholdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001223 RID: 4643 RVA: 0x000C0208 File Offset: 0x000BE408
		static ConfigFlagStrongholdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagStrongholdById.CreateStaticDefaultValue), new Action(ConfigFlagStrongholdById.ResetStaticDefaultValue));
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000C0228 File Offset: 0x000BE428
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

		// Token: 0x06001225 RID: 4645 RVA: 0x000C02A7 File Offset: 0x000BE4A7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagStrongholdById.LogPair = null;
			ConfigFlagStrongholdById.HandleId = 0;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000C02B5 File Offset: 0x000BE4B5
		public static void Init()
		{
			ConfigFlagStrongholdById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagStrongholdById.HandleId, "db_flagchallenge.db", "select BinData from `FlagStronghold` where Id=?");
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000C02D0 File Offset: 0x000BE4D0
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

		// Token: 0x04001507 RID: 5383
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001508 RID: 5384
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001509 RID: 5385
		private const string TABLE = "FlagStronghold";

		// Token: 0x0400150A RID: 5386
		private const string COMMAND = "select BinData from `FlagStronghold` where Id=?";

		// Token: 0x0400150B RID: 5387
		private const string KEY_PREFIX = "FlagStrongholdById";

		// Token: 0x0400150C RID: 5388
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400150D RID: 5389
		private static int HandleId;
	}
}
