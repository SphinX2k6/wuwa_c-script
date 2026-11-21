using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098C RID: 2444
	public class ConfigSkillFollowerButtonByPbDataId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600395B RID: 14683 RVA: 0x001A0D9B File Offset: 0x0019EF9B
		static ConfigSkillFollowerButtonByPbDataId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillFollowerButtonByPbDataId.CreateStaticDefaultValue), new Action(ConfigSkillFollowerButtonByPbDataId.ResetStaticDefaultValue));
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x001A0DBC File Offset: 0x0019EFBC
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillFollowerButtonByPbDataId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillFollowerButtonByPbDataId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillFollowerButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillFollowerButton` where PbDataId=?")
			});
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x001A0E3B File Offset: 0x0019F03B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillFollowerButtonByPbDataId.LogPair = null;
			ConfigSkillFollowerButtonByPbDataId.HandleId = 0;
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x001A0E49 File Offset: 0x0019F049
		public static void Init()
		{
			ConfigSkillFollowerButtonByPbDataId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillFollowerButtonByPbDataId.HandleId, "db_skillbutton.db", "select BinData from `SkillFollowerButton` where PbDataId=?");
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x001A0E64 File Offset: 0x0019F064
		[NullableContext(2)]
		public static IReadOnlyList<SkillFollowerButton> GetConfigList(int p0PbDataId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillFollowerButtonByPbDataId.HandleId, ConfigSkillFollowerButtonByPbDataId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillFollowerButtonByPbDataId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PbDataId);
				IReadOnlyList<SkillFollowerButton> readOnlyList = (IReadOnlyList<SkillFollowerButton>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillFollowerButtonByPbDataId.LogPair.Clear();
			ConfigSkillFollowerButtonByPbDataId.LogPair.Add(new ValueTuple<string, object>("PbDataId", p0PbDataId));
			if (!ConfigCommon.BindInt(ConfigSkillFollowerButtonByPbDataId.HandleId, 1, p0PbDataId, ConfigSkillFollowerButtonByPbDataId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillFollowerButtonByPbDataId.HandleId, ConfigSkillFollowerButtonByPbDataId.LogPair);
				return null;
			}
			List<SkillFollowerButton> list = new List<SkillFollowerButton>();
			while (ConfigCommon.Step(ConfigSkillFollowerButtonByPbDataId.HandleId, false, ConfigSkillFollowerButtonByPbDataId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillFollowerButtonByPbDataId.HandleId, 0, ConfigSkillFollowerButtonByPbDataId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillFollowerButtonByPbDataId.HandleId, ConfigSkillFollowerButtonByPbDataId.LogPair);
					return null;
				}
				SkillFollowerButton rootAsSkillFollowerButton = SkillFollowerButton.GetRootAsSkillFollowerButton(new ByteBuffer(item2));
				list.Add(rootAsSkillFollowerButton);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillFollowerButtonByPbDataId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PbDataId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillFollowerButtonByPbDataId.HandleId, ConfigSkillFollowerButtonByPbDataId.LogPair);
			return list;
		}

		// Token: 0x040042BA RID: 17082
		private const string DB = "db_skillbutton.db";

		// Token: 0x040042BB RID: 17083
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040042BC RID: 17084
		private const string TABLE = "SkillFollowerButton";

		// Token: 0x040042BD RID: 17085
		private const string COMMAND = "select BinData from `SkillFollowerButton` where PbDataId=?";

		// Token: 0x040042BE RID: 17086
		private const string KEY_PREFIX = "SkillFollowerButtonByPbDataId";

		// Token: 0x040042BF RID: 17087
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042C0 RID: 17088
		private static int HandleId;
	}
}
