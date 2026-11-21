using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D6 RID: 982
	public class ConfigGuideGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x000DF52F File Offset: 0x000DD72F
		static ConfigGuideGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideGroupById.CreateStaticDefaultValue), new Action(ConfigGuideGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000DF550 File Offset: 0x000DD750
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

		// Token: 0x0600170D RID: 5901 RVA: 0x000DF5CF File Offset: 0x000DD7CF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideGroupById.LogPair = null;
			ConfigGuideGroupById.HandleId = 0;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000DF5DD File Offset: 0x000DD7DD
		public static void Init()
		{
			ConfigGuideGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideGroupById.HandleId, "db_guide_new.db", "select BinData from `GuideGroup` where Id=?");
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
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

		// Token: 0x04001ABE RID: 6846
		private const string DB = "db_guide_new.db";

		// Token: 0x04001ABF RID: 6847
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AC0 RID: 6848
		private const string TABLE = "GuideGroup";

		// Token: 0x04001AC1 RID: 6849
		private const string COMMAND = "select BinData from `GuideGroup` where Id=?";

		// Token: 0x04001AC2 RID: 6850
		private const string KEY_PREFIX = "GuideGroupById";

		// Token: 0x04001AC3 RID: 6851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AC4 RID: 6852
		private static int HandleId;
	}
}
