using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000941 RID: 2369
	public class ConfigSkillFollowerButtonByPbDataId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003799 RID: 14233 RVA: 0x00193B7B File Offset: 0x00191D7B
		static ConfigSkillFollowerButtonByPbDataId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillFollowerButtonByPbDataId.CreateStaticDefaultValue), new Action(ConfigSkillFollowerButtonByPbDataId.ResetStaticDefaultValue));
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00193B9C File Offset: 0x00191D9C
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

		// Token: 0x0600379B RID: 14235 RVA: 0x00193C1B File Offset: 0x00191E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillFollowerButtonByPbDataId.LogPair = null;
			ConfigSkillFollowerButtonByPbDataId.HandleId = 0;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00193C29 File Offset: 0x00191E29
		public static void Init()
		{
			ConfigSkillFollowerButtonByPbDataId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillFollowerButtonByPbDataId.HandleId, "db_skillbutton.db", "select BinData from `SkillFollowerButton` where PbDataId=?");
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00193C44 File Offset: 0x00191E44
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

		// Token: 0x040040AD RID: 16557
		private const string DB = "db_skillbutton.db";

		// Token: 0x040040AE RID: 16558
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040040AF RID: 16559
		private const string TABLE = "SkillFollowerButton";

		// Token: 0x040040B0 RID: 16560
		private const string COMMAND = "select BinData from `SkillFollowerButton` where PbDataId=?";

		// Token: 0x040040B1 RID: 16561
		private const string KEY_PREFIX = "SkillFollowerButtonByPbDataId";

		// Token: 0x040040B2 RID: 16562
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040B3 RID: 16563
		private static int HandleId;
	}
}
