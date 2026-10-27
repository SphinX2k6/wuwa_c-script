using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E4 RID: 228
	public class ConfigBattleLinkCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x00077D6B File Offset: 0x00075F6B
		static ConfigBattleLinkCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleLinkCharacterById.CreateStaticDefaultValue), new Action(ConfigBattleLinkCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00077D8C File Offset: 0x00075F8C
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

		// Token: 0x0600055B RID: 1371 RVA: 0x00077E0B File Offset: 0x0007600B
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleLinkCharacterById.LogPair = null;
			ConfigBattleLinkCharacterById.HandleId = 0;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00077E19 File Offset: 0x00076019
		public static void Init()
		{
			ConfigBattleLinkCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleLinkCharacterById.HandleId, "db_dreamlink.db", "select BinData from `BattleLinkCharacter` where Id=?");
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00077E34 File Offset: 0x00076034
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

		// Token: 0x04000620 RID: 1568
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000621 RID: 1569
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000622 RID: 1570
		private const string TABLE = "BattleLinkCharacter";

		// Token: 0x04000623 RID: 1571
		private const string COMMAND = "select BinData from `BattleLinkCharacter` where Id=?";

		// Token: 0x04000624 RID: 1572
		private const string KEY_PREFIX = "BattleLinkCharacterById";

		// Token: 0x04000625 RID: 1573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000626 RID: 1574
		private static int HandleId;
	}
}
