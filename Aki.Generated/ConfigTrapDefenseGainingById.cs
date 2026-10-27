using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2D RID: 2605
	public class ConfigTrapDefenseGainingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x001B3864 File Offset: 0x001B1A64
		static ConfigTrapDefenseGainingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseGainingById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseGainingById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x001B3884 File Offset: 0x001B1A84
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseGainingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseGainingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseGaining"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseGaining` where Id=?")
			});
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x001B3903 File Offset: 0x001B1B03
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseGainingById.LogPair = null;
			ConfigTrapDefenseGainingById.HandleId = 0;
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x001B3911 File Offset: 0x001B1B11
		public static void Init()
		{
			ConfigTrapDefenseGainingById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseGainingById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseGaining` where Id=?");
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x001B392C File Offset: 0x001B1B2C
		public static TrapDefenseGaining? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseGainingById.HandleId, ConfigTrapDefenseGainingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseGainingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseGaining?(TrapDefenseGaining.GetRootAsTrapDefenseGaining(configBuffer));
				}
			}
			ConfigTrapDefenseGainingById.LogPair.Clear();
			ConfigTrapDefenseGainingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseGainingById.HandleId, 1, p0Id, ConfigTrapDefenseGainingById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseGainingById.HandleId, true, ConfigTrapDefenseGainingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseGainingById.HandleId, ConfigTrapDefenseGainingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseGainingById.HandleId, 0, ConfigTrapDefenseGainingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseGainingById.HandleId, ConfigTrapDefenseGainingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseGaining rootAsTrapDefenseGaining = TrapDefenseGaining.GetRootAsTrapDefenseGaining(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseGainingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseGainingById.HandleId, ConfigTrapDefenseGainingById.LogPair);
			return new TrapDefenseGaining?(rootAsTrapDefenseGaining);
		}

		// Token: 0x04004721 RID: 18209
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004722 RID: 18210
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004723 RID: 18211
		private const string TABLE = "TrapDefenseGaining";

		// Token: 0x04004724 RID: 18212
		private const string COMMAND = "select BinData from `TrapDefenseGaining` where Id=?";

		// Token: 0x04004725 RID: 18213
		private const string KEY_PREFIX = "TrapDefenseGainingById";

		// Token: 0x04004726 RID: 18214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004727 RID: 18215
		private static int HandleId;
	}
}
