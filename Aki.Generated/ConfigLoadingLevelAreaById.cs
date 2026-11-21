using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FB RID: 1275
	public class ConfigLoadingLevelAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x00105E83 File Offset: 0x00104083
		static ConfigLoadingLevelAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingLevelAreaById.CreateStaticDefaultValue), new Action(ConfigLoadingLevelAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00105EA4 File Offset: 0x001040A4
		public static void CreateStaticDefaultValue()
		{
			ConfigLoadingLevelAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoadingLevelAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "LoadingLevelArea"),
				new ValueTuple<string, object>("语句", "select BinData from `LoadingLevelArea` where Id=?")
			});
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00105F23 File Offset: 0x00104123
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingLevelAreaById.LogPair = null;
			ConfigLoadingLevelAreaById.HandleId = 0;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00105F31 File Offset: 0x00104131
		public static void Init()
		{
			ConfigLoadingLevelAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingLevelAreaById.HandleId, "db_loadingtips.db", "select BinData from `LoadingLevelArea` where Id=?");
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00105F4C File Offset: 0x0010414C
		public static LoadingLevelArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoadingLevelAreaById.HandleId, ConfigLoadingLevelAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingLevelAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LoadingLevelArea?(LoadingLevelArea.GetRootAsLoadingLevelArea(configBuffer));
				}
			}
			ConfigLoadingLevelAreaById.LogPair.Clear();
			ConfigLoadingLevelAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLoadingLevelAreaById.HandleId, 1, p0Id, ConfigLoadingLevelAreaById.LogPair) || ConfigCommon.Step(ConfigLoadingLevelAreaById.HandleId, true, ConfigLoadingLevelAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLoadingLevelAreaById.HandleId, ConfigLoadingLevelAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoadingLevelAreaById.HandleId, 0, ConfigLoadingLevelAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLoadingLevelAreaById.HandleId, ConfigLoadingLevelAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LoadingLevelArea rootAsLoadingLevelArea = LoadingLevelArea.GetRootAsLoadingLevelArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingLevelAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLoadingLevelAreaById.HandleId, ConfigLoadingLevelAreaById.LogPair);
			return new LoadingLevelArea?(rootAsLoadingLevelArea);
		}

		// Token: 0x040022C1 RID: 8897
		private const string DB = "db_loadingtips.db";

		// Token: 0x040022C2 RID: 8898
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040022C3 RID: 8899
		private const string TABLE = "LoadingLevelArea";

		// Token: 0x040022C4 RID: 8900
		private const string COMMAND = "select BinData from `LoadingLevelArea` where Id=?";

		// Token: 0x040022C5 RID: 8901
		private const string KEY_PREFIX = "LoadingLevelAreaById";

		// Token: 0x040022C6 RID: 8902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022C7 RID: 8903
		private static int HandleId;
	}
}
