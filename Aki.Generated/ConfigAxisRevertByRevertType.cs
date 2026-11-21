using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D8 RID: 216
	public class ConfigAxisRevertByRevertType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00079F23 File Offset: 0x00078123
		static ConfigAxisRevertByRevertType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisRevertByRevertType.CreateStaticDefaultValue), new Action(ConfigAxisRevertByRevertType.ResetStaticDefaultValue));
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00079F44 File Offset: 0x00078144
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

		// Token: 0x06000513 RID: 1299 RVA: 0x00079FC3 File Offset: 0x000781C3
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisRevertByRevertType.LogPair = null;
			ConfigAxisRevertByRevertType.HandleId = 0;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00079FD1 File Offset: 0x000781D1
		public static void Init()
		{
			ConfigAxisRevertByRevertType.HandleId = ConfigCommon.InitDataStatement(ConfigAxisRevertByRevertType.HandleId, "db_menu.db", "select BinData from `AxisRevert` where RevertType=?");
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00079FEC File Offset: 0x000781EC
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

		// Token: 0x040005CC RID: 1484
		private const string DB = "db_menu.db";

		// Token: 0x040005CD RID: 1485
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040005CE RID: 1486
		private const string TABLE = "AxisRevert";

		// Token: 0x040005CF RID: 1487
		private const string COMMAND = "select BinData from `AxisRevert` where RevertType=?";

		// Token: 0x040005D0 RID: 1488
		private const string KEY_PREFIX = "AxisRevertByRevertType";

		// Token: 0x040005D1 RID: 1489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005D2 RID: 1490
		private static int HandleId;
	}
}
