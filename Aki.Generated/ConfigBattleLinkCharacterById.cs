using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F3 RID: 243
	public class ConfigBattleLinkCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x0007D6CF File Offset: 0x0007B8CF
		static ConfigBattleLinkCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleLinkCharacterById.CreateStaticDefaultValue), new Action(ConfigBattleLinkCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0007D6F0 File Offset: 0x0007B8F0
		public static void CreateStaticDefaultValue()
		{
			ConfigBattleLinkCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattleLinkCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "BattleLinkCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `BattleLinkCharacter` where Id=?")
			});
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0007D76F File Offset: 0x0007B96F
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleLinkCharacterById.LogPair = null;
			ConfigBattleLinkCharacterById.HandleId = 0;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0007D77D File Offset: 0x0007B97D
		public static void Init()
		{
			ConfigBattleLinkCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleLinkCharacterById.HandleId, "db_dreamlink.db", "select BinData from `BattleLinkCharacter` where Id=?");
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0007D798 File Offset: 0x0007B998
		public static BattleLinkCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattleLinkCharacterById.HandleId, ConfigBattleLinkCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleLinkCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattleLinkCharacter?(BattleLinkCharacter.GetRootAsBattleLinkCharacter(configBuffer));
				}
			}
			ConfigBattleLinkCharacterById.LogPair.Clear();
			ConfigBattleLinkCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBattleLinkCharacterById.HandleId, 1, p0Id, ConfigBattleLinkCharacterById.LogPair) || ConfigCommon.Step(ConfigBattleLinkCharacterById.HandleId, true, ConfigBattleLinkCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattleLinkCharacterById.HandleId, ConfigBattleLinkCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattleLinkCharacterById.HandleId, 0, ConfigBattleLinkCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattleLinkCharacterById.HandleId, ConfigBattleLinkCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattleLinkCharacter rootAsBattleLinkCharacter = BattleLinkCharacter.GetRootAsBattleLinkCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleLinkCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattleLinkCharacterById.HandleId, ConfigBattleLinkCharacterById.LogPair);
			return new BattleLinkCharacter?(rootAsBattleLinkCharacter);
		}

		// Token: 0x04000689 RID: 1673
		private const string DB = "db_dreamlink.db";

		// Token: 0x0400068A RID: 1674
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x0400068B RID: 1675
		private const string TABLE = "BattleLinkCharacter";

		// Token: 0x0400068C RID: 1676
		private const string COMMAND = "select BinData from `BattleLinkCharacter` where Id=?";

		// Token: 0x0400068D RID: 1677
		private const string KEY_PREFIX = "BattleLinkCharacterById";

		// Token: 0x0400068E RID: 1678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400068F RID: 1679
		private static int HandleId;
	}
}
