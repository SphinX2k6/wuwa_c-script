using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E5 RID: 1253
	public class ConfigLoadingLevelAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D69 RID: 7529 RVA: 0x000FF72F File Offset: 0x000FD92F
		static ConfigLoadingLevelAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingLevelAreaById.CreateStaticDefaultValue), new Action(ConfigLoadingLevelAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000FF750 File Offset: 0x000FD950
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

		// Token: 0x06001D6B RID: 7531 RVA: 0x000FF7CF File Offset: 0x000FD9CF
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingLevelAreaById.LogPair = null;
			ConfigLoadingLevelAreaById.HandleId = 0;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x000FF7DD File Offset: 0x000FD9DD
		public static void Init()
		{
			ConfigLoadingLevelAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingLevelAreaById.HandleId, "db_loadingtips.db", "select BinData from `LoadingLevelArea` where Id=?");
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000FF7F8 File Offset: 0x000FD9F8
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

		// Token: 0x04002227 RID: 8743
		private const string DB = "db_loadingtips.db";

		// Token: 0x04002228 RID: 8744
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x04002229 RID: 8745
		private const string TABLE = "LoadingLevelArea";

		// Token: 0x0400222A RID: 8746
		private const string COMMAND = "select BinData from `LoadingLevelArea` where Id=?";

		// Token: 0x0400222B RID: 8747
		private const string KEY_PREFIX = "LoadingLevelAreaById";

		// Token: 0x0400222C RID: 8748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400222D RID: 8749
		private static int HandleId;
	}
}
