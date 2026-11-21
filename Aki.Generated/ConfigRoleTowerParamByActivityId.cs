using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FB RID: 2299
	public class ConfigRoleTowerParamByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035F5 RID: 13813 RVA: 0x0018DB70 File Offset: 0x0018BD70
		static ConfigRoleTowerParamByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerParamByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerParamByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0018DB90 File Offset: 0x0018BD90
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerParamByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerParamByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerParam` where ActivityId=?")
			});
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0018DC0F File Offset: 0x0018BE0F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerParamByActivityId.LogPair = null;
			ConfigRoleTowerParamByActivityId.HandleId = 0;
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0018DC1D File Offset: 0x0018BE1D
		public static void Init()
		{
			ConfigRoleTowerParamByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerParamByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerParam` where ActivityId=?");
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0018DC38 File Offset: 0x0018BE38
		public static RoleTowerParam? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerParamByActivityId.HandleId, ConfigRoleTowerParamByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerParam?(RoleTowerParam.GetRootAsRoleTowerParam(configBuffer));
				}
			}
			ConfigRoleTowerParamByActivityId.LogPair.Clear();
			ConfigRoleTowerParamByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerParamByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerParamByActivityId.LogPair) || ConfigCommon.Step(ConfigRoleTowerParamByActivityId.HandleId, true, ConfigRoleTowerParamByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerParamByActivityId.HandleId, ConfigRoleTowerParamByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerParamByActivityId.HandleId, 0, ConfigRoleTowerParamByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerParamByActivityId.HandleId, ConfigRoleTowerParamByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerParam rootAsRoleTowerParam = RoleTowerParam.GetRootAsRoleTowerParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerParamByActivityId.HandleId, ConfigRoleTowerParamByActivityId.LogPair);
			return new RoleTowerParam?(rootAsRoleTowerParam);
		}

		// Token: 0x04003EC3 RID: 16067
		private const string DB = "db_roletower.db";

		// Token: 0x04003EC4 RID: 16068
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EC5 RID: 16069
		private const string TABLE = "RoleTowerParam";

		// Token: 0x04003EC6 RID: 16070
		private const string COMMAND = "select BinData from `RoleTowerParam` where ActivityId=?";

		// Token: 0x04003EC7 RID: 16071
		private const string KEY_PREFIX = "RoleTowerParamByActivityId";

		// Token: 0x04003EC8 RID: 16072
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EC9 RID: 16073
		private static int HandleId;
	}
}
