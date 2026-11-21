using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086B RID: 2155
	public class ConfigRogueResInstGridById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003294 RID: 12948 RVA: 0x0017AEBC File Offset: 0x001790BC
		static ConfigRogueResInstGridById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResInstGridById.CreateStaticDefaultValue), new Action(ConfigRogueResInstGridById.ResetStaticDefaultValue));
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x0017AEDC File Offset: 0x001790DC
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

		// Token: 0x06003296 RID: 12950 RVA: 0x0017AF5B File Offset: 0x0017915B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResInstGridById.LogPair = null;
			ConfigRogueResInstGridById.HandleId = 0;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0017AF69 File Offset: 0x00179169
		public static void Init()
		{
			ConfigRogueResInstGridById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResInstGridById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResInstGrid` where Id=?");
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x0017AF84 File Offset: 0x00179184
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

		// Token: 0x04003AD3 RID: 15059
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AD4 RID: 15060
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AD5 RID: 15061
		private const string TABLE = "RogueResInstGrid";

		// Token: 0x04003AD6 RID: 15062
		private const string COMMAND = "select BinData from `RogueResInstGrid` where Id=?";

		// Token: 0x04003AD7 RID: 15063
		private const string KEY_PREFIX = "RogueResInstGridById";

		// Token: 0x04003AD8 RID: 15064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AD9 RID: 15065
		private static int HandleId;
	}
}
