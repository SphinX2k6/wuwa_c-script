using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F6 RID: 1014
	public class ConfigHonamiStoryMascotByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017CB RID: 6091 RVA: 0x000E027C File Offset: 0x000DE47C
		static ConfigHonamiStoryMascotByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMascotByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMascotByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000E029C File Offset: 0x000DE49C
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

		// Token: 0x060017CD RID: 6093 RVA: 0x000E031B File Offset: 0x000DE51B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMascotByActivityId.LogPair = null;
			ConfigHonamiStoryMascotByActivityId.HandleId = 0;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000E0329 File Offset: 0x000DE529
		public static void Init()
		{
			ConfigHonamiStoryMascotByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMascotByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMascot` where ActivityId=?");
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000E0344 File Offset: 0x000DE544
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

		// Token: 0x04001B9E RID: 7070
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B9F RID: 7071
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BA0 RID: 7072
		private const string TABLE = "HonamiStoryMascot";

		// Token: 0x04001BA1 RID: 7073
		private const string COMMAND = "select BinData from `HonamiStoryMascot` where ActivityId=?";

		// Token: 0x04001BA2 RID: 7074
		private const string KEY_PREFIX = "HonamiStoryMascotByActivityId";

		// Token: 0x04001BA3 RID: 7075
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BA4 RID: 7076
		private static int HandleId;
	}
}
