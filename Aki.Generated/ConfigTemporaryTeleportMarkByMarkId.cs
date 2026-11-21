using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA4 RID: 2724
	public class ConfigTemporaryTeleportMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FEC RID: 16364 RVA: 0x001C6338 File Offset: 0x001C4538
		static ConfigTemporaryTeleportMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemporaryTeleportMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTemporaryTeleportMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x001C6358 File Offset: 0x001C4558
		public static void CreateStaticDefaultValue()
		{
			ConfigTemporaryTeleportMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemporaryTeleportMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "TemporaryTeleportMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TemporaryTeleportMark` where MarkId=?")
			});
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x001C63D7 File Offset: 0x001C45D7
		public static void ResetStaticDefaultValue()
		{
			ConfigTemporaryTeleportMarkByMarkId.LogPair = null;
			ConfigTemporaryTeleportMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x001C63E5 File Offset: 0x001C45E5
		public static void Init()
		{
			ConfigTemporaryTeleportMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTemporaryTeleportMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TemporaryTeleportMark` where MarkId=?");
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x001C6400 File Offset: 0x001C4600
		public static TemporaryTeleportMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemporaryTeleportMarkByMarkId.HandleId, ConfigTemporaryTeleportMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemporaryTeleportMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TemporaryTeleportMark?(TemporaryTeleportMark.GetRootAsTemporaryTeleportMark(configBuffer));
				}
			}
			ConfigTemporaryTeleportMarkByMarkId.LogPair.Clear();
			ConfigTemporaryTeleportMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigTemporaryTeleportMarkByMarkId.HandleId, 1, p0MarkId, ConfigTemporaryTeleportMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigTemporaryTeleportMarkByMarkId.HandleId, true, ConfigTemporaryTeleportMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTemporaryTeleportMarkByMarkId.HandleId, ConfigTemporaryTeleportMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemporaryTeleportMarkByMarkId.HandleId, 0, ConfigTemporaryTeleportMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTemporaryTeleportMarkByMarkId.HandleId, ConfigTemporaryTeleportMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TemporaryTeleportMark rootAsTemporaryTeleportMark = TemporaryTeleportMark.GetRootAsTemporaryTeleportMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemporaryTeleportMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTemporaryTeleportMarkByMarkId.HandleId, ConfigTemporaryTeleportMarkByMarkId.LogPair);
			return new TemporaryTeleportMark?(rootAsTemporaryTeleportMark);
		}

		// Token: 0x04004A62 RID: 19042
		private const string DB = "db_map_mark.db";

		// Token: 0x04004A63 RID: 19043
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004A64 RID: 19044
		private const string TABLE = "TemporaryTeleportMark";

		// Token: 0x04004A65 RID: 19045
		private const string COMMAND = "select BinData from `TemporaryTeleportMark` where MarkId=?";

		// Token: 0x04004A66 RID: 19046
		private const string KEY_PREFIX = "TemporaryTeleportMarkByMarkId";

		// Token: 0x04004A67 RID: 19047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A68 RID: 19048
		private static int HandleId;
	}
}
