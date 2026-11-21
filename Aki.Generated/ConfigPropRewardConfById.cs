using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000780 RID: 1920
	public class ConfigPropRewardConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x0015B7BC File Offset: 0x001599BC
		static ConfigPropRewardConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropRewardConfById.CreateStaticDefaultValue), new Action(ConfigPropRewardConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0015B7DC File Offset: 0x001599DC
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

		// Token: 0x06002D13 RID: 11539 RVA: 0x0015B85B File Offset: 0x00159A5B
		public static void ResetStaticDefaultValue()
		{
			ConfigPropRewardConfById.LogPair = null;
			ConfigPropRewardConfById.HandleId = 0;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x0015B869 File Offset: 0x00159A69
		public static void Init()
		{
			ConfigPropRewardConfById.HandleId = ConfigCommon.InitDataStatement(ConfigPropRewardConfById.HandleId, "db_itemattributereward.db", "select BinData from `PropRewardConf` where Id=?");
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x0015B884 File Offset: 0x00159A84
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

		// Token: 0x04003466 RID: 13414
		private const string DB = "db_itemattributereward.db";

		// Token: 0x04003467 RID: 13415
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x04003468 RID: 13416
		private const string TABLE = "PropRewardConf";

		// Token: 0x04003469 RID: 13417
		private const string COMMAND = "select BinData from `PropRewardConf` where Id=?";

		// Token: 0x0400346A RID: 13418
		private const string KEY_PREFIX = "PropRewardConfById";

		// Token: 0x0400346B RID: 13419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400346C RID: 13420
		private static int HandleId;
	}
}
