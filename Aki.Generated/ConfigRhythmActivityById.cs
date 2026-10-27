using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007ED RID: 2029
	public class ConfigRhythmActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x00166790 File Offset: 0x00164990
		static ConfigRhythmActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmActivityById.CreateStaticDefaultValue), new Action(ConfigRhythmActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x001667B0 File Offset: 0x001649B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmActivity` where Id=?")
			});
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x0016682F File Offset: 0x00164A2F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmActivityById.LogPair = null;
			ConfigRhythmActivityById.HandleId = 0;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0016683D File Offset: 0x00164A3D
		public static void Init()
		{
			ConfigRhythmActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmActivityById.HandleId, "db_rhythmship.db", "select BinData from `RhythmActivity` where Id=?");
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00166858 File Offset: 0x00164A58
		public static RhythmActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmActivity?(RhythmActivity.GetRootAsRhythmActivity(configBuffer));
				}
			}
			ConfigRhythmActivityById.LogPair.Clear();
			ConfigRhythmActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmActivityById.HandleId, 1, p0Id, ConfigRhythmActivityById.LogPair) || ConfigCommon.Step(ConfigRhythmActivityById.HandleId, true, ConfigRhythmActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmActivityById.HandleId, 0, ConfigRhythmActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmActivity rootAsRhythmActivity = RhythmActivity.GetRootAsRhythmActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmActivityById.HandleId, ConfigRhythmActivityById.LogPair);
			return new RhythmActivity?(rootAsRhythmActivity);
		}

		// Token: 0x04003761 RID: 14177
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003762 RID: 14178
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003763 RID: 14179
		private const string TABLE = "RhythmActivity";

		// Token: 0x04003764 RID: 14180
		private const string COMMAND = "select BinData from `RhythmActivity` where Id=?";

		// Token: 0x04003765 RID: 14181
		private const string KEY_PREFIX = "RhythmActivityById";

		// Token: 0x04003766 RID: 14182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003767 RID: 14183
		private static int HandleId;
	}
}
