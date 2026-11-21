using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089D RID: 2205
	public class ConfigRogueWhiteCatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x001816B4 File Offset: 0x0017F8B4
		static ConfigRogueWhiteCatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatById.ResetStaticDefaultValue));
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x001816D4 File Offset: 0x0017F8D4
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

		// Token: 0x060033C2 RID: 13250 RVA: 0x00181753 File Offset: 0x0017F953
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatById.LogPair = null;
			ConfigRogueWhiteCatById.HandleId = 0;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00181761 File Offset: 0x0017F961
		public static void Init()
		{
			ConfigRogueWhiteCatById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCat` where Id=?");
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x0018177C File Offset: 0x0017F97C
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

		// Token: 0x04003C31 RID: 15409
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003C32 RID: 15410
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003C33 RID: 15411
		private const string TABLE = "RogueWhiteCat";

		// Token: 0x04003C34 RID: 15412
		private const string COMMAND = "select BinData from `RogueWhiteCat` where Id=?";

		// Token: 0x04003C35 RID: 15413
		private const string KEY_PREFIX = "RogueWhiteCatById";

		// Token: 0x04003C36 RID: 15414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C37 RID: 15415
		private static int HandleId;
	}
}
