using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000353 RID: 851
	public class ConfigFormationPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013F7 RID: 5111 RVA: 0x000CA67F File Offset: 0x000C887F
		static ConfigFormationPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationPropertyById.CreateStaticDefaultValue), new Action(ConfigFormationPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000CA6A0 File Offset: 0x000C88A0
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

		// Token: 0x060013F9 RID: 5113 RVA: 0x000CA71F File Offset: 0x000C891F
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationPropertyById.LogPair = null;
			ConfigFormationPropertyById.HandleId = 0;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000CA72D File Offset: 0x000C892D
		public static void Init()
		{
			ConfigFormationPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigFormationPropertyById.HandleId, "db_formationproperty.db", "select BinData from `FormationProperty` where Id=?");
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000CA748 File Offset: 0x000C8948
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

		// Token: 0x04001729 RID: 5929
		private const string DB = "db_formationproperty.db";

		// Token: 0x0400172A RID: 5930
		private const string FILE = "d.队伍属性表.xlsx";

		// Token: 0x0400172B RID: 5931
		private const string TABLE = "FormationProperty";

		// Token: 0x0400172C RID: 5932
		private const string COMMAND = "select BinData from `FormationProperty` where Id=?";

		// Token: 0x0400172D RID: 5933
		private const string KEY_PREFIX = "FormationPropertyById";

		// Token: 0x0400172E RID: 5934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400172F RID: 5935
		private static int HandleId;
	}
}
