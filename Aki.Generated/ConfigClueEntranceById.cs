using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000187 RID: 391
	public class ConfigClueEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x00090E04 File Offset: 0x0008F004
		static ConfigClueEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueEntranceById.CreateStaticDefaultValue), new Action(ConfigClueEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00090E24 File Offset: 0x0008F024
		public static void CreateStaticDefaultValue()
		{
			ConfigClueEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigClueEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_clue.db"),
				new ValueTuple<string, object>("文件", "x.线索.xlsx"),
				new ValueTuple<string, object>("表名", "ClueEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `ClueEntrance` where Id=?")
			});
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00090EA3 File Offset: 0x0008F0A3
		public static void ResetStaticDefaultValue()
		{
			ConfigClueEntranceById.LogPair = null;
			ConfigClueEntranceById.HandleId = 0;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00090EB1 File Offset: 0x0008F0B1
		public static void Init()
		{
			ConfigClueEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigClueEntranceById.HandleId, "db_clue.db", "select BinData from `ClueEntrance` where Id=?");
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00090ECC File Offset: 0x0008F0CC
		public static ClueEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigClueEntranceById.HandleId, ConfigClueEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ClueEntrance?(ClueEntrance.GetRootAsClueEntrance(configBuffer));
				}
			}
			ConfigClueEntranceById.LogPair.Clear();
			ConfigClueEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigClueEntranceById.HandleId, 1, p0Id, ConfigClueEntranceById.LogPair) || ConfigCommon.Step(ConfigClueEntranceById.HandleId, true, ConfigClueEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigClueEntranceById.HandleId, ConfigClueEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigClueEntranceById.HandleId, 0, ConfigClueEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigClueEntranceById.HandleId, ConfigClueEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ClueEntrance rootAsClueEntrance = ClueEntrance.GetRootAsClueEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigClueEntranceById.HandleId, ConfigClueEntranceById.LogPair);
			return new ClueEntrance?(rootAsClueEntrance);
		}

		// Token: 0x04000A95 RID: 2709
		private const string DB = "db_clue.db";

		// Token: 0x04000A96 RID: 2710
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A97 RID: 2711
		private const string TABLE = "ClueEntrance";

		// Token: 0x04000A98 RID: 2712
		private const string COMMAND = "select BinData from `ClueEntrance` where Id=?";

		// Token: 0x04000A99 RID: 2713
		private const string KEY_PREFIX = "ClueEntranceById";

		// Token: 0x04000A9A RID: 2714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A9B RID: 2715
		private static int HandleId;
	}
}
