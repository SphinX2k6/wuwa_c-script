using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F4 RID: 1012
	public class ConfigHonamiStoryAreaTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017BF RID: 6079 RVA: 0x000E3527 File Offset: 0x000E1727
		static ConfigHonamiStoryAreaTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000E3548 File Offset: 0x000E1748
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryAreaTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryAreaTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryAreaTask` where Id=?")
			});
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000E35C7 File Offset: 0x000E17C7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskById.LogPair = null;
			ConfigHonamiStoryAreaTaskById.HandleId = 0;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000E35D5 File Offset: 0x000E17D5
		public static void Init()
		{
			ConfigHonamiStoryAreaTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryAreaTask` where Id=?");
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000E35F0 File Offset: 0x000E17F0
		public static HonamiStoryAreaTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryAreaTask?(HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(configBuffer));
				}
			}
			ConfigHonamiStoryAreaTaskById.LogPair.Clear();
			ConfigHonamiStoryAreaTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryAreaTaskById.HandleId, 1, p0Id, ConfigHonamiStoryAreaTaskById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryAreaTaskById.HandleId, true, ConfigHonamiStoryAreaTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryAreaTaskById.HandleId, 0, ConfigHonamiStoryAreaTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryAreaTask rootAsHonamiStoryAreaTask = HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
			return new HonamiStoryAreaTask?(rootAsHonamiStoryAreaTask);
		}

		// Token: 0x04001B90 RID: 7056
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B91 RID: 7057
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B92 RID: 7058
		private const string TABLE = "HonamiStoryAreaTask";

		// Token: 0x04001B93 RID: 7059
		private const string COMMAND = "select BinData from `HonamiStoryAreaTask` where Id=?";

		// Token: 0x04001B94 RID: 7060
		private const string KEY_PREFIX = "HonamiStoryAreaTaskById";

		// Token: 0x04001B95 RID: 7061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B96 RID: 7062
		private static int HandleId;
	}
}
