using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000856 RID: 2134
	public class ConfigRogueResSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003216 RID: 12822 RVA: 0x00174B17 File Offset: 0x00172D17
		static ConfigRogueResSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSortById.CreateStaticDefaultValue), new Action(ConfigRogueResSortById.ResetStaticDefaultValue));
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00174B38 File Offset: 0x00172D38
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResSortById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResSortById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResSort"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResSort` where Id=?")
			});
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00174BB7 File Offset: 0x00172DB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSortById.LogPair = null;
			ConfigRogueResSortById.HandleId = 0;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00174BC5 File Offset: 0x00172DC5
		public static void Init()
		{
			ConfigRogueResSortById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSortById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSort` where Id=?");
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00174BE0 File Offset: 0x00172DE0
		public static RogueResSort? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResSortById.HandleId, ConfigRogueResSortById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResSortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResSort?(RogueResSort.GetRootAsRogueResSort(configBuffer));
				}
			}
			ConfigRogueResSortById.LogPair.Clear();
			ConfigRogueResSortById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResSortById.HandleId, 1, p0Id, ConfigRogueResSortById.LogPair) || ConfigCommon.Step(ConfigRogueResSortById.HandleId, true, ConfigRogueResSortById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResSortById.HandleId, ConfigRogueResSortById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResSortById.HandleId, 0, ConfigRogueResSortById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResSortById.HandleId, ConfigRogueResSortById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResSort rootAsRogueResSort = RogueResSort.GetRootAsRogueResSort(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResSortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResSortById.HandleId, ConfigRogueResSortById.LogPair);
			return new RogueResSort?(rootAsRogueResSort);
		}

		// Token: 0x04003A40 RID: 14912
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A41 RID: 14913
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A42 RID: 14914
		private const string TABLE = "RogueResSort";

		// Token: 0x04003A43 RID: 14915
		private const string COMMAND = "select BinData from `RogueResSort` where Id=?";

		// Token: 0x04003A44 RID: 14916
		private const string KEY_PREFIX = "RogueResSortById";

		// Token: 0x04003A45 RID: 14917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A46 RID: 14918
		private static int HandleId;
	}
}
