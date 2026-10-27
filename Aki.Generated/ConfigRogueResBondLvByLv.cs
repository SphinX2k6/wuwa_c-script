using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000833 RID: 2099
	public class ConfigRogueResBondLvByLv : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003144 RID: 12612 RVA: 0x0016FF14 File Offset: 0x0016E114
		static ConfigRogueResBondLvByLv()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondLvByLv.CreateStaticDefaultValue), new Action(ConfigRogueResBondLvByLv.ResetStaticDefaultValue));
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0016FF34 File Offset: 0x0016E134
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondLvByLv.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondLvByLv.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBondLv"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBondLv` where Lv=?")
			});
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0016FFB3 File Offset: 0x0016E1B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondLvByLv.LogPair = null;
			ConfigRogueResBondLvByLv.HandleId = 0;
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x0016FFC1 File Offset: 0x0016E1C1
		public static void Init()
		{
			ConfigRogueResBondLvByLv.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondLvByLv.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondLv` where Lv=?");
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0016FFDC File Offset: 0x0016E1DC
		public static RogueResBondLv? GetConfig(int p0Lv, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondLvByLv.HandleId, ConfigRogueResBondLvByLv.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondLvByLv");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Lv);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBondLv?(RogueResBondLv.GetRootAsRogueResBondLv(configBuffer));
				}
			}
			ConfigRogueResBondLvByLv.LogPair.Clear();
			ConfigRogueResBondLvByLv.LogPair.Add(new ValueTuple<string, object>("Lv", p0Lv));
			if (!ConfigCommon.BindInt(ConfigRogueResBondLvByLv.HandleId, 1, p0Lv, ConfigRogueResBondLvByLv.LogPair) || ConfigCommon.Step(ConfigRogueResBondLvByLv.HandleId, true, ConfigRogueResBondLvByLv.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBondLvByLv.HandleId, ConfigRogueResBondLvByLv.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondLvByLv.HandleId, 0, ConfigRogueResBondLvByLv.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBondLvByLv.HandleId, ConfigRogueResBondLvByLv.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBondLv rootAsRogueResBondLv = RogueResBondLv.GetRootAsRogueResBondLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondLvByLv");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Lv);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBondLvByLv.HandleId, ConfigRogueResBondLvByLv.LogPair);
			return new RogueResBondLv?(rootAsRogueResBondLv);
		}

		// Token: 0x0400394B RID: 14667
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400394C RID: 14668
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400394D RID: 14669
		private const string TABLE = "RogueResBondLv";

		// Token: 0x0400394E RID: 14670
		private const string COMMAND = "select BinData from `RogueResBondLv` where Lv=?";

		// Token: 0x0400394F RID: 14671
		private const string KEY_PREFIX = "RogueResBondLvByLv";

		// Token: 0x04003950 RID: 14672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003951 RID: 14673
		private static int HandleId;
	}
}
