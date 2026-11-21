using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060E RID: 1550
	public class ConfigNewPlayerSupportTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x0012AA87 File Offset: 0x00128C87
		static ConfigNewPlayerSupportTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportTaskById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0012AAA8 File Offset: 0x00128CA8
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupportTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupport.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupportTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupportTask` where Id=?")
			});
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0012AB27 File Offset: 0x00128D27
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskById.LogPair = null;
			ConfigNewPlayerSupportTaskById.HandleId = 0;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0012AB35 File Offset: 0x00128D35
		public static void Init()
		{
			ConfigNewPlayerSupportTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportTaskById.HandleId, "db_newplayersupport.db", "select BinData from `NewPlayerSupportTask` where Id=?");
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0012AB50 File Offset: 0x00128D50
		public static NewPlayerSupportTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewPlayerSupportTask?(NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(configBuffer));
				}
			}
			ConfigNewPlayerSupportTaskById.LogPair.Clear();
			ConfigNewPlayerSupportTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupportTaskById.HandleId, 1, p0Id, ConfigNewPlayerSupportTaskById.LogPair) || ConfigCommon.Step(ConfigNewPlayerSupportTaskById.HandleId, true, ConfigNewPlayerSupportTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupportTaskById.HandleId, 0, ConfigNewPlayerSupportTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewPlayerSupportTask rootAsNewPlayerSupportTask = NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
			return new NewPlayerSupportTask?(rootAsNewPlayerSupportTask);
		}

		// Token: 0x04002A48 RID: 10824
		private const string DB = "db_newplayersupport.db";

		// Token: 0x04002A49 RID: 10825
		private const string FILE = "x.新玩家助力活动.xlsx";

		// Token: 0x04002A4A RID: 10826
		private const string TABLE = "NewPlayerSupportTask";

		// Token: 0x04002A4B RID: 10827
		private const string COMMAND = "select BinData from `NewPlayerSupportTask` where Id=?";

		// Token: 0x04002A4C RID: 10828
		private const string KEY_PREFIX = "NewPlayerSupportTaskById";

		// Token: 0x04002A4D RID: 10829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A4E RID: 10830
		private static int HandleId;
	}
}
