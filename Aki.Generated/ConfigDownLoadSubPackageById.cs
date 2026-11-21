using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000228 RID: 552
	public class ConfigDownLoadSubPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x000A64DB File Offset: 0x000A46DB
		static ConfigDownLoadSubPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageById.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000A64FC File Offset: 0x000A46FC
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadSubPackageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadSubPackageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadSubPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadSubPackage` where Id=?")
			});
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000A657B File Offset: 0x000A477B
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageById.LogPair = null;
			ConfigDownLoadSubPackageById.HandleId = 0;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000A6589 File Offset: 0x000A4789
		public static void Init()
		{
			ConfigDownLoadSubPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageById.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage` where Id=?");
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000A65A4 File Offset: 0x000A47A4
		public static DownLoadSubPackage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadSubPackageById.HandleId, ConfigDownLoadSubPackageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadSubPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DownLoadSubPackage?(DownLoadSubPackage.GetRootAsDownLoadSubPackage(configBuffer));
				}
			}
			ConfigDownLoadSubPackageById.LogPair.Clear();
			ConfigDownLoadSubPackageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDownLoadSubPackageById.HandleId, 1, p0Id, ConfigDownLoadSubPackageById.LogPair) || ConfigCommon.Step(ConfigDownLoadSubPackageById.HandleId, true, ConfigDownLoadSubPackageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDownLoadSubPackageById.HandleId, ConfigDownLoadSubPackageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadSubPackageById.HandleId, 0, ConfigDownLoadSubPackageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDownLoadSubPackageById.HandleId, ConfigDownLoadSubPackageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DownLoadSubPackage rootAsDownLoadSubPackage = DownLoadSubPackage.GetRootAsDownLoadSubPackage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DownLoadSubPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDownLoadSubPackageById.HandleId, ConfigDownLoadSubPackageById.LogPair);
			return new DownLoadSubPackage?(rootAsDownLoadSubPackage);
		}

		// Token: 0x04000EFC RID: 3836
		private const string DB = "db_download.db";

		// Token: 0x04000EFD RID: 3837
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000EFE RID: 3838
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000EFF RID: 3839
		private const string COMMAND = "select BinData from `DownLoadSubPackage` where Id=?";

		// Token: 0x04000F00 RID: 3840
		private const string KEY_PREFIX = "DownLoadSubPackageById";

		// Token: 0x04000F01 RID: 3841
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F02 RID: 3842
		private static int HandleId;
	}
}
