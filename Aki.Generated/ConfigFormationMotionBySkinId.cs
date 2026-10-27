using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000350 RID: 848
	public class ConfigFormationMotionBySkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x000CA023 File Offset: 0x000C8223
		static ConfigFormationMotionBySkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionBySkinId.CreateStaticDefaultValue), new Action(ConfigFormationMotionBySkinId.ResetStaticDefaultValue));
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000CA044 File Offset: 0x000C8244
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

		// Token: 0x060013E7 RID: 5095 RVA: 0x000CA0C3 File Offset: 0x000C82C3
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionBySkinId.LogPair = null;
			ConfigFormationMotionBySkinId.HandleId = 0;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000CA0D1 File Offset: 0x000C82D1
		public static void Init()
		{
			ConfigFormationMotionBySkinId.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionBySkinId.HandleId, "db_formation.db", "select BinData from `FormationMotion` where SkinId=?");
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000CA0EC File Offset: 0x000C82EC
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

		// Token: 0x04001714 RID: 5908
		private const string DB = "db_formation.db";

		// Token: 0x04001715 RID: 5909
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04001716 RID: 5910
		private const string TABLE = "FormationMotion";

		// Token: 0x04001717 RID: 5911
		private const string COMMAND = "select BinData from `FormationMotion` where SkinId=?";

		// Token: 0x04001718 RID: 5912
		private const string KEY_PREFIX = "FormationMotionBySkinId";

		// Token: 0x04001719 RID: 5913
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400171A RID: 5914
		private static int HandleId;
	}
}
