using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083A RID: 2106
	public class ConfigRogueBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600316E RID: 12654 RVA: 0x00174328 File Offset: 0x00172528
		static ConfigRogueBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00174348 File Offset: 0x00172548
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueBuffPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueBuffPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueBuffPool` where Id=?")
			});
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x001743C7 File Offset: 0x001725C7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueBuffPoolById.LogPair = null;
			ConfigRogueBuffPoolById.HandleId = 0;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x001743D5 File Offset: 0x001725D5
		public static void Init()
		{
			ConfigRogueBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueBuffPoolById.HandleId, "db_rogue.db", "select BinData from `RogueBuffPool` where Id=?");
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x001743F0 File Offset: 0x001725F0
		public static RogueBuffPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueBuffPool?(RogueBuffPool.GetRootAsRogueBuffPool(configBuffer));
				}
			}
			ConfigRogueBuffPoolById.LogPair.Clear();
			ConfigRogueBuffPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueBuffPoolById.HandleId, 1, p0Id, ConfigRogueBuffPoolById.LogPair) || ConfigCommon.Step(ConfigRogueBuffPoolById.HandleId, true, ConfigRogueBuffPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueBuffPoolById.HandleId, 0, ConfigRogueBuffPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueBuffPool rootAsRogueBuffPool = RogueBuffPool.GetRootAsRogueBuffPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
			return new RogueBuffPool?(rootAsRogueBuffPool);
		}

		// Token: 0x0400397C RID: 14716
		private const string DB = "db_rogue.db";

		// Token: 0x0400397D RID: 14717
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400397E RID: 14718
		private const string TABLE = "RogueBuffPool";

		// Token: 0x0400397F RID: 14719
		private const string COMMAND = "select BinData from `RogueBuffPool` where Id=?";

		// Token: 0x04003980 RID: 14720
		private const string KEY_PREFIX = "RogueBuffPoolById";

		// Token: 0x04003981 RID: 14721
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003982 RID: 14722
		private static int HandleId;
	}
}
