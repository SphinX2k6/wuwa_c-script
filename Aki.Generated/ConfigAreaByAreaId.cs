using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A0 RID: 160
	public class ConfigAreaByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x0006EBF8 File Offset: 0x0006CDF8
		static ConfigAreaByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0006EC18 File Offset: 0x0006CE18
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area` where AreaId=?")
			});
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0006EC97 File Offset: 0x0006CE97
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByAreaId.LogPair = null;
			ConfigAreaByAreaId.HandleId = 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0006ECA5 File Offset: 0x0006CEA5
		public static void Init()
		{
			ConfigAreaByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByAreaId.HandleId, "db_area.db", "select BinData from `Area` where AreaId=?");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0006ECC0 File Offset: 0x0006CEC0
		public static Area? GetConfig(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Area?(Area.GetRootAsArea(configBuffer));
				}
			}
			ConfigAreaByAreaId.LogPair.Clear();
			ConfigAreaByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigAreaByAreaId.HandleId, 1, p0AreaId, ConfigAreaByAreaId.LogPair) || ConfigCommon.Step(ConfigAreaByAreaId.HandleId, true, ConfigAreaByAreaId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaByAreaId.HandleId, 0, ConfigAreaByAreaId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Area rootAsArea = Area.GetRootAsArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
			return new Area?(rootAsArea);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0006EE38 File Offset: 0x0006D038
		[NullableContext(2)]
		public static IReadOnlyList<Area> GetConfigList(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				IReadOnlyList<Area> readOnlyList = (IReadOnlyList<Area>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaByAreaId.LogPair.Clear();
			ConfigAreaByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigAreaByAreaId.HandleId, 1, p0AreaId, ConfigAreaByAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
				return null;
			}
			List<Area> list = new List<Area>();
			while (ConfigCommon.Step(ConfigAreaByAreaId.HandleId, false, ConfigAreaByAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaByAreaId.HandleId, 0, ConfigAreaByAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
					return null;
				}
				Area rootAsArea = Area.GetRootAsArea(new ByteBuffer(item2));
				list.Add(rootAsArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaByAreaId.HandleId, ConfigAreaByAreaId.LogPair);
			return list;
		}

		// Token: 0x04000444 RID: 1092
		private const string DB = "db_area.db";

		// Token: 0x04000445 RID: 1093
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000446 RID: 1094
		private const string TABLE = "Area";

		// Token: 0x04000447 RID: 1095
		private const string COMMAND = "select BinData from `Area` where AreaId=?";

		// Token: 0x04000448 RID: 1096
		private const string KEY_PREFIX = "AreaByAreaId";

		// Token: 0x04000449 RID: 1097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400044A RID: 1098
		private static int HandleId;
	}
}
