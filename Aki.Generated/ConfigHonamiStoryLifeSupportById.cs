using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EB RID: 1003
	public class ConfigHonamiStoryLifeSupportById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x000DEAA7 File Offset: 0x000DCCA7
		static ConfigHonamiStoryLifeSupportById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLifeSupportById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLifeSupportById.ResetStaticDefaultValue));
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLifeSupportById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLifeSupport"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLifeSupport` where Id=?")
			});
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000DEB47 File Offset: 0x000DCD47
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportById.LogPair = null;
			ConfigHonamiStoryLifeSupportById.HandleId = 0;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000DEB55 File Offset: 0x000DCD55
		public static void Init()
		{
			ConfigHonamiStoryLifeSupportById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLifeSupportById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLifeSupport` where Id=?");
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000DEB70 File Offset: 0x000DCD70
		public static HonamiStoryLifeSupport? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryLifeSupport?(HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(configBuffer));
				}
			}
			ConfigHonamiStoryLifeSupportById.LogPair.Clear();
			ConfigHonamiStoryLifeSupportById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLifeSupportById.HandleId, 1, p0Id, ConfigHonamiStoryLifeSupportById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryLifeSupportById.HandleId, true, ConfigHonamiStoryLifeSupportById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLifeSupportById.HandleId, 0, ConfigHonamiStoryLifeSupportById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryLifeSupport rootAsHonamiStoryLifeSupport = HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
			return new HonamiStoryLifeSupport?(rootAsHonamiStoryLifeSupport);
		}

		// Token: 0x04001B51 RID: 6993
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B52 RID: 6994
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001B53 RID: 6995
		private const string TABLE = "HonamiStoryLifeSupport";

		// Token: 0x04001B54 RID: 6996
		private const string COMMAND = "select BinData from `HonamiStoryLifeSupport` where Id=?";

		// Token: 0x04001B55 RID: 6997
		private const string KEY_PREFIX = "HonamiStoryLifeSupportById";

		// Token: 0x04001B56 RID: 6998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B57 RID: 6999
		private static int HandleId;
	}
}
