using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000728 RID: 1832
	public class ConfigPinballClassConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x0014FEA4 File Offset: 0x0014E0A4
		static ConfigPinballClassConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballClassConfigById.CreateStaticDefaultValue), new Action(ConfigPinballClassConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0014FEC4 File Offset: 0x0014E0C4
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

		// Token: 0x06002B02 RID: 11010 RVA: 0x0014FF43 File Offset: 0x0014E143
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballClassConfigById.LogPair = null;
			ConfigPinballClassConfigById.HandleId = 0;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0014FF51 File Offset: 0x0014E151
		public static void Init()
		{
			ConfigPinballClassConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballClassConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballClassConfig` where Id=?");
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0014FF6C File Offset: 0x0014E16C
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

		// Token: 0x040031FE RID: 12798
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031FF RID: 12799
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003200 RID: 12800
		private const string TABLE = "PinballClassConfig";

		// Token: 0x04003201 RID: 12801
		private const string COMMAND = "select BinData from `PinballClassConfig` where Id=?";

		// Token: 0x04003202 RID: 12802
		private const string KEY_PREFIX = "PinballClassConfigById";

		// Token: 0x04003203 RID: 12803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003204 RID: 12804
		private static int HandleId;
	}
}
