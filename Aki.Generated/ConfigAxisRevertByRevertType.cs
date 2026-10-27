using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C9 RID: 201
	public class ConfigAxisRevertByRevertType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x000745BF File Offset: 0x000727BF
		static ConfigAxisRevertByRevertType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisRevertByRevertType.CreateStaticDefaultValue), new Action(ConfigAxisRevertByRevertType.ResetStaticDefaultValue));
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000745E0 File Offset: 0x000727E0
		public static void CreateStaticDefaultValue()
		{
			ConfigAxisRevertByRevertType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAxisRevertByRevertType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "AxisRevert"),
				new ValueTuple<string, object>("语句", "select BinData from `AxisRevert` where RevertType=?")
			});
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0007465F File Offset: 0x0007285F
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisRevertByRevertType.LogPair = null;
			ConfigAxisRevertByRevertType.HandleId = 0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0007466D File Offset: 0x0007286D
		public static void Init()
		{
			ConfigAxisRevertByRevertType.HandleId = ConfigCommon.InitDataStatement(ConfigAxisRevertByRevertType.HandleId, "db_menu.db", "select BinData from `AxisRevert` where RevertType=?");
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00074688 File Offset: 0x00072888
		[NullableContext(2)]
		public static IReadOnlyList<AxisRevert> GetConfigList(int p0RevertType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAxisRevertByRevertType.HandleId, ConfigAxisRevertByRevertType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AxisRevertByRevertType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RevertType);
				IReadOnlyList<AxisRevert> readOnlyList = (IReadOnlyList<AxisRevert>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAxisRevertByRevertType.LogPair.Clear();
			ConfigAxisRevertByRevertType.LogPair.Add(new ValueTuple<string, object>("RevertType", p0RevertType));
			if (!ConfigCommon.BindInt(ConfigAxisRevertByRevertType.HandleId, 1, p0RevertType, ConfigAxisRevertByRevertType.LogPair))
			{
				ConfigCommon.Reset(ConfigAxisRevertByRevertType.HandleId, ConfigAxisRevertByRevertType.LogPair);
				return null;
			}
			List<AxisRevert> list = new List<AxisRevert>();
			while (ConfigCommon.Step(ConfigAxisRevertByRevertType.HandleId, false, ConfigAxisRevertByRevertType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAxisRevertByRevertType.HandleId, 0, ConfigAxisRevertByRevertType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAxisRevertByRevertType.HandleId, ConfigAxisRevertByRevertType.LogPair);
					return null;
				}
				AxisRevert rootAsAxisRevert = AxisRevert.GetRootAsAxisRevert(new ByteBuffer(item2));
				list.Add(rootAsAxisRevert);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AxisRevertByRevertType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RevertType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAxisRevertByRevertType.HandleId, ConfigAxisRevertByRevertType.LogPair);
			return list;
		}

		// Token: 0x04000563 RID: 1379
		private const string DB = "db_menu.db";

		// Token: 0x04000564 RID: 1380
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04000565 RID: 1381
		private const string TABLE = "AxisRevert";

		// Token: 0x04000566 RID: 1382
		private const string COMMAND = "select BinData from `AxisRevert` where RevertType=?";

		// Token: 0x04000567 RID: 1383
		private const string KEY_PREFIX = "AxisRevertByRevertType";

		// Token: 0x04000568 RID: 1384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000569 RID: 1385
		private static int HandleId;
	}
}
