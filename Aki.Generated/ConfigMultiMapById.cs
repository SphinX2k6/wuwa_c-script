using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F1 RID: 1521
	public class ConfigMultiMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023B3 RID: 9139 RVA: 0x00126C07 File Offset: 0x00124E07
		static ConfigMultiMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapById.CreateStaticDefaultValue), new Action(ConfigMultiMapById.ResetStaticDefaultValue));
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00126C28 File Offset: 0x00124E28
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MultiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiMap` where Id=?")
			});
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00126CA7 File Offset: 0x00124EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapById.LogPair = null;
			ConfigMultiMapById.HandleId = 0;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00126CB5 File Offset: 0x00124EB5
		public static void Init()
		{
			ConfigMultiMapById.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapById.HandleId, "db_map.db", "select BinData from `MultiMap` where Id=?");
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00126CD0 File Offset: 0x00124ED0
		public static MultiMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MultiMap?(MultiMap.GetRootAsMultiMap(configBuffer));
				}
			}
			ConfigMultiMapById.LogPair.Clear();
			ConfigMultiMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMultiMapById.HandleId, 1, p0Id, ConfigMultiMapById.LogPair) || ConfigCommon.Step(ConfigMultiMapById.HandleId, true, ConfigMultiMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiMapById.HandleId, 0, ConfigMultiMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MultiMap rootAsMultiMap = MultiMap.GetRootAsMultiMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
			return new MultiMap?(rootAsMultiMap);
		}

		// Token: 0x0400297B RID: 10619
		private const string DB = "db_map.db";

		// Token: 0x0400297C RID: 10620
		private const string FILE = "d.地图.xlsx";

		// Token: 0x0400297D RID: 10621
		private const string TABLE = "MultiMap";

		// Token: 0x0400297E RID: 10622
		private const string COMMAND = "select BinData from `MultiMap` where Id=?";

		// Token: 0x0400297F RID: 10623
		private const string KEY_PREFIX = "MultiMapById";

		// Token: 0x04002980 RID: 10624
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002981 RID: 10625
		private static int HandleId;
	}
}
