using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000365 RID: 869
	public class ConfigFormationMotionBySkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x000D052F File Offset: 0x000CE72F
		static ConfigFormationMotionBySkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionBySkinId.CreateStaticDefaultValue), new Action(ConfigFormationMotionBySkinId.ResetStaticDefaultValue));
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000D0550 File Offset: 0x000CE750
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationMotionBySkinId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationMotionBySkinId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FormationMotion"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationMotion` where SkinId=?")
			});
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000D05CF File Offset: 0x000CE7CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionBySkinId.LogPair = null;
			ConfigFormationMotionBySkinId.HandleId = 0;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000D05DD File Offset: 0x000CE7DD
		public static void Init()
		{
			ConfigFormationMotionBySkinId.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionBySkinId.HandleId, "db_formation.db", "select BinData from `FormationMotion` where SkinId=?");
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000D05F8 File Offset: 0x000CE7F8
		[NullableContext(2)]
		public static IReadOnlyList<FormationMotion> GetConfigList(int p0SkinId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationMotionBySkinId.HandleId, ConfigFormationMotionBySkinId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionBySkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				IReadOnlyList<FormationMotion> readOnlyList = (IReadOnlyList<FormationMotion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFormationMotionBySkinId.LogPair.Clear();
			ConfigFormationMotionBySkinId.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			if (!ConfigCommon.BindInt(ConfigFormationMotionBySkinId.HandleId, 1, p0SkinId, ConfigFormationMotionBySkinId.LogPair))
			{
				ConfigCommon.Reset(ConfigFormationMotionBySkinId.HandleId, ConfigFormationMotionBySkinId.LogPair);
				return null;
			}
			List<FormationMotion> list = new List<FormationMotion>();
			while (ConfigCommon.Step(ConfigFormationMotionBySkinId.HandleId, false, ConfigFormationMotionBySkinId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationMotionBySkinId.HandleId, 0, ConfigFormationMotionBySkinId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFormationMotionBySkinId.HandleId, ConfigFormationMotionBySkinId.LogPair);
					return null;
				}
				FormationMotion rootAsFormationMotion = FormationMotion.GetRootAsFormationMotion(new ByteBuffer(item2));
				list.Add(rootAsFormationMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionBySkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFormationMotionBySkinId.HandleId, ConfigFormationMotionBySkinId.LogPair);
			return list;
		}

		// Token: 0x040017A7 RID: 6055
		private const string DB = "db_formation.db";

		// Token: 0x040017A8 RID: 6056
		private const string FILE = "b.编队.xlsx";

		// Token: 0x040017A9 RID: 6057
		private const string TABLE = "FormationMotion";

		// Token: 0x040017AA RID: 6058
		private const string COMMAND = "select BinData from `FormationMotion` where SkinId=?";

		// Token: 0x040017AB RID: 6059
		private const string KEY_PREFIX = "FormationMotionBySkinId";

		// Token: 0x040017AC RID: 6060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017AD RID: 6061
		private static int HandleId;
	}
}
