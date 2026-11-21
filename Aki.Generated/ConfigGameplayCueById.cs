using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000391 RID: 913
	public class ConfigGameplayCueById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600156C RID: 5484 RVA: 0x000D6445 File Offset: 0x000D4645
		static ConfigGameplayCueById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGameplayCueById.CreateStaticDefaultValue), new Action(ConfigGameplayCueById.ResetStaticDefaultValue));
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000D6464 File Offset: 0x000D4664
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

		// Token: 0x0600156E RID: 5486 RVA: 0x000D64E3 File Offset: 0x000D46E3
		public static void ResetStaticDefaultValue()
		{
			ConfigGameplayCueById.LogPair = null;
			ConfigGameplayCueById.HandleId = 0;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000D64F1 File Offset: 0x000D46F1
		public static void Init()
		{
			ConfigGameplayCueById.HandleId = ConfigCommon.InitDataStatement(ConfigGameplayCueById.HandleId, "db_buffeffect.db", "select BinData from `GameplayCue` where Id=?");
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000D650C File Offset: 0x000D470C
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

		// Token: 0x040018DB RID: 6363
		private const string DB = "db_buffeffect.db";

		// Token: 0x040018DC RID: 6364
		private const string FILE = "b.Buff特效.xlsx";

		// Token: 0x040018DD RID: 6365
		private const string TABLE = "GameplayCue";

		// Token: 0x040018DE RID: 6366
		private const string COMMAND = "select BinData from `GameplayCue` where Id=?";

		// Token: 0x040018DF RID: 6367
		private const string KEY_PREFIX = "GameplayCueById";

		// Token: 0x040018E0 RID: 6368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018E1 RID: 6369
		private static int HandleId;
	}
}
