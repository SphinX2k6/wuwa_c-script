using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000217 RID: 535
	public class ConfigDownLoadSubPackageByVersion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x000A07EC File Offset: 0x0009E9EC
		static ConfigDownLoadSubPackageByVersion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageByVersion.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageByVersion.ResetStaticDefaultValue));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000A080C File Offset: 0x0009EA0C
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadSubPackageByVersion.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadSubPackageByVersion.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadSubPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadSubPackage` where Version=?")
			});
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000A088B File Offset: 0x0009EA8B
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageByVersion.LogPair = null;
			ConfigDownLoadSubPackageByVersion.HandleId = 0;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000A0899 File Offset: 0x0009EA99
		public static void Init()
		{
			ConfigDownLoadSubPackageByVersion.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageByVersion.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage` where Version=?");
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000A08B4 File Offset: 0x0009EAB4
		[NullableContext(2)]
		public static IReadOnlyList<DownLoadSubPackage> GetConfigList(int p0Version, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadSubPackageByVersion.HandleId, ConfigDownLoadSubPackageByVersion.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadSubPackageByVersion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Version);
				IReadOnlyList<DownLoadSubPackage> readOnlyList = (IReadOnlyList<DownLoadSubPackage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDownLoadSubPackageByVersion.LogPair.Clear();
			ConfigDownLoadSubPackageByVersion.LogPair.Add(new ValueTuple<string, object>("Version", p0Version));
			if (!ConfigCommon.BindInt(ConfigDownLoadSubPackageByVersion.HandleId, 1, p0Version, ConfigDownLoadSubPackageByVersion.LogPair))
			{
				ConfigCommon.Reset(ConfigDownLoadSubPackageByVersion.HandleId, ConfigDownLoadSubPackageByVersion.LogPair);
				return null;
			}
			List<DownLoadSubPackage> list = new List<DownLoadSubPackage>();
			while (ConfigCommon.Step(ConfigDownLoadSubPackageByVersion.HandleId, false, ConfigDownLoadSubPackageByVersion.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadSubPackageByVersion.HandleId, 0, ConfigDownLoadSubPackageByVersion.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDownLoadSubPackageByVersion.HandleId, ConfigDownLoadSubPackageByVersion.LogPair);
					return null;
				}
				DownLoadSubPackage rootAsDownLoadSubPackage = DownLoadSubPackage.GetRootAsDownLoadSubPackage(new ByteBuffer(item2));
				list.Add(rootAsDownLoadSubPackage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadSubPackageByVersion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Version);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDownLoadSubPackageByVersion.HandleId, ConfigDownLoadSubPackageByVersion.LogPair);
			return list;
		}

		// Token: 0x04000E85 RID: 3717
		private const string DB = "db_download.db";

		// Token: 0x04000E86 RID: 3718
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E87 RID: 3719
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000E88 RID: 3720
		private const string COMMAND = "select BinData from `DownLoadSubPackage` where Version=?";

		// Token: 0x04000E89 RID: 3721
		private const string KEY_PREFIX = "DownLoadSubPackageByVersion";

		// Token: 0x04000E8A RID: 3722
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E8B RID: 3723
		private static int HandleId;
	}
}
