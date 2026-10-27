using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A21 RID: 2593
	public class ConfigTrapDefenseBdBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x001B1E27 File Offset: 0x001B0027
		static ConfigTrapDefenseBdBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001B1E48 File Offset: 0x001B0048
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdBuff` where Id=?")
			});
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x001B1EC7 File Offset: 0x001B00C7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffById.LogPair = null;
			ConfigTrapDefenseBdBuffById.HandleId = 0;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x001B1ED5 File Offset: 0x001B00D5
		public static void Init()
		{
			ConfigTrapDefenseBdBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where Id=?");
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x001B1EF0 File Offset: 0x001B00F0
		public static TrapDefenseBdBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdBuffById.HandleId, ConfigTrapDefenseBdBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBdBuff?(TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(configBuffer));
				}
			}
			ConfigTrapDefenseBdBuffById.LogPair.Clear();
			ConfigTrapDefenseBdBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdBuffById.HandleId, 1, p0Id, ConfigTrapDefenseBdBuffById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBdBuffById.HandleId, true, ConfigTrapDefenseBdBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdBuffById.HandleId, ConfigTrapDefenseBdBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdBuffById.HandleId, 0, ConfigTrapDefenseBdBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdBuffById.HandleId, ConfigTrapDefenseBdBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBdBuff rootAsTrapDefenseBdBuff = TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdBuffById.HandleId, ConfigTrapDefenseBdBuffById.LogPair);
			return new TrapDefenseBdBuff?(rootAsTrapDefenseBdBuff);
		}

		// Token: 0x040046CD RID: 18125
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046CE RID: 18126
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046CF RID: 18127
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x040046D0 RID: 18128
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where Id=?";

		// Token: 0x040046D1 RID: 18129
		private const string KEY_PREFIX = "TrapDefenseBdBuffById";

		// Token: 0x040046D2 RID: 18130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046D3 RID: 18131
		private static int HandleId;
	}
}
