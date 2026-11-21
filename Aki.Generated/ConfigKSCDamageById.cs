using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000490 RID: 1168
	public class ConfigKSCDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x000F7DF3 File Offset: 0x000F5FF3
		static ConfigKSCDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageById.CreateStaticDefaultValue), new Action(ConfigKSCDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000F7E14 File Offset: 0x000F6014
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCDamageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCDamageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscdamage.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat结算.xlsx"),
				new ValueTuple<string, object>("表名", "KSCDamage"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCDamage` where Id=?")
			});
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000F7E93 File Offset: 0x000F6093
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageById.LogPair = null;
			ConfigKSCDamageById.HandleId = 0;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000F7EA1 File Offset: 0x000F60A1
		public static void Init()
		{
			ConfigKSCDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageById.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage` where Id=?");
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000F7EBC File Offset: 0x000F60BC
		public static KSCDamage? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCDamageById.HandleId, ConfigKSCDamageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCDamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KSCDamage?(KSCDamage.GetRootAsKSCDamage(configBuffer));
				}
			}
			ConfigKSCDamageById.LogPair.Clear();
			ConfigKSCDamageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigKSCDamageById.HandleId, 1, (double)p0Id, ConfigKSCDamageById.LogPair) || ConfigCommon.Step(ConfigKSCDamageById.HandleId, true, ConfigKSCDamageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKSCDamageById.HandleId, ConfigKSCDamageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCDamageById.HandleId, 0, ConfigKSCDamageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKSCDamageById.HandleId, ConfigKSCDamageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KSCDamage rootAsKSCDamage = KSCDamage.GetRootAsKSCDamage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCDamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKSCDamageById.HandleId, ConfigKSCDamageById.LogPair);
			return new KSCDamage?(rootAsKSCDamage);
		}

		// Token: 0x04001FD4 RID: 8148
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001FD5 RID: 8149
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001FD6 RID: 8150
		private const string TABLE = "KSCDamage";

		// Token: 0x04001FD7 RID: 8151
		private const string COMMAND = "select BinData from `KSCDamage` where Id=?";

		// Token: 0x04001FD8 RID: 8152
		private const string KEY_PREFIX = "KSCDamageById";

		// Token: 0x04001FD9 RID: 8153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FDA RID: 8154
		private static int HandleId;
	}
}
