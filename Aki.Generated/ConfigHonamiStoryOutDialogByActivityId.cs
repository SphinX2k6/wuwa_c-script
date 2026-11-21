using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040E RID: 1038
	public class ConfigHonamiStoryOutDialogByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x000E6E50 File Offset: 0x000E5050
		static ConfigHonamiStoryOutDialogByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryOutDialogByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryOutDialogByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000E6E70 File Offset: 0x000E5070
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

		// Token: 0x0600185D RID: 6237 RVA: 0x000E6EEF File Offset: 0x000E50EF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityId.LogPair = null;
			ConfigHonamiStoryOutDialogByActivityId.HandleId = 0;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000E6EFD File Offset: 0x000E50FD
		public static void Init()
		{
			ConfigHonamiStoryOutDialogByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryOutDialogByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryOutDialog` where ActivityId=?");
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000E6F18 File Offset: 0x000E5118
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

		// Token: 0x04001C46 RID: 7238
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C47 RID: 7239
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C48 RID: 7240
		private const string TABLE = "HonamiStoryOutDialog";

		// Token: 0x04001C49 RID: 7241
		private const string COMMAND = "select BinData from `HonamiStoryOutDialog` where ActivityId=?";

		// Token: 0x04001C4A RID: 7242
		private const string KEY_PREFIX = "HonamiStoryOutDialogByActivityId";

		// Token: 0x04001C4B RID: 7243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C4C RID: 7244
		private static int HandleId;
	}
}
