using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000649 RID: 1609
	public class ConfigPbDataPreloadByMapIdAndPbId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x0012F33F File Offset: 0x0012D53F
		static ConfigPbDataPreloadByMapIdAndPbId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPbDataPreloadByMapIdAndPbId.CreateStaticDefaultValue), new Action(ConfigPbDataPreloadByMapIdAndPbId.ResetStaticDefaultValue));
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0012F360 File Offset: 0x0012D560
		public static void CreateStaticDefaultValue()
		{
			ConfigPbDataPreloadByMapIdAndPbId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPbDataPreloadByMapIdAndPbId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pbdata_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/PbDataPreload.csv"),
				new ValueTuple<string, object>("表名", "PbDataPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `PbDataPreload` where MapId=? AND PbDataId=?")
			});
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0012F3DF File Offset: 0x0012D5DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPbDataPreloadByMapIdAndPbId.LogPair = null;
			ConfigPbDataPreloadByMapIdAndPbId.HandleId = 0;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0012F3ED File Offset: 0x0012D5ED
		public static void Init()
		{
			ConfigPbDataPreloadByMapIdAndPbId.HandleId = ConfigCommon.InitDataStatement(ConfigPbDataPreloadByMapIdAndPbId.HandleId, "db_pbdata_preload.db", "select BinData from `PbDataPreload` where MapId=? AND PbDataId=?");
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0012F408 File Offset: 0x0012D608
		public static PbDataPreload? GetConfig(int p0MapId, int p1PbDataId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPbDataPreloadByMapIdAndPbId.HandleId, ConfigPbDataPreloadByMapIdAndPbId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PbDataPreloadByMapIdAndPbId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PbDataId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PbDataPreload?(PbDataPreload.GetRootAsPbDataPreload(configBuffer));
				}
			}
			ConfigPbDataPreloadByMapIdAndPbId.LogPair.Clear();
			ConfigPbDataPreloadByMapIdAndPbId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			ConfigPbDataPreloadByMapIdAndPbId.LogPair.Add(new ValueTuple<string, object>("PbDataId", p1PbDataId));
			if (!ConfigCommon.BindInt(ConfigPbDataPreloadByMapIdAndPbId.HandleId, 1, p0MapId, ConfigPbDataPreloadByMapIdAndPbId.LogPair) || !ConfigCommon.BindInt(ConfigPbDataPreloadByMapIdAndPbId.HandleId, 2, p1PbDataId, ConfigPbDataPreloadByMapIdAndPbId.LogPair) || ConfigCommon.Step(ConfigPbDataPreloadByMapIdAndPbId.HandleId, true, ConfigPbDataPreloadByMapIdAndPbId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPbDataPreloadByMapIdAndPbId.HandleId, ConfigPbDataPreloadByMapIdAndPbId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPbDataPreloadByMapIdAndPbId.HandleId, 0, ConfigPbDataPreloadByMapIdAndPbId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPbDataPreloadByMapIdAndPbId.HandleId, ConfigPbDataPreloadByMapIdAndPbId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PbDataPreload rootAsPbDataPreload = PbDataPreload.GetRootAsPbDataPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PbDataPreloadByMapIdAndPbId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PbDataId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPbDataPreloadByMapIdAndPbId.HandleId, ConfigPbDataPreloadByMapIdAndPbId.LogPair);
			return new PbDataPreload?(rootAsPbDataPreload);
		}

		// Token: 0x04002BE5 RID: 11237
		private const string DB = "db_pbdata_preload.db";

		// Token: 0x04002BE6 RID: 11238
		private const string FILE = "Preload/PbDataPreload.csv";

		// Token: 0x04002BE7 RID: 11239
		private const string TABLE = "PbDataPreload";

		// Token: 0x04002BE8 RID: 11240
		private const string COMMAND = "select BinData from `PbDataPreload` where MapId=? AND PbDataId=?";

		// Token: 0x04002BE9 RID: 11241
		private const string KEY_PREFIX = "PbDataPreloadByMapIdAndPbId";

		// Token: 0x04002BEA RID: 11242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BEB RID: 11243
		private static int HandleId;
	}
}
