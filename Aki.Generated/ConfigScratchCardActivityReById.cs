using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000946 RID: 2374
	public class ConfigScratchCardActivityReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037B7 RID: 14263 RVA: 0x00197714 File Offset: 0x00195914
		static ConfigScratchCardActivityReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardActivityReById.CreateStaticDefaultValue), new Action(ConfigScratchCardActivityReById.ResetStaticDefaultValue));
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00197734 File Offset: 0x00195934
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

		// Token: 0x060037B9 RID: 14265 RVA: 0x001977B3 File Offset: 0x001959B3
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardActivityReById.LogPair = null;
			ConfigScratchCardActivityReById.HandleId = 0;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x001977C1 File Offset: 0x001959C1
		public static void Init()
		{
			ConfigScratchCardActivityReById.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardActivityReById.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardActivityRe` where Id=?");
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x001977DC File Offset: 0x001959DC
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

		// Token: 0x040040D0 RID: 16592
		private const string DB = "db_scratchcard.db";

		// Token: 0x040040D1 RID: 16593
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x040040D2 RID: 16594
		private const string TABLE = "ScratchCardActivityRe";

		// Token: 0x040040D3 RID: 16595
		private const string COMMAND = "select BinData from `ScratchCardActivityRe` where Id=?";

		// Token: 0x040040D4 RID: 16596
		private const string KEY_PREFIX = "ScratchCardActivityReById";

		// Token: 0x040040D5 RID: 16597
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040D6 RID: 16598
		private static int HandleId;
	}
}
