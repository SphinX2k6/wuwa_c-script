using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000569 RID: 1385
	public class ConfigMoraleLevelDiffShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00111297 File Offset: 0x0010F497
		static ConfigMoraleLevelDiffShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffShowById.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x001112B8 File Offset: 0x0010F4B8
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

		// Token: 0x06002085 RID: 8325 RVA: 0x00111337 File Offset: 0x0010F537
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowById.LogPair = null;
			ConfigMoraleLevelDiffShowById.HandleId = 0;
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00111345 File Offset: 0x0010F545
		public static void Init()
		{
			ConfigMoraleLevelDiffShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffShowById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiffShow` where Id=?");
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00111360 File Offset: 0x0010F560
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

		// Token: 0x040025C3 RID: 9667
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025C4 RID: 9668
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025C5 RID: 9669
		private const string TABLE = "MoraleLevelDiffShow";

		// Token: 0x040025C6 RID: 9670
		private const string COMMAND = "select BinData from `MoraleLevelDiffShow` where Id=?";

		// Token: 0x040025C7 RID: 9671
		private const string KEY_PREFIX = "MoraleLevelDiffShowById";

		// Token: 0x040025C8 RID: 9672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025C9 RID: 9673
		private static int HandleId;
	}
}
