using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B5 RID: 1461
	public class ConfigMotorFightTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600224B RID: 8779 RVA: 0x0011EF7B File Offset: 0x0011D17B
		static ConfigMotorFightTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskById.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0011EF9C File Offset: 0x0011D19C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTask` where Id=?")
			});
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0011F01B File Offset: 0x0011D21B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskById.LogPair = null;
			ConfigMotorFightTaskById.HandleId = 0;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0011F029 File Offset: 0x0011D229
		public static void Init()
		{
			ConfigMotorFightTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTask` where Id=?");
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0011F044 File Offset: 0x0011D244
		public static MotorFightTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTask?(MotorFightTask.GetRootAsMotorFightTask(configBuffer));
				}
			}
			ConfigMotorFightTaskById.LogPair.Clear();
			ConfigMotorFightTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskById.HandleId, 1, p0Id, ConfigMotorFightTaskById.LogPair) || ConfigCommon.Step(ConfigMotorFightTaskById.HandleId, true, ConfigMotorFightTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskById.HandleId, 0, ConfigMotorFightTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTask rootAsMotorFightTask = MotorFightTask.GetRootAsMotorFightTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
			return new MotorFightTask?(rootAsMotorFightTask);
		}

		// Token: 0x040027D7 RID: 10199
		private const string DB = "db_motorfight.db";

		// Token: 0x040027D8 RID: 10200
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027D9 RID: 10201
		private const string TABLE = "MotorFightTask";

		// Token: 0x040027DA RID: 10202
		private const string COMMAND = "select BinData from `MotorFightTask` where Id=?";

		// Token: 0x040027DB RID: 10203
		private const string KEY_PREFIX = "MotorFightTaskById";

		// Token: 0x040027DC RID: 10204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027DD RID: 10205
		private static int HandleId;
	}
}
