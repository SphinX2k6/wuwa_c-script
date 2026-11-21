using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B27 RID: 2855
	public class ConfigTrialPhantomPropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x001D7BFC File Offset: 0x001D5DFC
		static ConfigTrialPhantomPropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialPhantomPropItemById.CreateStaticDefaultValue), new Action(ConfigTrialPhantomPropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x001D7C1C File Offset: 0x001D5E1C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialPhantomPropItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialPhantomPropItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialPhantomPropItem"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialPhantomPropItem` where Id = ?")
			});
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x001D7C9B File Offset: 0x001D5E9B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialPhantomPropItemById.LogPair = null;
			ConfigTrialPhantomPropItemById.HandleId = 0;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x001D7CA9 File Offset: 0x001D5EA9
		public static void Init()
		{
			ConfigTrialPhantomPropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialPhantomPropItemById.HandleId, "db_trial_role.db", "select BinData from `TrialPhantomPropItem` where Id = ?");
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x001D7CC4 File Offset: 0x001D5EC4
		public static TrialPhantomPropItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialPhantomPropItemById.HandleId, ConfigTrialPhantomPropItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialPhantomPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrialPhantomPropItem?(TrialPhantomPropItem.GetRootAsTrialPhantomPropItem(configBuffer));
				}
			}
			ConfigTrialPhantomPropItemById.LogPair.Clear();
			ConfigTrialPhantomPropItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrialPhantomPropItemById.HandleId, 1, p0Id, ConfigTrialPhantomPropItemById.LogPair) || ConfigCommon.Step(ConfigTrialPhantomPropItemById.HandleId, true, ConfigTrialPhantomPropItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrialPhantomPropItemById.HandleId, ConfigTrialPhantomPropItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialPhantomPropItemById.HandleId, 0, ConfigTrialPhantomPropItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrialPhantomPropItemById.HandleId, ConfigTrialPhantomPropItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrialPhantomPropItem rootAsTrialPhantomPropItem = TrialPhantomPropItem.GetRootAsTrialPhantomPropItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialPhantomPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrialPhantomPropItemById.HandleId, ConfigTrialPhantomPropItemById.LogPair);
			return new TrialPhantomPropItem?(rootAsTrialPhantomPropItem);
		}

		// Token: 0x04004DF7 RID: 19959
		private const string DB = "db_trial_role.db";

		// Token: 0x04004DF8 RID: 19960
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004DF9 RID: 19961
		private const string TABLE = "TrialPhantomPropItem";

		// Token: 0x04004DFA RID: 19962
		private const string COMMAND = "select BinData from `TrialPhantomPropItem` where Id = ?";

		// Token: 0x04004DFB RID: 19963
		private const string KEY_PREFIX = "TrialPhantomPropItemById";

		// Token: 0x04004DFC RID: 19964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DFD RID: 19965
		private static int HandleId;
	}
}
