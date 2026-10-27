using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F3 RID: 1011
	public class ConfigHonamiStoryMapMarkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x000DFC57 File Offset: 0x000DDE57
		static ConfigHonamiStoryMapMarkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMapMarkById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMapMarkById.ResetStaticDefaultValue));
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000DFC78 File Offset: 0x000DDE78
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

		// Token: 0x060017BB RID: 6075 RVA: 0x000DFCF7 File Offset: 0x000DDEF7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkById.LogPair = null;
			ConfigHonamiStoryMapMarkById.HandleId = 0;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000DFD05 File Offset: 0x000DDF05
		public static void Init()
		{
			ConfigHonamiStoryMapMarkById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMapMarkById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMapMark` where Id=?");
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000DFD20 File Offset: 0x000DDF20
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

		// Token: 0x04001B89 RID: 7049
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B8A RID: 7050
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001B8B RID: 7051
		private const string TABLE = "HonamiStoryMapMark";

		// Token: 0x04001B8C RID: 7052
		private const string COMMAND = "select BinData from `HonamiStoryMapMark` where Id=?";

		// Token: 0x04001B8D RID: 7053
		private const string KEY_PREFIX = "HonamiStoryMapMarkById";

		// Token: 0x04001B8E RID: 7054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B8F RID: 7055
		private static int HandleId;
	}
}
