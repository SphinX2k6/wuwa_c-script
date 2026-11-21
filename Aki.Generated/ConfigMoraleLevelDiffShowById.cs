using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057F RID: 1407
	public class ConfigMoraleLevelDiffShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x001179EB File Offset: 0x00115BEB
		static ConfigMoraleLevelDiffShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffShowById.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00117A0C File Offset: 0x00115C0C
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLevelDiffShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLevelDiffShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLevelDiffShow` where Id=?")
			});
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00117A8B File Offset: 0x00115C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowById.LogPair = null;
			ConfigMoraleLevelDiffShowById.HandleId = 0;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00117A99 File Offset: 0x00115C99
		public static void Init()
		{
			ConfigMoraleLevelDiffShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffShowById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiffShow` where Id=?");
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00117AB4 File Offset: 0x00115CB4
		public static MoraleLevelDiffShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLevelDiffShowById.HandleId, ConfigMoraleLevelDiffShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleLevelDiffShow?(MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(configBuffer));
				}
			}
			ConfigMoraleLevelDiffShowById.LogPair.Clear();
			ConfigMoraleLevelDiffShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoraleLevelDiffShowById.HandleId, 1, p0Id, ConfigMoraleLevelDiffShowById.LogPair) || ConfigCommon.Step(ConfigMoraleLevelDiffShowById.HandleId, true, ConfigMoraleLevelDiffShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffShowById.HandleId, ConfigMoraleLevelDiffShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLevelDiffShowById.HandleId, 0, ConfigMoraleLevelDiffShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffShowById.HandleId, ConfigMoraleLevelDiffShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleLevelDiffShow rootAsMoraleLevelDiffShow = MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleLevelDiffShowById.HandleId, ConfigMoraleLevelDiffShowById.LogPair);
			return new MoraleLevelDiffShow?(rootAsMoraleLevelDiffShow);
		}

		// Token: 0x0400265D RID: 9821
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400265E RID: 9822
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400265F RID: 9823
		private const string TABLE = "MoraleLevelDiffShow";

		// Token: 0x04002660 RID: 9824
		private const string COMMAND = "select BinData from `MoraleLevelDiffShow` where Id=?";

		// Token: 0x04002661 RID: 9825
		private const string KEY_PREFIX = "MoraleLevelDiffShowById";

		// Token: 0x04002662 RID: 9826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002663 RID: 9827
		private static int HandleId;
	}
}
