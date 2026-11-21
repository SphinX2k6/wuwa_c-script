using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088D RID: 2189
	public class ConfigRogueWeeklyBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x0017F5D7 File Offset: 0x0017D7D7
		static ConfigRogueWeeklyBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0017F5F8 File Offset: 0x0017D7F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBuffPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBuffPool` where Id=?")
			});
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0017F677 File Offset: 0x0017D877
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolById.LogPair = null;
			ConfigRogueWeeklyBuffPoolById.HandleId = 0;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0017F685 File Offset: 0x0017D885
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool` where Id=?");
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x0017F6A0 File Offset: 0x0017D8A0
		public static RogueWeeklyBuffPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyBuffPool?(RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(configBuffer));
				}
			}
			ConfigRogueWeeklyBuffPoolById.LogPair.Clear();
			ConfigRogueWeeklyBuffPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBuffPoolById.HandleId, 1, p0Id, ConfigRogueWeeklyBuffPoolById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyBuffPoolById.HandleId, true, ConfigRogueWeeklyBuffPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBuffPoolById.HandleId, 0, ConfigRogueWeeklyBuffPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyBuffPool rootAsRogueWeeklyBuffPool = RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
			return new RogueWeeklyBuffPool?(rootAsRogueWeeklyBuffPool);
		}

		// Token: 0x04003BC1 RID: 15297
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BC2 RID: 15298
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BC3 RID: 15299
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003BC4 RID: 15300
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool` where Id=?";

		// Token: 0x04003BC5 RID: 15301
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolById";

		// Token: 0x04003BC6 RID: 15302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BC7 RID: 15303
		private static int HandleId;
	}
}
