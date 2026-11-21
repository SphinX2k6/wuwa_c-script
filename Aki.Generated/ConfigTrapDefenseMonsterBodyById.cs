using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0A RID: 2826
	public class ConfigTrapDefenseMonsterBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004250 RID: 16976 RVA: 0x001D3B67 File Offset: 0x001D1D67
		static ConfigTrapDefenseMonsterBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterBodyById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001D3B88 File Offset: 0x001D1D88
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterBodyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterBody"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterBody` where Id=?")
			});
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x001D3C07 File Offset: 0x001D1E07
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyById.LogPair = null;
			ConfigTrapDefenseMonsterBodyById.HandleId = 0;
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x001D3C15 File Offset: 0x001D1E15
		public static void Init()
		{
			ConfigTrapDefenseMonsterBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterBodyById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterBody` where Id=?");
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x001D3C30 File Offset: 0x001D1E30
		public static TrapDefenseMonsterBody? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterBodyById.HandleId, ConfigTrapDefenseMonsterBodyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterBody?(TrapDefenseMonsterBody.GetRootAsTrapDefenseMonsterBody(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterBodyById.LogPair.Clear();
			ConfigTrapDefenseMonsterBodyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterBodyById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterBodyById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterBodyById.HandleId, true, ConfigTrapDefenseMonsterBodyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterBodyById.HandleId, ConfigTrapDefenseMonsterBodyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterBodyById.HandleId, 0, ConfigTrapDefenseMonsterBodyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterBodyById.HandleId, ConfigTrapDefenseMonsterBodyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterBody rootAsTrapDefenseMonsterBody = TrapDefenseMonsterBody.GetRootAsTrapDefenseMonsterBody(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterBodyById.HandleId, ConfigTrapDefenseMonsterBodyById.LogPair);
			return new TrapDefenseMonsterBody?(rootAsTrapDefenseMonsterBody);
		}

		// Token: 0x04004D2C RID: 19756
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D2D RID: 19757
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D2E RID: 19758
		private const string TABLE = "TrapDefenseMonsterBody";

		// Token: 0x04004D2F RID: 19759
		private const string COMMAND = "select BinData from `TrapDefenseMonsterBody` where Id=?";

		// Token: 0x04004D30 RID: 19760
		private const string KEY_PREFIX = "TrapDefenseMonsterBodyById";

		// Token: 0x04004D31 RID: 19761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D32 RID: 19762
		private static int HandleId;
	}
}
