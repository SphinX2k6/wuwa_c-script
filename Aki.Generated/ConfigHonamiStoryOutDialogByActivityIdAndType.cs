using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040F RID: 1039
	public class ConfigHonamiStoryOutDialogByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001861 RID: 6241 RVA: 0x000E7087 File Offset: 0x000E5287
		static ConfigHonamiStoryOutDialogByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryOutDialogByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigHonamiStoryOutDialogByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000E70A8 File Offset: 0x000E52A8
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

		// Token: 0x06001863 RID: 6243 RVA: 0x000E7127 File Offset: 0x000E5327
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogByActivityIdAndType.LogPair = null;
			ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000E7135 File Offset: 0x000E5335
		public static void Init()
		{
			ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryOutDialogByActivityIdAndType.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryOutDialog` where ActivityId=? AND Type = ?");
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000E7150 File Offset: 0x000E5350
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

		// Token: 0x04001C4D RID: 7245
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C4E RID: 7246
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C4F RID: 7247
		private const string TABLE = "HonamiStoryOutDialog";

		// Token: 0x04001C50 RID: 7248
		private const string COMMAND = "select BinData from `HonamiStoryOutDialog` where ActivityId=? AND Type = ?";

		// Token: 0x04001C51 RID: 7249
		private const string KEY_PREFIX = "HonamiStoryOutDialogByActivityIdAndType";

		// Token: 0x04001C52 RID: 7250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C53 RID: 7251
		private static int HandleId;
	}
}
