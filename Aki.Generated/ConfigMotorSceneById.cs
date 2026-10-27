using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C2 RID: 1474
	public class ConfigMotorSceneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x0011D22F File Offset: 0x0011B42F
		static ConfigMotorSceneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSceneById.CreateStaticDefaultValue), new Action(ConfigMotorSceneById.ResetStaticDefaultValue));
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0011D250 File Offset: 0x0011B450
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSceneById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSceneById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorScene"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorScene` where Id=?")
			});
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0011D2CF File Offset: 0x0011B4CF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSceneById.LogPair = null;
			ConfigMotorSceneById.HandleId = 0;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0011D2DD File Offset: 0x0011B4DD
		public static void Init()
		{
			ConfigMotorSceneById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSceneById.HandleId, "db_motordiy.db", "select BinData from `MotorScene` where Id=?");
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0011D2F8 File Offset: 0x0011B4F8
		public static MotorScene? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSceneById.HandleId, ConfigMotorSceneById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSceneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorScene?(MotorScene.GetRootAsMotorScene(configBuffer));
				}
			}
			ConfigMotorSceneById.LogPair.Clear();
			ConfigMotorSceneById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorSceneById.HandleId, 1, p0Id, ConfigMotorSceneById.LogPair) || ConfigCommon.Step(ConfigMotorSceneById.HandleId, true, ConfigMotorSceneById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorSceneById.HandleId, ConfigMotorSceneById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSceneById.HandleId, 0, ConfigMotorSceneById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorSceneById.HandleId, ConfigMotorSceneById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorScene rootAsMotorScene = MotorScene.GetRootAsMotorScene(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSceneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorSceneById.HandleId, ConfigMotorSceneById.LogPair);
			return new MotorScene?(rootAsMotorScene);
		}

		// Token: 0x04002832 RID: 10290
		private const string DB = "db_motordiy.db";

		// Token: 0x04002833 RID: 10291
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002834 RID: 10292
		private const string TABLE = "MotorScene";

		// Token: 0x04002835 RID: 10293
		private const string COMMAND = "select BinData from `MotorScene` where Id=?";

		// Token: 0x04002836 RID: 10294
		private const string KEY_PREFIX = "MotorSceneById";

		// Token: 0x04002837 RID: 10295
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002838 RID: 10296
		private static int HandleId;
	}
}
