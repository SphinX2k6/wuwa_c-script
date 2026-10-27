using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BB RID: 699
	public class ConfigFeedingAnimalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x000B6393 File Offset: 0x000B4593
		static ConfigFeedingAnimalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFeedingAnimalById.CreateStaticDefaultValue), new Action(ConfigFeedingAnimalById.ResetStaticDefaultValue));
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000B63B4 File Offset: 0x000B45B4
		public static void CreateStaticDefaultValue()
		{
			ConfigFeedingAnimalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFeedingAnimalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedinganimal.db"),
				new ValueTuple<string, object>("文件", "t.投喂动物.xlsx"),
				new ValueTuple<string, object>("表名", "FeedingAnimal"),
				new ValueTuple<string, object>("语句", "select BinData from `FeedingAnimal` where Id=?")
			});
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000B6433 File Offset: 0x000B4633
		public static void ResetStaticDefaultValue()
		{
			ConfigFeedingAnimalById.LogPair = null;
			ConfigFeedingAnimalById.HandleId = 0;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000B6441 File Offset: 0x000B4641
		public static void Init()
		{
			ConfigFeedingAnimalById.HandleId = ConfigCommon.InitDataStatement(ConfigFeedingAnimalById.HandleId, "db_feedinganimal.db", "select BinData from `FeedingAnimal` where Id=?");
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000B645C File Offset: 0x000B465C
		public static FeedingAnimal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFeedingAnimalById.HandleId, ConfigFeedingAnimalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FeedingAnimalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FeedingAnimal?(FeedingAnimal.GetRootAsFeedingAnimal(configBuffer));
				}
			}
			ConfigFeedingAnimalById.LogPair.Clear();
			ConfigFeedingAnimalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFeedingAnimalById.HandleId, 1, p0Id, ConfigFeedingAnimalById.LogPair) || ConfigCommon.Step(ConfigFeedingAnimalById.HandleId, true, ConfigFeedingAnimalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFeedingAnimalById.HandleId, ConfigFeedingAnimalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFeedingAnimalById.HandleId, 0, ConfigFeedingAnimalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFeedingAnimalById.HandleId, ConfigFeedingAnimalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FeedingAnimal rootAsFeedingAnimal = FeedingAnimal.GetRootAsFeedingAnimal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FeedingAnimalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFeedingAnimalById.HandleId, ConfigFeedingAnimalById.LogPair);
			return new FeedingAnimal?(rootAsFeedingAnimal);
		}

		// Token: 0x04001301 RID: 4865
		private const string DB = "db_feedinganimal.db";

		// Token: 0x04001302 RID: 4866
		private const string FILE = "t.投喂动物.xlsx";

		// Token: 0x04001303 RID: 4867
		private const string TABLE = "FeedingAnimal";

		// Token: 0x04001304 RID: 4868
		private const string COMMAND = "select BinData from `FeedingAnimal` where Id=?";

		// Token: 0x04001305 RID: 4869
		private const string KEY_PREFIX = "FeedingAnimalById";

		// Token: 0x04001306 RID: 4870
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001307 RID: 4871
		private static int HandleId;
	}
}
