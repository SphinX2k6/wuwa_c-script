using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000208 RID: 520
	public class ConfigDarkCoastDeliveryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x000A2343 File Offset: 0x000A0543
		static ConfigDarkCoastDeliveryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDarkCoastDeliveryById.CreateStaticDefaultValue), new Action(ConfigDarkCoastDeliveryById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000A2364 File Offset: 0x000A0564
		public static void CreateStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDarkCoastDeliveryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "DarkCoastDelivery"),
				new ValueTuple<string, object>("语句", "select BinData from `DarkCoastDelivery` where Id=?")
			});
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000A23E3 File Offset: 0x000A05E3
		public static void ResetStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryById.LogPair = null;
			ConfigDarkCoastDeliveryById.HandleId = 0;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000A23F1 File Offset: 0x000A05F1
		public static void Init()
		{
			ConfigDarkCoastDeliveryById.HandleId = ConfigCommon.InitDataStatement(ConfigDarkCoastDeliveryById.HandleId, "db_dragon_ball.db", "select BinData from `DarkCoastDelivery` where Id=?");
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000A240C File Offset: 0x000A060C
		public static DarkCoastDelivery? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDarkCoastDeliveryById.HandleId, ConfigDarkCoastDeliveryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DarkCoastDeliveryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DarkCoastDelivery?(DarkCoastDelivery.GetRootAsDarkCoastDelivery(configBuffer));
				}
			}
			ConfigDarkCoastDeliveryById.LogPair.Clear();
			ConfigDarkCoastDeliveryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDarkCoastDeliveryById.HandleId, 1, p0Id, ConfigDarkCoastDeliveryById.LogPair) || ConfigCommon.Step(ConfigDarkCoastDeliveryById.HandleId, true, ConfigDarkCoastDeliveryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDarkCoastDeliveryById.HandleId, ConfigDarkCoastDeliveryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDarkCoastDeliveryById.HandleId, 0, ConfigDarkCoastDeliveryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDarkCoastDeliveryById.HandleId, ConfigDarkCoastDeliveryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DarkCoastDelivery rootAsDarkCoastDelivery = DarkCoastDelivery.GetRootAsDarkCoastDelivery(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DarkCoastDeliveryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDarkCoastDeliveryById.HandleId, ConfigDarkCoastDeliveryById.LogPair);
			return new DarkCoastDelivery?(rootAsDarkCoastDelivery);
		}

		// Token: 0x04000E1C RID: 3612
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000E1D RID: 3613
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000E1E RID: 3614
		private const string TABLE = "DarkCoastDelivery";

		// Token: 0x04000E1F RID: 3615
		private const string COMMAND = "select BinData from `DarkCoastDelivery` where Id=?";

		// Token: 0x04000E20 RID: 3616
		private const string KEY_PREFIX = "DarkCoastDeliveryById";

		// Token: 0x04000E21 RID: 3617
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E22 RID: 3618
		private static int HandleId;
	}
}
