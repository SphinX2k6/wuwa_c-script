using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F8 RID: 504
	public class ConfigDangoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x000A007C File Offset: 0x0009E27C
		static ConfigDangoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoByType.CreateStaticDefaultValue), new Action(ConfigDangoByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000A009C File Offset: 0x0009E29C
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

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000A011B File Offset: 0x0009E31B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoByType.LogPair = null;
			ConfigDangoByType.HandleId = 0;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000A0129 File Offset: 0x0009E329
		public static void Init()
		{
			ConfigDangoByType.HandleId = ConfigCommon.InitDataStatement(ConfigDangoByType.HandleId, "db_dango.db", "select BinData from `Dango` where Type=?");
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000A0144 File Offset: 0x0009E344
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

		// Token: 0x04000DAC RID: 3500
		private const string DB = "db_dango.db";

		// Token: 0x04000DAD RID: 3501
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000DAE RID: 3502
		private const string TABLE = "Dango";

		// Token: 0x04000DAF RID: 3503
		private const string COMMAND = "select BinData from `Dango` where Type=?";

		// Token: 0x04000DB0 RID: 3504
		private const string KEY_PREFIX = "DangoByType";

		// Token: 0x04000DB1 RID: 3505
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DB2 RID: 3506
		private static int HandleId;
	}
}
