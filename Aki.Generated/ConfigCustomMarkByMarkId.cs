using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C5 RID: 453
	public class ConfigCustomMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x00099347 File Offset: 0x00097547
		static ConfigCustomMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigCustomMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00099368 File Offset: 0x00097568
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

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000993E7 File Offset: 0x000975E7
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomMarkByMarkId.LogPair = null;
			ConfigCustomMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000993F5 File Offset: 0x000975F5
		public static void Init()
		{
			ConfigCustomMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigCustomMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `CustomMark` where MarkId=?");
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00099410 File Offset: 0x00097610
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

		// Token: 0x04000C47 RID: 3143
		private const string DB = "db_map_mark.db";

		// Token: 0x04000C48 RID: 3144
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000C49 RID: 3145
		private const string TABLE = "CustomMark";

		// Token: 0x04000C4A RID: 3146
		private const string COMMAND = "select BinData from `CustomMark` where MarkId=?";

		// Token: 0x04000C4B RID: 3147
		private const string KEY_PREFIX = "CustomMarkByMarkId";

		// Token: 0x04000C4C RID: 3148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C4D RID: 3149
		private static int HandleId;
	}
}
