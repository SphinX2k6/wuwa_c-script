using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F9 RID: 1017
	public class ConfigHonamiStoryEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x000E4090 File Offset: 0x000E2290
		static ConfigHonamiStoryEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryEffectById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x000E40B0 File Offset: 0x000E22B0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryEffect` where Id=?")
			});
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000E412F File Offset: 0x000E232F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryEffectById.LogPair = null;
			ConfigHonamiStoryEffectById.HandleId = 0;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000E413D File Offset: 0x000E233D
		public static void Init()
		{
			ConfigHonamiStoryEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryEffectById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryEffect` where Id=?");
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000E4158 File Offset: 0x000E2358
		public static HonamiStoryEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryEffectById.HandleId, ConfigHonamiStoryEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryEffect?(HonamiStoryEffect.GetRootAsHonamiStoryEffect(configBuffer));
				}
			}
			ConfigHonamiStoryEffectById.LogPair.Clear();
			ConfigHonamiStoryEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryEffectById.HandleId, 1, p0Id, ConfigHonamiStoryEffectById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryEffectById.HandleId, true, ConfigHonamiStoryEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryEffectById.HandleId, ConfigHonamiStoryEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryEffectById.HandleId, 0, ConfigHonamiStoryEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryEffectById.HandleId, ConfigHonamiStoryEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryEffect rootAsHonamiStoryEffect = HonamiStoryEffect.GetRootAsHonamiStoryEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryEffectById.HandleId, ConfigHonamiStoryEffectById.LogPair);
			return new HonamiStoryEffect?(rootAsHonamiStoryEffect);
		}

		// Token: 0x04001BB3 RID: 7091
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BB4 RID: 7092
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001BB5 RID: 7093
		private const string TABLE = "HonamiStoryEffect";

		// Token: 0x04001BB6 RID: 7094
		private const string COMMAND = "select BinData from `HonamiStoryEffect` where Id=?";

		// Token: 0x04001BB7 RID: 7095
		private const string KEY_PREFIX = "HonamiStoryEffectById";

		// Token: 0x04001BB8 RID: 7096
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BB9 RID: 7097
		private static int HandleId;
	}
}
