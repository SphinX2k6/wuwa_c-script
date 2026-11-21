using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000947 RID: 2375
	public class ConfigScratchCardRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037BD RID: 14269 RVA: 0x0019795C File Offset: 0x00195B5C
		static ConfigScratchCardRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRewardReById.CreateStaticDefaultValue), new Action(ConfigScratchCardRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x0019797C File Offset: 0x00195B7C
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardRewardReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardRewardReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardRewardRe` where Id=?")
			});
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x001979FB File Offset: 0x00195BFB
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRewardReById.LogPair = null;
			ConfigScratchCardRewardReById.HandleId = 0;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00197A09 File Offset: 0x00195C09
		public static void Init()
		{
			ConfigScratchCardRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRewardReById.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRewardRe` where Id=?");
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00197A24 File Offset: 0x00195C24
		public static ScratchCardRewardRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardRewardReById.HandleId, ConfigScratchCardRewardReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScratchCardRewardRe?(ScratchCardRewardRe.GetRootAsScratchCardRewardRe(configBuffer));
				}
			}
			ConfigScratchCardRewardReById.LogPair.Clear();
			ConfigScratchCardRewardReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigScratchCardRewardReById.HandleId, 1, p0Id, ConfigScratchCardRewardReById.LogPair) || ConfigCommon.Step(ConfigScratchCardRewardReById.HandleId, true, ConfigScratchCardRewardReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScratchCardRewardReById.HandleId, ConfigScratchCardRewardReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardRewardReById.HandleId, 0, ConfigScratchCardRewardReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScratchCardRewardReById.HandleId, ConfigScratchCardRewardReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScratchCardRewardRe rootAsScratchCardRewardRe = ScratchCardRewardRe.GetRootAsScratchCardRewardRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScratchCardRewardReById.HandleId, ConfigScratchCardRewardReById.LogPair);
			return new ScratchCardRewardRe?(rootAsScratchCardRewardRe);
		}

		// Token: 0x040040D7 RID: 16599
		private const string DB = "db_scratchcard.db";

		// Token: 0x040040D8 RID: 16600
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x040040D9 RID: 16601
		private const string TABLE = "ScratchCardRewardRe";

		// Token: 0x040040DA RID: 16602
		private const string COMMAND = "select BinData from `ScratchCardRewardRe` where Id=?";

		// Token: 0x040040DB RID: 16603
		private const string KEY_PREFIX = "ScratchCardRewardReById";

		// Token: 0x040040DC RID: 16604
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040DD RID: 16605
		private static int HandleId;
	}
}
