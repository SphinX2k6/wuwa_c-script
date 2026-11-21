using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B10 RID: 2832
	public class ConfigTrapDefenseMonsterTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004274 RID: 17012 RVA: 0x001D47AF File Offset: 0x001D29AF
		static ConfigTrapDefenseMonsterTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTagById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x001D47D0 File Offset: 0x001D29D0
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

		// Token: 0x06004276 RID: 17014 RVA: 0x001D484F File Offset: 0x001D2A4F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagById.LogPair = null;
			ConfigTrapDefenseMonsterTagById.HandleId = 0;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x001D485D File Offset: 0x001D2A5D
		public static void Init()
		{
			ConfigTrapDefenseMonsterTagById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTagById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterTag` where Id=?");
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x001D4878 File Offset: 0x001D2A78
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

		// Token: 0x04004D56 RID: 19798
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D57 RID: 19799
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D58 RID: 19800
		private const string TABLE = "TrapDefenseMonsterTag";

		// Token: 0x04004D59 RID: 19801
		private const string COMMAND = "select BinData from `TrapDefenseMonsterTag` where Id=?";

		// Token: 0x04004D5A RID: 19802
		private const string KEY_PREFIX = "TrapDefenseMonsterTagById";

		// Token: 0x04004D5B RID: 19803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D5C RID: 19804
		private static int HandleId;
	}
}
