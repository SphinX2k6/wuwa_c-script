using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000119 RID: 281
	public class ConfigBossRushActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x0008288F File Offset: 0x00080A8F
		static ConfigBossRushActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushActivityById.CreateStaticDefaultValue), new Action(ConfigBossRushActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000828B0 File Offset: 0x00080AB0
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushActivity` where Id=?")
			});
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0008292F File Offset: 0x00080B2F
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushActivityById.LogPair = null;
			ConfigBossRushActivityById.HandleId = 0;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0008293D File Offset: 0x00080B3D
		public static void Init()
		{
			ConfigBossRushActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushActivityById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushActivity` where Id=?");
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00082958 File Offset: 0x00080B58
		public static BossRushActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushActivity?(BossRushActivity.GetRootAsBossRushActivity(configBuffer));
				}
			}
			ConfigBossRushActivityById.LogPair.Clear();
			ConfigBossRushActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossRushActivityById.HandleId, 1, p0Id, ConfigBossRushActivityById.LogPair) || ConfigCommon.Step(ConfigBossRushActivityById.HandleId, true, ConfigBossRushActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushActivityById.HandleId, 0, ConfigBossRushActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushActivity rootAsBossRushActivity = BossRushActivity.GetRootAsBossRushActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
			return new BossRushActivity?(rootAsBossRushActivity);
		}

		// Token: 0x04000793 RID: 1939
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000794 RID: 1940
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000795 RID: 1941
		private const string TABLE = "BossRushActivity";

		// Token: 0x04000796 RID: 1942
		private const string COMMAND = "select BinData from `BossRushActivity` where Id=?";

		// Token: 0x04000797 RID: 1943
		private const string KEY_PREFIX = "BossRushActivityById";

		// Token: 0x04000798 RID: 1944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000799 RID: 1945
		private static int HandleId;
	}
}
