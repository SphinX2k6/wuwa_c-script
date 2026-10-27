using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037C RID: 892
	public class ConfigGameplayCueById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x000CFF39 File Offset: 0x000CE139
		static ConfigGameplayCueById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGameplayCueById.CreateStaticDefaultValue), new Action(ConfigGameplayCueById.ResetStaticDefaultValue));
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000CFF58 File Offset: 0x000CE158
		public static void CreateStaticDefaultValue()
		{
			ConfigGameplayCueById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGameplayCueById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buffeffect.db"),
				new ValueTuple<string, object>("文件", "b.Buff特效.xlsx"),
				new ValueTuple<string, object>("表名", "GameplayCue"),
				new ValueTuple<string, object>("语句", "select BinData from `GameplayCue` where Id=?")
			});
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000CFFD7 File Offset: 0x000CE1D7
		public static void ResetStaticDefaultValue()
		{
			ConfigGameplayCueById.LogPair = null;
			ConfigGameplayCueById.HandleId = 0;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000CFFE5 File Offset: 0x000CE1E5
		public static void Init()
		{
			ConfigGameplayCueById.HandleId = ConfigCommon.InitDataStatement(ConfigGameplayCueById.HandleId, "db_buffeffect.db", "select BinData from `GameplayCue` where Id=?");
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000D0000 File Offset: 0x000CE200
		public static GameplayCue? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGameplayCueById.HandleId, ConfigGameplayCueById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GameplayCueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GameplayCue?(GameplayCue.GetRootAsGameplayCue(configBuffer));
				}
			}
			ConfigGameplayCueById.LogPair.Clear();
			ConfigGameplayCueById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigGameplayCueById.HandleId, 1, (double)p0Id, ConfigGameplayCueById.LogPair) || ConfigCommon.Step(ConfigGameplayCueById.HandleId, true, ConfigGameplayCueById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGameplayCueById.HandleId, ConfigGameplayCueById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGameplayCueById.HandleId, 0, ConfigGameplayCueById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGameplayCueById.HandleId, ConfigGameplayCueById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GameplayCue rootAsGameplayCue = GameplayCue.GetRootAsGameplayCue(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GameplayCueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGameplayCueById.HandleId, ConfigGameplayCueById.LogPair);
			return new GameplayCue?(rootAsGameplayCue);
		}

		// Token: 0x04001848 RID: 6216
		private const string DB = "db_buffeffect.db";

		// Token: 0x04001849 RID: 6217
		private const string FILE = "b.Buff特效.xlsx";

		// Token: 0x0400184A RID: 6218
		private const string TABLE = "GameplayCue";

		// Token: 0x0400184B RID: 6219
		private const string COMMAND = "select BinData from `GameplayCue` where Id=?";

		// Token: 0x0400184C RID: 6220
		private const string KEY_PREFIX = "GameplayCueById";

		// Token: 0x0400184D RID: 6221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400184E RID: 6222
		private static int HandleId;
	}
}
