using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3B RID: 2619
	public class ConfigTrapDefenseMonsterTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D76 RID: 15734 RVA: 0x001B541B File Offset: 0x001B361B
		static ConfigTrapDefenseMonsterTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTagById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x001B543C File Offset: 0x001B363C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterTag"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterTag` where Id=?")
			});
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x001B54BB File Offset: 0x001B36BB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagById.LogPair = null;
			ConfigTrapDefenseMonsterTagById.HandleId = 0;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x001B54C9 File Offset: 0x001B36C9
		public static void Init()
		{
			ConfigTrapDefenseMonsterTagById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTagById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterTag` where Id=?");
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001B54E4 File Offset: 0x001B36E4
		public static TrapDefenseMonsterTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterTagById.HandleId, ConfigTrapDefenseMonsterTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterTag?(TrapDefenseMonsterTag.GetRootAsTrapDefenseMonsterTag(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterTagById.LogPair.Clear();
			ConfigTrapDefenseMonsterTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterTagById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterTagById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterTagById.HandleId, true, ConfigTrapDefenseMonsterTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTagById.HandleId, ConfigTrapDefenseMonsterTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterTagById.HandleId, 0, ConfigTrapDefenseMonsterTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTagById.HandleId, ConfigTrapDefenseMonsterTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterTag rootAsTrapDefenseMonsterTag = TrapDefenseMonsterTag.GetRootAsTrapDefenseMonsterTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterTagById.HandleId, ConfigTrapDefenseMonsterTagById.LogPair);
			return new TrapDefenseMonsterTag?(rootAsTrapDefenseMonsterTag);
		}

		// Token: 0x04004783 RID: 18307
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004784 RID: 18308
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004785 RID: 18309
		private const string TABLE = "TrapDefenseMonsterTag";

		// Token: 0x04004786 RID: 18310
		private const string COMMAND = "select BinData from `TrapDefenseMonsterTag` where Id=?";

		// Token: 0x04004787 RID: 18311
		private const string KEY_PREFIX = "TrapDefenseMonsterTagById";

		// Token: 0x04004788 RID: 18312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004789 RID: 18313
		private static int HandleId;
	}
}
