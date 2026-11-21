using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022D RID: 557
	public class ConfigDownLoadVersionByVersion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D11 RID: 3345 RVA: 0x000A6F6F File Offset: 0x000A516F
		static ConfigDownLoadVersionByVersion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadVersionByVersion.CreateStaticDefaultValue), new Action(ConfigDownLoadVersionByVersion.ResetStaticDefaultValue));
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000A6F90 File Offset: 0x000A5190
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

		// Token: 0x06000D13 RID: 3347 RVA: 0x000A700F File Offset: 0x000A520F
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadVersionByVersion.LogPair = null;
			ConfigDownLoadVersionByVersion.HandleId = 0;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000A701D File Offset: 0x000A521D
		public static void Init()
		{
			ConfigDownLoadVersionByVersion.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadVersionByVersion.HandleId, "db_download.db", "select BinData from `DownLoadVersion` where Version=?");
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000A7038 File Offset: 0x000A5238
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

		// Token: 0x04000F1F RID: 3871
		private const string DB = "db_download.db";

		// Token: 0x04000F20 RID: 3872
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000F21 RID: 3873
		private const string TABLE = "DownLoadVersion";

		// Token: 0x04000F22 RID: 3874
		private const string COMMAND = "select BinData from `DownLoadVersion` where Version=?";

		// Token: 0x04000F23 RID: 3875
		private const string KEY_PREFIX = "DownLoadVersionByVersion";

		// Token: 0x04000F24 RID: 3876
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F25 RID: 3877
		private static int HandleId;
	}
}
