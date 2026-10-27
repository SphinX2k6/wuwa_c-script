using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031B RID: 795
	public class ConfigFloroRanchFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x000C2DD3 File Offset: 0x000C0FD3
		static ConfigFloroRanchFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchFilterTypeById.CreateStaticDefaultValue), new Action(ConfigFloroRanchFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000C2DF4 File Offset: 0x000C0FF4
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchFilterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchFilterType` where Id=?")
			});
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000C2E73 File Offset: 0x000C1073
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeById.LogPair = null;
			ConfigFloroRanchFilterTypeById.HandleId = 0;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000C2E81 File Offset: 0x000C1081
		public static void Init()
		{
			ConfigFloroRanchFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchFilterTypeById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchFilterType` where Id=?");
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000C2E9C File Offset: 0x000C109C
		public static FloroRanchFilterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchFilterType?(FloroRanchFilterType.GetRootAsFloroRanchFilterType(configBuffer));
				}
			}
			ConfigFloroRanchFilterTypeById.LogPair.Clear();
			ConfigFloroRanchFilterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchFilterTypeById.HandleId, 1, p0Id, ConfigFloroRanchFilterTypeById.LogPair) || ConfigCommon.Step(ConfigFloroRanchFilterTypeById.HandleId, true, ConfigFloroRanchFilterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchFilterTypeById.HandleId, 0, ConfigFloroRanchFilterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchFilterType rootAsFloroRanchFilterType = FloroRanchFilterType.GetRootAsFloroRanchFilterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
			return new FloroRanchFilterType?(rootAsFloroRanchFilterType);
		}

		// Token: 0x040015A1 RID: 5537
		private const string DB = "db_flororanch.db";

		// Token: 0x040015A2 RID: 5538
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015A3 RID: 5539
		private const string TABLE = "FloroRanchFilterType";

		// Token: 0x040015A4 RID: 5540
		private const string COMMAND = "select BinData from `FloroRanchFilterType` where Id=?";

		// Token: 0x040015A5 RID: 5541
		private const string KEY_PREFIX = "FloroRanchFilterTypeById";

		// Token: 0x040015A6 RID: 5542
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015A7 RID: 5543
		private static int HandleId;
	}
}
