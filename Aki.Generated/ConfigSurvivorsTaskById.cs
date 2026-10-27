using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AD RID: 2477
	public class ConfigSurvivorsTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A22 RID: 14882 RVA: 0x001A27EF File Offset: 0x001A09EF
		static ConfigSurvivorsTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTaskById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001A2810 File Offset: 0x001A0A10
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTask` where Id=?")
			});
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001A288F File Offset: 0x001A0A8F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTaskById.LogPair = null;
			ConfigSurvivorsTaskById.HandleId = 0;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001A289D File Offset: 0x001A0A9D
		public static void Init()
		{
			ConfigSurvivorsTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTaskById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTask` where Id=?");
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x001A28B8 File Offset: 0x001A0AB8
		public static SurvivorsTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTask?(SurvivorsTask.GetRootAsSurvivorsTask(configBuffer));
				}
			}
			ConfigSurvivorsTaskById.LogPair.Clear();
			ConfigSurvivorsTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTaskById.HandleId, 1, p0Id, ConfigSurvivorsTaskById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTaskById.HandleId, true, ConfigSurvivorsTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTaskById.HandleId, 0, ConfigSurvivorsTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTask rootAsSurvivorsTask = SurvivorsTask.GetRootAsSurvivorsTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
			return new SurvivorsTask?(rootAsSurvivorsTask);
		}

		// Token: 0x040043A1 RID: 17313
		private const string DB = "db_survivors.db";

		// Token: 0x040043A2 RID: 17314
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x040043A3 RID: 17315
		private const string TABLE = "SurvivorsTask";

		// Token: 0x040043A4 RID: 17316
		private const string COMMAND = "select BinData from `SurvivorsTask` where Id=?";

		// Token: 0x040043A5 RID: 17317
		private const string KEY_PREFIX = "SurvivorsTaskById";

		// Token: 0x040043A6 RID: 17318
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043A7 RID: 17319
		private static int HandleId;
	}
}
