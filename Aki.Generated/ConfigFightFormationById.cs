using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D2 RID: 722
	public class ConfigFightFormationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010F1 RID: 4337 RVA: 0x000BCD30 File Offset: 0x000BAF30
		static ConfigFightFormationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightFormationById.CreateStaticDefaultValue), new Action(ConfigFightFormationById.ResetStaticDefaultValue));
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000BCD50 File Offset: 0x000BAF50
		public static void CreateStaticDefaultValue()
		{
			ConfigFightFormationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightFormationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FightFormation"),
				new ValueTuple<string, object>("语句", "select BinData from `FightFormation` where Id=?")
			});
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000BCDCF File Offset: 0x000BAFCF
		public static void ResetStaticDefaultValue()
		{
			ConfigFightFormationById.LogPair = null;
			ConfigFightFormationById.HandleId = 0;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000BCDDD File Offset: 0x000BAFDD
		public static void Init()
		{
			ConfigFightFormationById.HandleId = ConfigCommon.InitDataStatement(ConfigFightFormationById.HandleId, "db_formation.db", "select BinData from `FightFormation` where Id=?");
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000BCDF8 File Offset: 0x000BAFF8
		public static FightFormation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightFormation?(FightFormation.GetRootAsFightFormation(configBuffer));
				}
			}
			ConfigFightFormationById.LogPair.Clear();
			ConfigFightFormationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightFormationById.HandleId, 1, p0Id, ConfigFightFormationById.LogPair) || ConfigCommon.Step(ConfigFightFormationById.HandleId, true, ConfigFightFormationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightFormationById.HandleId, 0, ConfigFightFormationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightFormation rootAsFightFormation = FightFormation.GetRootAsFightFormation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightFormationById.HandleId, ConfigFightFormationById.LogPair);
			return new FightFormation?(rootAsFightFormation);
		}

		// Token: 0x040013A2 RID: 5026
		private const string DB = "db_formation.db";

		// Token: 0x040013A3 RID: 5027
		private const string FILE = "b.编队.xlsx";

		// Token: 0x040013A4 RID: 5028
		private const string TABLE = "FightFormation";

		// Token: 0x040013A5 RID: 5029
		private const string COMMAND = "select BinData from `FightFormation` where Id=?";

		// Token: 0x040013A6 RID: 5030
		private const string KEY_PREFIX = "FightFormationById";

		// Token: 0x040013A7 RID: 5031
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013A8 RID: 5032
		private static int HandleId;
	}
}
