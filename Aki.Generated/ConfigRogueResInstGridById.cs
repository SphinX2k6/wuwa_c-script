using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084F RID: 2127
	public class ConfigRogueResInstGridById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031EC RID: 12780 RVA: 0x00173BD4 File Offset: 0x00171DD4
		static ConfigRogueResInstGridById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResInstGridById.CreateStaticDefaultValue), new Action(ConfigRogueResInstGridById.ResetStaticDefaultValue));
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00173BF4 File Offset: 0x00171DF4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResInstGridById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResInstGridById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResInstGrid"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResInstGrid` where Id=?")
			});
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00173C73 File Offset: 0x00171E73
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResInstGridById.LogPair = null;
			ConfigRogueResInstGridById.HandleId = 0;
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00173C81 File Offset: 0x00171E81
		public static void Init()
		{
			ConfigRogueResInstGridById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResInstGridById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResInstGrid` where Id=?");
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00173C9C File Offset: 0x00171E9C
		public static RogueResInstGrid? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResInstGridById.HandleId, ConfigRogueResInstGridById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResInstGridById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResInstGrid?(RogueResInstGrid.GetRootAsRogueResInstGrid(configBuffer));
				}
			}
			ConfigRogueResInstGridById.LogPair.Clear();
			ConfigRogueResInstGridById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResInstGridById.HandleId, 1, p0Id, ConfigRogueResInstGridById.LogPair) || ConfigCommon.Step(ConfigRogueResInstGridById.HandleId, true, ConfigRogueResInstGridById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResInstGridById.HandleId, ConfigRogueResInstGridById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResInstGridById.HandleId, 0, ConfigRogueResInstGridById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResInstGridById.HandleId, ConfigRogueResInstGridById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResInstGrid rootAsRogueResInstGrid = RogueResInstGrid.GetRootAsRogueResInstGrid(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResInstGridById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResInstGridById.HandleId, ConfigRogueResInstGridById.LogPair);
			return new RogueResInstGrid?(rootAsRogueResInstGrid);
		}

		// Token: 0x04003A0F RID: 14863
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A10 RID: 14864
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A11 RID: 14865
		private const string TABLE = "RogueResInstGrid";

		// Token: 0x04003A12 RID: 14866
		private const string COMMAND = "select BinData from `RogueResInstGrid` where Id=?";

		// Token: 0x04003A13 RID: 14867
		private const string KEY_PREFIX = "RogueResInstGridById";

		// Token: 0x04003A14 RID: 14868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A15 RID: 14869
		private static int HandleId;
	}
}
