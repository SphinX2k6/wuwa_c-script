using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CE RID: 718
	public class ConfigFindSunSpiritById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x000B8AB4 File Offset: 0x000B6CB4
		static ConfigFindSunSpiritById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFindSunSpiritById.CreateStaticDefaultValue), new Action(ConfigFindSunSpiritById.ResetStaticDefaultValue));
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000B8AD4 File Offset: 0x000B6CD4
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

		// Token: 0x060010DB RID: 4315 RVA: 0x000B8B53 File Offset: 0x000B6D53
		public static void ResetStaticDefaultValue()
		{
			ConfigFindSunSpiritById.LogPair = null;
			ConfigFindSunSpiritById.HandleId = 0;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000B8B61 File Offset: 0x000B6D61
		public static void Init()
		{
			ConfigFindSunSpiritById.HandleId = ConfigCommon.InitDataStatement(ConfigFindSunSpiritById.HandleId, "db_findsunspirit.db", "select BinData from `FindSunSpirit` where Id=?");
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000B8B7C File Offset: 0x000B6D7C
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

		// Token: 0x04001386 RID: 4998
		private const string DB = "db_findsunspirit.db";

		// Token: 0x04001387 RID: 4999
		private const string FILE = "k.可视化编辑/c.Csv/z.找日灵配置/*.csv*";

		// Token: 0x04001388 RID: 5000
		private const string TABLE = "FindSunSpirit";

		// Token: 0x04001389 RID: 5001
		private const string COMMAND = "select BinData from `FindSunSpirit` where Id=?";

		// Token: 0x0400138A RID: 5002
		private const string KEY_PREFIX = "FindSunSpiritById";

		// Token: 0x0400138B RID: 5003
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400138C RID: 5004
		private static int HandleId;
	}
}
