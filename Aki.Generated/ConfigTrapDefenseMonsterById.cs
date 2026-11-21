using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0B RID: 2827
	public class ConfigTrapDefenseMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004256 RID: 16982 RVA: 0x001D3DB0 File Offset: 0x001D1FB0
		static ConfigTrapDefenseMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x001D3DD0 File Offset: 0x001D1FD0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonster` where Id=?")
			});
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x001D3E4F File Offset: 0x001D204F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterById.LogPair = null;
			ConfigTrapDefenseMonsterById.HandleId = 0;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x001D3E5D File Offset: 0x001D205D
		public static void Init()
		{
			ConfigTrapDefenseMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonster` where Id=?");
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x001D3E78 File Offset: 0x001D2078
		public static TrapDefenseMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonster?(TrapDefenseMonster.GetRootAsTrapDefenseMonster(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterById.LogPair.Clear();
			ConfigTrapDefenseMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterById.HandleId, true, ConfigTrapDefenseMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterById.HandleId, 0, ConfigTrapDefenseMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonster rootAsTrapDefenseMonster = TrapDefenseMonster.GetRootAsTrapDefenseMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
			return new TrapDefenseMonster?(rootAsTrapDefenseMonster);
		}

		// Token: 0x04004D33 RID: 19763
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D34 RID: 19764
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D35 RID: 19765
		private const string TABLE = "TrapDefenseMonster";

		// Token: 0x04004D36 RID: 19766
		private const string COMMAND = "select BinData from `TrapDefenseMonster` where Id=?";

		// Token: 0x04004D37 RID: 19767
		private const string KEY_PREFIX = "TrapDefenseMonsterById";

		// Token: 0x04004D38 RID: 19768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D39 RID: 19769
		private static int HandleId;
	}
}
