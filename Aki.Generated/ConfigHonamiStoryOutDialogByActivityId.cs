using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F8 RID: 1016
	public class ConfigHonamiStoryOutDialogByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017D7 RID: 6103 RVA: 0x000E06FC File Offset: 0x000DE8FC
		static ConfigHonamiStoryOutDialogByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryOutDialogByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryOutDialogByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000E071C File Offset: 0x000DE91C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryOutDialogByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryOutDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryOutDialog` where ActivityId=?")
			});
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000E079B File Offset: 0x000DE99B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityId.LogPair = null;
			ConfigHonamiStoryOutDialogByActivityId.HandleId = 0;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x000E07A9 File Offset: 0x000DE9A9
		public static void Init()
		{
			ConfigHonamiStoryOutDialogByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryOutDialogByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryOutDialog` where ActivityId=?");
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000E07C4 File Offset: 0x000DE9C4
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryOutDialog> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryOutDialogByActivityId.HandleId, ConfigHonamiStoryOutDialogByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryOutDialog> readOnlyList = (IReadOnlyList<HonamiStoryOutDialog>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryOutDialogByActivityId.LogPair.Clear();
			ConfigHonamiStoryOutDialogByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryOutDialogByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryOutDialogByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityId.HandleId, ConfigHonamiStoryOutDialogByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryOutDialog> list = new List<HonamiStoryOutDialog>();
			while (ConfigCommon.Step(ConfigHonamiStoryOutDialogByActivityId.HandleId, false, ConfigHonamiStoryOutDialogByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryOutDialogByActivityId.HandleId, 0, ConfigHonamiStoryOutDialogByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityId.HandleId, ConfigHonamiStoryOutDialogByActivityId.LogPair);
					return null;
				}
				HonamiStoryOutDialog rootAsHonamiStoryOutDialog = HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryOutDialog);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityId.HandleId, ConfigHonamiStoryOutDialogByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001BAC RID: 7084
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BAD RID: 7085
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BAE RID: 7086
		private const string TABLE = "HonamiStoryOutDialog";

		// Token: 0x04001BAF RID: 7087
		private const string COMMAND = "select BinData from `HonamiStoryOutDialog` where ActivityId=?";

		// Token: 0x04001BB0 RID: 7088
		private const string KEY_PREFIX = "HonamiStoryOutDialogByActivityId";

		// Token: 0x04001BB1 RID: 7089
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BB2 RID: 7090
		private static int HandleId;
	}
}
