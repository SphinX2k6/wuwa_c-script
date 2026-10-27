using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093A RID: 2362
	public class ConfigSkillButtonTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600376F RID: 14191 RVA: 0x00192C57 File Offset: 0x00190E57
		static ConfigSkillButtonTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonTextById.CreateStaticDefaultValue), new Action(ConfigSkillButtonTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00192C78 File Offset: 0x00190E78
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

		// Token: 0x06003771 RID: 14193 RVA: 0x00192CF7 File Offset: 0x00190EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonTextById.LogPair = null;
			ConfigSkillButtonTextById.HandleId = 0;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00192D05 File Offset: 0x00190F05
		public static void Init()
		{
			ConfigSkillButtonTextById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonTextById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonText` where Id=?");
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00192D20 File Offset: 0x00190F20
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

		// Token: 0x0400407C RID: 16508
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400407D RID: 16509
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x0400407E RID: 16510
		private const string TABLE = "SkillButtonText";

		// Token: 0x0400407F RID: 16511
		private const string COMMAND = "select BinData from `SkillButtonText` where Id=?";

		// Token: 0x04004080 RID: 16512
		private const string KEY_PREFIX = "SkillButtonTextById";

		// Token: 0x04004081 RID: 16513
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004082 RID: 16514
		private static int HandleId;
	}
}
