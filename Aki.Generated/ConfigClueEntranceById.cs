using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000177 RID: 375
	public class ConfigClueEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x0008B2A8 File Offset: 0x000894A8
		static ConfigClueEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueEntranceById.CreateStaticDefaultValue), new Action(ConfigClueEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0008B2C8 File Offset: 0x000894C8
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

		// Token: 0x060008CD RID: 2253 RVA: 0x0008B347 File Offset: 0x00089547
		public static void ResetStaticDefaultValue()
		{
			ConfigClueEntranceById.LogPair = null;
			ConfigClueEntranceById.HandleId = 0;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0008B355 File Offset: 0x00089555
		public static void Init()
		{
			ConfigClueEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigClueEntranceById.HandleId, "db_clue.db", "select BinData from `ClueEntrance` where Id=?");
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0008B370 File Offset: 0x00089570
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

		// Token: 0x04000A25 RID: 2597
		private const string DB = "db_clue.db";

		// Token: 0x04000A26 RID: 2598
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A27 RID: 2599
		private const string TABLE = "ClueEntrance";

		// Token: 0x04000A28 RID: 2600
		private const string COMMAND = "select BinData from `ClueEntrance` where Id=?";

		// Token: 0x04000A29 RID: 2601
		private const string KEY_PREFIX = "ClueEntranceById";

		// Token: 0x04000A2A RID: 2602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A2B RID: 2603
		private static int HandleId;
	}
}
