using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AE RID: 174
	public class ConfigAreaMapGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x00074347 File Offset: 0x00072547
		static ConfigAreaMapGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMapGroupById.CreateStaticDefaultValue), new Action(ConfigAreaMapGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00074368 File Offset: 0x00072568
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaMapGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaMapGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaMapGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaMapGroup` where Id=?")
			});
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000743E7 File Offset: 0x000725E7
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMapGroupById.LogPair = null;
			ConfigAreaMapGroupById.HandleId = 0;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000743F5 File Offset: 0x000725F5
		public static void Init()
		{
			ConfigAreaMapGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMapGroupById.HandleId, "db_areaterminal.db", "select BinData from `AreaMapGroup` where Id=?");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00074410 File Offset: 0x00072610
		public static AreaMapGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaMapGroupById.HandleId, ConfigAreaMapGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaMapGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaMapGroup?(AreaMapGroup.GetRootAsAreaMapGroup(configBuffer));
				}
			}
			ConfigAreaMapGroupById.LogPair.Clear();
			ConfigAreaMapGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaMapGroupById.HandleId, 1, p0Id, ConfigAreaMapGroupById.LogPair) || ConfigCommon.Step(ConfigAreaMapGroupById.HandleId, true, ConfigAreaMapGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaMapGroupById.HandleId, ConfigAreaMapGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaMapGroupById.HandleId, 0, ConfigAreaMapGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaMapGroupById.HandleId, ConfigAreaMapGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaMapGroup rootAsAreaMapGroup = AreaMapGroup.GetRootAsAreaMapGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaMapGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaMapGroupById.HandleId, ConfigAreaMapGroupById.LogPair);
			return new AreaMapGroup?(rootAsAreaMapGroup);
		}

		// Token: 0x040004A6 RID: 1190
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004A7 RID: 1191
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004A8 RID: 1192
		private const string TABLE = "AreaMapGroup";

		// Token: 0x040004A9 RID: 1193
		private const string COMMAND = "select BinData from `AreaMapGroup` where Id=?";

		// Token: 0x040004AA RID: 1194
		private const string KEY_PREFIX = "AreaMapGroupById";

		// Token: 0x040004AB RID: 1195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004AC RID: 1196
		private static int HandleId;
	}
}
