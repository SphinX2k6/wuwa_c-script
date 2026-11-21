using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000368 RID: 872
	public class ConfigFormationPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x000D0B8B File Offset: 0x000CED8B
		static ConfigFormationPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationPropertyById.CreateStaticDefaultValue), new Action(ConfigFormationPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000D0BAC File Offset: 0x000CEDAC
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formationproperty.db"),
				new ValueTuple<string, object>("文件", "d.队伍属性表.xlsx"),
				new ValueTuple<string, object>("表名", "FormationProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationProperty` where Id=?")
			});
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000D0C2B File Offset: 0x000CEE2B
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationPropertyById.LogPair = null;
			ConfigFormationPropertyById.HandleId = 0;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000D0C39 File Offset: 0x000CEE39
		public static void Init()
		{
			ConfigFormationPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigFormationPropertyById.HandleId, "db_formationproperty.db", "select BinData from `FormationProperty` where Id=?");
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000D0C54 File Offset: 0x000CEE54
		public static FormationProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationPropertyById.HandleId, ConfigFormationPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FormationProperty?(FormationProperty.GetRootAsFormationProperty(configBuffer));
				}
			}
			ConfigFormationPropertyById.LogPair.Clear();
			ConfigFormationPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFormationPropertyById.HandleId, 1, p0Id, ConfigFormationPropertyById.LogPair) || ConfigCommon.Step(ConfigFormationPropertyById.HandleId, true, ConfigFormationPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFormationPropertyById.HandleId, ConfigFormationPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationPropertyById.HandleId, 0, ConfigFormationPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFormationPropertyById.HandleId, ConfigFormationPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FormationProperty rootAsFormationProperty = FormationProperty.GetRootAsFormationProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFormationPropertyById.HandleId, ConfigFormationPropertyById.LogPair);
			return new FormationProperty?(rootAsFormationProperty);
		}

		// Token: 0x040017BC RID: 6076
		private const string DB = "db_formationproperty.db";

		// Token: 0x040017BD RID: 6077
		private const string FILE = "d.队伍属性表.xlsx";

		// Token: 0x040017BE RID: 6078
		private const string TABLE = "FormationProperty";

		// Token: 0x040017BF RID: 6079
		private const string COMMAND = "select BinData from `FormationProperty` where Id=?";

		// Token: 0x040017C0 RID: 6080
		private const string KEY_PREFIX = "FormationPropertyById";

		// Token: 0x040017C1 RID: 6081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017C2 RID: 6082
		private static int HandleId;
	}
}
