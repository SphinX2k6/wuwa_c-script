using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E3 RID: 995
	public class ConfigHonamiStoryEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x000DD93C File Offset: 0x000DBB3C
		static ConfigHonamiStoryEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryEffectById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000DD95C File Offset: 0x000DBB5C
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

		// Token: 0x0600175B RID: 5979 RVA: 0x000DD9DB File Offset: 0x000DBBDB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryEffectById.LogPair = null;
			ConfigHonamiStoryEffectById.HandleId = 0;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000DD9E9 File Offset: 0x000DBBE9
		public static void Init()
		{
			ConfigHonamiStoryEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryEffectById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryEffect` where Id=?");
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000DDA04 File Offset: 0x000DBC04
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

		// Token: 0x04001B19 RID: 6937
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B1A RID: 6938
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001B1B RID: 6939
		private const string TABLE = "HonamiStoryEffect";

		// Token: 0x04001B1C RID: 6940
		private const string COMMAND = "select BinData from `HonamiStoryEffect` where Id=?";

		// Token: 0x04001B1D RID: 6941
		private const string KEY_PREFIX = "HonamiStoryEffectById";

		// Token: 0x04001B1E RID: 6942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B1F RID: 6943
		private static int HandleId;
	}
}
