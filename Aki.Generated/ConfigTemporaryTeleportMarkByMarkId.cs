using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CF RID: 2511
	public class ConfigTemporaryTeleportMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AEE RID: 15086 RVA: 0x001A6FA4 File Offset: 0x001A51A4
		static ConfigTemporaryTeleportMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemporaryTeleportMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTemporaryTeleportMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x001A6FC4 File Offset: 0x001A51C4
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

		// Token: 0x06003AF0 RID: 15088 RVA: 0x001A7043 File Offset: 0x001A5243
		public static void ResetStaticDefaultValue()
		{
			ConfigTemporaryTeleportMarkByMarkId.LogPair = null;
			ConfigTemporaryTeleportMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x001A7051 File Offset: 0x001A5251
		public static void Init()
		{
			ConfigTemporaryTeleportMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTemporaryTeleportMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TemporaryTeleportMark` where MarkId=?");
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x001A706C File Offset: 0x001A526C
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

		// Token: 0x0400448F RID: 17551
		private const string DB = "db_map_mark.db";

		// Token: 0x04004490 RID: 17552
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004491 RID: 17553
		private const string TABLE = "TemporaryTeleportMark";

		// Token: 0x04004492 RID: 17554
		private const string COMMAND = "select BinData from `TemporaryTeleportMark` where MarkId=?";

		// Token: 0x04004493 RID: 17555
		private const string KEY_PREFIX = "TemporaryTeleportMarkByMarkId";

		// Token: 0x04004494 RID: 17556
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004495 RID: 17557
		private static int HandleId;
	}
}
