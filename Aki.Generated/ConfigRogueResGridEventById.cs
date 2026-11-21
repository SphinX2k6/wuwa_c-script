using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000868 RID: 2152
	public class ConfigRogueResGridEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003282 RID: 12930 RVA: 0x0017A7E3 File Offset: 0x001789E3
		static ConfigRogueResGridEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridEventById.CreateStaticDefaultValue), new Action(ConfigRogueResGridEventById.ResetStaticDefaultValue));
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0017A804 File Offset: 0x00178A04
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGridEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGridEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGridEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGridEvent` where Id=?")
			});
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x0017A883 File Offset: 0x00178A83
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridEventById.LogPair = null;
			ConfigRogueResGridEventById.HandleId = 0;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0017A891 File Offset: 0x00178A91
		public static void Init()
		{
			ConfigRogueResGridEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridEventById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridEvent` where Id=?");
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0017A8AC File Offset: 0x00178AAC
		public static RogueResGridEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResGridEvent?(RogueResGridEvent.GetRootAsRogueResGridEvent(configBuffer));
				}
			}
			ConfigRogueResGridEventById.LogPair.Clear();
			ConfigRogueResGridEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResGridEventById.HandleId, 1, p0Id, ConfigRogueResGridEventById.LogPair) || ConfigCommon.Step(ConfigRogueResGridEventById.HandleId, true, ConfigRogueResGridEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGridEventById.HandleId, 0, ConfigRogueResGridEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResGridEvent rootAsRogueResGridEvent = RogueResGridEvent.GetRootAsRogueResGridEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
			return new RogueResGridEvent?(rootAsRogueResGridEvent);
		}

		// Token: 0x04003ABE RID: 15038
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003ABF RID: 15039
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AC0 RID: 15040
		private const string TABLE = "RogueResGridEvent";

		// Token: 0x04003AC1 RID: 15041
		private const string COMMAND = "select BinData from `RogueResGridEvent` where Id=?";

		// Token: 0x04003AC2 RID: 15042
		private const string KEY_PREFIX = "RogueResGridEventById";

		// Token: 0x04003AC3 RID: 15043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AC4 RID: 15044
		private static int HandleId;
	}
}
