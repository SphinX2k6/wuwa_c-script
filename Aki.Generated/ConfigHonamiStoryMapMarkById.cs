using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000409 RID: 1033
	public class ConfigHonamiStoryMapMarkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600183D RID: 6205 RVA: 0x000E63AB File Offset: 0x000E45AB
		static ConfigHonamiStoryMapMarkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMapMarkById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMapMarkById.ResetStaticDefaultValue));
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000E63CC File Offset: 0x000E45CC
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMapMarkById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMapMark` where Id=?")
			});
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000E644B File Offset: 0x000E464B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkById.LogPair = null;
			ConfigHonamiStoryMapMarkById.HandleId = 0;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000E6459 File Offset: 0x000E4659
		public static void Init()
		{
			ConfigHonamiStoryMapMarkById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMapMarkById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMapMark` where Id=?");
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000E6474 File Offset: 0x000E4674
		public static HonamiStoryMapMark? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMapMarkById.HandleId, ConfigHonamiStoryMapMarkById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMapMarkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryMapMark?(HonamiStoryMapMark.GetRootAsHonamiStoryMapMark(configBuffer));
				}
			}
			ConfigHonamiStoryMapMarkById.LogPair.Clear();
			ConfigHonamiStoryMapMarkById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryMapMarkById.HandleId, 1, p0Id, ConfigHonamiStoryMapMarkById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryMapMarkById.HandleId, true, ConfigHonamiStoryMapMarkById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMapMarkById.HandleId, ConfigHonamiStoryMapMarkById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMapMarkById.HandleId, 0, ConfigHonamiStoryMapMarkById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMapMarkById.HandleId, ConfigHonamiStoryMapMarkById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryMapMark rootAsHonamiStoryMapMark = HonamiStoryMapMark.GetRootAsHonamiStoryMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMapMarkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMapMarkById.HandleId, ConfigHonamiStoryMapMarkById.LogPair);
			return new HonamiStoryMapMark?(rootAsHonamiStoryMapMark);
		}

		// Token: 0x04001C23 RID: 7203
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C24 RID: 7204
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C25 RID: 7205
		private const string TABLE = "HonamiStoryMapMark";

		// Token: 0x04001C26 RID: 7206
		private const string COMMAND = "select BinData from `HonamiStoryMapMark` where Id=?";

		// Token: 0x04001C27 RID: 7207
		private const string KEY_PREFIX = "HonamiStoryMapMarkById";

		// Token: 0x04001C28 RID: 7208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C29 RID: 7209
		private static int HandleId;
	}
}
