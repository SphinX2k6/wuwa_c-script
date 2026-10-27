using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EA RID: 2282
	public class ConfigRoverRogueLootByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600358F RID: 13711 RVA: 0x0018811C File Offset: 0x0018631C
		static ConfigRoverRogueLootByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueLootByActivityId.CreateStaticDefaultValue), new Action(ConfigRoverRogueLootByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0018813C File Offset: 0x0018633C
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

		// Token: 0x06003591 RID: 13713 RVA: 0x001881BB File Offset: 0x001863BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueLootByActivityId.LogPair = null;
			ConfigRoverRogueLootByActivityId.HandleId = 0;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x001881C9 File Offset: 0x001863C9
		public static void Init()
		{
			ConfigRoverRogueLootByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueLootByActivityId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueLoot` where ActivityId=?");
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x001881E4 File Offset: 0x001863E4
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

		// Token: 0x04003E4C RID: 15948
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E4D RID: 15949
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E4E RID: 15950
		private const string TABLE = "RoverRogueLoot";

		// Token: 0x04003E4F RID: 15951
		private const string COMMAND = "select BinData from `RoverRogueLoot` where ActivityId=?";

		// Token: 0x04003E50 RID: 15952
		private const string KEY_PREFIX = "RoverRogueLootByActivityId";

		// Token: 0x04003E51 RID: 15953
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E52 RID: 15954
		private static int HandleId;
	}
}
