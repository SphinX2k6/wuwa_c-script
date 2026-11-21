using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000399 RID: 921
	public class ConfigGenderTextByMaleText : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x000D75D0 File Offset: 0x000D57D0
		static ConfigGenderTextByMaleText()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenderTextByMaleText.CreateStaticDefaultValue), new Action(ConfigGenderTextByMaleText.ResetStaticDefaultValue));
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000D75F0 File Offset: 0x000D57F0
		public static void CreateStaticDefaultValue()
		{
			ConfigGenderTextByMaleText.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGenderTextByMaleText.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gender_text.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/x.性别通配符表/*.csv*"),
				new ValueTuple<string, object>("表名", "GenderText"),
				new ValueTuple<string, object>("语句", "select BinData from `GenderText` where MaleText=?")
			});
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000D766F File Offset: 0x000D586F
		public static void ResetStaticDefaultValue()
		{
			ConfigGenderTextByMaleText.LogPair = null;
			ConfigGenderTextByMaleText.HandleId = 0;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000D767D File Offset: 0x000D587D
		public static void Init()
		{
			ConfigGenderTextByMaleText.HandleId = ConfigCommon.InitDataStatement(ConfigGenderTextByMaleText.HandleId, "db_gender_text.db", "select BinData from `GenderText` where MaleText=?");
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000D7698 File Offset: 0x000D5898
		public static GenderText? GetConfig(string p0MaleText, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGenderTextByMaleText.HandleId, ConfigGenderTextByMaleText.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GenderTextByMaleText#" + p0MaleText);
				if (configBuffer != null)
				{
					return new GenderText?(GenderText.GetRootAsGenderText(configBuffer));
				}
			}
			ConfigGenderTextByMaleText.LogPair.Clear();
			ConfigGenderTextByMaleText.LogPair.Add(new ValueTuple<string, object>("MaleText", p0MaleText));
			if (!ConfigCommon.BindString(ConfigGenderTextByMaleText.HandleId, 1, p0MaleText, ConfigGenderTextByMaleText.LogPair) || ConfigCommon.Step(ConfigGenderTextByMaleText.HandleId, true, ConfigGenderTextByMaleText.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGenderTextByMaleText.HandleId, ConfigGenderTextByMaleText.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGenderTextByMaleText.HandleId, 0, ConfigGenderTextByMaleText.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGenderTextByMaleText.HandleId, ConfigGenderTextByMaleText.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GenderText rootAsGenderText = GenderText.GetRootAsGenderText(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GenderTextByMaleText#" + p0MaleText, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGenderTextByMaleText.HandleId, ConfigGenderTextByMaleText.LogPair);
			return new GenderText?(rootAsGenderText);
		}

		// Token: 0x04001913 RID: 6419
		private const string DB = "db_gender_text.db";

		// Token: 0x04001914 RID: 6420
		private const string FILE = "k.可视化编辑/c.Csv/x.性别通配符表/*.csv*";

		// Token: 0x04001915 RID: 6421
		private const string TABLE = "GenderText";

		// Token: 0x04001916 RID: 6422
		private const string COMMAND = "select BinData from `GenderText` where MaleText=?";

		// Token: 0x04001917 RID: 6423
		private const string KEY_PREFIX = "GenderTextByMaleText";

		// Token: 0x04001918 RID: 6424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001919 RID: 6425
		private static int HandleId;
	}
}
