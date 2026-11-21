using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DA RID: 730
	public class ConfigFightPhotoTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x000BDC9F File Offset: 0x000BBE9F
		static ConfigFightPhotoTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoTabById.CreateStaticDefaultValue), new Action(ConfigFightPhotoTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000BDCC0 File Offset: 0x000BBEC0
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

		// Token: 0x06001123 RID: 4387 RVA: 0x000BDD3F File Offset: 0x000BBF3F
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoTabById.LogPair = null;
			ConfigFightPhotoTabById.HandleId = 0;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000BDD4D File Offset: 0x000BBF4D
		public static void Init()
		{
			ConfigFightPhotoTabById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoTabById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoTab` where Id=?");
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000BDD68 File Offset: 0x000BBF68
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

		// Token: 0x040013DA RID: 5082
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013DB RID: 5083
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013DC RID: 5084
		private const string TABLE = "FightPhotoTab";

		// Token: 0x040013DD RID: 5085
		private const string COMMAND = "select BinData from `FightPhotoTab` where Id=?";

		// Token: 0x040013DE RID: 5086
		private const string KEY_PREFIX = "FightPhotoTabById";

		// Token: 0x040013DF RID: 5087
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013E0 RID: 5088
		private static int HandleId;
	}
}
