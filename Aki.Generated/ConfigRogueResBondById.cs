using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084E RID: 2126
	public class ConfigRogueResBondById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031E6 RID: 12774 RVA: 0x00176FB3 File Offset: 0x001751B3
		static ConfigRogueResBondById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondById.CreateStaticDefaultValue), new Action(ConfigRogueResBondById.ResetStaticDefaultValue));
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00176FD4 File Offset: 0x001751D4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBond"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBond` where Id=?")
			});
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00177053 File Offset: 0x00175253
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondById.LogPair = null;
			ConfigRogueResBondById.HandleId = 0;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00177061 File Offset: 0x00175261
		public static void Init()
		{
			ConfigRogueResBondById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBond` where Id=?");
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0017707C File Offset: 0x0017527C
		public static RogueResBond? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBond?(RogueResBond.GetRootAsRogueResBond(configBuffer));
				}
			}
			ConfigRogueResBondById.LogPair.Clear();
			ConfigRogueResBondById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResBondById.HandleId, 1, p0Id, ConfigRogueResBondById.LogPair) || ConfigCommon.Step(ConfigRogueResBondById.HandleId, true, ConfigRogueResBondById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondById.HandleId, 0, ConfigRogueResBondById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBond rootAsRogueResBond = RogueResBond.GetRootAsRogueResBond(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
			return new RogueResBond?(rootAsRogueResBond);
		}

		// Token: 0x04003A08 RID: 14856
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A09 RID: 14857
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A0A RID: 14858
		private const string TABLE = "RogueResBond";

		// Token: 0x04003A0B RID: 14859
		private const string COMMAND = "select BinData from `RogueResBond` where Id=?";

		// Token: 0x04003A0C RID: 14860
		private const string KEY_PREFIX = "RogueResBondById";

		// Token: 0x04003A0D RID: 14861
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A0E RID: 14862
		private static int HandleId;
	}
}
