using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000421 RID: 1057
	public class ConfigHonamiStoryTalentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018CD RID: 6349 RVA: 0x000E98E7 File Offset: 0x000E7AE7
		static ConfigHonamiStoryTalentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryTalentById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryTalentById.ResetStaticDefaultValue));
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000E9908 File Offset: 0x000E7B08
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

		// Token: 0x060018CF RID: 6351 RVA: 0x000E9987 File Offset: 0x000E7B87
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryTalentById.LogPair = null;
			ConfigHonamiStoryTalentById.HandleId = 0;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000E9995 File Offset: 0x000E7B95
		public static void Init()
		{
			ConfigHonamiStoryTalentById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryTalentById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryTalent` where Id=?");
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000E99B0 File Offset: 0x000E7BB0
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

		// Token: 0x04001CCB RID: 7371
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CCC RID: 7372
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001CCD RID: 7373
		private const string TABLE = "HonamiStoryTalent";

		// Token: 0x04001CCE RID: 7374
		private const string COMMAND = "select BinData from `HonamiStoryTalent` where Id=?";

		// Token: 0x04001CCF RID: 7375
		private const string KEY_PREFIX = "HonamiStoryTalentById";

		// Token: 0x04001CD0 RID: 7376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CD1 RID: 7377
		private static int HandleId;
	}
}
