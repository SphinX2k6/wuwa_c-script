using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A11 RID: 23057
	public class DangoBrawlBattleLogToggle : UiPanelBase
	{
		// Token: 0x0603A78C RID: 239500 RVA: 0x00DEA02F File Offset: 0x00DE822F
		public DangoBrawlBattleLogToggle(bool isSelf)
		{
			this.IsSelf = isSelf;
		}

		// Token: 0x0603A78D RID: 239501 RVA: 0x00DEA040 File Offset: 0x00DE8240
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleTab));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A78E RID: 239502 RVA: 0x00DEA107 File Offset: 0x00DE8307
		[NullableContext(1)]
		public void SetOnToggleCallback(Action<EToggleState> callback)
		{
			this.OnToggleCallback = callback;
		}

		// Token: 0x0603A78F RID: 239503 RVA: 0x00DEA110 File Offset: 0x00DE8310
		public void SetSelected(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603A790 RID: 239504 RVA: 0x00DEA130 File Offset: 0x00DE8330
		public void Refresh(bool isSelf)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			int dangoId = battleManager.GetDangoId(this.IsSelf);
			if (dangoId != this.CurDangoId)
			{
				this.CurDangoId = dangoId;
				string path = "";
				if (this.IsSelf)
				{
					DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(this.CurDangoId);
					if (roleConfigById != null)
					{
						path = roleConfigById.Value.LogIcon;
					}
				}
				else
				{
					DangoBrawlOpponent? opponentConfigById = DangoBrawlConfig.Instance.GetOpponentConfigById(this.CurDangoId);
					if (opponentConfigById != null)
					{
						path = opponentConfigById.Value.RoleIcon;
					}
				}
				base.SetTextureByPath(path, base.GetTexture(1), null, null);
				base.SetTextureByPath(path, base.GetTexture(2), null, null);
			}
			this.SetSelected(isSelf == this.IsSelf);
		}

		// Token: 0x0603A791 RID: 239505 RVA: 0x00DEA215 File Offset: 0x00DE8415
		private void OnToggleTab(EToggleState state)
		{
			Action<EToggleState> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(state);
		}

		// Token: 0x0401E76E RID: 124782
		private readonly bool IsSelf;

		// Token: 0x0401E76F RID: 124783
		private int CurDangoId;

		// Token: 0x0401E770 RID: 124784
		[Nullable(2)]
		private Action<EToggleState> OnToggleCallback;

		// Token: 0x0200BC81 RID: 48257
		private enum EComp
		{
			// Token: 0x04038DF9 RID: 232953
			TogTab,
			// Token: 0x04038DFA RID: 232954
			TexIcon,
			// Token: 0x04038DFB RID: 232955
			TexIconMask
		}
	}
}
