using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000475 RID: 1141
	public class ConfigKSCBasePropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AC8 RID: 6856 RVA: 0x000F0CAF File Offset: 0x000EEEAF
		static ConfigKSCBasePropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyById.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x000F0CD0 File Offset: 0x000EEED0
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBasePropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBasePropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscproperty.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat属性.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBaseProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBaseProperty` where Id=?")
			});
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x000F0D4F File Offset: 0x000EEF4F
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyById.LogPair = null;
			ConfigKSCBasePropertyById.HandleId = 0;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x000F0D5D File Offset: 0x000EEF5D
		public static void Init()
		{
			ConfigKSCBasePropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyById.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty` where Id=?");
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000F0D78 File Offset: 0x000EEF78
		public static KSCBaseProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBasePropertyById.HandleId, ConfigKSCBasePropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBasePropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KSCBaseProperty?(KSCBaseProperty.GetRootAsKSCBaseProperty(configBuffer));
				}
			}
			ConfigKSCBasePropertyById.LogPair.Clear();
			ConfigKSCBasePropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKSCBasePropertyById.HandleId, 1, p0Id, ConfigKSCBasePropertyById.LogPair) || ConfigCommon.Step(ConfigKSCBasePropertyById.HandleId, true, ConfigKSCBasePropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKSCBasePropertyById.HandleId, ConfigKSCBasePropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBasePropertyById.HandleId, 0, ConfigKSCBasePropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKSCBasePropertyById.HandleId, ConfigKSCBasePropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KSCBaseProperty rootAsKSCBaseProperty = KSCBaseProperty.GetRootAsKSCBaseProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBasePropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKSCBasePropertyById.HandleId, ConfigKSCBasePropertyById.LogPair);
			return new KSCBaseProperty?(rootAsKSCBaseProperty);
		}

		// Token: 0x04001F17 RID: 7959
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001F18 RID: 7960
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001F19 RID: 7961
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001F1A RID: 7962
		private const string COMMAND = "select BinData from `KSCBaseProperty` where Id=?";

		// Token: 0x04001F1B RID: 7963
		private const string KEY_PREFIX = "KSCBasePropertyById";

		// Token: 0x04001F1C RID: 7964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F1D RID: 7965
		private static int HandleId;
	}
}
