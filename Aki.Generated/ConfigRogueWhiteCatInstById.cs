using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000882 RID: 2178
	public class ConfigRogueWhiteCatInstById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600331E RID: 13086 RVA: 0x0017A614 File Offset: 0x00178814
		static ConfigRogueWhiteCatInstById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatInstById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatInstById.ResetStaticDefaultValue));
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0017A634 File Offset: 0x00178834
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWhiteCatInstById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWhiteCatInstById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWhiteCatInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWhiteCatInst` where Id=?")
			});
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x0017A6B3 File Offset: 0x001788B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatInstById.LogPair = null;
			ConfigRogueWhiteCatInstById.HandleId = 0;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0017A6C1 File Offset: 0x001788C1
		public static void Init()
		{
			ConfigRogueWhiteCatInstById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatInstById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatInst` where Id=?");
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0017A6DC File Offset: 0x001788DC
		public static RogueWhiteCatInst? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWhiteCatInstById.HandleId, ConfigRogueWhiteCatInstById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWhiteCatInst?(RogueWhiteCatInst.GetRootAsRogueWhiteCatInst(configBuffer));
				}
			}
			ConfigRogueWhiteCatInstById.LogPair.Clear();
			ConfigRogueWhiteCatInstById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWhiteCatInstById.HandleId, 1, p0Id, ConfigRogueWhiteCatInstById.LogPair) || ConfigCommon.Step(ConfigRogueWhiteCatInstById.HandleId, true, ConfigRogueWhiteCatInstById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatInstById.HandleId, ConfigRogueWhiteCatInstById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWhiteCatInstById.HandleId, 0, ConfigRogueWhiteCatInstById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatInstById.HandleId, ConfigRogueWhiteCatInstById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWhiteCatInst rootAsRogueWhiteCatInst = RogueWhiteCatInst.GetRootAsRogueWhiteCatInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWhiteCatInstById.HandleId, ConfigRogueWhiteCatInstById.LogPair);
			return new RogueWhiteCatInst?(rootAsRogueWhiteCatInst);
		}

		// Token: 0x04003B74 RID: 15220
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003B75 RID: 15221
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003B76 RID: 15222
		private const string TABLE = "RogueWhiteCatInst";

		// Token: 0x04003B77 RID: 15223
		private const string COMMAND = "select BinData from `RogueWhiteCatInst` where Id=?";

		// Token: 0x04003B78 RID: 15224
		private const string KEY_PREFIX = "RogueWhiteCatInstById";

		// Token: 0x04003B79 RID: 15225
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B7A RID: 15226
		private static int HandleId;
	}
}
