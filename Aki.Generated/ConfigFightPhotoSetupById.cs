using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D8 RID: 728
	public class ConfigFightPhotoSetupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x000BD8C3 File Offset: 0x000BBAC3
		static ConfigFightPhotoSetupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoSetupById.CreateStaticDefaultValue), new Action(ConfigFightPhotoSetupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000BD8E4 File Offset: 0x000BBAE4
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

		// Token: 0x06001117 RID: 4375 RVA: 0x000BD963 File Offset: 0x000BBB63
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoSetupById.LogPair = null;
			ConfigFightPhotoSetupById.HandleId = 0;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000BD971 File Offset: 0x000BBB71
		public static void Init()
		{
			ConfigFightPhotoSetupById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoSetupById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoSetup` where Id=?");
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000BD98C File Offset: 0x000BBB8C
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

		// Token: 0x040013CC RID: 5068
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013CD RID: 5069
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013CE RID: 5070
		private const string TABLE = "FightPhotoSetup";

		// Token: 0x040013CF RID: 5071
		private const string COMMAND = "select BinData from `FightPhotoSetup` where Id=?";

		// Token: 0x040013D0 RID: 5072
		private const string KEY_PREFIX = "FightPhotoSetupById";

		// Token: 0x040013D1 RID: 5073
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013D2 RID: 5074
		private static int HandleId;
	}
}
