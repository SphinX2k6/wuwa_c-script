using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A35 RID: 2613
	public class ConfigTrapDefenseMonsterBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D52 RID: 15698 RVA: 0x001B47D3 File Offset: 0x001B29D3
		static ConfigTrapDefenseMonsterBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterBodyById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x001B47F4 File Offset: 0x001B29F4
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

		// Token: 0x06003D54 RID: 15700 RVA: 0x001B4873 File Offset: 0x001B2A73
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyById.LogPair = null;
			ConfigTrapDefenseMonsterBodyById.HandleId = 0;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x001B4881 File Offset: 0x001B2A81
		public static void Init()
		{
			ConfigTrapDefenseMonsterBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterBodyById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterBody` where Id=?");
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x001B489C File Offset: 0x001B2A9C
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

		// Token: 0x04004759 RID: 18265
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400475A RID: 18266
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x0400475B RID: 18267
		private const string TABLE = "TrapDefenseMonsterBody";

		// Token: 0x0400475C RID: 18268
		private const string COMMAND = "select BinData from `TrapDefenseMonsterBody` where Id=?";

		// Token: 0x0400475D RID: 18269
		private const string KEY_PREFIX = "TrapDefenseMonsterBodyById";

		// Token: 0x0400475E RID: 18270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400475F RID: 18271
		private static int HandleId;
	}
}
