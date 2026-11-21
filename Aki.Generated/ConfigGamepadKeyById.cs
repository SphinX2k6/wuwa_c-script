using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038F RID: 911
	public class ConfigGamepadKeyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x000D6004 File Offset: 0x000D4204
		static ConfigGamepadKeyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamepadKeyById.CreateStaticDefaultValue), new Action(ConfigGamepadKeyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000D6024 File Offset: 0x000D4224
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

		// Token: 0x06001562 RID: 5474 RVA: 0x000D60A3 File Offset: 0x000D42A3
		public static void ResetStaticDefaultValue()
		{
			ConfigGamepadKeyById.LogPair = null;
			ConfigGamepadKeyById.HandleId = 0;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000D60B1 File Offset: 0x000D42B1
		public static void Init()
		{
			ConfigGamepadKeyById.HandleId = ConfigCommon.InitDataStatement(ConfigGamepadKeyById.HandleId, "db_key.db", "select BinData from `GamepadKey` where Id=?");
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000D60CC File Offset: 0x000D42CC
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

		// Token: 0x040018CD RID: 6349
		private const string DB = "db_key.db";

		// Token: 0x040018CE RID: 6350
		private const string FILE = "a.按键.xlsx";

		// Token: 0x040018CF RID: 6351
		private const string TABLE = "GamepadKey";

		// Token: 0x040018D0 RID: 6352
		private const string COMMAND = "select BinData from `GamepadKey` where Id=?";

		// Token: 0x040018D1 RID: 6353
		private const string KEY_PREFIX = "GamepadKeyById";

		// Token: 0x040018D2 RID: 6354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018D3 RID: 6355
		private static int HandleId;
	}
}
