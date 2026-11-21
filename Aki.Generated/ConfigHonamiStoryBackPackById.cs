using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F5 RID: 1013
	public class ConfigHonamiStoryBackPackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017C5 RID: 6085 RVA: 0x000E3770 File Offset: 0x000E1970
		static ConfigHonamiStoryBackPackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBackPackById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBackPackById.ResetStaticDefaultValue));
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000E3790 File Offset: 0x000E1990
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

		// Token: 0x060017C7 RID: 6087 RVA: 0x000E380F File Offset: 0x000E1A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBackPackById.LogPair = null;
			ConfigHonamiStoryBackPackById.HandleId = 0;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000E381D File Offset: 0x000E1A1D
		public static void Init()
		{
			ConfigHonamiStoryBackPackById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBackPackById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBackPack` where Id=?");
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000E3838 File Offset: 0x000E1A38
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

		// Token: 0x04001B97 RID: 7063
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B98 RID: 7064
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B99 RID: 7065
		private const string TABLE = "HonamiStoryBackPack";

		// Token: 0x04001B9A RID: 7066
		private const string COMMAND = "select BinData from `HonamiStoryBackPack` where Id=?";

		// Token: 0x04001B9B RID: 7067
		private const string KEY_PREFIX = "HonamiStoryBackPackById";

		// Token: 0x04001B9C RID: 7068
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B9D RID: 7069
		private static int HandleId;
	}
}
