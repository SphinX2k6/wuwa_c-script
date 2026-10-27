using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000836 RID: 2102
	public class ConfigRogueResBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003156 RID: 12630 RVA: 0x00170538 File Offset: 0x0016E738
		static ConfigRogueResBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueResBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00170558 File Offset: 0x0016E758
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

		// Token: 0x06003158 RID: 12632 RVA: 0x001705D7 File Offset: 0x0016E7D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBuffPoolById.LogPair = null;
			ConfigRogueResBuffPoolById.HandleId = 0;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x001705E5 File Offset: 0x0016E7E5
		public static void Init()
		{
			ConfigRogueResBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBuffPoolById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBuffPool` where Id=?");
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00170600 File Offset: 0x0016E800
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

		// Token: 0x04003960 RID: 14688
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003961 RID: 14689
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003962 RID: 14690
		private const string TABLE = "RogueResBuffPool";

		// Token: 0x04003963 RID: 14691
		private const string COMMAND = "select BinData from `RogueResBuffPool` where Id=?";

		// Token: 0x04003964 RID: 14692
		private const string KEY_PREFIX = "RogueResBuffPoolById";

		// Token: 0x04003965 RID: 14693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003966 RID: 14694
		private static int HandleId;
	}
}
