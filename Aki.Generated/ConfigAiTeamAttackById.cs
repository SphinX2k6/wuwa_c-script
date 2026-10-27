using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008E RID: 142
	public class ConfigAiTeamAttackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0006C61C File Offset: 0x0006A81C
		static ConfigAiTeamAttackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiTeamAttackById.CreateStaticDefaultValue), new Action(ConfigAiTeamAttackById.ResetStaticDefaultValue));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0006C63C File Offset: 0x0006A83C
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

		// Token: 0x06000356 RID: 854 RVA: 0x0006C6BB File Offset: 0x0006A8BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAiTeamAttackById.LogPair = null;
			ConfigAiTeamAttackById.HandleId = 0;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0006C6C9 File Offset: 0x0006A8C9
		public static void Init()
		{
			ConfigAiTeamAttackById.HandleId = ConfigCommon.InitDataStatement(ConfigAiTeamAttackById.HandleId, "db_ai.db", "select BinData from `AiTeamAttack` where Id=?");
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0006C6E4 File Offset: 0x0006A8E4
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

		// Token: 0x040003C6 RID: 966
		private const string DB = "db_ai.db";

		// Token: 0x040003C7 RID: 967
		private const string FILE = "a.AI集群总表.xlsx";

		// Token: 0x040003C8 RID: 968
		private const string TABLE = "AiTeamAttack";

		// Token: 0x040003C9 RID: 969
		private const string COMMAND = "select BinData from `AiTeamAttack` where Id=?";

		// Token: 0x040003CA RID: 970
		private const string KEY_PREFIX = "AiTeamAttackById";

		// Token: 0x040003CB RID: 971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003CC RID: 972
		private static int HandleId;
	}
}
