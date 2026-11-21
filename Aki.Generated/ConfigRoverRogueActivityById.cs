using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000927 RID: 2343
	public class ConfigRoverRogueActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036FD RID: 14077 RVA: 0x0019362C File Offset: 0x0019182C
		static ConfigRoverRogueActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueActivityById.CreateStaticDefaultValue), new Action(ConfigRoverRogueActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x0019364C File Offset: 0x0019184C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueActivity` where Id=?")
			});
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x001936CB File Offset: 0x001918CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueActivityById.LogPair = null;
			ConfigRoverRogueActivityById.HandleId = 0;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x001936D9 File Offset: 0x001918D9
		public static void Init()
		{
			ConfigRoverRogueActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueActivityById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueActivity` where Id=?");
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x001936F4 File Offset: 0x001918F4
		public static RoverRogueActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueActivity?(RoverRogueActivity.GetRootAsRoverRogueActivity(configBuffer));
				}
			}
			ConfigRoverRogueActivityById.LogPair.Clear();
			ConfigRoverRogueActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueActivityById.HandleId, 1, p0Id, ConfigRoverRogueActivityById.LogPair) || ConfigCommon.Step(ConfigRoverRogueActivityById.HandleId, true, ConfigRoverRogueActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueActivityById.HandleId, 0, ConfigRoverRogueActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueActivity rootAsRoverRogueActivity = RoverRogueActivity.GetRootAsRoverRogueActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
			return new RoverRogueActivity?(rootAsRoverRogueActivity);
		}

		// Token: 0x04003FF7 RID: 16375
		private const string DB = "db_roverlike.db";

		// Token: 0x04003FF8 RID: 16376
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003FF9 RID: 16377
		private const string TABLE = "RoverRogueActivity";

		// Token: 0x04003FFA RID: 16378
		private const string COMMAND = "select BinData from `RoverRogueActivity` where Id=?";

		// Token: 0x04003FFB RID: 16379
		private const string KEY_PREFIX = "RoverRogueActivityById";

		// Token: 0x04003FFC RID: 16380
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FFD RID: 16381
		private static int HandleId;
	}
}
