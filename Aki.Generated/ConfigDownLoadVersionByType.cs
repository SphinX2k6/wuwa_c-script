using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022C RID: 556
	public class ConfigDownLoadVersionByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D0B RID: 3339 RVA: 0x000A6D38 File Offset: 0x000A4F38
		static ConfigDownLoadVersionByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadVersionByType.CreateStaticDefaultValue), new Action(ConfigDownLoadVersionByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000A6D58 File Offset: 0x000A4F58
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

		// Token: 0x06000D0D RID: 3341 RVA: 0x000A6DD7 File Offset: 0x000A4FD7
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadVersionByType.LogPair = null;
			ConfigDownLoadVersionByType.HandleId = 0;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000A6DE5 File Offset: 0x000A4FE5
		public static void Init()
		{
			ConfigDownLoadVersionByType.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadVersionByType.HandleId, "db_download.db", "select BinData from `DownLoadVersion` where Type=?");
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000A6E00 File Offset: 0x000A5000
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

		// Token: 0x04000F18 RID: 3864
		private const string DB = "db_download.db";

		// Token: 0x04000F19 RID: 3865
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000F1A RID: 3866
		private const string TABLE = "DownLoadVersion";

		// Token: 0x04000F1B RID: 3867
		private const string COMMAND = "select BinData from `DownLoadVersion` where Type=?";

		// Token: 0x04000F1C RID: 3868
		private const string KEY_PREFIX = "DownLoadVersionByType";

		// Token: 0x04000F1D RID: 3869
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F1E RID: 3870
		private static int HandleId;
	}
}
