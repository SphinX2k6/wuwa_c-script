using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094D RID: 2381
	public class ConfigSkillVehicleButtonByTemplateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037E1 RID: 14305 RVA: 0x00195680 File Offset: 0x00193880
		static ConfigSkillVehicleButtonByTemplateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillVehicleButtonByTemplateId.CreateStaticDefaultValue), new Action(ConfigSkillVehicleButtonByTemplateId.ResetStaticDefaultValue));
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x001956A0 File Offset: 0x001938A0
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

		// Token: 0x060037E3 RID: 14307 RVA: 0x0019571F File Offset: 0x0019391F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillVehicleButtonByTemplateId.LogPair = null;
			ConfigSkillVehicleButtonByTemplateId.HandleId = 0;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x0019572D File Offset: 0x0019392D
		public static void Init()
		{
			ConfigSkillVehicleButtonByTemplateId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillVehicleButtonByTemplateId.HandleId, "db_skillbutton.db", "select BinData from `SkillVehicleButton` where TemplateId=?");
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00195748 File Offset: 0x00193948
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

		// Token: 0x04004101 RID: 16641
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004102 RID: 16642
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004103 RID: 16643
		private const string TABLE = "SkillVehicleButton";

		// Token: 0x04004104 RID: 16644
		private const string COMMAND = "select BinData from `SkillVehicleButton` where TemplateId=?";

		// Token: 0x04004105 RID: 16645
		private const string KEY_PREFIX = "SkillVehicleButtonByTemplateId";

		// Token: 0x04004106 RID: 16646
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004107 RID: 16647
		private static int HandleId;
	}
}
