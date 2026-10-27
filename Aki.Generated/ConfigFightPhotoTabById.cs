using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C5 RID: 709
	public class ConfigFightPhotoTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x000B7793 File Offset: 0x000B5993
		static ConfigFightPhotoTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoTabById.CreateStaticDefaultValue), new Action(ConfigFightPhotoTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000B77B4 File Offset: 0x000B59B4
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoTab` where Id=?")
			});
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000B7833 File Offset: 0x000B5A33
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoTabById.LogPair = null;
			ConfigFightPhotoTabById.HandleId = 0;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000B7841 File Offset: 0x000B5A41
		public static void Init()
		{
			ConfigFightPhotoTabById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoTabById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoTab` where Id=?");
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000B785C File Offset: 0x000B5A5C
		public static FightPhotoTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoTabById.HandleId, ConfigFightPhotoTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightPhotoTab?(FightPhotoTab.GetRootAsFightPhotoTab(configBuffer));
				}
			}
			ConfigFightPhotoTabById.LogPair.Clear();
			ConfigFightPhotoTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightPhotoTabById.HandleId, 1, p0Id, ConfigFightPhotoTabById.LogPair) || ConfigCommon.Step(ConfigFightPhotoTabById.HandleId, true, ConfigFightPhotoTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightPhotoTabById.HandleId, ConfigFightPhotoTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoTabById.HandleId, 0, ConfigFightPhotoTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightPhotoTabById.HandleId, ConfigFightPhotoTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightPhotoTab rootAsFightPhotoTab = FightPhotoTab.GetRootAsFightPhotoTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightPhotoTabById.HandleId, ConfigFightPhotoTabById.LogPair);
			return new FightPhotoTab?(rootAsFightPhotoTab);
		}

		// Token: 0x04001347 RID: 4935
		private const string DB = "db_fightphotooption.db";

		// Token: 0x04001348 RID: 4936
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x04001349 RID: 4937
		private const string TABLE = "FightPhotoTab";

		// Token: 0x0400134A RID: 4938
		private const string COMMAND = "select BinData from `FightPhotoTab` where Id=?";

		// Token: 0x0400134B RID: 4939
		private const string KEY_PREFIX = "FightPhotoTabById";

		// Token: 0x0400134C RID: 4940
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400134D RID: 4941
		private static int HandleId;
	}
}
