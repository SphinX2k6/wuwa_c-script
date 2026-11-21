using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EE RID: 750
	public class ConfigFishingEntrustTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x000C06BC File Offset: 0x000BE8BC
		static ConfigFishingEntrustTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustTypeById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000C06DC File Offset: 0x000BE8DC
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrustType"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrustType` where Id=?")
			});
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x000C075B File Offset: 0x000BE95B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustTypeById.LogPair = null;
			ConfigFishingEntrustTypeById.HandleId = 0;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000C0769 File Offset: 0x000BE969
		public static void Init()
		{
			ConfigFishingEntrustTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustTypeById.HandleId, "db_fishing.db", "select BinData from `FishingEntrustType` where Id=?");
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000C0784 File Offset: 0x000BE984
		public static FishingEntrustType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingEntrustType?(FishingEntrustType.GetRootAsFishingEntrustType(configBuffer));
				}
			}
			ConfigFishingEntrustTypeById.LogPair.Clear();
			ConfigFishingEntrustTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingEntrustTypeById.HandleId, 1, p0Id, ConfigFishingEntrustTypeById.LogPair) || ConfigCommon.Step(ConfigFishingEntrustTypeById.HandleId, true, ConfigFishingEntrustTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustTypeById.HandleId, 0, ConfigFishingEntrustTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingEntrustType rootAsFishingEntrustType = FishingEntrustType.GetRootAsFishingEntrustType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
			return new FishingEntrustType?(rootAsFishingEntrustType);
		}

		// Token: 0x04001466 RID: 5222
		private const string DB = "db_fishing.db";

		// Token: 0x04001467 RID: 5223
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x04001468 RID: 5224
		private const string TABLE = "FishingEntrustType";

		// Token: 0x04001469 RID: 5225
		private const string COMMAND = "select BinData from `FishingEntrustType` where Id=?";

		// Token: 0x0400146A RID: 5226
		private const string KEY_PREFIX = "FishingEntrustTypeById";

		// Token: 0x0400146B RID: 5227
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400146C RID: 5228
		private static int HandleId;
	}
}
