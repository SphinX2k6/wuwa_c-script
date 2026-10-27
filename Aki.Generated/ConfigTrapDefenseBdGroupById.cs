using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A26 RID: 2598
	public class ConfigTrapDefenseBdGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CF8 RID: 15608 RVA: 0x001B291F File Offset: 0x001B0B1F
		static ConfigTrapDefenseBdGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x001B2940 File Offset: 0x001B0B40
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

		// Token: 0x06003CFA RID: 15610 RVA: 0x001B29BF File Offset: 0x001B0BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupById.LogPair = null;
			ConfigTrapDefenseBdGroupById.HandleId = 0;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x001B29CD File Offset: 0x001B0BCD
		public static void Init()
		{
			ConfigTrapDefenseBdGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup` where Id=?");
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x001B29E8 File Offset: 0x001B0BE8
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

		// Token: 0x040046F0 RID: 18160
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046F1 RID: 18161
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046F2 RID: 18162
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x040046F3 RID: 18163
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup` where Id=?";

		// Token: 0x040046F4 RID: 18164
		private const string KEY_PREFIX = "TrapDefenseBdGroupById";

		// Token: 0x040046F5 RID: 18165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046F6 RID: 18166
		private static int HandleId;
	}
}
