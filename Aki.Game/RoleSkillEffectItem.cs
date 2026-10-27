using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028FC RID: 10492
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillEffectItem : UiPanelBase
{
	// Token: 0x06015A8E RID: 88718 RVA: 0x00577E62 File Offset: 0x00576062
	public RoleSkillEffectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06015A8F RID: 88719 RVA: 0x00577E78 File Offset: 0x00576078
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06015A90 RID: 88720 RVA: 0x00577ED4 File Offset: 0x005760D4
	public void UpdateItem(OneSkillEffect currentValue, OneSkillEffect nextValue)
	{
		SkillDescription? roleSkillDescriptionConfigById = RoleSkillConfig.Instance.GetRoleSkillDescriptionConfigById(currentValue.Id);
		if (roleSkillDescriptionConfigById == null)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(roleSkillDescriptionConfigById.Value.AttributeName, null);
		base.GetText(0).SetText(localTextNew ?? "", true);
		base.GetText(1).SetText(this.GetAttrValueStr(roleSkillDescriptionConfigById.Value, currentValue), true);
		base.GetText(2).SetText(this.GetAttrValueStr(roleSkillDescriptionConfigById.Value, nextValue), true);
	}

	// Token: 0x06015A91 RID: 88721 RVA: 0x00577F60 File Offset: 0x00576160
	public string GetAttrValueStr(SkillDescription skillDescription, OneSkillEffect value)
	{
		string result;
		if (!string.IsNullOrEmpty(skillDescription.Description))
		{
			string format = ConfigMultiTextLang.GetLocalTextNew(skillDescription.Description, null) ?? "";
			object[] args = value.Desc.ToArray();
			result = string.Format(format, args);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			int count = value.Desc.Count;
			for (int i = 0; i < count; i++)
			{
				stringBuilder.Append(value.Desc[i]);
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x02008F02 RID: 36610
	[NullableContext(0)]
	private enum ERoleSkillEffectItemDefine
	{
		// Token: 0x0402E5EB RID: 189931
		EffectText,
		// Token: 0x0402E5EC RID: 189932
		EffectCurrentValue,
		// Token: 0x0402E5ED RID: 189933
		EffectNextValue
	}
}
