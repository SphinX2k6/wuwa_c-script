using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000731 RID: 1841
	public class ConfigPinballSpawnConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B36 RID: 11062 RVA: 0x0014DB5C File Offset: 0x0014BD5C
		static ConfigPinballSpawnConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballSpawnConfigById.CreateStaticDefaultValue), new Action(ConfigPinballSpawnConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0014DB7C File Offset: 0x0014BD7C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballSpawnConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballSpawnConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballSpawnConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballSpawnConfig` where Id=?")
			});
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0014DBFB File Offset: 0x0014BDFB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballSpawnConfigById.LogPair = null;
			ConfigPinballSpawnConfigById.HandleId = 0;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0014DC09 File Offset: 0x0014BE09
		public static void Init()
		{
			ConfigPinballSpawnConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballSpawnConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballSpawnConfig` where Id=?");
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0014DC24 File Offset: 0x0014BE24
		public static PinballSpawnConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballSpawnConfigById.HandleId, ConfigPinballSpawnConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballSpawnConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballSpawnConfig?(PinballSpawnConfig.GetRootAsPinballSpawnConfig(configBuffer));
				}
			}
			ConfigPinballSpawnConfigById.LogPair.Clear();
			ConfigPinballSpawnConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballSpawnConfigById.HandleId, 1, p0Id, ConfigPinballSpawnConfigById.LogPair) || ConfigCommon.Step(ConfigPinballSpawnConfigById.HandleId, true, ConfigPinballSpawnConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballSpawnConfigById.HandleId, ConfigPinballSpawnConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballSpawnConfigById.HandleId, 0, ConfigPinballSpawnConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballSpawnConfigById.HandleId, ConfigPinballSpawnConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballSpawnConfig rootAsPinballSpawnConfig = PinballSpawnConfig.GetRootAsPinballSpawnConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballSpawnConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballSpawnConfigById.HandleId, ConfigPinballSpawnConfigById.LogPair);
			return new PinballSpawnConfig?(rootAsPinballSpawnConfig);
		}

		// Token: 0x0400323D RID: 12861
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400323E RID: 12862
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400323F RID: 12863
		private const string TABLE = "PinballSpawnConfig";

		// Token: 0x04003240 RID: 12864
		private const string COMMAND = "select BinData from `PinballSpawnConfig` where Id=?";

		// Token: 0x04003241 RID: 12865
		private const string KEY_PREFIX = "PinballSpawnConfigById";

		// Token: 0x04003242 RID: 12866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003243 RID: 12867
		private static int HandleId;
	}
}
