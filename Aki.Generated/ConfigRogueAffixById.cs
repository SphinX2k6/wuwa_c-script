using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081C RID: 2076
	public class ConfigRogueAffixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030BA RID: 12474 RVA: 0x0016CBB0 File Offset: 0x0016ADB0
		static ConfigRogueAffixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueAffixById.CreateStaticDefaultValue), new Action(ConfigRogueAffixById.ResetStaticDefaultValue));
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0016CBD0 File Offset: 0x0016ADD0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueAffixById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueAffixById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueAffix"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueAffix` where Id=?")
			});
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0016CC4F File Offset: 0x0016AE4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueAffixById.LogPair = null;
			ConfigRogueAffixById.HandleId = 0;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0016CC5D File Offset: 0x0016AE5D
		public static void Init()
		{
			ConfigRogueAffixById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueAffixById.HandleId, "db_rogue.db", "select BinData from `RogueAffix` where Id=?");
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0016CC78 File Offset: 0x0016AE78
		public static RogueAffix? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueAffixById.HandleId, ConfigRogueAffixById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueAffix?(RogueAffix.GetRootAsRogueAffix(configBuffer));
				}
			}
			ConfigRogueAffixById.LogPair.Clear();
			ConfigRogueAffixById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueAffixById.HandleId, 1, p0Id, ConfigRogueAffixById.LogPair) || ConfigCommon.Step(ConfigRogueAffixById.HandleId, true, ConfigRogueAffixById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueAffixById.HandleId, ConfigRogueAffixById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueAffixById.HandleId, 0, ConfigRogueAffixById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueAffixById.HandleId, ConfigRogueAffixById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueAffix rootAsRogueAffix = RogueAffix.GetRootAsRogueAffix(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueAffixById.HandleId, ConfigRogueAffixById.LogPair);
			return new RogueAffix?(rootAsRogueAffix);
		}

		// Token: 0x040038AA RID: 14506
		private const string DB = "db_rogue.db";

		// Token: 0x040038AB RID: 14507
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038AC RID: 14508
		private const string TABLE = "RogueAffix";

		// Token: 0x040038AD RID: 14509
		private const string COMMAND = "select BinData from `RogueAffix` where Id=?";

		// Token: 0x040038AE RID: 14510
		private const string KEY_PREFIX = "RogueAffixById";

		// Token: 0x040038AF RID: 14511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038B0 RID: 14512
		private static int HandleId;
	}
}
