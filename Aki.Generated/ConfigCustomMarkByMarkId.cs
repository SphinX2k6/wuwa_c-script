using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B3 RID: 435
	public class ConfigCustomMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A35 RID: 2613 RVA: 0x0009340F File Offset: 0x0009160F
		static ConfigCustomMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigCustomMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00093430 File Offset: 0x00091630
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "CustomMark"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomMark` where MarkId=?")
			});
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000934AF File Offset: 0x000916AF
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomMarkByMarkId.LogPair = null;
			ConfigCustomMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000934BD File Offset: 0x000916BD
		public static void Init()
		{
			ConfigCustomMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigCustomMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `CustomMark` where MarkId=?");
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000934D8 File Offset: 0x000916D8
		public static CustomMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomMarkByMarkId.HandleId, ConfigCustomMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CustomMark?(CustomMark.GetRootAsCustomMark(configBuffer));
				}
			}
			ConfigCustomMarkByMarkId.LogPair.Clear();
			ConfigCustomMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigCustomMarkByMarkId.HandleId, 1, p0MarkId, ConfigCustomMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigCustomMarkByMarkId.HandleId, true, ConfigCustomMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCustomMarkByMarkId.HandleId, ConfigCustomMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomMarkByMarkId.HandleId, 0, ConfigCustomMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCustomMarkByMarkId.HandleId, ConfigCustomMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CustomMark rootAsCustomMark = CustomMark.GetRootAsCustomMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCustomMarkByMarkId.HandleId, ConfigCustomMarkByMarkId.LogPair);
			return new CustomMark?(rootAsCustomMark);
		}

		// Token: 0x04000BC9 RID: 3017
		private const string DB = "db_map_mark.db";

		// Token: 0x04000BCA RID: 3018
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000BCB RID: 3019
		private const string TABLE = "CustomMark";

		// Token: 0x04000BCC RID: 3020
		private const string COMMAND = "select BinData from `CustomMark` where MarkId=?";

		// Token: 0x04000BCD RID: 3021
		private const string KEY_PREFIX = "CustomMarkByMarkId";

		// Token: 0x04000BCE RID: 3022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BCF RID: 3023
		private static int HandleId;
	}
}
