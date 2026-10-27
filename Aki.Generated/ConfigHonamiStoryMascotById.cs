using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F7 RID: 1015
	public class ConfigHonamiStoryMascotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017D1 RID: 6097 RVA: 0x000E04B3 File Offset: 0x000DE6B3
		static ConfigHonamiStoryMascotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMascotById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMascotById.ResetStaticDefaultValue));
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000E04D4 File Offset: 0x000DE6D4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMascotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMascotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMascot"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMascot` where Id=?")
			});
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000E0553 File Offset: 0x000DE753
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMascotById.LogPair = null;
			ConfigHonamiStoryMascotById.HandleId = 0;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000E0561 File Offset: 0x000DE761
		public static void Init()
		{
			ConfigHonamiStoryMascotById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMascotById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMascot` where Id=?");
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000E057C File Offset: 0x000DE77C
		public static HonamiStoryMascot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMascotById.HandleId, ConfigHonamiStoryMascotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMascotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryMascot?(HonamiStoryMascot.GetRootAsHonamiStoryMascot(configBuffer));
				}
			}
			ConfigHonamiStoryMascotById.LogPair.Clear();
			ConfigHonamiStoryMascotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryMascotById.HandleId, 1, p0Id, ConfigHonamiStoryMascotById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryMascotById.HandleId, true, ConfigHonamiStoryMascotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMascotById.HandleId, ConfigHonamiStoryMascotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMascotById.HandleId, 0, ConfigHonamiStoryMascotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMascotById.HandleId, ConfigHonamiStoryMascotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryMascot rootAsHonamiStoryMascot = HonamiStoryMascot.GetRootAsHonamiStoryMascot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMascotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMascotById.HandleId, ConfigHonamiStoryMascotById.LogPair);
			return new HonamiStoryMascot?(rootAsHonamiStoryMascot);
		}

		// Token: 0x04001BA5 RID: 7077
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BA6 RID: 7078
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BA7 RID: 7079
		private const string TABLE = "HonamiStoryMascot";

		// Token: 0x04001BA8 RID: 7080
		private const string COMMAND = "select BinData from `HonamiStoryMascot` where Id=?";

		// Token: 0x04001BA9 RID: 7081
		private const string KEY_PREFIX = "HonamiStoryMascotById";

		// Token: 0x04001BAA RID: 7082
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BAB RID: 7083
		private static int HandleId;
	}
}
