using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000181 RID: 385
	public class ConfigComboTeachingConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x0008C750 File Offset: 0x0008A950
		static ConfigComboTeachingConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComboTeachingConditionById.CreateStaticDefaultValue), new Action(ConfigComboTeachingConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0008C770 File Offset: 0x0008A970
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

		// Token: 0x06000909 RID: 2313 RVA: 0x0008C7EF File Offset: 0x0008A9EF
		public static void ResetStaticDefaultValue()
		{
			ConfigComboTeachingConditionById.LogPair = null;
			ConfigComboTeachingConditionById.HandleId = 0;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0008C7FD File Offset: 0x0008A9FD
		public static void Init()
		{
			ConfigComboTeachingConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigComboTeachingConditionById.HandleId, "db_combo_teaching.db", "select BinData from `ComboTeachingCondition` where Id=?");
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0008C818 File Offset: 0x0008AA18
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

		// Token: 0x04000A6B RID: 2667
		private const string DB = "db_combo_teaching.db";

		// Token: 0x04000A6C RID: 2668
		private const string FILE = "j.角色出招教学.xlsx";

		// Token: 0x04000A6D RID: 2669
		private const string TABLE = "ComboTeachingCondition";

		// Token: 0x04000A6E RID: 2670
		private const string COMMAND = "select BinData from `ComboTeachingCondition` where Id=?";

		// Token: 0x04000A6F RID: 2671
		private const string KEY_PREFIX = "ComboTeachingConditionById";

		// Token: 0x04000A70 RID: 2672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A71 RID: 2673
		private static int HandleId;
	}
}
