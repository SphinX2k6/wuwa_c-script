using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E9 RID: 1257
	public class ConfigLockOnConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D81 RID: 7553 RVA: 0x000FFF8B File Offset: 0x000FE18B
		static ConfigLockOnConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLockOnConfigById.CreateStaticDefaultValue), new Action(ConfigLockOnConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000FFFAC File Offset: 0x000FE1AC
		public static void CreateStaticDefaultValue()
		{
			ConfigLockOnConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLockOnConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lockon.db"),
				new ValueTuple<string, object>("文件", "m.目标筛选配置.xlsx"),
				new ValueTuple<string, object>("表名", "LockOnConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LockOnConfig` where Id=?")
			});
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0010002B File Offset: 0x000FE22B
		public static void ResetStaticDefaultValue()
		{
			ConfigLockOnConfigById.LogPair = null;
			ConfigLockOnConfigById.HandleId = 0;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00100039 File Offset: 0x000FE239
		public static void Init()
		{
			ConfigLockOnConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLockOnConfigById.HandleId, "db_lockon.db", "select BinData from `LockOnConfig` where Id=?");
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00100054 File Offset: 0x000FE254
		public static LockOnConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLockOnConfigById.HandleId, ConfigLockOnConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LockOnConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LockOnConfig?(LockOnConfig.GetRootAsLockOnConfig(configBuffer));
				}
			}
			ConfigLockOnConfigById.LogPair.Clear();
			ConfigLockOnConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLockOnConfigById.HandleId, 1, p0Id, ConfigLockOnConfigById.LogPair) || ConfigCommon.Step(ConfigLockOnConfigById.HandleId, true, ConfigLockOnConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLockOnConfigById.HandleId, ConfigLockOnConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLockOnConfigById.HandleId, 0, ConfigLockOnConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLockOnConfigById.HandleId, ConfigLockOnConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LockOnConfig rootAsLockOnConfig = LockOnConfig.GetRootAsLockOnConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LockOnConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLockOnConfigById.HandleId, ConfigLockOnConfigById.LogPair);
			return new LockOnConfig?(rootAsLockOnConfig);
		}

		// Token: 0x04002243 RID: 8771
		private const string DB = "db_lockon.db";

		// Token: 0x04002244 RID: 8772
		private const string FILE = "m.目标筛选配置.xlsx";

		// Token: 0x04002245 RID: 8773
		private const string TABLE = "LockOnConfig";

		// Token: 0x04002246 RID: 8774
		private const string COMMAND = "select BinData from `LockOnConfig` where Id=?";

		// Token: 0x04002247 RID: 8775
		private const string KEY_PREFIX = "LockOnConfigById";

		// Token: 0x04002248 RID: 8776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002249 RID: 8777
		private static int HandleId;
	}
}
