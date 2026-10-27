using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E6 RID: 486
	public class ConfigDangoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x0009A144 File Offset: 0x00098344
		static ConfigDangoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoByType.CreateStaticDefaultValue), new Action(ConfigDangoByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0009A164 File Offset: 0x00098364
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "Dango"),
				new ValueTuple<string, object>("语句", "select BinData from `Dango` where Type=?")
			});
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0009A1E3 File Offset: 0x000983E3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoByType.LogPair = null;
			ConfigDangoByType.HandleId = 0;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0009A1F1 File Offset: 0x000983F1
		public static void Init()
		{
			ConfigDangoByType.HandleId = ConfigCommon.InitDataStatement(ConfigDangoByType.HandleId, "db_dango.db", "select BinData from `Dango` where Type=?");
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0009A20C File Offset: 0x0009840C
		[NullableContext(2)]
		public static IReadOnlyList<Dango> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoByType.HandleId, ConfigDangoByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<Dango> readOnlyList = (IReadOnlyList<Dango>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoByType.LogPair.Clear();
			ConfigDangoByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigDangoByType.HandleId, 1, p0Type, ConfigDangoByType.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoByType.HandleId, ConfigDangoByType.LogPair);
				return null;
			}
			List<Dango> list = new List<Dango>();
			while (ConfigCommon.Step(ConfigDangoByType.HandleId, false, ConfigDangoByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoByType.HandleId, 0, ConfigDangoByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoByType.HandleId, ConfigDangoByType.LogPair);
					return null;
				}
				Dango rootAsDango = Dango.GetRootAsDango(new ByteBuffer(item2));
				list.Add(rootAsDango);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoByType.HandleId, ConfigDangoByType.LogPair);
			return list;
		}

		// Token: 0x04000D2E RID: 3374
		private const string DB = "db_dango.db";

		// Token: 0x04000D2F RID: 3375
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000D30 RID: 3376
		private const string TABLE = "Dango";

		// Token: 0x04000D31 RID: 3377
		private const string COMMAND = "select BinData from `Dango` where Type=?";

		// Token: 0x04000D32 RID: 3378
		private const string KEY_PREFIX = "DangoByType";

		// Token: 0x04000D33 RID: 3379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D34 RID: 3380
		private static int HandleId;
	}
}
