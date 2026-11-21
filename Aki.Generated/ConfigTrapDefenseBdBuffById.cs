using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF6 RID: 2806
	public class ConfigTrapDefenseBdBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041D8 RID: 16856 RVA: 0x001D11BB File Offset: 0x001CF3BB
		static ConfigTrapDefenseBdBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x001D11DC File Offset: 0x001CF3DC
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

		// Token: 0x060041DA RID: 16858 RVA: 0x001D125B File Offset: 0x001CF45B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffById.LogPair = null;
			ConfigTrapDefenseBdBuffById.HandleId = 0;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x001D1269 File Offset: 0x001CF469
		public static void Init()
		{
			ConfigTrapDefenseBdBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where Id=?");
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x001D1284 File Offset: 0x001CF484
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

		// Token: 0x04004CA0 RID: 19616
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CA1 RID: 19617
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CA2 RID: 19618
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x04004CA3 RID: 19619
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where Id=?";

		// Token: 0x04004CA4 RID: 19620
		private const string KEY_PREFIX = "TrapDefenseBdBuffById";

		// Token: 0x04004CA5 RID: 19621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CA6 RID: 19622
		private static int HandleId;
	}
}
