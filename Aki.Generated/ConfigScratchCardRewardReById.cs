using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FC RID: 2300
	public class ConfigScratchCardRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035FB RID: 13819 RVA: 0x0018A73C File Offset: 0x0018893C
		static ConfigScratchCardRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRewardReById.CreateStaticDefaultValue), new Action(ConfigScratchCardRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x0018A75C File Offset: 0x0018895C
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

		// Token: 0x060035FD RID: 13821 RVA: 0x0018A7DB File Offset: 0x001889DB
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRewardReById.LogPair = null;
			ConfigScratchCardRewardReById.HandleId = 0;
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0018A7E9 File Offset: 0x001889E9
		public static void Init()
		{
			ConfigScratchCardRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRewardReById.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRewardRe` where Id=?");
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0018A804 File Offset: 0x00188A04
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

		// Token: 0x04003ECA RID: 16074
		private const string DB = "db_scratchcard.db";

		// Token: 0x04003ECB RID: 16075
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x04003ECC RID: 16076
		private const string TABLE = "ScratchCardRewardRe";

		// Token: 0x04003ECD RID: 16077
		private const string COMMAND = "select BinData from `ScratchCardRewardRe` where Id=?";

		// Token: 0x04003ECE RID: 16078
		private const string KEY_PREFIX = "ScratchCardRewardReById";

		// Token: 0x04003ECF RID: 16079
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ED0 RID: 16080
		private static int HandleId;
	}
}
