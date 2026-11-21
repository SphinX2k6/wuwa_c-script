using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000935 RID: 2357
	public class ConfigRoverRogueLootByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x0019533C File Offset: 0x0019353C
		static ConfigRoverRogueLootByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueLootByActivityId.CreateStaticDefaultValue), new Action(ConfigRoverRogueLootByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0019535C File Offset: 0x0019355C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueLootByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueLootByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueLoot"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueLoot` where ActivityId=?")
			});
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x001953DB File Offset: 0x001935DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueLootByActivityId.LogPair = null;
			ConfigRoverRogueLootByActivityId.HandleId = 0;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001953E9 File Offset: 0x001935E9
		public static void Init()
		{
			ConfigRoverRogueLootByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueLootByActivityId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueLoot` where ActivityId=?");
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00195404 File Offset: 0x00193604
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueLoot> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueLootByActivityId.HandleId, ConfigRoverRogueLootByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueLootByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoverRogueLoot> readOnlyList = (IReadOnlyList<RoverRogueLoot>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoverRogueLootByActivityId.LogPair.Clear();
			ConfigRoverRogueLootByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoverRogueLootByActivityId.HandleId, 1, p0ActivityId, ConfigRoverRogueLootByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoverRogueLootByActivityId.HandleId, ConfigRoverRogueLootByActivityId.LogPair);
				return null;
			}
			List<RoverRogueLoot> list = new List<RoverRogueLoot>();
			while (ConfigCommon.Step(ConfigRoverRogueLootByActivityId.HandleId, false, ConfigRoverRogueLootByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueLootByActivityId.HandleId, 0, ConfigRoverRogueLootByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueLootByActivityId.HandleId, ConfigRoverRogueLootByActivityId.LogPair);
					return null;
				}
				RoverRogueLoot rootAsRoverRogueLoot = RoverRogueLoot.GetRootAsRoverRogueLoot(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueLoot);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueLootByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueLootByActivityId.HandleId, ConfigRoverRogueLootByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004059 RID: 16473
		private const string DB = "db_roverlike.db";

		// Token: 0x0400405A RID: 16474
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x0400405B RID: 16475
		private const string TABLE = "RoverRogueLoot";

		// Token: 0x0400405C RID: 16476
		private const string COMMAND = "select BinData from `RoverRogueLoot` where ActivityId=?";

		// Token: 0x0400405D RID: 16477
		private const string KEY_PREFIX = "RoverRogueLootByActivityId";

		// Token: 0x0400405E RID: 16478
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400405F RID: 16479
		private static int HandleId;
	}
}
