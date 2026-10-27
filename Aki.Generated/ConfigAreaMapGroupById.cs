using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A6 RID: 166
	public class ConfigAreaMapGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x0006FA93 File Offset: 0x0006DC93
		static ConfigAreaMapGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMapGroupById.CreateStaticDefaultValue), new Action(ConfigAreaMapGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0006FAB4 File Offset: 0x0006DCB4
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

		// Token: 0x060003E7 RID: 999 RVA: 0x0006FB33 File Offset: 0x0006DD33
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMapGroupById.LogPair = null;
			ConfigAreaMapGroupById.HandleId = 0;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0006FB41 File Offset: 0x0006DD41
		public static void Init()
		{
			ConfigAreaMapGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMapGroupById.HandleId, "db_areaterminal.db", "select BinData from `AreaMapGroup` where Id=?");
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0006FB5C File Offset: 0x0006DD5C
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

		// Token: 0x0400046E RID: 1134
		private const string DB = "db_areaterminal.db";

		// Token: 0x0400046F RID: 1135
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x04000470 RID: 1136
		private const string TABLE = "AreaMapGroup";

		// Token: 0x04000471 RID: 1137
		private const string COMMAND = "select BinData from `AreaMapGroup` where Id=?";

		// Token: 0x04000472 RID: 1138
		private const string KEY_PREFIX = "AreaMapGroupById";

		// Token: 0x04000473 RID: 1139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000474 RID: 1140
		private static int HandleId;
	}
}
