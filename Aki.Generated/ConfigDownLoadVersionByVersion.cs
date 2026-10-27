using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021B RID: 539
	public class ConfigDownLoadVersionByVersion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x000A1037 File Offset: 0x0009F237
		static ConfigDownLoadVersionByVersion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadVersionByVersion.CreateStaticDefaultValue), new Action(ConfigDownLoadVersionByVersion.ResetStaticDefaultValue));
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000A1058 File Offset: 0x0009F258
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadVersionByVersion.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadVersionByVersion.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadVersion"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadVersion` where Version=?")
			});
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000A10D7 File Offset: 0x0009F2D7
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadVersionByVersion.LogPair = null;
			ConfigDownLoadVersionByVersion.HandleId = 0;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000A10E5 File Offset: 0x0009F2E5
		public static void Init()
		{
			ConfigDownLoadVersionByVersion.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadVersionByVersion.HandleId, "db_download.db", "select BinData from `DownLoadVersion` where Version=?");
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000A1100 File Offset: 0x0009F300
		public static DownLoadVersion? GetConfig(int p0Version, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadVersionByVersion.HandleId, ConfigDownLoadVersionByVersion.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadVersionByVersion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Version);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DownLoadVersion?(DownLoadVersion.GetRootAsDownLoadVersion(configBuffer));
				}
			}
			ConfigDownLoadVersionByVersion.LogPair.Clear();
			ConfigDownLoadVersionByVersion.LogPair.Add(new ValueTuple<string, object>("Version", p0Version));
			if (!ConfigCommon.BindInt(ConfigDownLoadVersionByVersion.HandleId, 1, p0Version, ConfigDownLoadVersionByVersion.LogPair) || ConfigCommon.Step(ConfigDownLoadVersionByVersion.HandleId, true, ConfigDownLoadVersionByVersion.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDownLoadVersionByVersion.HandleId, ConfigDownLoadVersionByVersion.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadVersionByVersion.HandleId, 0, ConfigDownLoadVersionByVersion.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDownLoadVersionByVersion.HandleId, ConfigDownLoadVersionByVersion.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DownLoadVersion rootAsDownLoadVersion = DownLoadVersion.GetRootAsDownLoadVersion(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadVersionByVersion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Version);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDownLoadVersionByVersion.HandleId, ConfigDownLoadVersionByVersion.LogPair);
			return new DownLoadVersion?(rootAsDownLoadVersion);
		}

		// Token: 0x04000EA1 RID: 3745
		private const string DB = "db_download.db";

		// Token: 0x04000EA2 RID: 3746
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000EA3 RID: 3747
		private const string TABLE = "DownLoadVersion";

		// Token: 0x04000EA4 RID: 3748
		private const string COMMAND = "select BinData from `DownLoadVersion` where Version=?";

		// Token: 0x04000EA5 RID: 3749
		private const string KEY_PREFIX = "DownLoadVersionByVersion";

		// Token: 0x04000EA6 RID: 3750
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EA7 RID: 3751
		private static int HandleId;
	}
}
