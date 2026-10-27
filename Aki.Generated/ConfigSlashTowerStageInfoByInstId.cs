using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095C RID: 2396
	public class ConfigSlashTowerStageInfoByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600383B RID: 14395 RVA: 0x0019769F File Offset: 0x0019589F
		static ConfigSlashTowerStageInfoByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerStageInfoByInstId.CreateStaticDefaultValue), new Action(ConfigSlashTowerStageInfoByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x001976C0 File Offset: 0x001958C0
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashTowerStageInfoByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashTowerStageInfoByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashTowerStageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashTowerStageInfo` where InstId=?")
			});
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0019773F File Offset: 0x0019593F
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerStageInfoByInstId.LogPair = null;
			ConfigSlashTowerStageInfoByInstId.HandleId = 0;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0019774D File Offset: 0x0019594D
		public static void Init()
		{
			ConfigSlashTowerStageInfoByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerStageInfoByInstId.HandleId, "db_shiptower.db", "select BinData from `SlashTowerStageInfo` where InstId=?");
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00197768 File Offset: 0x00195968
		public static SlashTowerStageInfo? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerStageInfoByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashTowerStageInfo?(SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(configBuffer));
				}
			}
			ConfigSlashTowerStageInfoByInstId.LogPair.Clear();
			ConfigSlashTowerStageInfoByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigSlashTowerStageInfoByInstId.HandleId, 1, p0InstId, ConfigSlashTowerStageInfoByInstId.LogPair) || ConfigCommon.Step(ConfigSlashTowerStageInfoByInstId.HandleId, true, ConfigSlashTowerStageInfoByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashTowerStageInfoByInstId.HandleId, 0, ConfigSlashTowerStageInfoByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashTowerStageInfo rootAsSlashTowerStageInfo = SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerStageInfoByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
			return new SlashTowerStageInfo?(rootAsSlashTowerStageInfo);
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x001978E0 File Offset: 0x00195AE0
		[NullableContext(2)]
		public static IReadOnlyList<SlashTowerStageInfo> GetConfigList(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerStageInfoByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				IReadOnlyList<SlashTowerStageInfo> readOnlyList = (IReadOnlyList<SlashTowerStageInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSlashTowerStageInfoByInstId.LogPair.Clear();
			ConfigSlashTowerStageInfoByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigSlashTowerStageInfoByInstId.HandleId, 1, p0InstId, ConfigSlashTowerStageInfoByInstId.LogPair))
			{
				ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
				return null;
			}
			List<SlashTowerStageInfo> list = new List<SlashTowerStageInfo>();
			while (ConfigCommon.Step(ConfigSlashTowerStageInfoByInstId.HandleId, false, ConfigSlashTowerStageInfoByInstId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashTowerStageInfoByInstId.HandleId, 0, ConfigSlashTowerStageInfoByInstId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
					return null;
				}
				SlashTowerStageInfo rootAsSlashTowerStageInfo = SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(new ByteBuffer(item2));
				list.Add(rootAsSlashTowerStageInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerStageInfoByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSlashTowerStageInfoByInstId.HandleId, ConfigSlashTowerStageInfoByInstId.LogPair);
			return list;
		}

		// Token: 0x0400416A RID: 16746
		private const string DB = "db_shiptower.db";

		// Token: 0x0400416B RID: 16747
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400416C RID: 16748
		private const string TABLE = "SlashTowerStageInfo";

		// Token: 0x0400416D RID: 16749
		private const string COMMAND = "select BinData from `SlashTowerStageInfo` where InstId=?";

		// Token: 0x0400416E RID: 16750
		private const string KEY_PREFIX = "SlashTowerStageInfoByInstId";

		// Token: 0x0400416F RID: 16751
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004170 RID: 16752
		private static int HandleId;
	}
}
