using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FB RID: 2299
	public class ConfigScratchCardActivityReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035F5 RID: 13813 RVA: 0x0018A4F4 File Offset: 0x001886F4
		static ConfigScratchCardActivityReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardActivityReById.CreateStaticDefaultValue), new Action(ConfigScratchCardActivityReById.ResetStaticDefaultValue));
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0018A514 File Offset: 0x00188714
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardActivityReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardActivityReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardActivityRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardActivityRe` where Id=?")
			});
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0018A593 File Offset: 0x00188793
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardActivityReById.LogPair = null;
			ConfigScratchCardActivityReById.HandleId = 0;
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0018A5A1 File Offset: 0x001887A1
		public static void Init()
		{
			ConfigScratchCardActivityReById.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardActivityReById.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardActivityRe` where Id=?");
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0018A5BC File Offset: 0x001887BC
		public static ScratchCardActivityRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardActivityReById.HandleId, ConfigScratchCardActivityReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardActivityReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScratchCardActivityRe?(ScratchCardActivityRe.GetRootAsScratchCardActivityRe(configBuffer));
				}
			}
			ConfigScratchCardActivityReById.LogPair.Clear();
			ConfigScratchCardActivityReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigScratchCardActivityReById.HandleId, 1, p0Id, ConfigScratchCardActivityReById.LogPair) || ConfigCommon.Step(ConfigScratchCardActivityReById.HandleId, true, ConfigScratchCardActivityReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScratchCardActivityReById.HandleId, ConfigScratchCardActivityReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardActivityReById.HandleId, 0, ConfigScratchCardActivityReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScratchCardActivityReById.HandleId, ConfigScratchCardActivityReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScratchCardActivityRe rootAsScratchCardActivityRe = ScratchCardActivityRe.GetRootAsScratchCardActivityRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardActivityReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScratchCardActivityReById.HandleId, ConfigScratchCardActivityReById.LogPair);
			return new ScratchCardActivityRe?(rootAsScratchCardActivityRe);
		}

		// Token: 0x04003EC3 RID: 16067
		private const string DB = "db_scratchcard.db";

		// Token: 0x04003EC4 RID: 16068
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x04003EC5 RID: 16069
		private const string TABLE = "ScratchCardActivityRe";

		// Token: 0x04003EC6 RID: 16070
		private const string COMMAND = "select BinData from `ScratchCardActivityRe` where Id=?";

		// Token: 0x04003EC7 RID: 16071
		private const string KEY_PREFIX = "ScratchCardActivityReById";

		// Token: 0x04003EC8 RID: 16072
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EC9 RID: 16073
		private static int HandleId;
	}
}
