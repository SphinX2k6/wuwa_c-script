using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022B RID: 555
	public class ConfigDownLoadTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x000A6AEF File Offset: 0x000A4CEF
		static ConfigDownLoadTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadTabById.CreateStaticDefaultValue), new Action(ConfigDownLoadTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000A6B10 File Offset: 0x000A4D10
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadTab"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadTab` where Id=?")
			});
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000A6B8F File Offset: 0x000A4D8F
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadTabById.LogPair = null;
			ConfigDownLoadTabById.HandleId = 0;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000A6B9D File Offset: 0x000A4D9D
		public static void Init()
		{
			ConfigDownLoadTabById.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadTabById.HandleId, "db_download.db", "select BinData from `DownLoadTab` where Id=?");
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000A6BB8 File Offset: 0x000A4DB8
		public static DownLoadTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadTabById.HandleId, ConfigDownLoadTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DownLoadTab?(DownLoadTab.GetRootAsDownLoadTab(configBuffer));
				}
			}
			ConfigDownLoadTabById.LogPair.Clear();
			ConfigDownLoadTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDownLoadTabById.HandleId, 1, p0Id, ConfigDownLoadTabById.LogPair) || ConfigCommon.Step(ConfigDownLoadTabById.HandleId, true, ConfigDownLoadTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDownLoadTabById.HandleId, ConfigDownLoadTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadTabById.HandleId, 0, ConfigDownLoadTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDownLoadTabById.HandleId, ConfigDownLoadTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DownLoadTab rootAsDownLoadTab = DownLoadTab.GetRootAsDownLoadTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDownLoadTabById.HandleId, ConfigDownLoadTabById.LogPair);
			return new DownLoadTab?(rootAsDownLoadTab);
		}

		// Token: 0x04000F11 RID: 3857
		private const string DB = "db_download.db";

		// Token: 0x04000F12 RID: 3858
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000F13 RID: 3859
		private const string TABLE = "DownLoadTab";

		// Token: 0x04000F14 RID: 3860
		private const string COMMAND = "select BinData from `DownLoadTab` where Id=?";

		// Token: 0x04000F15 RID: 3861
		private const string KEY_PREFIX = "DownLoadTabById";

		// Token: 0x04000F16 RID: 3862
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F17 RID: 3863
		private static int HandleId;
	}
}
