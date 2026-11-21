using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000491 RID: 1169
	public class ConfigKSCDamageByKscGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x000F803D File Offset: 0x000F623D
		static ConfigKSCDamageByKscGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageByKscGameplayType.CreateStaticDefaultValue), new Action(ConfigKSCDamageByKscGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000F805C File Offset: 0x000F625C
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

		// Token: 0x06001B72 RID: 7026 RVA: 0x000F80DB File Offset: 0x000F62DB
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageByKscGameplayType.LogPair = null;
			ConfigKSCDamageByKscGameplayType.HandleId = 0;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000F80E9 File Offset: 0x000F62E9
		public static void Init()
		{
			ConfigKSCDamageByKscGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageByKscGameplayType.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage` where KscGameplayType=?");
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000F8104 File Offset: 0x000F6304
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

		// Token: 0x04001FDB RID: 8155
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001FDC RID: 8156
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001FDD RID: 8157
		private const string TABLE = "KSCDamage";

		// Token: 0x04001FDE RID: 8158
		private const string COMMAND = "select BinData from `KSCDamage` where KscGameplayType=?";

		// Token: 0x04001FDF RID: 8159
		private const string KEY_PREFIX = "KSCDamageByKscGameplayType";

		// Token: 0x04001FE0 RID: 8160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FE1 RID: 8161
		private static int HandleId;
	}
}
