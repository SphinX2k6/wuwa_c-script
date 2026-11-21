using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A85 RID: 2693
	public class ConfigSurvivorsWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F32 RID: 16178 RVA: 0x001C21A8 File Offset: 0x001C03A8
		static ConfigSurvivorsWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWaveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x001C21C8 File Offset: 0x001C03C8
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

		// Token: 0x06003F34 RID: 16180 RVA: 0x001C2247 File Offset: 0x001C0447
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWaveById.LogPair = null;
			ConfigSurvivorsWaveById.HandleId = 0;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001C2255 File Offset: 0x001C0455
		public static void Init()
		{
			ConfigSurvivorsWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWaveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWave` where Id=?");
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001C2270 File Offset: 0x001C0470
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

		// Token: 0x04004989 RID: 18825
		private const string DB = "db_survivors.db";

		// Token: 0x0400498A RID: 18826
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x0400498B RID: 18827
		private const string TABLE = "SurvivorsWave";

		// Token: 0x0400498C RID: 18828
		private const string COMMAND = "select BinData from `SurvivorsWave` where Id=?";

		// Token: 0x0400498D RID: 18829
		private const string KEY_PREFIX = "SurvivorsWaveById";

		// Token: 0x0400498E RID: 18830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400498F RID: 18831
		private static int HandleId;
	}
}
