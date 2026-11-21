using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000863 RID: 2147
	public class ConfigRogueResEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x00179D80 File Offset: 0x00177F80
		static ConfigRogueResEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventById.CreateStaticDefaultValue), new Action(ConfigRogueResEventById.ResetStaticDefaultValue));
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00179DA0 File Offset: 0x00177FA0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEvent` where Id=?")
			});
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00179E1F File Offset: 0x0017801F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventById.LogPair = null;
			ConfigRogueResEventById.HandleId = 0;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x00179E2D File Offset: 0x0017802D
		public static void Init()
		{
			ConfigRogueResEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEvent` where Id=?");
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00179E48 File Offset: 0x00178048
		public static RogueResEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEvent?(RogueResEvent.GetRootAsRogueResEvent(configBuffer));
				}
			}
			ConfigRogueResEventById.LogPair.Clear();
			ConfigRogueResEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventById.HandleId, 1, p0Id, ConfigRogueResEventById.LogPair) || ConfigCommon.Step(ConfigRogueResEventById.HandleId, true, ConfigRogueResEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventById.HandleId, 0, ConfigRogueResEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEvent rootAsRogueResEvent = RogueResEvent.GetRootAsRogueResEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventById.HandleId, ConfigRogueResEventById.LogPair);
			return new RogueResEvent?(rootAsRogueResEvent);
		}

		// Token: 0x04003A9B RID: 15003
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A9C RID: 15004
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A9D RID: 15005
		private const string TABLE = "RogueResEvent";

		// Token: 0x04003A9E RID: 15006
		private const string COMMAND = "select BinData from `RogueResEvent` where Id=?";

		// Token: 0x04003A9F RID: 15007
		private const string KEY_PREFIX = "RogueResEventById";

		// Token: 0x04003AA0 RID: 15008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AA1 RID: 15009
		private static int HandleId;
	}
}
