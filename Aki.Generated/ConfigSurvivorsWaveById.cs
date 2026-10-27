using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B0 RID: 2480
	public class ConfigSurvivorsWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x001A2E14 File Offset: 0x001A1014
		static ConfigSurvivorsWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWaveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x001A2E34 File Offset: 0x001A1034
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWaveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWaveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWave"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWave` where Id=?")
			});
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x001A2EB3 File Offset: 0x001A10B3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWaveById.LogPair = null;
			ConfigSurvivorsWaveById.HandleId = 0;
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x001A2EC1 File Offset: 0x001A10C1
		public static void Init()
		{
			ConfigSurvivorsWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWaveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWave` where Id=?");
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001A2EDC File Offset: 0x001A10DC
		public static SurvivorsWave? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWaveById.HandleId, ConfigSurvivorsWaveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWave?(SurvivorsWave.GetRootAsSurvivorsWave(configBuffer));
				}
			}
			ConfigSurvivorsWaveById.LogPair.Clear();
			ConfigSurvivorsWaveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWaveById.HandleId, 1, p0Id, ConfigSurvivorsWaveById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWaveById.HandleId, true, ConfigSurvivorsWaveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWaveById.HandleId, ConfigSurvivorsWaveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWaveById.HandleId, 0, ConfigSurvivorsWaveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWaveById.HandleId, ConfigSurvivorsWaveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWave rootAsSurvivorsWave = SurvivorsWave.GetRootAsSurvivorsWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWaveById.HandleId, ConfigSurvivorsWaveById.LogPair);
			return new SurvivorsWave?(rootAsSurvivorsWave);
		}

		// Token: 0x040043B6 RID: 17334
		private const string DB = "db_survivors.db";

		// Token: 0x040043B7 RID: 17335
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x040043B8 RID: 17336
		private const string TABLE = "SurvivorsWave";

		// Token: 0x040043B9 RID: 17337
		private const string COMMAND = "select BinData from `SurvivorsWave` where Id=?";

		// Token: 0x040043BA RID: 17338
		private const string KEY_PREFIX = "SurvivorsWaveById";

		// Token: 0x040043BB RID: 17339
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043BC RID: 17340
		private static int HandleId;
	}
}
