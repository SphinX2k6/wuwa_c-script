using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006231 RID: 25137
	internal class RoleDetailPanel : UiPanelBase
	{
		// Token: 0x0603F608 RID: 259592 RVA: 0x00F5242C File Offset: 0x00F5062C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0603F609 RID: 259593 RVA: 0x00F524E0 File Offset: 0x00F506E0
		public void RefreshPanel()
		{
			if (RhythmShipModel.Instance.RhythmShipLevelRole <= 0)
			{
				base.GetItem(5).SetUIActive(true);
				base.GetItem(0).SetUIActive(false);
				return;
			}
			base.GetItem(5).SetUIActive(false);
			base.GetItem(0).SetUIActive(true);
			RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(RhythmShipModel.Instance.RhythmShipLevelRole);
			if (rhythmRoleById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rhythmRoleById.Value.RoleNameText, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rhythmRoleById.Value.RoleDesText, Array.Empty<object>());
			base.SetTextureByPath(rhythmRoleById.Value.RoleHeadTexture, base.GetTexture(1), null, null);
			if (!string.IsNullOrEmpty(rhythmRoleById.Value.SkillIcon))
			{
				base.GetItem(6).SetUIActive(true);
				base.SetTextureByPath(rhythmRoleById.Value.SkillIcon, base.GetTexture(2), null, null);
				return;
			}
			base.GetItem(6).SetUIActive(false);
		}
	}
}
