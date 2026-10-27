using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C3 RID: 707
	public class ConfigFightPhotoSetupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x000B73B7 File Offset: 0x000B55B7
		static ConfigFightPhotoSetupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoSetupById.CreateStaticDefaultValue), new Action(ConfigFightPhotoSetupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x000B73D8 File Offset: 0x000B55D8
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoSetupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoSetupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoSetup` where Id=?")
			});
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x000B7457 File Offset: 0x000B5657
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoSetupById.LogPair = null;
			ConfigFightPhotoSetupById.HandleId = 0;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000B7465 File Offset: 0x000B5665
		public static void Init()
		{
			ConfigFightPhotoSetupById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoSetupById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoSetup` where Id=?");
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000B7480 File Offset: 0x000B5680
		public static FightPhotoSetup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoSetupById.HandleId, ConfigFightPhotoSetupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightPhotoSetup?(FightPhotoSetup.GetRootAsFightPhotoSetup(configBuffer));
				}
			}
			ConfigFightPhotoSetupById.LogPair.Clear();
			ConfigFightPhotoSetupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightPhotoSetupById.HandleId, 1, p0Id, ConfigFightPhotoSetupById.LogPair) || ConfigCommon.Step(ConfigFightPhotoSetupById.HandleId, true, ConfigFightPhotoSetupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightPhotoSetupById.HandleId, ConfigFightPhotoSetupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoSetupById.HandleId, 0, ConfigFightPhotoSetupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightPhotoSetupById.HandleId, ConfigFightPhotoSetupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightPhotoSetup rootAsFightPhotoSetup = FightPhotoSetup.GetRootAsFightPhotoSetup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightPhotoSetupById.HandleId, ConfigFightPhotoSetupById.LogPair);
			return new FightPhotoSetup?(rootAsFightPhotoSetup);
		}

		// Token: 0x04001339 RID: 4921
		private const string DB = "db_fightphotooption.db";

		// Token: 0x0400133A RID: 4922
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x0400133B RID: 4923
		private const string TABLE = "FightPhotoSetup";

		// Token: 0x0400133C RID: 4924
		private const string COMMAND = "select BinData from `FightPhotoSetup` where Id=?";

		// Token: 0x0400133D RID: 4925
		private const string KEY_PREFIX = "FightPhotoSetupById";

		// Token: 0x0400133E RID: 4926
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400133F RID: 4927
		private static int HandleId;
	}
}
