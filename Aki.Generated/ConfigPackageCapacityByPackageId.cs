using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064D RID: 1613
	public class ConfigPackageCapacityByPackageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x0013337B File Offset: 0x0013157B
		static ConfigPackageCapacityByPackageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPackageCapacityByPackageId.CreateStaticDefaultValue), new Action(ConfigPackageCapacityByPackageId.ResetStaticDefaultValue));
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x0013339C File Offset: 0x0013159C
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

		// Token: 0x060025E0 RID: 9696 RVA: 0x0013341B File Offset: 0x0013161B
		public static void ResetStaticDefaultValue()
		{
			ConfigPackageCapacityByPackageId.LogPair = null;
			ConfigPackageCapacityByPackageId.HandleId = 0;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00133429 File Offset: 0x00131629
		public static void Init()
		{
			ConfigPackageCapacityByPackageId.HandleId = ConfigCommon.InitDataStatement(ConfigPackageCapacityByPackageId.HandleId, "db_bag.db", "select BinData from `PackageCapacity` where PackageId=?");
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00133444 File Offset: 0x00131644
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

		// Token: 0x04002C01 RID: 11265
		private const string DB = "db_bag.db";

		// Token: 0x04002C02 RID: 11266
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04002C03 RID: 11267
		private const string TABLE = "PackageCapacity";

		// Token: 0x04002C04 RID: 11268
		private const string COMMAND = "select BinData from `PackageCapacity` where PackageId=?";

		// Token: 0x04002C05 RID: 11269
		private const string KEY_PREFIX = "PackageCapacityByPackageId";

		// Token: 0x04002C06 RID: 11270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C07 RID: 11271
		private static int HandleId;
	}
}
