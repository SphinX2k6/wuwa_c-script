using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000872 RID: 2162
	public class ConfigRogueResSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032BE RID: 12990 RVA: 0x0017BDFF File Offset: 0x00179FFF
		static ConfigRogueResSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSortById.CreateStaticDefaultValue), new Action(ConfigRogueResSortById.ResetStaticDefaultValue));
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x0017BE20 File Offset: 0x0017A020
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

		// Token: 0x060032C0 RID: 12992 RVA: 0x0017BE9F File Offset: 0x0017A09F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSortById.LogPair = null;
			ConfigRogueResSortById.HandleId = 0;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x0017BEAD File Offset: 0x0017A0AD
		public static void Init()
		{
			ConfigRogueResSortById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSortById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSort` where Id=?");
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x0017BEC8 File Offset: 0x0017A0C8
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

		// Token: 0x04003B04 RID: 15108
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B05 RID: 15109
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B06 RID: 15110
		private const string TABLE = "RogueResSort";

		// Token: 0x04003B07 RID: 15111
		private const string COMMAND = "select BinData from `RogueResSort` where Id=?";

		// Token: 0x04003B08 RID: 15112
		private const string KEY_PREFIX = "RogueResSortById";

		// Token: 0x04003B09 RID: 15113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B0A RID: 15114
		private static int HandleId;
	}
}
