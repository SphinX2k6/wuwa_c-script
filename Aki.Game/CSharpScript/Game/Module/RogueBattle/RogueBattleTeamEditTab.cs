using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E7A RID: 15994
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTeamEditTab : CommonTabItemBase
	{
		// Token: 0x06028A56 RID: 166486 RVA: 0x00B68F98 File Offset: 0x00B67198
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick))
			};
		}

		// Token: 0x06028A57 RID: 166487 RVA: 0x00B69041 File Offset: 0x00B67241
		protected override void OnStart()
		{
			base.OnStart();
			this.GetTabToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06028A58 RID: 166488 RVA: 0x00B69066 File Offset: 0x00B67266
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x06028A59 RID: 166489 RVA: 0x00B6907F File Offset: 0x00B6727F
		protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}

		// Token: 0x06028A5A RID: 166490 RVA: 0x00B69094 File Offset: 0x00B67294
		protected override void OnUpdateTabIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
		}

		// Token: 0x06028A5B RID: 166491 RVA: 0x00B690C8 File Offset: 0x00B672C8
		protected void RefreshTransition(bool _)
		{
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
			if (uiExtendToggleSpriteTransition != null)
			{
				uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
			}
		}

		// Token: 0x06028A5C RID: 166492 RVA: 0x00B690F2 File Offset: 0x00B672F2
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			this.GetTabToggle().SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06028A5D RID: 166493 RVA: 0x00B69104 File Offset: 0x00B67304
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(1);
		}
	}
}
