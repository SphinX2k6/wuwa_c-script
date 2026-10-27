using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A41 RID: 2625
	public class ConfigTrapDefenseSpecialCellTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D9A RID: 15770 RVA: 0x001B61AC File Offset: 0x001B43AC
		static ConfigTrapDefenseSpecialCellTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialCellTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialCellTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001B61CC File Offset: 0x001B43CC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialCellTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_特殊地块.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialCellType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialCellType` where Id=?")
			});
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x001B624B File Offset: 0x001B444B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellTypeById.LogPair = null;
			ConfigTrapDefenseSpecialCellTypeById.HandleId = 0;
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x001B6259 File Offset: 0x001B4459
		public static void Init()
		{
			ConfigTrapDefenseSpecialCellTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialCellTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialCellType` where Id=?");
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x001B6274 File Offset: 0x001B4474
		public static TrapDefenseSpecialCellType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseSpecialCellType?(TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(configBuffer));
				}
			}
			ConfigTrapDefenseSpecialCellTypeById.LogPair.Clear();
			ConfigTrapDefenseSpecialCellTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialCellTypeById.HandleId, 1, p0Id, ConfigTrapDefenseSpecialCellTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseSpecialCellTypeById.HandleId, true, ConfigTrapDefenseSpecialCellTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialCellTypeById.HandleId, 0, ConfigTrapDefenseSpecialCellTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseSpecialCellType rootAsTrapDefenseSpecialCellType = TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
			return new TrapDefenseSpecialCellType?(rootAsTrapDefenseSpecialCellType);
		}

		// Token: 0x040047AD RID: 18349
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047AE RID: 18350
		private const string FILE = "x.陷阱塔防活动_特殊地块.xlsx";

		// Token: 0x040047AF RID: 18351
		private const string TABLE = "TrapDefenseSpecialCellType";

		// Token: 0x040047B0 RID: 18352
		private const string COMMAND = "select BinData from `TrapDefenseSpecialCellType` where Id=?";

		// Token: 0x040047B1 RID: 18353
		private const string KEY_PREFIX = "TrapDefenseSpecialCellTypeById";

		// Token: 0x040047B2 RID: 18354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047B3 RID: 18355
		private static int HandleId;
	}
}
