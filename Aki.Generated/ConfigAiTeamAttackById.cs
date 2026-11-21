using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000096 RID: 150
	public class ConfigAiTeamAttackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00070ED0 File Offset: 0x0006F0D0
		static ConfigAiTeamAttackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiTeamAttackById.CreateStaticDefaultValue), new Action(ConfigAiTeamAttackById.ResetStaticDefaultValue));
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00070EF0 File Offset: 0x0006F0F0
		public static void CreateStaticDefaultValue()
		{
			ConfigAiTeamAttackById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiTeamAttackById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI集群总表.xlsx"),
				new ValueTuple<string, object>("表名", "AiTeamAttack"),
				new ValueTuple<string, object>("语句", "select BinData from `AiTeamAttack` where Id=?")
			});
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00070F6F File Offset: 0x0006F16F
		public static void ResetStaticDefaultValue()
		{
			ConfigAiTeamAttackById.LogPair = null;
			ConfigAiTeamAttackById.HandleId = 0;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00070F7D File Offset: 0x0006F17D
		public static void Init()
		{
			ConfigAiTeamAttackById.HandleId = ConfigCommon.InitDataStatement(ConfigAiTeamAttackById.HandleId, "db_ai.db", "select BinData from `AiTeamAttack` where Id=?");
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00070F98 File Offset: 0x0006F198
		public static AiTeamAttack? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiTeamAttackById.HandleId, ConfigAiTeamAttackById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamAttackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiTeamAttack?(AiTeamAttack.GetRootAsAiTeamAttack(configBuffer));
				}
			}
			ConfigAiTeamAttackById.LogPair.Clear();
			ConfigAiTeamAttackById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiTeamAttackById.HandleId, 1, p0Id, ConfigAiTeamAttackById.LogPair) || ConfigCommon.Step(ConfigAiTeamAttackById.HandleId, true, ConfigAiTeamAttackById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiTeamAttackById.HandleId, ConfigAiTeamAttackById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiTeamAttackById.HandleId, 0, ConfigAiTeamAttackById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiTeamAttackById.HandleId, ConfigAiTeamAttackById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiTeamAttack rootAsAiTeamAttack = AiTeamAttack.GetRootAsAiTeamAttack(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamAttackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiTeamAttackById.HandleId, ConfigAiTeamAttackById.LogPair);
			return new AiTeamAttack?(rootAsAiTeamAttack);
		}

		// Token: 0x040003FE RID: 1022
		private const string DB = "db_ai.db";

		// Token: 0x040003FF RID: 1023
		private const string FILE = "a.AI集群总表.xlsx";

		// Token: 0x04000400 RID: 1024
		private const string TABLE = "AiTeamAttack";

		// Token: 0x04000401 RID: 1025
		private const string COMMAND = "select BinData from `AiTeamAttack` where Id=?";

		// Token: 0x04000402 RID: 1026
		private const string KEY_PREFIX = "AiTeamAttackById";

		// Token: 0x04000403 RID: 1027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000404 RID: 1028
		private static int HandleId;
	}
}
