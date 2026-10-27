using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000635 RID: 1589
	public class ConfigPackageCapacityByPackageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600254E RID: 9550 RVA: 0x0012C8FF File Offset: 0x0012AAFF
		static ConfigPackageCapacityByPackageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPackageCapacityByPackageId.CreateStaticDefaultValue), new Action(ConfigPackageCapacityByPackageId.ResetStaticDefaultValue));
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x0012C920 File Offset: 0x0012AB20
		public static void CreateStaticDefaultValue()
		{
			ConfigPackageCapacityByPackageId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPackageCapacityByPackageId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bag.db"),
				new ValueTuple<string, object>("文件", "b.背包.xlsx"),
				new ValueTuple<string, object>("表名", "PackageCapacity"),
				new ValueTuple<string, object>("语句", "select BinData from `PackageCapacity` where PackageId=?")
			});
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x0012C99F File Offset: 0x0012AB9F
		public static void ResetStaticDefaultValue()
		{
			ConfigPackageCapacityByPackageId.LogPair = null;
			ConfigPackageCapacityByPackageId.HandleId = 0;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0012C9AD File Offset: 0x0012ABAD
		public static void Init()
		{
			ConfigPackageCapacityByPackageId.HandleId = ConfigCommon.InitDataStatement(ConfigPackageCapacityByPackageId.HandleId, "db_bag.db", "select BinData from `PackageCapacity` where PackageId=?");
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0012C9C8 File Offset: 0x0012ABC8
		public static PackageCapacity? GetConfig(int p0PackageId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPackageCapacityByPackageId.HandleId, ConfigPackageCapacityByPackageId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PackageCapacityByPackageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PackageCapacity?(PackageCapacity.GetRootAsPackageCapacity(configBuffer));
				}
			}
			ConfigPackageCapacityByPackageId.LogPair.Clear();
			ConfigPackageCapacityByPackageId.LogPair.Add(new ValueTuple<string, object>("PackageId", p0PackageId));
			if (!ConfigCommon.BindInt(ConfigPackageCapacityByPackageId.HandleId, 1, p0PackageId, ConfigPackageCapacityByPackageId.LogPair) || ConfigCommon.Step(ConfigPackageCapacityByPackageId.HandleId, true, ConfigPackageCapacityByPackageId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPackageCapacityByPackageId.HandleId, ConfigPackageCapacityByPackageId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPackageCapacityByPackageId.HandleId, 0, ConfigPackageCapacityByPackageId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPackageCapacityByPackageId.HandleId, ConfigPackageCapacityByPackageId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PackageCapacity rootAsPackageCapacity = PackageCapacity.GetRootAsPackageCapacity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PackageCapacityByPackageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPackageCapacityByPackageId.HandleId, ConfigPackageCapacityByPackageId.LogPair);
			return new PackageCapacity?(rootAsPackageCapacity);
		}

		// Token: 0x04002B59 RID: 11097
		private const string DB = "db_bag.db";

		// Token: 0x04002B5A RID: 11098
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04002B5B RID: 11099
		private const string TABLE = "PackageCapacity";

		// Token: 0x04002B5C RID: 11100
		private const string COMMAND = "select BinData from `PackageCapacity` where PackageId=?";

		// Token: 0x04002B5D RID: 11101
		private const string KEY_PREFIX = "PackageCapacityByPackageId";

		// Token: 0x04002B5E RID: 11102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B5F RID: 11103
		private static int HandleId;
	}
}
