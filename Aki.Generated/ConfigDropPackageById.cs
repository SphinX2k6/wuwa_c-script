using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000251 RID: 593
	public class ConfigDropPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DEA RID: 3562 RVA: 0x000ABC24 File Offset: 0x000A9E24
		static ConfigDropPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropPackageById.CreateStaticDefaultValue), new Action(ConfigDropPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000ABC44 File Offset: 0x000A9E44
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

		// Token: 0x06000DEC RID: 3564 RVA: 0x000ABCC3 File Offset: 0x000A9EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropPackageById.LogPair = null;
			ConfigDropPackageById.HandleId = 0;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000ABCD1 File Offset: 0x000A9ED1
		public static void Init()
		{
			ConfigDropPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigDropPackageById.HandleId, "db_drop.db", "select BinData from `DropPackage` where Id=?");
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000ABCEC File Offset: 0x000A9EEC
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

		// Token: 0x0400101B RID: 4123
		private const string DB = "db_drop.db";

		// Token: 0x0400101C RID: 4124
		private const string FILE = "d.掉落.xlsx";

		// Token: 0x0400101D RID: 4125
		private const string TABLE = "DropPackage";

		// Token: 0x0400101E RID: 4126
		private const string COMMAND = "select BinData from `DropPackage` where Id=?";

		// Token: 0x0400101F RID: 4127
		private const string KEY_PREFIX = "DropPackageById";

		// Token: 0x04001020 RID: 4128
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001021 RID: 4129
		private static int HandleId;
	}
}
