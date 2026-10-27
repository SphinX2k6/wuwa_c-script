using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047B RID: 1147
	public class ConfigKSCDamageByKscGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x000F18E9 File Offset: 0x000EFAE9
		static ConfigKSCDamageByKscGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageByKscGameplayType.CreateStaticDefaultValue), new Action(ConfigKSCDamageByKscGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000F1908 File Offset: 0x000EFB08
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCDamageByKscGameplayType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCDamageByKscGameplayType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscdamage.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat结算.xlsx"),
				new ValueTuple<string, object>("表名", "KSCDamage"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCDamage` where KscGameplayType=?")
			});
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000F1987 File Offset: 0x000EFB87
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageByKscGameplayType.LogPair = null;
			ConfigKSCDamageByKscGameplayType.HandleId = 0;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000F1995 File Offset: 0x000EFB95
		public static void Init()
		{
			ConfigKSCDamageByKscGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageByKscGameplayType.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage` where KscGameplayType=?");
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000F19B0 File Offset: 0x000EFBB0
		[NullableContext(2)]
		public static IReadOnlyList<KSCDamage> GetConfigList(int p0KscGameplayType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCDamageByKscGameplayType.HandleId, ConfigKSCDamageByKscGameplayType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCDamageByKscGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KscGameplayType);
				IReadOnlyList<KSCDamage> readOnlyList = (IReadOnlyList<KSCDamage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKSCDamageByKscGameplayType.LogPair.Clear();
			ConfigKSCDamageByKscGameplayType.LogPair.Add(new ValueTuple<string, object>("KscGameplayType", p0KscGameplayType));
			if (!ConfigCommon.BindInt(ConfigKSCDamageByKscGameplayType.HandleId, 1, p0KscGameplayType, ConfigKSCDamageByKscGameplayType.LogPair))
			{
				ConfigCommon.Reset(ConfigKSCDamageByKscGameplayType.HandleId, ConfigKSCDamageByKscGameplayType.LogPair);
				return null;
			}
			List<KSCDamage> list = new List<KSCDamage>();
			while (ConfigCommon.Step(ConfigKSCDamageByKscGameplayType.HandleId, false, ConfigKSCDamageByKscGameplayType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCDamageByKscGameplayType.HandleId, 0, ConfigKSCDamageByKscGameplayType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCDamageByKscGameplayType.HandleId, ConfigKSCDamageByKscGameplayType.LogPair);
					return null;
				}
				KSCDamage rootAsKSCDamage = KSCDamage.GetRootAsKSCDamage(new ByteBuffer(item2));
				list.Add(rootAsKSCDamage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCDamageByKscGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KscGameplayType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCDamageByKscGameplayType.HandleId, ConfigKSCDamageByKscGameplayType.LogPair);
			return list;
		}

		// Token: 0x04001F41 RID: 8001
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001F42 RID: 8002
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001F43 RID: 8003
		private const string TABLE = "KSCDamage";

		// Token: 0x04001F44 RID: 8004
		private const string COMMAND = "select BinData from `KSCDamage` where KscGameplayType=?";

		// Token: 0x04001F45 RID: 8005
		private const string KEY_PREFIX = "KSCDamageByKscGameplayType";

		// Token: 0x04001F46 RID: 8006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F47 RID: 8007
		private static int HandleId;
	}
}
