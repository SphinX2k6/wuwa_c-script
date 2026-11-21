using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004302 RID: 17154
	public class RogueResSkillDesc : UiPanelBase
	{
		// Token: 0x0602B617 RID: 177687 RVA: 0x00C316FC File Offset: 0x00C2F8FC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0602B618 RID: 177688 RVA: 0x00C3176C File Offset: 0x00C2F96C
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x0602B619 RID: 177689 RVA: 0x00C31774 File Offset: 0x00C2F974
		public void Refresh()
		{
			if (this.Data == null)
			{
				return;
			}
			RogueResTalentTreeDesc? config = ConfigRogueResTalentTreeDescById.GetConfig(this.Data.Value.Describe, true);
			int skillLevelById = ActivityPermanentRogueModel.Instance.GetSkillLevelById(this.Data.Value.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.TalentDesc, new <>z__ReadOnlySingleElementList<object>(config.Value.Args(skillLevelById - 1)));
			if (this.Index % 2 == 1)
			{
				base.GetSprite(2).useChangeColor = true;
			}
		}

		// Token: 0x040176DF RID: 95967
		public RogueResTalentTree? Data;

		// Token: 0x040176E0 RID: 95968
		public int Index;
	}
}
