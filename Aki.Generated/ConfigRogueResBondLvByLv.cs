using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084F RID: 2127
	public class ConfigRogueResBondLvByLv : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031EC RID: 12780 RVA: 0x001771FC File Offset: 0x001753FC
		static ConfigRogueResBondLvByLv()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondLvByLv.CreateStaticDefaultValue), new Action(ConfigRogueResBondLvByLv.ResetStaticDefaultValue));
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0017721C File Offset: 0x0017541C
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

		// Token: 0x060031EE RID: 12782 RVA: 0x0017729B File Offset: 0x0017549B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondLvByLv.LogPair = null;
			ConfigRogueResBondLvByLv.HandleId = 0;
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x001772A9 File Offset: 0x001754A9
		public static void Init()
		{
			ConfigRogueResBondLvByLv.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondLvByLv.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondLv` where Lv=?");
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x001772C4 File Offset: 0x001754C4
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

		// Token: 0x04003A0F RID: 14863
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A10 RID: 14864
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A11 RID: 14865
		private const string TABLE = "RogueResBondLv";

		// Token: 0x04003A12 RID: 14866
		private const string COMMAND = "select BinData from `RogueResBondLv` where Lv=?";

		// Token: 0x04003A13 RID: 14867
		private const string KEY_PREFIX = "RogueResBondLvByLv";

		// Token: 0x04003A14 RID: 14868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A15 RID: 14869
		private static int HandleId;
	}
}
