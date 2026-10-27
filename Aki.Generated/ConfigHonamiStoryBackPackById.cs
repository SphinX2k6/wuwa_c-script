using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DF RID: 991
	public class ConfigHonamiStoryBackPackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x000DD01C File Offset: 0x000DB21C
		static ConfigHonamiStoryBackPackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBackPackById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBackPackById.ResetStaticDefaultValue));
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000DD03C File Offset: 0x000DB23C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryBackPackById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryBackPackById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryBackPack"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryBackPack` where Id=?")
			});
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000DD0BB File Offset: 0x000DB2BB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBackPackById.LogPair = null;
			ConfigHonamiStoryBackPackById.HandleId = 0;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000DD0C9 File Offset: 0x000DB2C9
		public static void Init()
		{
			ConfigHonamiStoryBackPackById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBackPackById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBackPack` where Id=?");
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000DD0E4 File Offset: 0x000DB2E4
		public static HonamiStoryBackPack? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryBackPackById.HandleId, ConfigHonamiStoryBackPackById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBackPackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryBackPack?(HonamiStoryBackPack.GetRootAsHonamiStoryBackPack(configBuffer));
				}
			}
			ConfigHonamiStoryBackPackById.LogPair.Clear();
			ConfigHonamiStoryBackPackById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryBackPackById.HandleId, 1, p0Id, ConfigHonamiStoryBackPackById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryBackPackById.HandleId, true, ConfigHonamiStoryBackPackById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBackPackById.HandleId, ConfigHonamiStoryBackPackById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryBackPackById.HandleId, 0, ConfigHonamiStoryBackPackById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBackPackById.HandleId, ConfigHonamiStoryBackPackById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryBackPack rootAsHonamiStoryBackPack = HonamiStoryBackPack.GetRootAsHonamiStoryBackPack(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBackPackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryBackPackById.HandleId, ConfigHonamiStoryBackPackById.LogPair);
			return new HonamiStoryBackPack?(rootAsHonamiStoryBackPack);
		}

		// Token: 0x04001AFD RID: 6909
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AFE RID: 6910
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AFF RID: 6911
		private const string TABLE = "HonamiStoryBackPack";

		// Token: 0x04001B00 RID: 6912
		private const string COMMAND = "select BinData from `HonamiStoryBackPack` where Id=?";

		// Token: 0x04001B01 RID: 6913
		private const string KEY_PREFIX = "HonamiStoryBackPackById";

		// Token: 0x04001B02 RID: 6914
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B03 RID: 6915
		private static int HandleId;
	}
}
