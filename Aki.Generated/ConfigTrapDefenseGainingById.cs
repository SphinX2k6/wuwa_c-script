using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B02 RID: 2818
	public class ConfigTrapDefenseGainingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004220 RID: 16928 RVA: 0x001D2BF8 File Offset: 0x001D0DF8
		static ConfigTrapDefenseGainingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseGainingById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseGainingById.ResetStaticDefaultValue));
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x001D2C18 File Offset: 0x001D0E18
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

		// Token: 0x06004222 RID: 16930 RVA: 0x001D2C97 File Offset: 0x001D0E97
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseGainingById.LogPair = null;
			ConfigTrapDefenseGainingById.HandleId = 0;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x001D2CA5 File Offset: 0x001D0EA5
		public static void Init()
		{
			ConfigTrapDefenseGainingById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseGainingById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseGaining` where Id=?");
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x001D2CC0 File Offset: 0x001D0EC0
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

		// Token: 0x04004CF4 RID: 19700
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CF5 RID: 19701
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CF6 RID: 19702
		private const string TABLE = "TrapDefenseGaining";

		// Token: 0x04004CF7 RID: 19703
		private const string COMMAND = "select BinData from `TrapDefenseGaining` where Id=?";

		// Token: 0x04004CF8 RID: 19704
		private const string KEY_PREFIX = "TrapDefenseGainingById";

		// Token: 0x04004CF9 RID: 19705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CFA RID: 19706
		private static int HandleId;
	}
}
