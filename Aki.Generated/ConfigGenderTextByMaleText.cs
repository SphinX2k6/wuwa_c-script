using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000383 RID: 899
	public class ConfigGenderTextByMaleText : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001518 RID: 5400 RVA: 0x000D0E7C File Offset: 0x000CF07C
		static ConfigGenderTextByMaleText()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenderTextByMaleText.CreateStaticDefaultValue), new Action(ConfigGenderTextByMaleText.ResetStaticDefaultValue));
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000D0E9C File Offset: 0x000CF09C
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

		// Token: 0x0600151A RID: 5402 RVA: 0x000D0F1B File Offset: 0x000CF11B
		public static void ResetStaticDefaultValue()
		{
			ConfigGenderTextByMaleText.LogPair = null;
			ConfigGenderTextByMaleText.HandleId = 0;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000D0F29 File Offset: 0x000CF129
		public static void Init()
		{
			ConfigGenderTextByMaleText.HandleId = ConfigCommon.InitDataStatement(ConfigGenderTextByMaleText.HandleId, "db_gender_text.db", "select BinData from `GenderText` where MaleText=?");
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000D0F44 File Offset: 0x000CF144
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

		// Token: 0x04001879 RID: 6265
		private const string DB = "db_gender_text.db";

		// Token: 0x0400187A RID: 6266
		private const string FILE = "k.可视化编辑/c.Csv/x.性别通配符表/*.csv*";

		// Token: 0x0400187B RID: 6267
		private const string TABLE = "GenderText";

		// Token: 0x0400187C RID: 6268
		private const string COMMAND = "select BinData from `GenderText` where MaleText=?";

		// Token: 0x0400187D RID: 6269
		private const string KEY_PREFIX = "GenderTextByMaleText";

		// Token: 0x0400187E RID: 6270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400187F RID: 6271
		private static int HandleId;
	}
}
