using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000366 RID: 870
	public class ConfigFormationMotionBySkinIdAndPosition : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001469 RID: 5225 RVA: 0x000D0767 File Offset: 0x000CE967
		static ConfigFormationMotionBySkinIdAndPosition()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionBySkinIdAndPosition.CreateStaticDefaultValue), new Action(ConfigFormationMotionBySkinIdAndPosition.ResetStaticDefaultValue));
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000D0788 File Offset: 0x000CE988
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

		// Token: 0x0600146B RID: 5227 RVA: 0x000D0807 File Offset: 0x000CEA07
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionBySkinIdAndPosition.LogPair = null;
			ConfigFormationMotionBySkinIdAndPosition.HandleId = 0;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000D0815 File Offset: 0x000CEA15
		public static void Init()
		{
			ConfigFormationMotionBySkinIdAndPosition.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionBySkinIdAndPosition.HandleId, "db_formation.db", "select BinData from `FormationMotion` where SkinId=? And Position=?");
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000D0830 File Offset: 0x000CEA30
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

		// Token: 0x040017AE RID: 6062
		private const string DB = "db_formation.db";

		// Token: 0x040017AF RID: 6063
		private const string FILE = "b.编队.xlsx";

		// Token: 0x040017B0 RID: 6064
		private const string TABLE = "FormationMotion";

		// Token: 0x040017B1 RID: 6065
		private const string COMMAND = "select BinData from `FormationMotion` where SkinId=? And Position=?";

		// Token: 0x040017B2 RID: 6066
		private const string KEY_PREFIX = "FormationMotionBySkinIdAndPosition";

		// Token: 0x040017B3 RID: 6067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017B4 RID: 6068
		private static int HandleId;
	}
}
