using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000193 RID: 403
	public class ConfigComboTeachingConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00092688 File Offset: 0x00090888
		static ConfigComboTeachingConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComboTeachingConditionById.CreateStaticDefaultValue), new Action(ConfigComboTeachingConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000926A8 File Offset: 0x000908A8
		public static void CreateStaticDefaultValue()
		{
			ConfigComboTeachingConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigComboTeachingConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_combo_teaching.db"),
				new ValueTuple<string, object>("文件", "j.角色出招教学.xlsx"),
				new ValueTuple<string, object>("表名", "ComboTeachingCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `ComboTeachingCondition` where Id=?")
			});
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00092727 File Offset: 0x00090927
		public static void ResetStaticDefaultValue()
		{
			ConfigComboTeachingConditionById.LogPair = null;
			ConfigComboTeachingConditionById.HandleId = 0;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00092735 File Offset: 0x00090935
		public static void Init()
		{
			ConfigComboTeachingConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigComboTeachingConditionById.HandleId, "db_combo_teaching.db", "select BinData from `ComboTeachingCondition` where Id=?");
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00092750 File Offset: 0x00090950
		public static ComboTeachingCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigComboTeachingConditionById.HandleId, ConfigComboTeachingConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComboTeachingConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ComboTeachingCondition?(ComboTeachingCondition.GetRootAsComboTeachingCondition(configBuffer));
				}
			}
			ConfigComboTeachingConditionById.LogPair.Clear();
			ConfigComboTeachingConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigComboTeachingConditionById.HandleId, 1, p0Id, ConfigComboTeachingConditionById.LogPair) || ConfigCommon.Step(ConfigComboTeachingConditionById.HandleId, true, ConfigComboTeachingConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigComboTeachingConditionById.HandleId, ConfigComboTeachingConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigComboTeachingConditionById.HandleId, 0, ConfigComboTeachingConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigComboTeachingConditionById.HandleId, ConfigComboTeachingConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ComboTeachingCondition rootAsComboTeachingCondition = ComboTeachingCondition.GetRootAsComboTeachingCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComboTeachingConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigComboTeachingConditionById.HandleId, ConfigComboTeachingConditionById.LogPair);
			return new ComboTeachingCondition?(rootAsComboTeachingCondition);
		}

		// Token: 0x04000AE9 RID: 2793
		private const string DB = "db_combo_teaching.db";

		// Token: 0x04000AEA RID: 2794
		private const string FILE = "j.角色出招教学.xlsx";

		// Token: 0x04000AEB RID: 2795
		private const string TABLE = "ComboTeachingCondition";

		// Token: 0x04000AEC RID: 2796
		private const string COMMAND = "select BinData from `ComboTeachingCondition` where Id=?";

		// Token: 0x04000AED RID: 2797
		private const string KEY_PREFIX = "ComboTeachingConditionById";

		// Token: 0x04000AEE RID: 2798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AEF RID: 2799
		private static int HandleId;
	}
}
