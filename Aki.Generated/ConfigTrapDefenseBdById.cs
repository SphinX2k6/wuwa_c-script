using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A23 RID: 2595
	public class ConfigTrapDefenseBdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CE6 RID: 15590 RVA: 0x001B230D File Offset: 0x001B050D
		static ConfigTrapDefenseBdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x001B232C File Offset: 0x001B052C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBd"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBd` where Id=?")
			});
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x001B23AB File Offset: 0x001B05AB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdById.LogPair = null;
			ConfigTrapDefenseBdById.HandleId = 0;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x001B23B9 File Offset: 0x001B05B9
		public static void Init()
		{
			ConfigTrapDefenseBdById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBd` where Id=?");
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x001B23D4 File Offset: 0x001B05D4
		public static TrapDefenseBd? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBd?(TrapDefenseBd.GetRootAsTrapDefenseBd(configBuffer));
				}
			}
			ConfigTrapDefenseBdById.LogPair.Clear();
			ConfigTrapDefenseBdById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdById.HandleId, 1, p0Id, ConfigTrapDefenseBdById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBdById.HandleId, true, ConfigTrapDefenseBdById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdById.HandleId, 0, ConfigTrapDefenseBdById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBd rootAsTrapDefenseBd = TrapDefenseBd.GetRootAsTrapDefenseBd(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
			return new TrapDefenseBd?(rootAsTrapDefenseBd);
		}

		// Token: 0x040046DB RID: 18139
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046DC RID: 18140
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046DD RID: 18141
		private const string TABLE = "TrapDefenseBd";

		// Token: 0x040046DE RID: 18142
		private const string COMMAND = "select BinData from `TrapDefenseBd` where Id=?";

		// Token: 0x040046DF RID: 18143
		private const string KEY_PREFIX = "TrapDefenseBdById";

		// Token: 0x040046E0 RID: 18144
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046E1 RID: 18145
		private static int HandleId;
	}
}
