using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EF RID: 751
	public class ConfigFishingTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600119F RID: 4511 RVA: 0x000BD0F7 File Offset: 0x000BB2F7
		static ConfigFishingTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechById.CreateStaticDefaultValue), new Action(ConfigFishingTechById.ResetStaticDefaultValue));
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000BD118 File Offset: 0x000BB318
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTechById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTechById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTech"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTech` where Id=?")
			});
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000BD197 File Offset: 0x000BB397
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechById.LogPair = null;
			ConfigFishingTechById.HandleId = 0;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000BD1A5 File Offset: 0x000BB3A5
		public static void Init()
		{
			ConfigFishingTechById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechById.HandleId, "db_fishing.db", "select BinData from `FishingTech` where Id=?");
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000BD1C0 File Offset: 0x000BB3C0
		public static FishingTech? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTechById.HandleId, ConfigFishingTechById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingTech?(FishingTech.GetRootAsFishingTech(configBuffer));
				}
			}
			ConfigFishingTechById.LogPair.Clear();
			ConfigFishingTechById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingTechById.HandleId, 1, p0Id, ConfigFishingTechById.LogPair) || ConfigCommon.Step(ConfigFishingTechById.HandleId, true, ConfigFishingTechById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingTechById.HandleId, ConfigFishingTechById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTechById.HandleId, 0, ConfigFishingTechById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingTechById.HandleId, ConfigFishingTechById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingTech rootAsFishingTech = FishingTech.GetRootAsFishingTech(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingTechById.HandleId, ConfigFishingTechById.LogPair);
			return new FishingTech?(rootAsFishingTech);
		}

		// Token: 0x0400146D RID: 5229
		private const string DB = "db_fishing.db";

		// Token: 0x0400146E RID: 5230
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x0400146F RID: 5231
		private const string TABLE = "FishingTech";

		// Token: 0x04001470 RID: 5232
		private const string COMMAND = "select BinData from `FishingTech` where Id=?";

		// Token: 0x04001471 RID: 5233
		private const string KEY_PREFIX = "FishingTechById";

		// Token: 0x04001472 RID: 5234
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001473 RID: 5235
		private static int HandleId;
	}
}
