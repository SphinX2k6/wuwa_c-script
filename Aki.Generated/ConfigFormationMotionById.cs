using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034D RID: 845
	public class ConfigFormationMotionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013D3 RID: 5075 RVA: 0x000C9913 File Offset: 0x000C7B13
		static ConfigFormationMotionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionById.CreateStaticDefaultValue), new Action(ConfigFormationMotionById.ResetStaticDefaultValue));
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000C9934 File Offset: 0x000C7B34
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationMotionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationMotionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FormationMotion"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationMotion` where Id=?")
			});
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000C99B3 File Offset: 0x000C7BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionById.LogPair = null;
			ConfigFormationMotionById.HandleId = 0;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000C99C1 File Offset: 0x000C7BC1
		public static void Init()
		{
			ConfigFormationMotionById.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionById.HandleId, "db_formation.db", "select BinData from `FormationMotion` where Id=?");
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000C99DC File Offset: 0x000C7BDC
		public static FormationMotion? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationMotionById.HandleId, ConfigFormationMotionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FormationMotion?(FormationMotion.GetRootAsFormationMotion(configBuffer));
				}
			}
			ConfigFormationMotionById.LogPair.Clear();
			ConfigFormationMotionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFormationMotionById.HandleId, 1, p0Id, ConfigFormationMotionById.LogPair) || ConfigCommon.Step(ConfigFormationMotionById.HandleId, true, ConfigFormationMotionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFormationMotionById.HandleId, ConfigFormationMotionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationMotionById.HandleId, 0, ConfigFormationMotionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFormationMotionById.HandleId, ConfigFormationMotionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FormationMotion rootAsFormationMotion = FormationMotion.GetRootAsFormationMotion(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFormationMotionById.HandleId, ConfigFormationMotionById.LogPair);
			return new FormationMotion?(rootAsFormationMotion);
		}

		// Token: 0x040016FF RID: 5887
		private const string DB = "db_formation.db";

		// Token: 0x04001700 RID: 5888
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04001701 RID: 5889
		private const string TABLE = "FormationMotion";

		// Token: 0x04001702 RID: 5890
		private const string COMMAND = "select BinData from `FormationMotion` where Id=?";

		// Token: 0x04001703 RID: 5891
		private const string KEY_PREFIX = "FormationMotionById";

		// Token: 0x04001704 RID: 5892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001705 RID: 5893
		private static int HandleId;
	}
}
