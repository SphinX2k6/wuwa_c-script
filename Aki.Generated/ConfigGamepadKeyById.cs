using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037A RID: 890
	public class ConfigGamepadKeyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014E2 RID: 5346 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
		static ConfigGamepadKeyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamepadKeyById.CreateStaticDefaultValue), new Action(ConfigGamepadKeyById.ResetStaticDefaultValue));
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000CFB18 File Offset: 0x000CDD18
		public static void CreateStaticDefaultValue()
		{
			ConfigGamepadKeyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamepadKeyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_key.db"),
				new ValueTuple<string, object>("文件", "a.按键.xlsx"),
				new ValueTuple<string, object>("表名", "GamepadKey"),
				new ValueTuple<string, object>("语句", "select BinData from `GamepadKey` where Id=?")
			});
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000CFB97 File Offset: 0x000CDD97
		public static void ResetStaticDefaultValue()
		{
			ConfigGamepadKeyById.LogPair = null;
			ConfigGamepadKeyById.HandleId = 0;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000CFBA5 File Offset: 0x000CDDA5
		public static void Init()
		{
			ConfigGamepadKeyById.HandleId = ConfigCommon.InitDataStatement(ConfigGamepadKeyById.HandleId, "db_key.db", "select BinData from `GamepadKey` where Id=?");
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x000CFBC0 File Offset: 0x000CDDC0
		public static GamepadKey? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamepadKeyById.HandleId, ConfigGamepadKeyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamepadKeyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GamepadKey?(GamepadKey.GetRootAsGamepadKey(configBuffer));
				}
			}
			ConfigGamepadKeyById.LogPair.Clear();
			ConfigGamepadKeyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGamepadKeyById.HandleId, 1, p0Id, ConfigGamepadKeyById.LogPair) || ConfigCommon.Step(ConfigGamepadKeyById.HandleId, true, ConfigGamepadKeyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamepadKeyById.HandleId, ConfigGamepadKeyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamepadKeyById.HandleId, 0, ConfigGamepadKeyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamepadKeyById.HandleId, ConfigGamepadKeyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamepadKey rootAsGamepadKey = GamepadKey.GetRootAsGamepadKey(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamepadKeyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamepadKeyById.HandleId, ConfigGamepadKeyById.LogPair);
			return new GamepadKey?(rootAsGamepadKey);
		}

		// Token: 0x0400183A RID: 6202
		private const string DB = "db_key.db";

		// Token: 0x0400183B RID: 6203
		private const string FILE = "a.按键.xlsx";

		// Token: 0x0400183C RID: 6204
		private const string TABLE = "GamepadKey";

		// Token: 0x0400183D RID: 6205
		private const string COMMAND = "select BinData from `GamepadKey` where Id=?";

		// Token: 0x0400183E RID: 6206
		private const string KEY_PREFIX = "GamepadKeyById";

		// Token: 0x0400183F RID: 6207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001840 RID: 6208
		private static int HandleId;
	}
}
