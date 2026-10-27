using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000351 RID: 849
	public class ConfigFormationMotionBySkinIdAndPosition : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013EB RID: 5099 RVA: 0x000CA25B File Offset: 0x000C845B
		static ConfigFormationMotionBySkinIdAndPosition()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionBySkinIdAndPosition.CreateStaticDefaultValue), new Action(ConfigFormationMotionBySkinIdAndPosition.ResetStaticDefaultValue));
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000CA27C File Offset: 0x000C847C
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationMotionBySkinIdAndPosition.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationMotionBySkinIdAndPosition.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FormationMotion"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationMotion` where SkinId=? And Position=?")
			});
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000CA2FB File Offset: 0x000C84FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionBySkinIdAndPosition.LogPair = null;
			ConfigFormationMotionBySkinIdAndPosition.HandleId = 0;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000CA309 File Offset: 0x000C8509
		public static void Init()
		{
			ConfigFormationMotionBySkinIdAndPosition.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionBySkinIdAndPosition.HandleId, "db_formation.db", "select BinData from `FormationMotion` where SkinId=? And Position=?");
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x000CA324 File Offset: 0x000C8524
		[NullableContext(2)]
		public static IReadOnlyList<FormationMotion> GetConfigList(int p0SkinId, int p1Position, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationMotionBySkinIdAndPosition.HandleId, ConfigFormationMotionBySkinIdAndPosition.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionBySkinIdAndPosition");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Position);
				IReadOnlyList<FormationMotion> readOnlyList = (IReadOnlyList<FormationMotion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFormationMotionBySkinIdAndPosition.LogPair.Clear();
			ConfigFormationMotionBySkinIdAndPosition.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			ConfigFormationMotionBySkinIdAndPosition.LogPair.Add(new ValueTuple<string, object>("Position", p1Position));
			if (!ConfigCommon.BindInt(ConfigFormationMotionBySkinIdAndPosition.HandleId, 1, p0SkinId, ConfigFormationMotionBySkinIdAndPosition.LogPair) || !ConfigCommon.BindInt(ConfigFormationMotionBySkinIdAndPosition.HandleId, 2, p1Position, ConfigFormationMotionBySkinIdAndPosition.LogPair))
			{
				ConfigCommon.Reset(ConfigFormationMotionBySkinIdAndPosition.HandleId, ConfigFormationMotionBySkinIdAndPosition.LogPair);
				return null;
			}
			List<FormationMotion> list = new List<FormationMotion>();
			while (ConfigCommon.Step(ConfigFormationMotionBySkinIdAndPosition.HandleId, false, ConfigFormationMotionBySkinIdAndPosition.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationMotionBySkinIdAndPosition.HandleId, 0, ConfigFormationMotionBySkinIdAndPosition.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFormationMotionBySkinIdAndPosition.HandleId, ConfigFormationMotionBySkinIdAndPosition.LogPair);
					return null;
				}
				FormationMotion rootAsFormationMotion = FormationMotion.GetRootAsFormationMotion(new ByteBuffer(item2));
				list.Add(rootAsFormationMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionBySkinIdAndPosition");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Position);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFormationMotionBySkinIdAndPosition.HandleId, ConfigFormationMotionBySkinIdAndPosition.LogPair);
			return list;
		}

		// Token: 0x0400171B RID: 5915
		private const string DB = "db_formation.db";

		// Token: 0x0400171C RID: 5916
		private const string FILE = "b.编队.xlsx";

		// Token: 0x0400171D RID: 5917
		private const string TABLE = "FormationMotion";

		// Token: 0x0400171E RID: 5918
		private const string COMMAND = "select BinData from `FormationMotion` where SkinId=? And Position=?";

		// Token: 0x0400171F RID: 5919
		private const string KEY_PREFIX = "FormationMotionBySkinIdAndPosition";

		// Token: 0x04001720 RID: 5920
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001721 RID: 5921
		private static int HandleId;
	}
}
