using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EF RID: 495
	public class ConfigDangoBrawlRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0009ECA7 File Offset: 0x0009CEA7
		static ConfigDangoBrawlRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRoleById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0009ECC8 File Offset: 0x0009CEC8
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRole"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRole` where Id=?")
			});
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0009ED47 File Offset: 0x0009CF47
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRoleById.LogPair = null;
			ConfigDangoBrawlRoleById.HandleId = 0;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0009ED55 File Offset: 0x0009CF55
		public static void Init()
		{
			ConfigDangoBrawlRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRoleById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRole` where Id=?");
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0009ED70 File Offset: 0x0009CF70
		public static DangoBrawlRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlRole?(DangoBrawlRole.GetRootAsDangoBrawlRole(configBuffer));
				}
			}
			ConfigDangoBrawlRoleById.LogPair.Clear();
			ConfigDangoBrawlRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRoleById.HandleId, 1, p0Id, ConfigDangoBrawlRoleById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRoleById.HandleId, true, ConfigDangoBrawlRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRoleById.HandleId, 0, ConfigDangoBrawlRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlRole rootAsDangoBrawlRole = DangoBrawlRole.GetRootAsDangoBrawlRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
			return new DangoBrawlRole?(rootAsDangoBrawlRole);
		}

		// Token: 0x04000D6D RID: 3437
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D6E RID: 3438
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D6F RID: 3439
		private const string TABLE = "DangoBrawlRole";

		// Token: 0x04000D70 RID: 3440
		private const string COMMAND = "select BinData from `DangoBrawlRole` where Id=?";

		// Token: 0x04000D71 RID: 3441
		private const string KEY_PREFIX = "DangoBrawlRoleById";

		// Token: 0x04000D72 RID: 3442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D73 RID: 3443
		private static int HandleId;
	}
}
