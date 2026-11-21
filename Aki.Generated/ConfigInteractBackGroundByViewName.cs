using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000466 RID: 1126
	public class ConfigInteractBackGroundByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x000F26DC File Offset: 0x000F08DC
		static ConfigInteractBackGroundByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractBackGroundByViewName.CreateStaticDefaultValue), new Action(ConfigInteractBackGroundByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000F26FC File Offset: 0x000F08FC
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

		// Token: 0x06001A70 RID: 6768 RVA: 0x000F277B File Offset: 0x000F097B
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractBackGroundByViewName.LogPair = null;
			ConfigInteractBackGroundByViewName.HandleId = 0;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000F2789 File Offset: 0x000F0989
		public static void Init()
		{
			ConfigInteractBackGroundByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigInteractBackGroundByViewName.HandleId, "db_commonbackground.db", "select BinData from `InteractBackGround` where ViewName=?");
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000F27A4 File Offset: 0x000F09A4
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

		// Token: 0x04001EAE RID: 7854
		private const string DB = "db_commonbackground.db";

		// Token: 0x04001EAF RID: 7855
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04001EB0 RID: 7856
		private const string TABLE = "InteractBackGround";

		// Token: 0x04001EB1 RID: 7857
		private const string COMMAND = "select BinData from `InteractBackGround` where ViewName=?";

		// Token: 0x04001EB2 RID: 7858
		private const string KEY_PREFIX = "InteractBackGroundByViewName";

		// Token: 0x04001EB3 RID: 7859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EB4 RID: 7860
		private static int HandleId;
	}
}
