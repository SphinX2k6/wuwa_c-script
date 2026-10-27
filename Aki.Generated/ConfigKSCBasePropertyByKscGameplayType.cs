using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000476 RID: 1142
	public class ConfigKSCBasePropertyByKscGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x000F0EF8 File Offset: 0x000EF0F8
		static ConfigKSCBasePropertyByKscGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyByKscGameplayType.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyByKscGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000F0F18 File Offset: 0x000EF118
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

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000F0F97 File Offset: 0x000EF197
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyByKscGameplayType.LogPair = null;
			ConfigKSCBasePropertyByKscGameplayType.HandleId = 0;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000F0FA5 File Offset: 0x000EF1A5
		public static void Init()
		{
			ConfigKSCBasePropertyByKscGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyByKscGameplayType.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty` where KscGameplayType=?");
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000F0FC0 File Offset: 0x000EF1C0
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

		// Token: 0x04001F1E RID: 7966
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001F1F RID: 7967
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001F20 RID: 7968
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001F21 RID: 7969
		private const string COMMAND = "select BinData from `KSCBaseProperty` where KscGameplayType=?";

		// Token: 0x04001F22 RID: 7970
		private const string KEY_PREFIX = "KSCBasePropertyByKscGameplayType";

		// Token: 0x04001F23 RID: 7971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F24 RID: 7972
		private static int HandleId;
	}
}
