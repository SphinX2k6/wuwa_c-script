using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000478 RID: 1144
	public class ConfigKSCBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x000F12C3 File Offset: 0x000EF4C3
		static ConfigKSCBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBuffById.CreateStaticDefaultValue), new Action(ConfigKSCBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000F12E4 File Offset: 0x000EF4E4
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tdbuff.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombatBuff.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBuff` where Id=?")
			});
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000F1363 File Offset: 0x000EF563
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBuffById.LogPair = null;
			ConfigKSCBuffById.HandleId = 0;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000F1371 File Offset: 0x000EF571
		public static void Init()
		{
			ConfigKSCBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBuffById.HandleId, "db_tdbuff.db", "select BinData from `KSCBuff` where Id=?");
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000F138C File Offset: 0x000EF58C
		public static KSCBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBuffById.HandleId, ConfigKSCBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KSCBuff?(KSCBuff.GetRootAsKSCBuff(configBuffer));
				}
			}
			ConfigKSCBuffById.LogPair.Clear();
			ConfigKSCBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKSCBuffById.HandleId, 1, p0Id, ConfigKSCBuffById.LogPair) || ConfigCommon.Step(ConfigKSCBuffById.HandleId, true, ConfigKSCBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKSCBuffById.HandleId, ConfigKSCBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBuffById.HandleId, 0, ConfigKSCBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKSCBuffById.HandleId, ConfigKSCBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KSCBuff rootAsKSCBuff = KSCBuff.GetRootAsKSCBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KSCBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKSCBuffById.HandleId, ConfigKSCBuffById.LogPair);
			return new KSCBuff?(rootAsKSCBuff);
		}

		// Token: 0x04001F2C RID: 7980
		private const string DB = "db_tdbuff.db";

		// Token: 0x04001F2D RID: 7981
		private const string FILE = "s.SimpleCombatBuff.xlsx";

		// Token: 0x04001F2E RID: 7982
		private const string TABLE = "KSCBuff";

		// Token: 0x04001F2F RID: 7983
		private const string COMMAND = "select BinData from `KSCBuff` where Id=?";

		// Token: 0x04001F30 RID: 7984
		private const string KEY_PREFIX = "KSCBuffById";

		// Token: 0x04001F31 RID: 7985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F32 RID: 7986
		private static int HandleId;
	}
}
