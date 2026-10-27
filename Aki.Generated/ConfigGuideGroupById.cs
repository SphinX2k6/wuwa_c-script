using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C0 RID: 960
	public class ConfigGuideGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001687 RID: 5767 RVA: 0x000D8DDB File Offset: 0x000D6FDB
		static ConfigGuideGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideGroupById.CreateStaticDefaultValue), new Action(ConfigGuideGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000D8DFC File Offset: 0x000D6FFC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideGroup` where Id=?")
			});
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000D8E7B File Offset: 0x000D707B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideGroupById.LogPair = null;
			ConfigGuideGroupById.HandleId = 0;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000D8E89 File Offset: 0x000D7089
		public static void Init()
		{
			ConfigGuideGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideGroupById.HandleId, "db_guide_new.db", "select BinData from `GuideGroup` where Id=?");
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000D8EA4 File Offset: 0x000D70A4
		public static GuideGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideGroupById.HandleId, ConfigGuideGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideGroup?(GuideGroup.GetRootAsGuideGroup(configBuffer));
				}
			}
			ConfigGuideGroupById.LogPair.Clear();
			ConfigGuideGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideGroupById.HandleId, 1, p0Id, ConfigGuideGroupById.LogPair) || ConfigCommon.Step(ConfigGuideGroupById.HandleId, true, ConfigGuideGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideGroupById.HandleId, ConfigGuideGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideGroupById.HandleId, 0, ConfigGuideGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideGroupById.HandleId, ConfigGuideGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideGroup rootAsGuideGroup = GuideGroup.GetRootAsGuideGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideGroupById.HandleId, ConfigGuideGroupById.LogPair);
			return new GuideGroup?(rootAsGuideGroup);
		}

		// Token: 0x04001A24 RID: 6692
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A25 RID: 6693
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A26 RID: 6694
		private const string TABLE = "GuideGroup";

		// Token: 0x04001A27 RID: 6695
		private const string COMMAND = "select BinData from `GuideGroup` where Id=?";

		// Token: 0x04001A28 RID: 6696
		private const string KEY_PREFIX = "GuideGroupById";

		// Token: 0x04001A29 RID: 6697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A2A RID: 6698
		private static int HandleId;
	}
}
