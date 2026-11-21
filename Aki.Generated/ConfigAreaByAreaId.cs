using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A8 RID: 168
	public class ConfigAreaByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x000734AC File Offset: 0x000716AC
		static ConfigAreaByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000734CC File Offset: 0x000716CC
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

		// Token: 0x060003F2 RID: 1010 RVA: 0x0007354B File Offset: 0x0007174B
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByAreaId.LogPair = null;
			ConfigAreaByAreaId.HandleId = 0;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00073559 File Offset: 0x00071759
		public static void Init()
		{
			ConfigAreaByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByAreaId.HandleId, "db_area.db", "select BinData from `Area` where AreaId=?");
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00073574 File Offset: 0x00071774
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x000736EC File Offset: 0x000718EC
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

		// Token: 0x0400047C RID: 1148
		private const string DB = "db_area.db";

		// Token: 0x0400047D RID: 1149
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400047E RID: 1150
		private const string TABLE = "Area";

		// Token: 0x0400047F RID: 1151
		private const string COMMAND = "select BinData from `Area` where AreaId=?";

		// Token: 0x04000480 RID: 1152
		private const string KEY_PREFIX = "AreaByAreaId";

		// Token: 0x04000481 RID: 1153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000482 RID: 1154
		private static int HandleId;
	}
}
