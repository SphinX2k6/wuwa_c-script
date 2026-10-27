using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000248 RID: 584
	public class ConfigDynamicMapMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DB4 RID: 3508 RVA: 0x000A6F47 File Offset: 0x000A5147
		static ConfigDynamicMapMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000A6F68 File Offset: 0x000A5168
		public static void CreateStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDynamicMapMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "DynamicMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `DynamicMapMark` where MarkId=?")
			});
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000A6FE7 File Offset: 0x000A51E7
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMarkId.LogPair = null;
			ConfigDynamicMapMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x000A6FF5 File Offset: 0x000A51F5
		public static void Init()
		{
			ConfigDynamicMapMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark` where MarkId=?");
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000A7010 File Offset: 0x000A5210
		public static DynamicMapMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DynamicMapMark?(DynamicMapMark.GetRootAsDynamicMapMark(configBuffer));
				}
			}
			ConfigDynamicMapMarkByMarkId.LogPair.Clear();
			ConfigDynamicMapMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigDynamicMapMarkByMarkId.HandleId, 1, p0MarkId, ConfigDynamicMapMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigDynamicMapMarkByMarkId.HandleId, true, ConfigDynamicMapMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDynamicMapMarkByMarkId.HandleId, 0, ConfigDynamicMapMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DynamicMapMark rootAsDynamicMapMark = DynamicMapMark.GetRootAsDynamicMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
			return new DynamicMapMark?(rootAsDynamicMapMark);
		}

		// Token: 0x04000FDC RID: 4060
		private const string DB = "db_map_mark.db";

		// Token: 0x04000FDD RID: 4061
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000FDE RID: 4062
		private const string TABLE = "DynamicMapMark";

		// Token: 0x04000FDF RID: 4063
		private const string COMMAND = "select BinData from `DynamicMapMark` where MarkId=?";

		// Token: 0x04000FE0 RID: 4064
		private const string KEY_PREFIX = "DynamicMapMarkByMarkId";

		// Token: 0x04000FE1 RID: 4065
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FE2 RID: 4066
		private static int HandleId;
	}
}
