using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040C RID: 1036
	public class ConfigHonamiStoryMascotByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x000E69D0 File Offset: 0x000E4BD0
		static ConfigHonamiStoryMascotByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMascotByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMascotByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000E69F0 File Offset: 0x000E4BF0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMascotByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMascotByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMascot"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMascot` where ActivityId=?")
			});
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000E6A6F File Offset: 0x000E4C6F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMascotByActivityId.LogPair = null;
			ConfigHonamiStoryMascotByActivityId.HandleId = 0;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000E6A7D File Offset: 0x000E4C7D
		public static void Init()
		{
			ConfigHonamiStoryMascotByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMascotByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMascot` where ActivityId=?");
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000E6A98 File Offset: 0x000E4C98
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryMascot> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMascotByActivityId.HandleId, ConfigHonamiStoryMascotByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMascotByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryMascot> readOnlyList = (IReadOnlyList<HonamiStoryMascot>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryMascotByActivityId.LogPair.Clear();
			ConfigHonamiStoryMascotByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryMascotByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryMascotByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryMascotByActivityId.HandleId, ConfigHonamiStoryMascotByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryMascot> list = new List<HonamiStoryMascot>();
			while (ConfigCommon.Step(ConfigHonamiStoryMascotByActivityId.HandleId, false, ConfigHonamiStoryMascotByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMascotByActivityId.HandleId, 0, ConfigHonamiStoryMascotByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryMascotByActivityId.HandleId, ConfigHonamiStoryMascotByActivityId.LogPair);
					return null;
				}
				HonamiStoryMascot rootAsHonamiStoryMascot = HonamiStoryMascot.GetRootAsHonamiStoryMascot(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryMascot);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMascotByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMascotByActivityId.HandleId, ConfigHonamiStoryMascotByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001C38 RID: 7224
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C39 RID: 7225
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C3A RID: 7226
		private const string TABLE = "HonamiStoryMascot";

		// Token: 0x04001C3B RID: 7227
		private const string COMMAND = "select BinData from `HonamiStoryMascot` where ActivityId=?";

		// Token: 0x04001C3C RID: 7228
		private const string KEY_PREFIX = "HonamiStoryMascotByActivityId";

		// Token: 0x04001C3D RID: 7229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C3E RID: 7230
		private static int HandleId;
	}
}
