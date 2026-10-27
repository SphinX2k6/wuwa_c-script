using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FE RID: 1022
	public class ConfigHonamiStoryPluginSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x000E14E0 File Offset: 0x000DF6E0
		static ConfigHonamiStoryPluginSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginSubTypeById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000E1500 File Offset: 0x000DF700
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginSubType` where Id=?")
			});
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000E157F File Offset: 0x000DF77F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSubTypeById.LogPair = null;
			ConfigHonamiStoryPluginSubTypeById.HandleId = 0;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000E158D File Offset: 0x000DF78D
		public static void Init()
		{
			ConfigHonamiStoryPluginSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginSubTypeById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginSubType` where Id=?");
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000E15A8 File Offset: 0x000DF7A8
		public static HonamiStoryPluginSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginSubType?(HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(configBuffer));
				}
			}
			ConfigHonamiStoryPluginSubTypeById.LogPair.Clear();
			ConfigHonamiStoryPluginSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginSubTypeById.HandleId, 1, p0Id, ConfigHonamiStoryPluginSubTypeById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginSubTypeById.HandleId, true, ConfigHonamiStoryPluginSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginSubTypeById.HandleId, 0, ConfigHonamiStoryPluginSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginSubType rootAsHonamiStoryPluginSubType = HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
			return new HonamiStoryPluginSubType?(rootAsHonamiStoryPluginSubType);
		}

		// Token: 0x04001BD6 RID: 7126
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BD7 RID: 7127
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BD8 RID: 7128
		private const string TABLE = "HonamiStoryPluginSubType";

		// Token: 0x04001BD9 RID: 7129
		private const string COMMAND = "select BinData from `HonamiStoryPluginSubType` where Id=?";

		// Token: 0x04001BDA RID: 7130
		private const string KEY_PREFIX = "HonamiStoryPluginSubTypeById";

		// Token: 0x04001BDB RID: 7131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BDC RID: 7132
		private static int HandleId;
	}
}
