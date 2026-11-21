using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E77 RID: 7799
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillEffectItem : UiPanelBase
{
	// Token: 0x06013492 RID: 78994 RVA: 0x005A2D56 File Offset: 0x005A0F56
	public RoleSkillEffectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013493 RID: 78995 RVA: 0x005A2D6C File Offset: 0x005A0F6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013494 RID: 78996 RVA: 0x005A2DC8 File Offset: 0x005A0FC8
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

	// Token: 0x06013495 RID: 78997 RVA: 0x005A2E54 File Offset: 0x005A1054
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

	// Token: 0x0200814A RID: 33098
	[NullableContext(0)]
	private enum ERoleSkillEffectItemDefine
	{
		// Token: 0x04029CE6 RID: 171238
		EffectText,
		// Token: 0x04029CE7 RID: 171239
		EffectCurrentValue,
		// Token: 0x04029CE8 RID: 171240
		EffectNextValue
	}
}
