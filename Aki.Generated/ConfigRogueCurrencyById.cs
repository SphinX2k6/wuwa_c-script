using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083D RID: 2109
	public class ConfigRogueCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x00174A00 File Offset: 0x00172C00
		static ConfigRogueCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCurrencyById.CreateStaticDefaultValue), new Action(ConfigRogueCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00174A20 File Offset: 0x00172C20
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueCurrency` where Id=?")
			});
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00174A9F File Offset: 0x00172C9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCurrencyById.LogPair = null;
			ConfigRogueCurrencyById.HandleId = 0;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00174AAD File Offset: 0x00172CAD
		public static void Init()
		{
			ConfigRogueCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCurrencyById.HandleId, "db_rogue.db", "select BinData from `RogueCurrency` where Id=?");
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00174AC8 File Offset: 0x00172CC8
		public static RogueCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueCurrency?(RogueCurrency.GetRootAsRogueCurrency(configBuffer));
				}
			}
			ConfigRogueCurrencyById.LogPair.Clear();
			ConfigRogueCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueCurrencyById.HandleId, 1, p0Id, ConfigRogueCurrencyById.LogPair) || ConfigCommon.Step(ConfigRogueCurrencyById.HandleId, true, ConfigRogueCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueCurrencyById.HandleId, 0, ConfigRogueCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueCurrency rootAsRogueCurrency = RogueCurrency.GetRootAsRogueCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueCurrencyById.HandleId, ConfigRogueCurrencyById.LogPair);
			return new RogueCurrency?(rootAsRogueCurrency);
		}

		// Token: 0x04003991 RID: 14737
		private const string DB = "db_rogue.db";

		// Token: 0x04003992 RID: 14738
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003993 RID: 14739
		private const string TABLE = "RogueCurrency";

		// Token: 0x04003994 RID: 14740
		private const string COMMAND = "select BinData from `RogueCurrency` where Id=?";

		// Token: 0x04003995 RID: 14741
		private const string KEY_PREFIX = "RogueCurrencyById";

		// Token: 0x04003996 RID: 14742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003997 RID: 14743
		private static int HandleId;
	}
}
