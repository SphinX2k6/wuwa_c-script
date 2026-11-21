using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000661 RID: 1633
	public class ConfigPbDataPreloadByMapIdAndPbId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002656 RID: 9814 RVA: 0x00135DBB File Offset: 0x00133FBB
		static ConfigPbDataPreloadByMapIdAndPbId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPbDataPreloadByMapIdAndPbId.CreateStaticDefaultValue), new Action(ConfigPbDataPreloadByMapIdAndPbId.ResetStaticDefaultValue));
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00135DDC File Offset: 0x00133FDC
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

		// Token: 0x06002658 RID: 9816 RVA: 0x00135E5B File Offset: 0x0013405B
		public static void ResetStaticDefaultValue()
		{
			ConfigPbDataPreloadByMapIdAndPbId.LogPair = null;
			ConfigPbDataPreloadByMapIdAndPbId.HandleId = 0;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00135E69 File Offset: 0x00134069
		public static void Init()
		{
			ConfigPbDataPreloadByMapIdAndPbId.HandleId = ConfigCommon.InitDataStatement(ConfigPbDataPreloadByMapIdAndPbId.HandleId, "db_pbdata_preload.db", "select BinData from `PbDataPreload` where MapId=? AND PbDataId=?");
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00135E84 File Offset: 0x00134084
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

		// Token: 0x04002C8D RID: 11405
		private const string DB = "db_pbdata_preload.db";

		// Token: 0x04002C8E RID: 11406
		private const string FILE = "Preload/PbDataPreload.csv";

		// Token: 0x04002C8F RID: 11407
		private const string TABLE = "PbDataPreload";

		// Token: 0x04002C90 RID: 11408
		private const string COMMAND = "select BinData from `PbDataPreload` where MapId=? AND PbDataId=?";

		// Token: 0x04002C91 RID: 11409
		private const string KEY_PREFIX = "PbDataPreloadByMapIdAndPbId";

		// Token: 0x04002C92 RID: 11410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C93 RID: 11411
		private static int HandleId;
	}
}
