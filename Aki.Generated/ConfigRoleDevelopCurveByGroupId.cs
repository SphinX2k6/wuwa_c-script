using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B0 RID: 2224
	public class ConfigRoleDevelopCurveByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003432 RID: 13362 RVA: 0x00183E6C File Offset: 0x0018206C
		static ConfigRoleDevelopCurveByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevelopCurveByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleDevelopCurveByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00183E8C File Offset: 0x0018208C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevelopCurveByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevelopCurveByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevelopCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevelopCurve` where GroupId=?")
			});
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00183F0B File Offset: 0x0018210B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevelopCurveByGroupId.LogPair = null;
			ConfigRoleDevelopCurveByGroupId.HandleId = 0;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00183F19 File Offset: 0x00182119
		public static void Init()
		{
			ConfigRoleDevelopCurveByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevelopCurveByGroupId.HandleId, "db_moonchasing.db", "select BinData from `RoleDevelopCurve` where GroupId=?");
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00183F34 File Offset: 0x00182134
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevelopCurve> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleDevelopCurve> readOnlyList = (IReadOnlyList<RoleDevelopCurve>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleDevelopCurveByGroupId.LogPair.Clear();
			ConfigRoleDevelopCurveByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleDevelopCurveByGroupId.HandleId, 1, p0GroupId, ConfigRoleDevelopCurveByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
				return null;
			}
			List<RoleDevelopCurve> list = new List<RoleDevelopCurve>();
			while (ConfigCommon.Step(ConfigRoleDevelopCurveByGroupId.HandleId, false, ConfigRoleDevelopCurveByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevelopCurveByGroupId.HandleId, 0, ConfigRoleDevelopCurveByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
					return null;
				}
				RoleDevelopCurve rootAsRoleDevelopCurve = RoleDevelopCurve.GetRootAsRoleDevelopCurve(new ByteBuffer(item2));
				list.Add(rootAsRoleDevelopCurve);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003CB6 RID: 15542
		private const string DB = "db_moonchasing.db";

		// Token: 0x04003CB7 RID: 15543
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04003CB8 RID: 15544
		private const string TABLE = "RoleDevelopCurve";

		// Token: 0x04003CB9 RID: 15545
		private const string COMMAND = "select BinData from `RoleDevelopCurve` where GroupId=?";

		// Token: 0x04003CBA RID: 15546
		private const string KEY_PREFIX = "RoleDevelopCurveByGroupId";

		// Token: 0x04003CBB RID: 15547
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CBC RID: 15548
		private static int HandleId;
	}
}
