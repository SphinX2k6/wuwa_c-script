using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E3 RID: 739
	public class ConfigFindSunSpiritById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001157 RID: 4439 RVA: 0x000BEFC0 File Offset: 0x000BD1C0
		static ConfigFindSunSpiritById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFindSunSpiritById.CreateStaticDefaultValue), new Action(ConfigFindSunSpiritById.ResetStaticDefaultValue));
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000BEFE0 File Offset: 0x000BD1E0
		public static void CreateStaticDefaultValue()
		{
			ConfigFindSunSpiritById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFindSunSpiritById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_findsunspirit.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/z.找日灵配置/*.csv*"),
				new ValueTuple<string, object>("表名", "FindSunSpirit"),
				new ValueTuple<string, object>("语句", "select BinData from `FindSunSpirit` where Id=?")
			});
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000BF05F File Offset: 0x000BD25F
		public static void ResetStaticDefaultValue()
		{
			ConfigFindSunSpiritById.LogPair = null;
			ConfigFindSunSpiritById.HandleId = 0;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000BF06D File Offset: 0x000BD26D
		public static void Init()
		{
			ConfigFindSunSpiritById.HandleId = ConfigCommon.InitDataStatement(ConfigFindSunSpiritById.HandleId, "db_findsunspirit.db", "select BinData from `FindSunSpirit` where Id=?");
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000BF088 File Offset: 0x000BD288
		public static FindSunSpirit? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFindSunSpiritById.HandleId, ConfigFindSunSpiritById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FindSunSpiritById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FindSunSpirit?(FindSunSpirit.GetRootAsFindSunSpirit(configBuffer));
				}
			}
			ConfigFindSunSpiritById.LogPair.Clear();
			ConfigFindSunSpiritById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFindSunSpiritById.HandleId, 1, p0Id, ConfigFindSunSpiritById.LogPair) || ConfigCommon.Step(ConfigFindSunSpiritById.HandleId, true, ConfigFindSunSpiritById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFindSunSpiritById.HandleId, ConfigFindSunSpiritById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFindSunSpiritById.HandleId, 0, ConfigFindSunSpiritById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFindSunSpiritById.HandleId, ConfigFindSunSpiritById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FindSunSpirit rootAsFindSunSpirit = FindSunSpirit.GetRootAsFindSunSpirit(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FindSunSpiritById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFindSunSpiritById.HandleId, ConfigFindSunSpiritById.LogPair);
			return new FindSunSpirit?(rootAsFindSunSpirit);
		}

		// Token: 0x04001419 RID: 5145
		private const string DB = "db_findsunspirit.db";

		// Token: 0x0400141A RID: 5146
		private const string FILE = "k.可视化编辑/c.Csv/z.找日灵配置/*.csv*";

		// Token: 0x0400141B RID: 5147
		private const string TABLE = "FindSunSpirit";

		// Token: 0x0400141C RID: 5148
		private const string COMMAND = "select BinData from `FindSunSpirit` where Id=?";

		// Token: 0x0400141D RID: 5149
		private const string KEY_PREFIX = "FindSunSpiritById";

		// Token: 0x0400141E RID: 5150
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400141F RID: 5151
		private static int HandleId;
	}
}
