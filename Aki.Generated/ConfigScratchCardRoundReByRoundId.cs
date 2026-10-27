using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FE RID: 2302
	public class ConfigScratchCardRoundReByRoundId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003607 RID: 13831 RVA: 0x0018ABBB File Offset: 0x00188DBB
		static ConfigScratchCardRoundReByRoundId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRoundReByRoundId.CreateStaticDefaultValue), new Action(ConfigScratchCardRoundReByRoundId.ResetStaticDefaultValue));
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x0018ABDC File Offset: 0x00188DDC
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardRoundReByRoundId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardRoundReByRoundId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardRoundRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardRoundRe` where RoundId=?")
			});
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0018AC5B File Offset: 0x00188E5B
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRoundReByRoundId.LogPair = null;
			ConfigScratchCardRoundReByRoundId.HandleId = 0;
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x0018AC69 File Offset: 0x00188E69
		public static void Init()
		{
			ConfigScratchCardRoundReByRoundId.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRoundReByRoundId.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRoundRe` where RoundId=?");
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x0018AC84 File Offset: 0x00188E84
		public static ScratchCardRoundRe? GetConfig(int p0RoundId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRoundReByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScratchCardRoundRe?(ScratchCardRoundRe.GetRootAsScratchCardRoundRe(configBuffer));
				}
			}
			ConfigScratchCardRoundReByRoundId.LogPair.Clear();
			ConfigScratchCardRoundReByRoundId.LogPair.Add(new ValueTuple<string, object>("RoundId", p0RoundId));
			if (!ConfigCommon.BindInt(ConfigScratchCardRoundReByRoundId.HandleId, 1, p0RoundId, ConfigScratchCardRoundReByRoundId.LogPair) || ConfigCommon.Step(ConfigScratchCardRoundReByRoundId.HandleId, true, ConfigScratchCardRoundReByRoundId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardRoundReByRoundId.HandleId, 0, ConfigScratchCardRoundReByRoundId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScratchCardRoundRe rootAsScratchCardRoundRe = ScratchCardRoundRe.GetRootAsScratchCardRoundRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRoundReByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
			return new ScratchCardRoundRe?(rootAsScratchCardRoundRe);
		}

		// Token: 0x04003ED8 RID: 16088
		private const string DB = "db_scratchcard.db";

		// Token: 0x04003ED9 RID: 16089
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x04003EDA RID: 16090
		private const string TABLE = "ScratchCardRoundRe";

		// Token: 0x04003EDB RID: 16091
		private const string COMMAND = "select BinData from `ScratchCardRoundRe` where RoundId=?";

		// Token: 0x04003EDC RID: 16092
		private const string KEY_PREFIX = "ScratchCardRoundReByRoundId";

		// Token: 0x04003EDD RID: 16093
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EDE RID: 16094
		private static int HandleId;
	}
}
