using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AE2 RID: 23266
	internal class SkillPanel : UiPanelBase
	{
		// Token: 0x0603AE9A RID: 241306 RVA: 0x00E0BDEE File Offset: 0x00E09FEE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603AE9B RID: 241307 RVA: 0x00E0BE28 File Offset: 0x00E0A028
		[NullableContext(1)]
		public void Refresh(AbyssDangoRoleData data)
		{
			if (this.SkillType == ESkillShowType.Skill)
			{
				string skillDesc = data.GetSkillDesc();
				string[] skillDescAddition = data.GetSkillDescAddition();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), skillDesc, skillDescAddition.ToArray<string>());
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

		// Token: 0x0401EBFA RID: 125946
		public ESkillShowType SkillType;
	}
}
