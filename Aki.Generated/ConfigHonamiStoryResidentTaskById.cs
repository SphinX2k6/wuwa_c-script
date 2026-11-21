using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041B RID: 1051
	public class ConfigHonamiStoryResidentTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x000E8C0B File Offset: 0x000E6E0B
		static ConfigHonamiStoryResidentTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryResidentTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryResidentTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000E8C2C File Offset: 0x000E6E2C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryResidentTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryResidentTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryResidentTask` where Id=?")
			});
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000E8CAB File Offset: 0x000E6EAB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskById.LogPair = null;
			ConfigHonamiStoryResidentTaskById.HandleId = 0;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000E8CB9 File Offset: 0x000E6EB9
		public static void Init()
		{
			ConfigHonamiStoryResidentTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryResidentTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryResidentTask` where Id=?");
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000E8CD4 File Offset: 0x000E6ED4
		public static HonamiStoryResidentTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryResidentTask?(HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(configBuffer));
				}
			}
			ConfigHonamiStoryResidentTaskById.LogPair.Clear();
			ConfigHonamiStoryResidentTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryResidentTaskById.HandleId, 1, p0Id, ConfigHonamiStoryResidentTaskById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryResidentTaskById.HandleId, true, ConfigHonamiStoryResidentTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryResidentTaskById.HandleId, 0, ConfigHonamiStoryResidentTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryResidentTask rootAsHonamiStoryResidentTask = HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
			return new HonamiStoryResidentTask?(rootAsHonamiStoryResidentTask);
		}

		// Token: 0x04001CA1 RID: 7329
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CA2 RID: 7330
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001CA3 RID: 7331
		private const string TABLE = "HonamiStoryResidentTask";

		// Token: 0x04001CA4 RID: 7332
		private const string COMMAND = "select BinData from `HonamiStoryResidentTask` where Id=?";

		// Token: 0x04001CA5 RID: 7333
		private const string KEY_PREFIX = "HonamiStoryResidentTaskById";

		// Token: 0x04001CA6 RID: 7334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CA7 RID: 7335
		private static int HandleId;
	}
}
