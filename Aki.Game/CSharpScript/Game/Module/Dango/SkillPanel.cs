using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AC3 RID: 19139
	internal class SkillPanel : UiPanelBase
	{
		// Token: 0x0602FE0C RID: 196108 RVA: 0x00D5CAD6 File Offset: 0x00D5ACD6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602FE0D RID: 196109 RVA: 0x00D5CB10 File Offset: 0x00D5AD10
		[NullableContext(1)]
		public void Refresh(AbyssDangoRoleData data)
		{
			if (this.SkillType == ESkillShowType.Skill)
			{
				string skillDesc = data.GetSkillDesc();
				string[] skillDescAddition = data.GetSkillDescAddition();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), skillDesc, skillDescAddition);
				this.SetActive(true);
				return;
			}
			string[] effectPassiveSkillDescList = data.GetEffectPassiveSkillDescList();
			string text = string.Empty;
			int num = effectPassiveSkillDescList.Length;
			for (int i = 0; i < num; i++)
			{
				text = text + effectPassiveSkillDescList[i] + ((i != num - 1) ? "\n\n" : string.Empty);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
			this.SetActive(effectPassiveSkillDescList.Length != 0);
		}

		// Token: 0x040196B6 RID: 104118
		public ESkillShowType SkillType;
	}
}
