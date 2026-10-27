using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000219 RID: 537
	public class ConfigDownLoadTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x000A0BB7 File Offset: 0x0009EDB7
		static ConfigDownLoadTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadTabById.CreateStaticDefaultValue), new Action(ConfigDownLoadTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000A0BD8 File Offset: 0x0009EDD8
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

		// Token: 0x06000C9B RID: 3227 RVA: 0x000A0C57 File Offset: 0x0009EE57
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadTabById.LogPair = null;
			ConfigDownLoadTabById.HandleId = 0;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000A0C65 File Offset: 0x0009EE65
		public static void Init()
		{
			ConfigDownLoadTabById.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadTabById.HandleId, "db_download.db", "select BinData from `DownLoadTab` where Id=?");
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000A0C80 File Offset: 0x0009EE80
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

		// Token: 0x04000E93 RID: 3731
		private const string DB = "db_download.db";

		// Token: 0x04000E94 RID: 3732
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E95 RID: 3733
		private const string TABLE = "DownLoadTab";

		// Token: 0x04000E96 RID: 3734
		private const string COMMAND = "select BinData from `DownLoadTab` where Id=?";

		// Token: 0x04000E97 RID: 3735
		private const string KEY_PREFIX = "DownLoadTabById";

		// Token: 0x04000E98 RID: 3736
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E99 RID: 3737
		private static int HandleId;
	}
}
