using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000362 RID: 866
	public class ConfigFormationMotionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x000CFE1F File Offset: 0x000CE01F
		static ConfigFormationMotionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionById.CreateStaticDefaultValue), new Action(ConfigFormationMotionById.ResetStaticDefaultValue));
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000CFE40 File Offset: 0x000CE040
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

		// Token: 0x06001453 RID: 5203 RVA: 0x000CFEBF File Offset: 0x000CE0BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionById.LogPair = null;
			ConfigFormationMotionById.HandleId = 0;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000CFECD File Offset: 0x000CE0CD
		public static void Init()
		{
			ConfigFormationMotionById.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionById.HandleId, "db_formation.db", "select BinData from `FormationMotion` where Id=?");
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000CFEE8 File Offset: 0x000CE0E8
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

		// Token: 0x04001792 RID: 6034
		private const string DB = "db_formation.db";

		// Token: 0x04001793 RID: 6035
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04001794 RID: 6036
		private const string TABLE = "FormationMotion";

		// Token: 0x04001795 RID: 6037
		private const string COMMAND = "select BinData from `FormationMotion` where Id=?";

		// Token: 0x04001796 RID: 6038
		private const string KEY_PREFIX = "FormationMotionById";

		// Token: 0x04001797 RID: 6039
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001798 RID: 6040
		private static int HandleId;
	}
}
