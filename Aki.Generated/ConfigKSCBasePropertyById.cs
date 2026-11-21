using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048B RID: 1163
	public class ConfigKSCBasePropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B4C RID: 6988 RVA: 0x000F7403 File Offset: 0x000F5603
		static ConfigKSCBasePropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyById.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000F7424 File Offset: 0x000F5624
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

		// Token: 0x06001B4E RID: 6990 RVA: 0x000F74A3 File Offset: 0x000F56A3
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyById.LogPair = null;
			ConfigKSCBasePropertyById.HandleId = 0;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000F74B1 File Offset: 0x000F56B1
		public static void Init()
		{
			ConfigKSCBasePropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyById.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty` where Id=?");
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000F74CC File Offset: 0x000F56CC
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

		// Token: 0x04001FB1 RID: 8113
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001FB2 RID: 8114
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001FB3 RID: 8115
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001FB4 RID: 8116
		private const string COMMAND = "select BinData from `KSCBaseProperty` where Id=?";

		// Token: 0x04001FB5 RID: 8117
		private const string KEY_PREFIX = "KSCBasePropertyById";

		// Token: 0x04001FB6 RID: 8118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FB7 RID: 8119
		private static int HandleId;
	}
}
