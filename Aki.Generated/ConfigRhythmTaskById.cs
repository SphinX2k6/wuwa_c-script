using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FE RID: 2046
	public class ConfigRhythmTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x00168BE7 File Offset: 0x00166DE7
		static ConfigRhythmTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskById.CreateStaticDefaultValue), new Action(ConfigRhythmTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00168C08 File Offset: 0x00166E08
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTask` where Id=?")
			});
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00168C87 File Offset: 0x00166E87
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskById.LogPair = null;
			ConfigRhythmTaskById.HandleId = 0;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00168C95 File Offset: 0x00166E95
		public static void Init()
		{
			ConfigRhythmTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskById.HandleId, "db_rhythmship.db", "select BinData from `RhythmTask` where Id=?");
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00168CB0 File Offset: 0x00166EB0
		public static RhythmTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmTask?(RhythmTask.GetRootAsRhythmTask(configBuffer));
				}
			}
			ConfigRhythmTaskById.LogPair.Clear();
			ConfigRhythmTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskById.HandleId, 1, p0Id, ConfigRhythmTaskById.LogPair) || ConfigCommon.Step(ConfigRhythmTaskById.HandleId, true, ConfigRhythmTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskById.HandleId, 0, ConfigRhythmTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmTask rootAsRhythmTask = RhythmTask.GetRootAsRhythmTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
			return new RhythmTask?(rootAsRhythmTask);
		}

		// Token: 0x040037D8 RID: 14296
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037D9 RID: 14297
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037DA RID: 14298
		private const string TABLE = "RhythmTask";

		// Token: 0x040037DB RID: 14299
		private const string COMMAND = "select BinData from `RhythmTask` where Id=?";

		// Token: 0x040037DC RID: 14300
		private const string KEY_PREFIX = "RhythmTaskById";

		// Token: 0x040037DD RID: 14301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037DE RID: 14302
		private static int HandleId;
	}
}
