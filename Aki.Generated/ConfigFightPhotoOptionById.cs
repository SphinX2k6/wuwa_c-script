using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C1 RID: 705
	public class ConfigFightPhotoOptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600108B RID: 4235 RVA: 0x000B6FDB File Offset: 0x000B51DB
		static ConfigFightPhotoOptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoOptionById.CreateStaticDefaultValue), new Action(ConfigFightPhotoOptionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000B6FFC File Offset: 0x000B51FC
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

		// Token: 0x0600108D RID: 4237 RVA: 0x000B707B File Offset: 0x000B527B
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoOptionById.LogPair = null;
			ConfigFightPhotoOptionById.HandleId = 0;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000B7089 File Offset: 0x000B5289
		public static void Init()
		{
			ConfigFightPhotoOptionById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoOptionById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoOption` where Id=?");
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000B70A4 File Offset: 0x000B52A4
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

		// Token: 0x0400132B RID: 4907
		private const string DB = "db_fightphotooption.db";

		// Token: 0x0400132C RID: 4908
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x0400132D RID: 4909
		private const string TABLE = "FightPhotoOption";

		// Token: 0x0400132E RID: 4910
		private const string COMMAND = "select BinData from `FightPhotoOption` where Id=?";

		// Token: 0x0400132F RID: 4911
		private const string KEY_PREFIX = "FightPhotoOptionById";

		// Token: 0x04001330 RID: 4912
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001331 RID: 4913
		private static int HandleId;
	}
}
