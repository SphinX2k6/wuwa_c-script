using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023F RID: 575
	public class ConfigDropPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x000A5CEC File Offset: 0x000A3EEC
		static ConfigDropPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropPackageById.CreateStaticDefaultValue), new Action(ConfigDropPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000A5D0C File Offset: 0x000A3F0C
		public static void CreateStaticDefaultValue()
		{
			ConfigDropPackageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropPackageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drop.db"),
				new ValueTuple<string, object>("文件", "d.掉落.xlsx"),
				new ValueTuple<string, object>("表名", "DropPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `DropPackage` where Id=?")
			});
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000A5D8B File Offset: 0x000A3F8B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropPackageById.LogPair = null;
			ConfigDropPackageById.HandleId = 0;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000A5D99 File Offset: 0x000A3F99
		public static void Init()
		{
			ConfigDropPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigDropPackageById.HandleId, "db_drop.db", "select BinData from `DropPackage` where Id=?");
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000A5DB4 File Offset: 0x000A3FB4
		public static DropPackage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropPackageById.HandleId, ConfigDropPackageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropPackage?(DropPackage.GetRootAsDropPackage(configBuffer));
				}
			}
			ConfigDropPackageById.LogPair.Clear();
			ConfigDropPackageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropPackageById.HandleId, 1, p0Id, ConfigDropPackageById.LogPair) || ConfigCommon.Step(ConfigDropPackageById.HandleId, true, ConfigDropPackageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropPackageById.HandleId, ConfigDropPackageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropPackageById.HandleId, 0, ConfigDropPackageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropPackageById.HandleId, ConfigDropPackageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropPackage rootAsDropPackage = DropPackage.GetRootAsDropPackage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropPackageById.HandleId, ConfigDropPackageById.LogPair);
			return new DropPackage?(rootAsDropPackage);
		}

		// Token: 0x04000F9D RID: 3997
		private const string DB = "db_drop.db";

		// Token: 0x04000F9E RID: 3998
		private const string FILE = "d.掉落.xlsx";

		// Token: 0x04000F9F RID: 3999
		private const string TABLE = "DropPackage";

		// Token: 0x04000FA0 RID: 4000
		private const string COMMAND = "select BinData from `DropPackage` where Id=?";

		// Token: 0x04000FA1 RID: 4001
		private const string KEY_PREFIX = "DropPackageById";

		// Token: 0x04000FA2 RID: 4002
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FA3 RID: 4003
		private static int HandleId;
	}
}
