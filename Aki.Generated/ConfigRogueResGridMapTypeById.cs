using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084E RID: 2126
	public class ConfigRogueResGridMapTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031E6 RID: 12774 RVA: 0x0017398C File Offset: 0x00171B8C
		static ConfigRogueResGridMapTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridMapTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResGridMapTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x001739AC File Offset: 0x00171BAC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGridMapTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGridMapTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGridMapType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGridMapType` where Id=?")
			});
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00173A2B File Offset: 0x00171C2B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridMapTypeById.LogPair = null;
			ConfigRogueResGridMapTypeById.HandleId = 0;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00173A39 File Offset: 0x00171C39
		public static void Init()
		{
			ConfigRogueResGridMapTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridMapTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridMapType` where Id=?");
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x00173A54 File Offset: 0x00171C54
		public static RogueResGridMapType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridMapTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResGridMapType?(RogueResGridMapType.GetRootAsRogueResGridMapType(configBuffer));
				}
			}
			ConfigRogueResGridMapTypeById.LogPair.Clear();
			ConfigRogueResGridMapTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResGridMapTypeById.HandleId, 1, p0Id, ConfigRogueResGridMapTypeById.LogPair) || ConfigCommon.Step(ConfigRogueResGridMapTypeById.HandleId, true, ConfigRogueResGridMapTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGridMapTypeById.HandleId, 0, ConfigRogueResGridMapTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResGridMapType rootAsRogueResGridMapType = RogueResGridMapType.GetRootAsRogueResGridMapType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridMapTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
			return new RogueResGridMapType?(rootAsRogueResGridMapType);
		}

		// Token: 0x04003A08 RID: 14856
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A09 RID: 14857
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A0A RID: 14858
		private const string TABLE = "RogueResGridMapType";

		// Token: 0x04003A0B RID: 14859
		private const string COMMAND = "select BinData from `RogueResGridMapType` where Id=?";

		// Token: 0x04003A0C RID: 14860
		private const string KEY_PREFIX = "RogueResGridMapTypeById";

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
