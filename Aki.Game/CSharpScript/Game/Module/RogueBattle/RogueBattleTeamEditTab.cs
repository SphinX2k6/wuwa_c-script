using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EB1 RID: 20145
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTeamEditTab : CommonTabItemBase
	{
		// Token: 0x06033BEB RID: 211947 RVA: 0x00C1FA80 File Offset: 0x00C1DC80
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

		// Token: 0x06033BEC RID: 211948 RVA: 0x00C1FB29 File Offset: 0x00C1DD29
		protected override void OnStart()
		{
			base.OnStart();
			this.GetTabToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06033BED RID: 211949 RVA: 0x00C1FB4E File Offset: 0x00C1DD4E
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x06033BEE RID: 211950 RVA: 0x00C1FB67 File Offset: 0x00C1DD67
		protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}

		// Token: 0x06033BEF RID: 211951 RVA: 0x00C1FB7C File Offset: 0x00C1DD7C
		protected override void OnUpdateTabIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
		}

		// Token: 0x06033BF0 RID: 211952 RVA: 0x00C1FBB0 File Offset: 0x00C1DDB0
		protected void RefreshTransition(bool _)
		{
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
			if (uiExtendToggleSpriteTransition != null)
			{
				uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
			}
		}

		// Token: 0x06033BF1 RID: 211953 RVA: 0x00C1FBDA File Offset: 0x00C1DDDA
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			this.GetTabToggle().SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06033BF2 RID: 211954 RVA: 0x00C1FBEC File Offset: 0x00C1DDEC
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(1);
		}
	}
}
