using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000068 RID: 104
	public class ConfigAdventureTaskV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0006AF64 File Offset: 0x00069164
		static ConfigAdventureTaskV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskV2ById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0006AF84 File Offset: 0x00069184
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskV2ById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskV2ById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手开拓任务活动.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTaskV2"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTaskV2` where Id=?")
			});
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0006B003 File Offset: 0x00069203
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskV2ById.LogPair = null;
			ConfigAdventureTaskV2ById.HandleId = 0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0006B011 File Offset: 0x00069211
		public static void Init()
		{
			ConfigAdventureTaskV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskV2ById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `AdventureTaskV2` where Id=?");
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0006B02C File Offset: 0x0006922C
		public static AdventureTaskV2? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskV2ById.HandleId, ConfigAdventureTaskV2ById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureTaskV2?(AdventureTaskV2.GetRootAsAdventureTaskV2(configBuffer));
				}
			}
			ConfigAdventureTaskV2ById.LogPair.Clear();
			ConfigAdventureTaskV2ById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdventureTaskV2ById.HandleId, 1, p0Id, ConfigAdventureTaskV2ById.LogPair) || ConfigCommon.Step(ConfigAdventureTaskV2ById.HandleId, true, ConfigAdventureTaskV2ById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureTaskV2ById.HandleId, ConfigAdventureTaskV2ById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskV2ById.HandleId, 0, ConfigAdventureTaskV2ById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureTaskV2ById.HandleId, ConfigAdventureTaskV2ById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureTaskV2 rootAsAdventureTaskV = AdventureTaskV2.GetRootAsAdventureTaskV2(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureTaskV2ById.HandleId, ConfigAdventureTaskV2ById.LogPair);
			return new AdventureTaskV2?(rootAsAdventureTaskV);
		}

		// Token: 0x040002BC RID: 700
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040002BD RID: 701
		private const string FILE = "x.新手开拓任务活动.xlsx";

		// Token: 0x040002BE RID: 702
		private const string TABLE = "AdventureTaskV2";

		// Token: 0x040002BF RID: 703
		private const string COMMAND = "select BinData from `AdventureTaskV2` where Id=?";

		// Token: 0x040002C0 RID: 704
		private const string KEY_PREFIX = "AdventureTaskV2ById";

		// Token: 0x040002C1 RID: 705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002C2 RID: 706
		private static int HandleId;
	}
}
