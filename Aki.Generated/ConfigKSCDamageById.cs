using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047A RID: 1146
	public class ConfigKSCDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AE6 RID: 6886 RVA: 0x000F169F File Offset: 0x000EF89F
		static ConfigKSCDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageById.CreateStaticDefaultValue), new Action(ConfigKSCDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000F16C0 File Offset: 0x000EF8C0
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

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000F173F File Offset: 0x000EF93F
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageById.LogPair = null;
			ConfigKSCDamageById.HandleId = 0;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000F174D File Offset: 0x000EF94D
		public static void Init()
		{
			ConfigKSCDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageById.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage` where Id=?");
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000F1768 File Offset: 0x000EF968
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

		// Token: 0x04001F3A RID: 7994
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001F3B RID: 7995
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001F3C RID: 7996
		private const string TABLE = "KSCDamage";

		// Token: 0x04001F3D RID: 7997
		private const string COMMAND = "select BinData from `KSCDamage` where Id=?";

		// Token: 0x04001F3E RID: 7998
		private const string KEY_PREFIX = "KSCDamageById";

		// Token: 0x04001F3F RID: 7999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F40 RID: 8000
		private static int HandleId;
	}
}
