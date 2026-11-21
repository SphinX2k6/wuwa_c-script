using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040D RID: 1037
	public class ConfigHonamiStoryMascotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001855 RID: 6229 RVA: 0x000E6C07 File Offset: 0x000E4E07
		static ConfigHonamiStoryMascotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMascotById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMascotById.ResetStaticDefaultValue));
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000E6C28 File Offset: 0x000E4E28
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

		// Token: 0x06001857 RID: 6231 RVA: 0x000E6CA7 File Offset: 0x000E4EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMascotById.LogPair = null;
			ConfigHonamiStoryMascotById.HandleId = 0;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000E6CB5 File Offset: 0x000E4EB5
		public static void Init()
		{
			ConfigHonamiStoryMascotById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMascotById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMascot` where Id=?");
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000E6CD0 File Offset: 0x000E4ED0
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

		// Token: 0x04001C3F RID: 7231
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C40 RID: 7232
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C41 RID: 7233
		private const string TABLE = "HonamiStoryMascot";

		// Token: 0x04001C42 RID: 7234
		private const string COMMAND = "select BinData from `HonamiStoryMascot` where Id=?";

		// Token: 0x04001C43 RID: 7235
		private const string KEY_PREFIX = "HonamiStoryMascotById";

		// Token: 0x04001C44 RID: 7236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C45 RID: 7237
		private static int HandleId;
	}
}
