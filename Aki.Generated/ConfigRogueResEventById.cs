using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000847 RID: 2119
	public class ConfigRogueResEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031BC RID: 12732 RVA: 0x00172A98 File Offset: 0x00170C98
		static ConfigRogueResEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventById.CreateStaticDefaultValue), new Action(ConfigRogueResEventById.ResetStaticDefaultValue));
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x00172AB8 File Offset: 0x00170CB8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEvent` where Id=?")
			});
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00172B37 File Offset: 0x00170D37
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventById.LogPair = null;
			ConfigRogueResEventById.HandleId = 0;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00172B45 File Offset: 0x00170D45
		public static void Init()
		{
			ConfigRogueResEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEvent` where Id=?");
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00172B60 File Offset: 0x00170D60
		public static RogueResEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEvent?(RogueResEvent.GetRootAsRogueResEvent(configBuffer));
				}
			}
			ConfigRogueResEventById.LogPair.Clear();
			ConfigRogueResEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventById.HandleId, 1, p0Id, ConfigRogueResEventById.LogPair) || ConfigCommon.Step(ConfigRogueResEventById.HandleId, true, ConfigRogueResEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventById.HandleId, 0, ConfigRogueResEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEvent rootAsRogueResEvent = RogueResEvent.GetRootAsRogueResEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
			return new RogueResEvent?(rootAsRogueResEvent);
		}

		// Token: 0x040039D7 RID: 14807
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039D8 RID: 14808
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039D9 RID: 14809
		private const string TABLE = "RogueResEvent";

		// Token: 0x040039DA RID: 14810
		private const string COMMAND = "select BinData from `RogueResEvent` where Id=?";

		// Token: 0x040039DB RID: 14811
		private const string KEY_PREFIX = "RogueResEventById";

		// Token: 0x040039DC RID: 14812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039DD RID: 14813
		private static int HandleId;
	}
}
