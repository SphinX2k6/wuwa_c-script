using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000998 RID: 2456
	public class ConfigSkillVehicleButtonByTemplateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039A3 RID: 14755 RVA: 0x001A28A0 File Offset: 0x001A0AA0
		static ConfigSkillVehicleButtonByTemplateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillVehicleButtonByTemplateId.CreateStaticDefaultValue), new Action(ConfigSkillVehicleButtonByTemplateId.ResetStaticDefaultValue));
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x001A28C0 File Offset: 0x001A0AC0
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillVehicleButtonByTemplateId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillVehicleButtonByTemplateId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillVehicleButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillVehicleButton` where TemplateId=?")
			});
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x001A293F File Offset: 0x001A0B3F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillVehicleButtonByTemplateId.LogPair = null;
			ConfigSkillVehicleButtonByTemplateId.HandleId = 0;
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x001A294D File Offset: 0x001A0B4D
		public static void Init()
		{
			ConfigSkillVehicleButtonByTemplateId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillVehicleButtonByTemplateId.HandleId, "db_skillbutton.db", "select BinData from `SkillVehicleButton` where TemplateId=?");
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x001A2968 File Offset: 0x001A0B68
		[NullableContext(2)]
		public static IReadOnlyList<SkillVehicleButton> GetConfigList(int p0TemplateId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillVehicleButtonByTemplateId.HandleId, ConfigSkillVehicleButtonByTemplateId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillVehicleButtonByTemplateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TemplateId);
				IReadOnlyList<SkillVehicleButton> readOnlyList = (IReadOnlyList<SkillVehicleButton>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillVehicleButtonByTemplateId.LogPair.Clear();
			ConfigSkillVehicleButtonByTemplateId.LogPair.Add(new ValueTuple<string, object>("TemplateId", p0TemplateId));
			if (!ConfigCommon.BindInt(ConfigSkillVehicleButtonByTemplateId.HandleId, 1, p0TemplateId, ConfigSkillVehicleButtonByTemplateId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillVehicleButtonByTemplateId.HandleId, ConfigSkillVehicleButtonByTemplateId.LogPair);
				return null;
			}
			List<SkillVehicleButton> list = new List<SkillVehicleButton>();
			while (ConfigCommon.Step(ConfigSkillVehicleButtonByTemplateId.HandleId, false, ConfigSkillVehicleButtonByTemplateId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillVehicleButtonByTemplateId.HandleId, 0, ConfigSkillVehicleButtonByTemplateId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillVehicleButtonByTemplateId.HandleId, ConfigSkillVehicleButtonByTemplateId.LogPair);
					return null;
				}
				SkillVehicleButton rootAsSkillVehicleButton = SkillVehicleButton.GetRootAsSkillVehicleButton(new ByteBuffer(item2));
				list.Add(rootAsSkillVehicleButton);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillVehicleButtonByTemplateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TemplateId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillVehicleButtonByTemplateId.HandleId, ConfigSkillVehicleButtonByTemplateId.LogPair);
			return list;
		}

		// Token: 0x0400430E RID: 17166
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400430F RID: 17167
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004310 RID: 17168
		private const string TABLE = "SkillVehicleButton";

		// Token: 0x04004311 RID: 17169
		private const string COMMAND = "select BinData from `SkillVehicleButton` where TemplateId=?";

		// Token: 0x04004312 RID: 17170
		private const string KEY_PREFIX = "SkillVehicleButtonByTemplateId";

		// Token: 0x04004313 RID: 17171
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004314 RID: 17172
		private static int HandleId;
	}
}
