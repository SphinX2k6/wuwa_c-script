using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040B RID: 1035
	public class ConfigHonamiStoryTalentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x000E3193 File Offset: 0x000E1393
		static ConfigHonamiStoryTalentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryTalentById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryTalentById.ResetStaticDefaultValue));
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000E31B4 File Offset: 0x000E13B4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryTalentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryTalentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryTalent"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryTalent` where Id=?")
			});
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000E3233 File Offset: 0x000E1433
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryTalentById.LogPair = null;
			ConfigHonamiStoryTalentById.HandleId = 0;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000E3241 File Offset: 0x000E1441
		public static void Init()
		{
			ConfigHonamiStoryTalentById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryTalentById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryTalent` where Id=?");
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000E325C File Offset: 0x000E145C
		public static HonamiStoryTalent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryTalentById.HandleId, ConfigHonamiStoryTalentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryTalent?(HonamiStoryTalent.GetRootAsHonamiStoryTalent(configBuffer));
				}
			}
			ConfigHonamiStoryTalentById.LogPair.Clear();
			ConfigHonamiStoryTalentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryTalentById.HandleId, 1, p0Id, ConfigHonamiStoryTalentById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryTalentById.HandleId, true, ConfigHonamiStoryTalentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryTalentById.HandleId, ConfigHonamiStoryTalentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryTalentById.HandleId, 0, ConfigHonamiStoryTalentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryTalentById.HandleId, ConfigHonamiStoryTalentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryTalent rootAsHonamiStoryTalent = HonamiStoryTalent.GetRootAsHonamiStoryTalent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryTalentById.HandleId, ConfigHonamiStoryTalentById.LogPair);
			return new HonamiStoryTalent?(rootAsHonamiStoryTalent);
		}

		// Token: 0x04001C31 RID: 7217
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C32 RID: 7218
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C33 RID: 7219
		private const string TABLE = "HonamiStoryTalent";

		// Token: 0x04001C34 RID: 7220
		private const string COMMAND = "select BinData from `HonamiStoryTalent` where Id=?";

		// Token: 0x04001C35 RID: 7221
		private const string KEY_PREFIX = "HonamiStoryTalentById";

		// Token: 0x04001C36 RID: 7222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C37 RID: 7223
		private static int HandleId;
	}
}
