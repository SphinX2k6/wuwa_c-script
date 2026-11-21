using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D0 RID: 720
	public class ConfigFeedingAnimalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x000BC89F File Offset: 0x000BAA9F
		static ConfigFeedingAnimalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFeedingAnimalById.CreateStaticDefaultValue), new Action(ConfigFeedingAnimalById.ResetStaticDefaultValue));
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x000BC8C0 File Offset: 0x000BAAC0
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

		// Token: 0x060010E7 RID: 4327 RVA: 0x000BC93F File Offset: 0x000BAB3F
		public static void ResetStaticDefaultValue()
		{
			ConfigFeedingAnimalById.LogPair = null;
			ConfigFeedingAnimalById.HandleId = 0;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x000BC94D File Offset: 0x000BAB4D
		public static void Init()
		{
			ConfigFeedingAnimalById.HandleId = ConfigCommon.InitDataStatement(ConfigFeedingAnimalById.HandleId, "db_feedinganimal.db", "select BinData from `FeedingAnimal` where Id=?");
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000BC968 File Offset: 0x000BAB68
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

		// Token: 0x04001394 RID: 5012
		private const string DB = "db_feedinganimal.db";

		// Token: 0x04001395 RID: 5013
		private const string FILE = "t.投喂动物.xlsx";

		// Token: 0x04001396 RID: 5014
		private const string TABLE = "FeedingAnimal";

		// Token: 0x04001397 RID: 5015
		private const string COMMAND = "select BinData from `FeedingAnimal` where Id=?";

		// Token: 0x04001398 RID: 5016
		private const string KEY_PREFIX = "FeedingAnimalById";

		// Token: 0x04001399 RID: 5017
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400139A RID: 5018
		private static int HandleId;
	}
}
