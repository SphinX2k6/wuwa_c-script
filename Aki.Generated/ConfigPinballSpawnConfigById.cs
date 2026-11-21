using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000749 RID: 1865
	public class ConfigPinballSpawnConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BC6 RID: 11206 RVA: 0x001545D8 File Offset: 0x001527D8
		static ConfigPinballSpawnConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballSpawnConfigById.CreateStaticDefaultValue), new Action(ConfigPinballSpawnConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x001545F8 File Offset: 0x001527F8
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

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00154677 File Offset: 0x00152877
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballSpawnConfigById.LogPair = null;
			ConfigPinballSpawnConfigById.HandleId = 0;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00154685 File Offset: 0x00152885
		public static void Init()
		{
			ConfigPinballSpawnConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballSpawnConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballSpawnConfig` where Id=?");
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x001546A0 File Offset: 0x001528A0
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

		// Token: 0x040032E5 RID: 13029
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032E6 RID: 13030
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x040032E7 RID: 13031
		private const string TABLE = "PinballSpawnConfig";

		// Token: 0x040032E8 RID: 13032
		private const string COMMAND = "select BinData from `PinballSpawnConfig` where Id=?";

		// Token: 0x040032E9 RID: 13033
		private const string KEY_PREFIX = "PinballSpawnConfigById";

		// Token: 0x040032EA RID: 13034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032EB RID: 13035
		private static int HandleId;
	}
}
