using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F6 RID: 502
	public class ConfigDarkCoastDeliveryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x0009C40B File Offset: 0x0009A60B
		static ConfigDarkCoastDeliveryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDarkCoastDeliveryById.CreateStaticDefaultValue), new Action(ConfigDarkCoastDeliveryById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0009C42C File Offset: 0x0009A62C
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

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0009C4AB File Offset: 0x0009A6AB
		public static void ResetStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryById.LogPair = null;
			ConfigDarkCoastDeliveryById.HandleId = 0;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0009C4B9 File Offset: 0x0009A6B9
		public static void Init()
		{
			ConfigDarkCoastDeliveryById.HandleId = ConfigCommon.InitDataStatement(ConfigDarkCoastDeliveryById.HandleId, "db_dragon_ball.db", "select BinData from `DarkCoastDelivery` where Id=?");
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0009C4D4 File Offset: 0x0009A6D4
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

		// Token: 0x04000D9E RID: 3486
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000D9F RID: 3487
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000DA0 RID: 3488
		private const string TABLE = "DarkCoastDelivery";

		// Token: 0x04000DA1 RID: 3489
		private const string COMMAND = "select BinData from `DarkCoastDelivery` where Id=?";

		// Token: 0x04000DA2 RID: 3490
		private const string KEY_PREFIX = "DarkCoastDeliveryById";

		// Token: 0x04000DA3 RID: 3491
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DA4 RID: 3492
		private static int HandleId;
	}
}
