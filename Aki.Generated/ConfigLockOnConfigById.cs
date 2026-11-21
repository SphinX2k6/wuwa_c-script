using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FF RID: 1279
	public class ConfigLockOnConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x001066DF File Offset: 0x001048DF
		static ConfigLockOnConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLockOnConfigById.CreateStaticDefaultValue), new Action(ConfigLockOnConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00106700 File Offset: 0x00104900
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

		// Token: 0x06001E07 RID: 7687 RVA: 0x0010677F File Offset: 0x0010497F
		public static void ResetStaticDefaultValue()
		{
			ConfigLockOnConfigById.LogPair = null;
			ConfigLockOnConfigById.HandleId = 0;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0010678D File Offset: 0x0010498D
		public static void Init()
		{
			ConfigLockOnConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLockOnConfigById.HandleId, "db_lockon.db", "select BinData from `LockOnConfig` where Id=?");
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x001067A8 File Offset: 0x001049A8
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

		// Token: 0x040022DD RID: 8925
		private const string DB = "db_lockon.db";

		// Token: 0x040022DE RID: 8926
		private const string FILE = "m.目标筛选配置.xlsx";

		// Token: 0x040022DF RID: 8927
		private const string TABLE = "LockOnConfig";

		// Token: 0x040022E0 RID: 8928
		private const string COMMAND = "select BinData from `LockOnConfig` where Id=?";

		// Token: 0x040022E1 RID: 8929
		private const string KEY_PREFIX = "LockOnConfigById";

		// Token: 0x040022E2 RID: 8930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022E3 RID: 8931
		private static int HandleId;
	}
}
