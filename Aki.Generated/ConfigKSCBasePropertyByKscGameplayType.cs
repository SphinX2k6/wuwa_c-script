using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048C RID: 1164
	public class ConfigKSCBasePropertyByKscGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B52 RID: 6994 RVA: 0x000F764C File Offset: 0x000F584C
		static ConfigKSCBasePropertyByKscGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyByKscGameplayType.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyByKscGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000F766C File Offset: 0x000F586C
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBasePropertyByKscGameplayType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBasePropertyByKscGameplayType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscproperty.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat属性.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBaseProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBaseProperty` where KscGameplayType=?")
			});
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000F76EB File Offset: 0x000F58EB
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyByKscGameplayType.LogPair = null;
			ConfigKSCBasePropertyByKscGameplayType.HandleId = 0;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000F76F9 File Offset: 0x000F58F9
		public static void Init()
		{
			ConfigKSCBasePropertyByKscGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyByKscGameplayType.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty` where KscGameplayType=?");
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000F7714 File Offset: 0x000F5914
		[NullableContext(2)]
		public static IReadOnlyList<KSCBaseProperty> GetConfigList(int p0KscGameplayType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBasePropertyByKscGameplayType.HandleId, ConfigKSCBasePropertyByKscGameplayType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBasePropertyByKscGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KscGameplayType);
				IReadOnlyList<KSCBaseProperty> readOnlyList = (IReadOnlyList<KSCBaseProperty>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKSCBasePropertyByKscGameplayType.LogPair.Clear();
			ConfigKSCBasePropertyByKscGameplayType.LogPair.Add(new ValueTuple<string, object>("KscGameplayType", p0KscGameplayType));
			if (!ConfigCommon.BindInt(ConfigKSCBasePropertyByKscGameplayType.HandleId, 1, p0KscGameplayType, ConfigKSCBasePropertyByKscGameplayType.LogPair))
			{
				ConfigCommon.Reset(ConfigKSCBasePropertyByKscGameplayType.HandleId, ConfigKSCBasePropertyByKscGameplayType.LogPair);
				return null;
			}
			List<KSCBaseProperty> list = new List<KSCBaseProperty>();
			while (ConfigCommon.Step(ConfigKSCBasePropertyByKscGameplayType.HandleId, false, ConfigKSCBasePropertyByKscGameplayType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBasePropertyByKscGameplayType.HandleId, 0, ConfigKSCBasePropertyByKscGameplayType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCBasePropertyByKscGameplayType.HandleId, ConfigKSCBasePropertyByKscGameplayType.LogPair);
					return null;
				}
				KSCBaseProperty rootAsKSCBaseProperty = KSCBaseProperty.GetRootAsKSCBaseProperty(new ByteBuffer(item2));
				list.Add(rootAsKSCBaseProperty);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBasePropertyByKscGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0KscGameplayType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCBasePropertyByKscGameplayType.HandleId, ConfigKSCBasePropertyByKscGameplayType.LogPair);
			return list;
		}

		// Token: 0x04001FB8 RID: 8120
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001FB9 RID: 8121
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001FBA RID: 8122
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001FBB RID: 8123
		private const string COMMAND = "select BinData from `KSCBaseProperty` where KscGameplayType=?";

		// Token: 0x04001FBC RID: 8124
		private const string KEY_PREFIX = "KSCBasePropertyByKscGameplayType";

		// Token: 0x04001FBD RID: 8125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FBE RID: 8126
		private static int HandleId;
	}
}
