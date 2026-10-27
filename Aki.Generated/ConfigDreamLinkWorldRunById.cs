using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000220 RID: 544
	public class ConfigDreamLinkWorldRunById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x000A1C54 File Offset: 0x0009FE54
		static ConfigDreamLinkWorldRunById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDreamLinkWorldRunById.CreateStaticDefaultValue), new Action(ConfigDreamLinkWorldRunById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000A1C74 File Offset: 0x0009FE74
		public static void CreateStaticDefaultValue()
		{
			ConfigDreamLinkWorldRunById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDreamLinkWorldRunById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "DreamLinkWorldRun"),
				new ValueTuple<string, object>("语句", "select BinData from `DreamLinkWorldRun` where Id=?")
			});
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000A1CF3 File Offset: 0x0009FEF3
		public static void ResetStaticDefaultValue()
		{
			ConfigDreamLinkWorldRunById.LogPair = null;
			ConfigDreamLinkWorldRunById.HandleId = 0;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000A1D01 File Offset: 0x0009FF01
		public static void Init()
		{
			ConfigDreamLinkWorldRunById.HandleId = ConfigCommon.InitDataStatement(ConfigDreamLinkWorldRunById.HandleId, "db_dreamlink.db", "select BinData from `DreamLinkWorldRun` where Id=?");
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000A1D1C File Offset: 0x0009FF1C
		public static DreamLinkWorldRun? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDreamLinkWorldRunById.HandleId, ConfigDreamLinkWorldRunById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkWorldRunById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DreamLinkWorldRun?(DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(configBuffer));
				}
			}
			ConfigDreamLinkWorldRunById.LogPair.Clear();
			ConfigDreamLinkWorldRunById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDreamLinkWorldRunById.HandleId, 1, p0Id, ConfigDreamLinkWorldRunById.LogPair) || ConfigCommon.Step(ConfigDreamLinkWorldRunById.HandleId, true, ConfigDreamLinkWorldRunById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDreamLinkWorldRunById.HandleId, ConfigDreamLinkWorldRunById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDreamLinkWorldRunById.HandleId, 0, ConfigDreamLinkWorldRunById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDreamLinkWorldRunById.HandleId, ConfigDreamLinkWorldRunById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DreamLinkWorldRun rootAsDreamLinkWorldRun = DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkWorldRunById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDreamLinkWorldRunById.HandleId, ConfigDreamLinkWorldRunById.LogPair);
			return new DreamLinkWorldRun?(rootAsDreamLinkWorldRun);
		}

		// Token: 0x04000EC4 RID: 3780
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000EC5 RID: 3781
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000EC6 RID: 3782
		private const string TABLE = "DreamLinkWorldRun";

		// Token: 0x04000EC7 RID: 3783
		private const string COMMAND = "select BinData from `DreamLinkWorldRun` where Id=?";

		// Token: 0x04000EC8 RID: 3784
		private const string KEY_PREFIX = "DreamLinkWorldRunById";

		// Token: 0x04000EC9 RID: 3785
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ECA RID: 3786
		private static int HandleId;
	}
}
