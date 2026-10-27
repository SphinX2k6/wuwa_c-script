using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BD RID: 701
	public class ConfigFightFormationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x000B6824 File Offset: 0x000B4A24
		static ConfigFightFormationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightFormationById.CreateStaticDefaultValue), new Action(ConfigFightFormationById.ResetStaticDefaultValue));
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000B6844 File Offset: 0x000B4A44
		public static void CreateStaticDefaultValue()
		{
			ConfigFightFormationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightFormationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FightFormation"),
				new ValueTuple<string, object>("语句", "select BinData from `FightFormation` where Id=?")
			});
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000B68C3 File Offset: 0x000B4AC3
		public static void ResetStaticDefaultValue()
		{
			ConfigFightFormationById.LogPair = null;
			ConfigFightFormationById.HandleId = 0;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x000B68D1 File Offset: 0x000B4AD1
		public static void Init()
		{
			ConfigFightFormationById.HandleId = ConfigCommon.InitDataStatement(ConfigFightFormationById.HandleId, "db_formation.db", "select BinData from `FightFormation` where Id=?");
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000B68EC File Offset: 0x000B4AEC
		public static FightFormation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightFormation?(FightFormation.GetRootAsFightFormation(configBuffer));
				}
			}
			ConfigFightFormationById.LogPair.Clear();
			ConfigFightFormationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightFormationById.HandleId, 1, p0Id, ConfigFightFormationById.LogPair) || ConfigCommon.Step(ConfigFightFormationById.HandleId, true, ConfigFightFormationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightFormationById.HandleId, 0, ConfigFightFormationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightFormation rootAsFightFormation = FightFormation.GetRootAsFightFormation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
			return new FightFormation?(rootAsFightFormation);
		}

		// Token: 0x0400130F RID: 4879
		private const string DB = "db_formation.db";

		// Token: 0x04001310 RID: 4880
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04001311 RID: 4881
		private const string TABLE = "FightFormation";

		// Token: 0x04001312 RID: 4882
		private const string COMMAND = "select BinData from `FightFormation` where Id=?";

		// Token: 0x04001313 RID: 4883
		private const string KEY_PREFIX = "FightFormationById";

		// Token: 0x04001314 RID: 4884
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001315 RID: 4885
		private static int HandleId;
	}
}
