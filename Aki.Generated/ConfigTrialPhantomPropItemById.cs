using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A52 RID: 2642
	public class ConfigTrialPhantomPropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E00 RID: 15872 RVA: 0x001B8868 File Offset: 0x001B6A68
		static ConfigTrialPhantomPropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialPhantomPropItemById.CreateStaticDefaultValue), new Action(ConfigTrialPhantomPropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x001B8888 File Offset: 0x001B6A88
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

		// Token: 0x06003E02 RID: 15874 RVA: 0x001B8907 File Offset: 0x001B6B07
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialPhantomPropItemById.LogPair = null;
			ConfigTrialPhantomPropItemById.HandleId = 0;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x001B8915 File Offset: 0x001B6B15
		public static void Init()
		{
			ConfigTrialPhantomPropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialPhantomPropItemById.HandleId, "db_trial_role.db", "select BinData from `TrialPhantomPropItem` where Id = ?");
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x001B8930 File Offset: 0x001B6B30
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

		// Token: 0x04004824 RID: 18468
		private const string DB = "db_trial_role.db";

		// Token: 0x04004825 RID: 18469
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004826 RID: 18470
		private const string TABLE = "TrialPhantomPropItem";

		// Token: 0x04004827 RID: 18471
		private const string COMMAND = "select BinData from `TrialPhantomPropItem` where Id = ?";

		// Token: 0x04004828 RID: 18472
		private const string KEY_PREFIX = "TrialPhantomPropItemById";

		// Token: 0x04004829 RID: 18473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400482A RID: 18474
		private static int HandleId;
	}
}
