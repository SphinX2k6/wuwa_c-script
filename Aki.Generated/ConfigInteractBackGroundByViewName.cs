using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000450 RID: 1104
	public class ConfigInteractBackGroundByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019EA RID: 6634 RVA: 0x000EBF88 File Offset: 0x000EA188
		static ConfigInteractBackGroundByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractBackGroundByViewName.CreateStaticDefaultValue), new Action(ConfigInteractBackGroundByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x000EBFA8 File Offset: 0x000EA1A8
		public static void CreateStaticDefaultValue()
		{
			ConfigInteractBackGroundByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInteractBackGroundByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "InteractBackGround"),
				new ValueTuple<string, object>("语句", "select BinData from `InteractBackGround` where ViewName=?")
			});
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000EC027 File Offset: 0x000EA227
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractBackGroundByViewName.LogPair = null;
			ConfigInteractBackGroundByViewName.HandleId = 0;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x000EC035 File Offset: 0x000EA235
		public static void Init()
		{
			ConfigInteractBackGroundByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigInteractBackGroundByViewName.HandleId, "db_commonbackground.db", "select BinData from `InteractBackGround` where ViewName=?");
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000EC050 File Offset: 0x000EA250
		public static InteractBackGround? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInteractBackGroundByViewName.HandleId, ConfigInteractBackGroundByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("InteractBackGroundByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new InteractBackGround?(InteractBackGround.GetRootAsInteractBackGround(configBuffer));
				}
			}
			ConfigInteractBackGroundByViewName.LogPair.Clear();
			ConfigInteractBackGroundByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigInteractBackGroundByViewName.HandleId, 1, p0ViewName, ConfigInteractBackGroundByViewName.LogPair) || ConfigCommon.Step(ConfigInteractBackGroundByViewName.HandleId, true, ConfigInteractBackGroundByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundByViewName.HandleId, ConfigInteractBackGroundByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInteractBackGroundByViewName.HandleId, 0, ConfigInteractBackGroundByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundByViewName.HandleId, ConfigInteractBackGroundByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InteractBackGround rootAsInteractBackGround = InteractBackGround.GetRootAsInteractBackGround(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("InteractBackGroundByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInteractBackGroundByViewName.HandleId, ConfigInteractBackGroundByViewName.LogPair);
			return new InteractBackGround?(rootAsInteractBackGround);
		}

		// Token: 0x04001E14 RID: 7700
		private const string DB = "db_commonbackground.db";

		// Token: 0x04001E15 RID: 7701
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04001E16 RID: 7702
		private const string TABLE = "InteractBackGround";

		// Token: 0x04001E17 RID: 7703
		private const string COMMAND = "select BinData from `InteractBackGround` where ViewName=?";

		// Token: 0x04001E18 RID: 7704
		private const string KEY_PREFIX = "InteractBackGroundByViewName";

		// Token: 0x04001E19 RID: 7705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E1A RID: 7706
		private static int HandleId;
	}
}
