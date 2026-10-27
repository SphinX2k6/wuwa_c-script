using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008D RID: 141
	public class ConfigAiTeamAreaNewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600034E RID: 846 RVA: 0x0006C3D5 File Offset: 0x0006A5D5
		static ConfigAiTeamAreaNewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiTeamAreaNewById.CreateStaticDefaultValue), new Action(ConfigAiTeamAreaNewById.ResetStaticDefaultValue));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
		public static void CreateStaticDefaultValue()
		{
			ConfigAiTeamAreaNewById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiTeamAreaNewById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI集群总表.xlsx"),
				new ValueTuple<string, object>("表名", "AiTeamAreaNew"),
				new ValueTuple<string, object>("语句", "select BinData from `AiTeamAreaNew` where Id=?")
			});
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0006C473 File Offset: 0x0006A673
		public static void ResetStaticDefaultValue()
		{
			ConfigAiTeamAreaNewById.LogPair = null;
			ConfigAiTeamAreaNewById.HandleId = 0;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0006C481 File Offset: 0x0006A681
		public static void Init()
		{
			ConfigAiTeamAreaNewById.HandleId = ConfigCommon.InitDataStatement(ConfigAiTeamAreaNewById.HandleId, "db_ai.db", "select BinData from `AiTeamAreaNew` where Id=?");
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0006C49C File Offset: 0x0006A69C
		public static AiTeamAreaNew? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiTeamAreaNewById.HandleId, ConfigAiTeamAreaNewById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamAreaNewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiTeamAreaNew?(AiTeamAreaNew.GetRootAsAiTeamAreaNew(configBuffer));
				}
			}
			ConfigAiTeamAreaNewById.LogPair.Clear();
			ConfigAiTeamAreaNewById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiTeamAreaNewById.HandleId, 1, p0Id, ConfigAiTeamAreaNewById.LogPair) || ConfigCommon.Step(ConfigAiTeamAreaNewById.HandleId, true, ConfigAiTeamAreaNewById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiTeamAreaNewById.HandleId, ConfigAiTeamAreaNewById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiTeamAreaNewById.HandleId, 0, ConfigAiTeamAreaNewById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiTeamAreaNewById.HandleId, ConfigAiTeamAreaNewById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiTeamAreaNew rootAsAiTeamAreaNew = AiTeamAreaNew.GetRootAsAiTeamAreaNew(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamAreaNewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiTeamAreaNewById.HandleId, ConfigAiTeamAreaNewById.LogPair);
			return new AiTeamAreaNew?(rootAsAiTeamAreaNew);
		}

		// Token: 0x040003BF RID: 959
		private const string DB = "db_ai.db";

		// Token: 0x040003C0 RID: 960
		private const string FILE = "a.AI集群总表.xlsx";

		// Token: 0x040003C1 RID: 961
		private const string TABLE = "AiTeamAreaNew";

		// Token: 0x040003C2 RID: 962
		private const string COMMAND = "select BinData from `AiTeamAreaNew` where Id=?";

		// Token: 0x040003C3 RID: 963
		private const string KEY_PREFIX = "AiTeamAreaNewById";

		// Token: 0x040003C4 RID: 964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003C5 RID: 965
		private static int HandleId;
	}
}
