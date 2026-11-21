using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFB RID: 2811
	public class ConfigTrapDefenseBdGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041F6 RID: 16886 RVA: 0x001D1CB3 File Offset: 0x001CFEB3
		static ConfigTrapDefenseBdGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x001D1CD4 File Offset: 0x001CFED4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdGroup` where Id=?")
			});
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x001D1D53 File Offset: 0x001CFF53
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupById.LogPair = null;
			ConfigTrapDefenseBdGroupById.HandleId = 0;
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x001D1D61 File Offset: 0x001CFF61
		public static void Init()
		{
			ConfigTrapDefenseBdGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup` where Id=?");
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x001D1D7C File Offset: 0x001CFF7C
		public static TrapDefenseBdGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdGroupById.HandleId, ConfigTrapDefenseBdGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBdGroup?(TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(configBuffer));
				}
			}
			ConfigTrapDefenseBdGroupById.LogPair.Clear();
			ConfigTrapDefenseBdGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdGroupById.HandleId, 1, p0Id, ConfigTrapDefenseBdGroupById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBdGroupById.HandleId, true, ConfigTrapDefenseBdGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdGroupById.HandleId, ConfigTrapDefenseBdGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdGroupById.HandleId, 0, ConfigTrapDefenseBdGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdGroupById.HandleId, ConfigTrapDefenseBdGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBdGroup rootAsTrapDefenseBdGroup = TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdGroupById.HandleId, ConfigTrapDefenseBdGroupById.LogPair);
			return new TrapDefenseBdGroup?(rootAsTrapDefenseBdGroup);
		}

		// Token: 0x04004CC3 RID: 19651
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CC4 RID: 19652
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CC5 RID: 19653
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x04004CC6 RID: 19654
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup` where Id=?";

		// Token: 0x04004CC7 RID: 19655
		private const string KEY_PREFIX = "TrapDefenseBdGroupById";

		// Token: 0x04004CC8 RID: 19656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CC9 RID: 19657
		private static int HandleId;
	}
}
