using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000402 RID: 1026
	public class ConfigHonamiStoryPropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001813 RID: 6163 RVA: 0x000E1DF0 File Offset: 0x000DFFF0
		static ConfigHonamiStoryPropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPropById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPropById.ResetStaticDefaultValue));
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000E1E10 File Offset: 0x000E0010
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPropById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPropById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryProp"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryProp` where Id=?")
			});
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000E1E8F File Offset: 0x000E008F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPropById.LogPair = null;
			ConfigHonamiStoryPropById.HandleId = 0;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000E1E9D File Offset: 0x000E009D
		public static void Init()
		{
			ConfigHonamiStoryPropById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPropById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryProp` where Id=?");
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000E1EB8 File Offset: 0x000E00B8
		public static HonamiStoryProp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryProp?(HonamiStoryProp.GetRootAsHonamiStoryProp(configBuffer));
				}
			}
			ConfigHonamiStoryPropById.LogPair.Clear();
			ConfigHonamiStoryPropById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPropById.HandleId, 1, p0Id, ConfigHonamiStoryPropById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPropById.HandleId, true, ConfigHonamiStoryPropById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPropById.HandleId, 0, ConfigHonamiStoryPropById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryProp rootAsHonamiStoryProp = HonamiStoryProp.GetRootAsHonamiStoryProp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
			return new HonamiStoryProp?(rootAsHonamiStoryProp);
		}

		// Token: 0x04001BF2 RID: 7154
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BF3 RID: 7155
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BF4 RID: 7156
		private const string TABLE = "HonamiStoryProp";

		// Token: 0x04001BF5 RID: 7157
		private const string COMMAND = "select BinData from `HonamiStoryProp` where Id=?";

		// Token: 0x04001BF6 RID: 7158
		private const string KEY_PREFIX = "HonamiStoryPropById";

		// Token: 0x04001BF7 RID: 7159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BF8 RID: 7160
		private static int HandleId;
	}
}
