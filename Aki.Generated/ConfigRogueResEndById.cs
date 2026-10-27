using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000844 RID: 2116
	public class ConfigRogueResEndById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x001723C0 File Offset: 0x001705C0
		static ConfigRogueResEndById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndById.CreateStaticDefaultValue), new Action(ConfigRogueResEndById.ResetStaticDefaultValue));
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x001723E0 File Offset: 0x001705E0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEndById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEndById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEnd"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEnd` where Id=?")
			});
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x0017245F File Offset: 0x0017065F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndById.LogPair = null;
			ConfigRogueResEndById.HandleId = 0;
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0017246D File Offset: 0x0017066D
		public static void Init()
		{
			ConfigRogueResEndById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEnd` where Id=?");
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00172488 File Offset: 0x00170688
		public static RogueResEnd? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEnd?(RogueResEnd.GetRootAsRogueResEnd(configBuffer));
				}
			}
			ConfigRogueResEndById.LogPair.Clear();
			ConfigRogueResEndById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEndById.HandleId, 1, p0Id, ConfigRogueResEndById.LogPair) || ConfigCommon.Step(ConfigRogueResEndById.HandleId, true, ConfigRogueResEndById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEndById.HandleId, 0, ConfigRogueResEndById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEnd rootAsRogueResEnd = RogueResEnd.GetRootAsRogueResEnd(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
			return new RogueResEnd?(rootAsRogueResEnd);
		}

		// Token: 0x040039C2 RID: 14786
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039C3 RID: 14787
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039C4 RID: 14788
		private const string TABLE = "RogueResEnd";

		// Token: 0x040039C5 RID: 14789
		private const string COMMAND = "select BinData from `RogueResEnd` where Id=?";

		// Token: 0x040039C6 RID: 14790
		private const string KEY_PREFIX = "RogueResEndById";

		// Token: 0x040039C7 RID: 14791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039C8 RID: 14792
		private static int HandleId;
	}
}
