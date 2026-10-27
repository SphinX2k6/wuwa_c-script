using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021A RID: 538
	public class ConfigDownLoadVersionByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x000A0E00 File Offset: 0x0009F000
		static ConfigDownLoadVersionByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadVersionByType.CreateStaticDefaultValue), new Action(ConfigDownLoadVersionByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000A0E20 File Offset: 0x0009F020
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadVersionByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadVersionByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadVersion"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadVersion` where Type=?")
			});
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000A0E9F File Offset: 0x0009F09F
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadVersionByType.LogPair = null;
			ConfigDownLoadVersionByType.HandleId = 0;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000A0EAD File Offset: 0x0009F0AD
		public static void Init()
		{
			ConfigDownLoadVersionByType.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadVersionByType.HandleId, "db_download.db", "select BinData from `DownLoadVersion` where Type=?");
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000A0EC8 File Offset: 0x0009F0C8
		[NullableContext(2)]
		public static IReadOnlyList<DownLoadVersion> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadVersionByType.HandleId, ConfigDownLoadVersionByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadVersionByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<DownLoadVersion> readOnlyList = (IReadOnlyList<DownLoadVersion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDownLoadVersionByType.LogPair.Clear();
			ConfigDownLoadVersionByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigDownLoadVersionByType.HandleId, 1, p0Type, ConfigDownLoadVersionByType.LogPair))
			{
				ConfigCommon.Reset(ConfigDownLoadVersionByType.HandleId, ConfigDownLoadVersionByType.LogPair);
				return null;
			}
			List<DownLoadVersion> list = new List<DownLoadVersion>();
			while (ConfigCommon.Step(ConfigDownLoadVersionByType.HandleId, false, ConfigDownLoadVersionByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadVersionByType.HandleId, 0, ConfigDownLoadVersionByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDownLoadVersionByType.HandleId, ConfigDownLoadVersionByType.LogPair);
					return null;
				}
				DownLoadVersion rootAsDownLoadVersion = DownLoadVersion.GetRootAsDownLoadVersion(new ByteBuffer(item2));
				list.Add(rootAsDownLoadVersion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadVersionByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDownLoadVersionByType.HandleId, ConfigDownLoadVersionByType.LogPair);
			return list;
		}

		// Token: 0x04000E9A RID: 3738
		private const string DB = "db_download.db";

		// Token: 0x04000E9B RID: 3739
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E9C RID: 3740
		private const string TABLE = "DownLoadVersion";

		// Token: 0x04000E9D RID: 3741
		private const string COMMAND = "select BinData from `DownLoadVersion` where Type=?";

		// Token: 0x04000E9E RID: 3742
		private const string KEY_PREFIX = "DownLoadVersionByType";

		// Token: 0x04000E9F RID: 3743
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EA0 RID: 3744
		private static int HandleId;
	}
}
