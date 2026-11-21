using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000304 RID: 772
	public class ConfigFishingTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x000C3603 File Offset: 0x000C1803
		static ConfigFishingTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechById.CreateStaticDefaultValue), new Action(ConfigFishingTechById.ResetStaticDefaultValue));
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000C3624 File Offset: 0x000C1824
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

		// Token: 0x0600121F RID: 4639 RVA: 0x000C36A3 File Offset: 0x000C18A3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechById.LogPair = null;
			ConfigFishingTechById.HandleId = 0;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000C36B1 File Offset: 0x000C18B1
		public static void Init()
		{
			ConfigFishingTechById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechById.HandleId, "db_fishing.db", "select BinData from `FishingTech` where Id=?");
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000C36CC File Offset: 0x000C18CC
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

		// Token: 0x04001500 RID: 5376
		private const string DB = "db_fishing.db";

		// Token: 0x04001501 RID: 5377
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001502 RID: 5378
		private const string TABLE = "FishingTech";

		// Token: 0x04001503 RID: 5379
		private const string COMMAND = "select BinData from `FishingTech` where Id=?";

		// Token: 0x04001504 RID: 5380
		private const string KEY_PREFIX = "FishingTechById";

		// Token: 0x04001505 RID: 5381
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001506 RID: 5382
		private static int HandleId;
	}
}
