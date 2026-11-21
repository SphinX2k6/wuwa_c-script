using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000852 RID: 2130
	public class ConfigRogueResBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031FE RID: 12798 RVA: 0x00177820 File Offset: 0x00175A20
		static ConfigRogueResBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueResBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00177840 File Offset: 0x00175A40
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBuffPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBuffPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBuffPool` where Id=?")
			});
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x001778BF File Offset: 0x00175ABF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBuffPoolById.LogPair = null;
			ConfigRogueResBuffPoolById.HandleId = 0;
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x001778CD File Offset: 0x00175ACD
		public static void Init()
		{
			ConfigRogueResBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBuffPoolById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBuffPool` where Id=?");
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x001778E8 File Offset: 0x00175AE8
		public static RogueResBuffPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBuffPoolById.HandleId, ConfigRogueResBuffPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBuffPool?(RogueResBuffPool.GetRootAsRogueResBuffPool(configBuffer));
				}
			}
			ConfigRogueResBuffPoolById.LogPair.Clear();
			ConfigRogueResBuffPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResBuffPoolById.HandleId, 1, p0Id, ConfigRogueResBuffPoolById.LogPair) || ConfigCommon.Step(ConfigRogueResBuffPoolById.HandleId, true, ConfigRogueResBuffPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBuffPoolById.HandleId, ConfigRogueResBuffPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBuffPoolById.HandleId, 0, ConfigRogueResBuffPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBuffPoolById.HandleId, ConfigRogueResBuffPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBuffPool rootAsRogueResBuffPool = RogueResBuffPool.GetRootAsRogueResBuffPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBuffPoolById.HandleId, ConfigRogueResBuffPoolById.LogPair);
			return new RogueResBuffPool?(rootAsRogueResBuffPool);
		}

		// Token: 0x04003A24 RID: 14884
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A25 RID: 14885
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A26 RID: 14886
		private const string TABLE = "RogueResBuffPool";

		// Token: 0x04003A27 RID: 14887
		private const string COMMAND = "select BinData from `RogueResBuffPool` where Id=?";

		// Token: 0x04003A28 RID: 14888
		private const string KEY_PREFIX = "RogueResBuffPoolById";

		// Token: 0x04003A29 RID: 14889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A2A RID: 14890
		private static int HandleId;
	}
}
