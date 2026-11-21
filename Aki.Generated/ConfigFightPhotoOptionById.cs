using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D6 RID: 726
	public class ConfigFightPhotoOptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x000BD4E7 File Offset: 0x000BB6E7
		static ConfigFightPhotoOptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoOptionById.CreateStaticDefaultValue), new Action(ConfigFightPhotoOptionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x000BD508 File Offset: 0x000BB708
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoOptionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoOptionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoOption"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoOption` where Id=?")
			});
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000BD587 File Offset: 0x000BB787
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoOptionById.LogPair = null;
			ConfigFightPhotoOptionById.HandleId = 0;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000BD595 File Offset: 0x000BB795
		public static void Init()
		{
			ConfigFightPhotoOptionById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoOptionById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoOption` where Id=?");
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000BD5B0 File Offset: 0x000BB7B0
		public static FightPhotoOption? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoOptionById.HandleId, ConfigFightPhotoOptionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoOptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightPhotoOption?(FightPhotoOption.GetRootAsFightPhotoOption(configBuffer));
				}
			}
			ConfigFightPhotoOptionById.LogPair.Clear();
			ConfigFightPhotoOptionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightPhotoOptionById.HandleId, 1, p0Id, ConfigFightPhotoOptionById.LogPair) || ConfigCommon.Step(ConfigFightPhotoOptionById.HandleId, true, ConfigFightPhotoOptionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightPhotoOptionById.HandleId, ConfigFightPhotoOptionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoOptionById.HandleId, 0, ConfigFightPhotoOptionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightPhotoOptionById.HandleId, ConfigFightPhotoOptionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightPhotoOption rootAsFightPhotoOption = FightPhotoOption.GetRootAsFightPhotoOption(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoOptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightPhotoOptionById.HandleId, ConfigFightPhotoOptionById.LogPair);
			return new FightPhotoOption?(rootAsFightPhotoOption);
		}

		// Token: 0x040013BE RID: 5054
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013BF RID: 5055
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013C0 RID: 5056
		private const string TABLE = "FightPhotoOption";

		// Token: 0x040013C1 RID: 5057
		private const string COMMAND = "select BinData from `FightPhotoOption` where Id=?";

		// Token: 0x040013C2 RID: 5058
		private const string KEY_PREFIX = "FightPhotoOptionById";

		// Token: 0x040013C3 RID: 5059
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013C4 RID: 5060
		private static int HandleId;
	}
}
