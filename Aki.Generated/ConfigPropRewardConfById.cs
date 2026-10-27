using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000766 RID: 1894
	public class ConfigPropRewardConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x001548B0 File Offset: 0x00152AB0
		static ConfigPropRewardConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropRewardConfById.CreateStaticDefaultValue), new Action(ConfigPropRewardConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x001548D0 File Offset: 0x00152AD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPropRewardConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPropRewardConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "PropRewardConf"),
				new ValueTuple<string, object>("语句", "select BinData from `PropRewardConf` where Id=?")
			});
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0015494F File Offset: 0x00152B4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPropRewardConfById.LogPair = null;
			ConfigPropRewardConfById.HandleId = 0;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x0015495D File Offset: 0x00152B5D
		public static void Init()
		{
			ConfigPropRewardConfById.HandleId = ConfigCommon.InitDataStatement(ConfigPropRewardConfById.HandleId, "db_itemattributereward.db", "select BinData from `PropRewardConf` where Id=?");
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00154978 File Offset: 0x00152B78
		public static PropRewardConf? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPropRewardConfById.HandleId, ConfigPropRewardConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PropRewardConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PropRewardConf?(PropRewardConf.GetRootAsPropRewardConf(configBuffer));
				}
			}
			ConfigPropRewardConfById.LogPair.Clear();
			ConfigPropRewardConfById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPropRewardConfById.HandleId, 1, p0Id, ConfigPropRewardConfById.LogPair) || ConfigCommon.Step(ConfigPropRewardConfById.HandleId, true, ConfigPropRewardConfById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPropRewardConfById.HandleId, ConfigPropRewardConfById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPropRewardConfById.HandleId, 0, ConfigPropRewardConfById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPropRewardConfById.HandleId, ConfigPropRewardConfById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PropRewardConf rootAsPropRewardConf = PropRewardConf.GetRootAsPropRewardConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PropRewardConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPropRewardConfById.HandleId, ConfigPropRewardConfById.LogPair);
			return new PropRewardConf?(rootAsPropRewardConf);
		}

		// Token: 0x040033B0 RID: 13232
		private const string DB = "db_itemattributereward.db";

		// Token: 0x040033B1 RID: 13233
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x040033B2 RID: 13234
		private const string TABLE = "PropRewardConf";

		// Token: 0x040033B3 RID: 13235
		private const string COMMAND = "select BinData from `PropRewardConf` where Id=?";

		// Token: 0x040033B4 RID: 13236
		private const string KEY_PREFIX = "PropRewardConfById";

		// Token: 0x040033B5 RID: 13237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033B6 RID: 13238
		private static int HandleId;
	}
}
