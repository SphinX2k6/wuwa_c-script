using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000846 RID: 2118
	public class ConfigRogueResEventBgmById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x00172850 File Offset: 0x00170A50
		static ConfigRogueResEventBgmById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventBgmById.CreateStaticDefaultValue), new Action(ConfigRogueResEventBgmById.ResetStaticDefaultValue));
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00172870 File Offset: 0x00170A70
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventBgmById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventBgmById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventBgm"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventBgm` where Id=?")
			});
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x001728EF File Offset: 0x00170AEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventBgmById.LogPair = null;
			ConfigRogueResEventBgmById.HandleId = 0;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x001728FD File Offset: 0x00170AFD
		public static void Init()
		{
			ConfigRogueResEventBgmById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventBgmById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventBgm` where Id=?");
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00172918 File Offset: 0x00170B18
		public static RogueResEventBgm? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventBgm?(RogueResEventBgm.GetRootAsRogueResEventBgm(configBuffer));
				}
			}
			ConfigRogueResEventBgmById.LogPair.Clear();
			ConfigRogueResEventBgmById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventBgmById.HandleId, 1, p0Id, ConfigRogueResEventBgmById.LogPair) || ConfigCommon.Step(ConfigRogueResEventBgmById.HandleId, true, ConfigRogueResEventBgmById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventBgmById.HandleId, 0, ConfigRogueResEventBgmById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventBgm rootAsRogueResEventBgm = RogueResEventBgm.GetRootAsRogueResEventBgm(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
			return new RogueResEventBgm?(rootAsRogueResEventBgm);
		}

		// Token: 0x040039D0 RID: 14800
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039D1 RID: 14801
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039D2 RID: 14802
		private const string TABLE = "RogueResEventBgm";

		// Token: 0x040039D3 RID: 14803
		private const string COMMAND = "select BinData from `RogueResEventBgm` where Id=?";

		// Token: 0x040039D4 RID: 14804
		private const string KEY_PREFIX = "RogueResEventBgmById";

		// Token: 0x040039D5 RID: 14805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039D6 RID: 14806
		private static int HandleId;
	}
}
