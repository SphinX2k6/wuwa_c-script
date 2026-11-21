using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000838 RID: 2104
	public class ConfigRogueAffixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003162 RID: 12642 RVA: 0x00173E98 File Offset: 0x00172098
		static ConfigRogueAffixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueAffixById.CreateStaticDefaultValue), new Action(ConfigRogueAffixById.ResetStaticDefaultValue));
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00173EB8 File Offset: 0x001720B8
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

		// Token: 0x06003164 RID: 12644 RVA: 0x00173F37 File Offset: 0x00172137
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueAffixById.LogPair = null;
			ConfigRogueAffixById.HandleId = 0;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00173F45 File Offset: 0x00172145
		public static void Init()
		{
			ConfigRogueAffixById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueAffixById.HandleId, "db_rogue.db", "select BinData from `RogueAffix` where Id=?");
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00173F60 File Offset: 0x00172160
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

		// Token: 0x0400396E RID: 14702
		private const string DB = "db_rogue.db";

		// Token: 0x0400396F RID: 14703
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003970 RID: 14704
		private const string TABLE = "RogueAffix";

		// Token: 0x04003971 RID: 14705
		private const string COMMAND = "select BinData from `RogueAffix` where Id=?";

		// Token: 0x04003972 RID: 14706
		private const string KEY_PREFIX = "RogueAffixById";

		// Token: 0x04003973 RID: 14707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003974 RID: 14708
		private static int HandleId;
	}
}
