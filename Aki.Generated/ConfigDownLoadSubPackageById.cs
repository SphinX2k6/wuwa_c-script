using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000216 RID: 534
	public class ConfigDownLoadSubPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x000A05A3 File Offset: 0x0009E7A3
		static ConfigDownLoadSubPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageById.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000A05C4 File Offset: 0x0009E7C4
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

		// Token: 0x06000C89 RID: 3209 RVA: 0x000A0643 File Offset: 0x0009E843
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageById.LogPair = null;
			ConfigDownLoadSubPackageById.HandleId = 0;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000A0651 File Offset: 0x0009E851
		public static void Init()
		{
			ConfigDownLoadSubPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageById.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage` where Id=?");
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000A066C File Offset: 0x0009E86C
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

		// Token: 0x04000E7E RID: 3710
		private const string DB = "db_download.db";

		// Token: 0x04000E7F RID: 3711
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E80 RID: 3712
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000E81 RID: 3713
		private const string COMMAND = "select BinData from `DownLoadSubPackage` where Id=?";

		// Token: 0x04000E82 RID: 3714
		private const string KEY_PREFIX = "DownLoadSubPackageById";

		// Token: 0x04000E83 RID: 3715
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E84 RID: 3716
		private static int HandleId;
	}
}
