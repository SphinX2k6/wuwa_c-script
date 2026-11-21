using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D9 RID: 1497
	public class ConfigMotorSceneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002323 RID: 8995 RVA: 0x00123B17 File Offset: 0x00121D17
		static ConfigMotorSceneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSceneById.CreateStaticDefaultValue), new Action(ConfigMotorSceneById.ResetStaticDefaultValue));
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00123B38 File Offset: 0x00121D38
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

		// Token: 0x06002325 RID: 8997 RVA: 0x00123BB7 File Offset: 0x00121DB7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSceneById.LogPair = null;
			ConfigMotorSceneById.HandleId = 0;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00123BC5 File Offset: 0x00121DC5
		public static void Init()
		{
			ConfigMotorSceneById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSceneById.HandleId, "db_motordiy.db", "select BinData from `MotorScene` where Id=?");
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00123BE0 File Offset: 0x00121DE0
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

		// Token: 0x040028D3 RID: 10451
		private const string DB = "db_motordiy.db";

		// Token: 0x040028D4 RID: 10452
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028D5 RID: 10453
		private const string TABLE = "MotorScene";

		// Token: 0x040028D6 RID: 10454
		private const string COMMAND = "select BinData from `MotorScene` where Id=?";

		// Token: 0x040028D7 RID: 10455
		private const string KEY_PREFIX = "MotorSceneById";

		// Token: 0x040028D8 RID: 10456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028D9 RID: 10457
		private static int HandleId;
	}
}
