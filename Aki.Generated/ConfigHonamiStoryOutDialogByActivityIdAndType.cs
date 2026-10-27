using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F9 RID: 1017
	public class ConfigHonamiStoryOutDialogByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x000E0933 File Offset: 0x000DEB33
		static ConfigHonamiStoryOutDialogByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryOutDialogByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigHonamiStoryOutDialogByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x000E0954 File Offset: 0x000DEB54
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryOutDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryOutDialog` where ActivityId=? AND Type = ?")
			});
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000E09D3 File Offset: 0x000DEBD3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair = null;
			ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000E09E1 File Offset: 0x000DEBE1
		public static void Init()
		{
			ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryOutDialog` where ActivityId=? AND Type = ?");
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000E09FC File Offset: 0x000DEBFC
		public static HonamiStoryOutDialog? GetConfig(int p0ActivityId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryOutDialog?(HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(configBuffer));
				}
			}
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair.Clear();
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, 1, p0ActivityId, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, 2, p1Type, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair) || ConfigCommon.Step(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, true, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, 0, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryOutDialog rootAsHonamiStoryOutDialog = HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair);
			return new HonamiStoryOutDialog?(rootAsHonamiStoryOutDialog);
		}

		// Token: 0x04001BB3 RID: 7091
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BB4 RID: 7092
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BB5 RID: 7093
		private const string TABLE = "HonamiStoryOutDialog";

		// Token: 0x04001BB6 RID: 7094
		private const string COMMAND = "select BinData from `HonamiStoryOutDialog` where ActivityId=? AND Type = ?";

		// Token: 0x04001BB7 RID: 7095
		private const string KEY_PREFIX = "HonamiStoryOutDialogByActivityIdAndType";

		// Token: 0x04001BB8 RID: 7096
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BB9 RID: 7097
		private static int HandleId;
	}
}
