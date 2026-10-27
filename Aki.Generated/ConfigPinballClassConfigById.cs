using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000710 RID: 1808
	public class ConfigPinballClassConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A70 RID: 10864 RVA: 0x00149428 File Offset: 0x00147628
		static ConfigPinballClassConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballClassConfigById.CreateStaticDefaultValue), new Action(ConfigPinballClassConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00149448 File Offset: 0x00147648
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballClassConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballClassConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballClassConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballClassConfig` where Id=?")
			});
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x001494C7 File Offset: 0x001476C7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballClassConfigById.LogPair = null;
			ConfigPinballClassConfigById.HandleId = 0;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x001494D5 File Offset: 0x001476D5
		public static void Init()
		{
			ConfigPinballClassConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballClassConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballClassConfig` where Id=?");
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x001494F0 File Offset: 0x001476F0
		public static PinballClassConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballClassConfigById.HandleId, ConfigPinballClassConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballClassConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballClassConfig?(PinballClassConfig.GetRootAsPinballClassConfig(configBuffer));
				}
			}
			ConfigPinballClassConfigById.LogPair.Clear();
			ConfigPinballClassConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballClassConfigById.HandleId, 1, p0Id, ConfigPinballClassConfigById.LogPair) || ConfigCommon.Step(ConfigPinballClassConfigById.HandleId, true, ConfigPinballClassConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballClassConfigById.HandleId, ConfigPinballClassConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballClassConfigById.HandleId, 0, ConfigPinballClassConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballClassConfigById.HandleId, ConfigPinballClassConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballClassConfig rootAsPinballClassConfig = PinballClassConfig.GetRootAsPinballClassConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballClassConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballClassConfigById.HandleId, ConfigPinballClassConfigById.LogPair);
			return new PinballClassConfig?(rootAsPinballClassConfig);
		}

		// Token: 0x04003156 RID: 12630
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003157 RID: 12631
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003158 RID: 12632
		private const string TABLE = "PinballClassConfig";

		// Token: 0x04003159 RID: 12633
		private const string COMMAND = "select BinData from `PinballClassConfig` where Id=?";

		// Token: 0x0400315A RID: 12634
		private const string KEY_PREFIX = "PinballClassConfigById";

		// Token: 0x0400315B RID: 12635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400315C RID: 12636
		private static int HandleId;
	}
}
