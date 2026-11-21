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
	// Token: 0x020049ED RID: 18925
	public class DangoBrawlBattleLogToggle : UiPanelBase
	{
		// Token: 0x0602F6D5 RID: 194261 RVA: 0x00D3A5C7 File Offset: 0x00D387C7
		public DangoBrawlBattleLogToggle(bool isSelf)
		{
			this.IsSelf = isSelf;
		}

		// Token: 0x0602F6D6 RID: 194262 RVA: 0x00D3A5D8 File Offset: 0x00D387D8
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

		// Token: 0x0602F6D7 RID: 194263 RVA: 0x00D3A69F File Offset: 0x00D3889F
		[NullableContext(1)]
		public void SetOnToggleCallback(Action<EToggleState> callback)
		{
			this.OnToggleCallback = callback;
		}

		// Token: 0x0602F6D8 RID: 194264 RVA: 0x00D3A6A8 File Offset: 0x00D388A8
		public void SetSelected(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602F6D9 RID: 194265 RVA: 0x00D3A6C8 File Offset: 0x00D388C8
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

		// Token: 0x0602F6DA RID: 194266 RVA: 0x00D3A7AD File Offset: 0x00D389AD
		private void OnToggleTab(EToggleState state)
		{
			Action<EToggleState> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(state);
		}

		// Token: 0x04019215 RID: 102933
		private readonly bool IsSelf;

		// Token: 0x04019216 RID: 102934
		private int CurDangoId;

		// Token: 0x04019217 RID: 102935
		[Nullable(2)]
		private Action<EToggleState> OnToggleCallback;

		// Token: 0x0200A68A RID: 42634
		private enum EComp
		{
			// Token: 0x040337C4 RID: 210884
			TogTab,
			// Token: 0x040337C5 RID: 210885
			TexIcon,
			// Token: 0x040337C6 RID: 210886
			TexIconMask
		}
	}
}
