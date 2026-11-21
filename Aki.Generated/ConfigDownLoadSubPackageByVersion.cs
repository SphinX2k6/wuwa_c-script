using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000229 RID: 553
	public class ConfigDownLoadSubPackageByVersion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x000A6724 File Offset: 0x000A4924
		static ConfigDownLoadSubPackageByVersion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageByVersion.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageByVersion.ResetStaticDefaultValue));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000A6744 File Offset: 0x000A4944
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

		// Token: 0x06000CFB RID: 3323 RVA: 0x000A67C3 File Offset: 0x000A49C3
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageByVersion.LogPair = null;
			ConfigDownLoadSubPackageByVersion.HandleId = 0;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000A67D1 File Offset: 0x000A49D1
		public static void Init()
		{
			ConfigDownLoadSubPackageByVersion.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageByVersion.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage` where Version=?");
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000A67EC File Offset: 0x000A49EC
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

		// Token: 0x04000F03 RID: 3843
		private const string DB = "db_download.db";

		// Token: 0x04000F04 RID: 3844
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000F05 RID: 3845
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000F06 RID: 3846
		private const string COMMAND = "select BinData from `DownLoadSubPackage` where Version=?";

		// Token: 0x04000F07 RID: 3847
		private const string KEY_PREFIX = "DownLoadSubPackageByVersion";

		// Token: 0x04000F08 RID: 3848
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F09 RID: 3849
		private static int HandleId;
	}
}
