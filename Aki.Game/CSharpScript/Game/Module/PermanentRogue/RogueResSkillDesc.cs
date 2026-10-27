using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005332 RID: 21298
	public class RogueResSkillDesc : UiPanelBase
	{
		// Token: 0x0603671B RID: 223003 RVA: 0x00CE3D2C File Offset: 0x00CE1F2C
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

		// Token: 0x0603671C RID: 223004 RVA: 0x00CE3D9C File Offset: 0x00CE1F9C
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x0603671D RID: 223005 RVA: 0x00CE3DA4 File Offset: 0x00CE1FA4
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

		// Token: 0x0401CCA9 RID: 117929
		public RogueResTalentTree? Data;

		// Token: 0x0401CCAA RID: 117930
		public int Index;
	}
}
