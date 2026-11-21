using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089E RID: 2206
	public class ConfigRogueWhiteCatInstById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033C6 RID: 13254 RVA: 0x001818FC File Offset: 0x0017FAFC
		static ConfigRogueWhiteCatInstById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatInstById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatInstById.ResetStaticDefaultValue));
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0018191C File Offset: 0x0017FB1C
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

		// Token: 0x060033C8 RID: 13256 RVA: 0x0018199B File Offset: 0x0017FB9B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatInstById.LogPair = null;
			ConfigRogueWhiteCatInstById.HandleId = 0;
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x001819A9 File Offset: 0x0017FBA9
		public static void Init()
		{
			ConfigRogueWhiteCatInstById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatInstById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatInst` where Id=?");
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x001819C4 File Offset: 0x0017FBC4
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

		// Token: 0x04003C38 RID: 15416
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003C39 RID: 15417
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003C3A RID: 15418
		private const string TABLE = "RogueWhiteCatInst";

		// Token: 0x04003C3B RID: 15419
		private const string COMMAND = "select BinData from `RogueWhiteCatInst` where Id=?";

		// Token: 0x04003C3C RID: 15420
		private const string KEY_PREFIX = "RogueWhiteCatInstById";

		// Token: 0x04003C3D RID: 15421
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C3E RID: 15422
		private static int HandleId;
	}
}
