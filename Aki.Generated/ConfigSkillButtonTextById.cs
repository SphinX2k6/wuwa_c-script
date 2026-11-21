using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000985 RID: 2437
	public class ConfigSkillButtonTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003931 RID: 14641 RVA: 0x0019FE77 File Offset: 0x0019E077
		static ConfigSkillButtonTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonTextById.CreateStaticDefaultValue), new Action(ConfigSkillButtonTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0019FE98 File Offset: 0x0019E098
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonText"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonText` where Id=?")
			});
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0019FF17 File Offset: 0x0019E117
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonTextById.LogPair = null;
			ConfigSkillButtonTextById.HandleId = 0;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0019FF25 File Offset: 0x0019E125
		public static void Init()
		{
			ConfigSkillButtonTextById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonTextById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonText` where Id=?");
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0019FF40 File Offset: 0x0019E140
		public static SkillButtonText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonTextById.HandleId, ConfigSkillButtonTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillButtonText?(SkillButtonText.GetRootAsSkillButtonText(configBuffer));
				}
			}
			ConfigSkillButtonTextById.LogPair.Clear();
			ConfigSkillButtonTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillButtonTextById.HandleId, 1, p0Id, ConfigSkillButtonTextById.LogPair) || ConfigCommon.Step(ConfigSkillButtonTextById.HandleId, true, ConfigSkillButtonTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillButtonTextById.HandleId, ConfigSkillButtonTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonTextById.HandleId, 0, ConfigSkillButtonTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillButtonTextById.HandleId, ConfigSkillButtonTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillButtonText rootAsSkillButtonText = SkillButtonText.GetRootAsSkillButtonText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillButtonTextById.HandleId, ConfigSkillButtonTextById.LogPair);
			return new SkillButtonText?(rootAsSkillButtonText);
		}

		// Token: 0x04004289 RID: 17033
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400428A RID: 17034
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x0400428B RID: 17035
		private const string TABLE = "SkillButtonText";

		// Token: 0x0400428C RID: 17036
		private const string COMMAND = "select BinData from `SkillButtonText` where Id=?";

		// Token: 0x0400428D RID: 17037
		private const string KEY_PREFIX = "SkillButtonTextById";

		// Token: 0x0400428E RID: 17038
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400428F RID: 17039
		private static int HandleId;
	}
}
