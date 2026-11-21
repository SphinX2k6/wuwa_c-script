using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1A RID: 2842
	public class ConfigTrapDefenseTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042B0 RID: 17072 RVA: 0x001D5E3F File Offset: 0x001D403F
		static ConfigTrapDefenseTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseTechById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseTechById.ResetStaticDefaultValue));
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x001D5E60 File Offset: 0x001D4060
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseTechById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseTechById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseTech"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseTech` where Id=?")
			});
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x001D5EDF File Offset: 0x001D40DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseTechById.LogPair = null;
			ConfigTrapDefenseTechById.HandleId = 0;
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x001D5EED File Offset: 0x001D40ED
		public static void Init()
		{
			ConfigTrapDefenseTechById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseTechById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseTech` where Id=?");
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x001D5F08 File Offset: 0x001D4108
		public static TrapDefenseTech? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseTech?(TrapDefenseTech.GetRootAsTrapDefenseTech(configBuffer));
				}
			}
			ConfigTrapDefenseTechById.LogPair.Clear();
			ConfigTrapDefenseTechById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseTechById.HandleId, 1, p0Id, ConfigTrapDefenseTechById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseTechById.HandleId, true, ConfigTrapDefenseTechById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseTechById.HandleId, 0, ConfigTrapDefenseTechById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseTech rootAsTrapDefenseTech = TrapDefenseTech.GetRootAsTrapDefenseTech(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
			return new TrapDefenseTech?(rootAsTrapDefenseTech);
		}

		// Token: 0x04004D9C RID: 19868
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D9D RID: 19869
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D9E RID: 19870
		private const string TABLE = "TrapDefenseTech";

		// Token: 0x04004D9F RID: 19871
		private const string COMMAND = "select BinData from `TrapDefenseTech` where Id=?";

		// Token: 0x04004DA0 RID: 19872
		private const string KEY_PREFIX = "TrapDefenseTechById";

		// Token: 0x04004DA1 RID: 19873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DA2 RID: 19874
		private static int HandleId;
	}
}
