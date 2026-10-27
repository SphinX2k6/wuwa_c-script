using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000881 RID: 2177
	public class ConfigRogueWhiteCatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x0017A3CC File Offset: 0x001785CC
		static ConfigRogueWhiteCatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatById.ResetStaticDefaultValue));
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0017A3EC File Offset: 0x001785EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWhiteCatById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWhiteCatById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWhiteCat"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWhiteCat` where Id=?")
			});
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x0017A46B File Offset: 0x0017866B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatById.LogPair = null;
			ConfigRogueWhiteCatById.HandleId = 0;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0017A479 File Offset: 0x00178679
		public static void Init()
		{
			ConfigRogueWhiteCatById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCat` where Id=?");
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0017A494 File Offset: 0x00178694
		public static RogueWhiteCat? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWhiteCatById.HandleId, ConfigRogueWhiteCatById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWhiteCat?(RogueWhiteCat.GetRootAsRogueWhiteCat(configBuffer));
				}
			}
			ConfigRogueWhiteCatById.LogPair.Clear();
			ConfigRogueWhiteCatById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWhiteCatById.HandleId, 1, p0Id, ConfigRogueWhiteCatById.LogPair) || ConfigCommon.Step(ConfigRogueWhiteCatById.HandleId, true, ConfigRogueWhiteCatById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatById.HandleId, ConfigRogueWhiteCatById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWhiteCatById.HandleId, 0, ConfigRogueWhiteCatById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatById.HandleId, ConfigRogueWhiteCatById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWhiteCat rootAsRogueWhiteCat = RogueWhiteCat.GetRootAsRogueWhiteCat(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWhiteCatById.HandleId, ConfigRogueWhiteCatById.LogPair);
			return new RogueWhiteCat?(rootAsRogueWhiteCat);
		}

		// Token: 0x04003B6D RID: 15213
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003B6E RID: 15214
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003B6F RID: 15215
		private const string TABLE = "RogueWhiteCat";

		// Token: 0x04003B70 RID: 15216
		private const string COMMAND = "select BinData from `RogueWhiteCat` where Id=?";

		// Token: 0x04003B71 RID: 15217
		private const string KEY_PREFIX = "RogueWhiteCatById";

		// Token: 0x04003B72 RID: 15218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B73 RID: 15219
		private static int HandleId;
	}
}
