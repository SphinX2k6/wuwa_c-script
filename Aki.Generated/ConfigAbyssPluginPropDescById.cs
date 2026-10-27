using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001A RID: 26
	public class ConfigAbyssPluginPropDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0005D5E3 File Offset: 0x0005B7E3
		static ConfigAbyssPluginPropDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssPluginPropDescById.CreateStaticDefaultValue), new Action(ConfigAbyssPluginPropDescById.ResetStaticDefaultValue));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0005D604 File Offset: 0x0005B804
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssPluginPropDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssPluginPropDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssPluginPropDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssPluginPropDesc` where Id=?")
			});
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0005D683 File Offset: 0x0005B883
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssPluginPropDescById.LogPair = null;
			ConfigAbyssPluginPropDescById.HandleId = 0;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0005D691 File Offset: 0x0005B891
		public static void Init()
		{
			ConfigAbyssPluginPropDescById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssPluginPropDescById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssPluginPropDesc` where Id=?");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0005D6AC File Offset: 0x0005B8AC
		public static AbyssPluginPropDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssPluginPropDescById.HandleId, ConfigAbyssPluginPropDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssPluginPropDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssPluginPropDesc?(AbyssPluginPropDesc.GetRootAsAbyssPluginPropDesc(configBuffer));
				}
			}
			ConfigAbyssPluginPropDescById.LogPair.Clear();
			ConfigAbyssPluginPropDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssPluginPropDescById.HandleId, 1, p0Id, ConfigAbyssPluginPropDescById.LogPair) || ConfigCommon.Step(ConfigAbyssPluginPropDescById.HandleId, true, ConfigAbyssPluginPropDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssPluginPropDescById.HandleId, ConfigAbyssPluginPropDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssPluginPropDescById.HandleId, 0, ConfigAbyssPluginPropDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssPluginPropDescById.HandleId, ConfigAbyssPluginPropDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssPluginPropDesc rootAsAbyssPluginPropDesc = AbyssPluginPropDesc.GetRootAsAbyssPluginPropDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssPluginPropDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssPluginPropDescById.HandleId, ConfigAbyssPluginPropDescById.LogPair);
			return new AbyssPluginPropDesc?(rootAsAbyssPluginPropDesc);
		}

		// Token: 0x0400009A RID: 154
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x0400009B RID: 155
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x0400009C RID: 156
		private const string TABLE = "AbyssPluginPropDesc";

		// Token: 0x0400009D RID: 157
		private const string COMMAND = "select BinData from `AbyssPluginPropDesc` where Id=?";

		// Token: 0x0400009E RID: 158
		private const string KEY_PREFIX = "AbyssPluginPropDescById";

		// Token: 0x0400009F RID: 159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000A0 RID: 160
		private static int HandleId;
	}
}
