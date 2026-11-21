using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAE RID: 15790
	public class RoguelikeRoleAffixDetailToggle : GridProxyAbstract<int>
	{
		// Token: 0x060285DC RID: 165340 RVA: 0x00B4F954 File Offset: 0x00B4DB54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickExtendToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060285DD RID: 165341 RVA: 0x00B4F9FA File Offset: 0x00B4DBFA
		private void OnClickExtendToggle(EToggleState toggleState)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x060285DE RID: 165342 RVA: 0x00B4FA14 File Offset: 0x00B4DC14
		public override void Refresh(int id, bool isSelected, int gridIndex)
		{
			this.Id = id;
			RogueCharacterBuff? rogueCharacterBuffConfig = RoguelikeConfig.Instance.GetRogueCharacterBuffConfig(id);
			if (rogueCharacterBuffConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(rogueCharacterBuffConfig.Value.AffixIcon, base.GetSprite(0), false, null, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060285DF RID: 165343 RVA: 0x00B4FA81 File Offset: 0x00B4DC81
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060285E0 RID: 165344 RVA: 0x00B4FA94 File Offset: 0x00B4DC94
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04015EEB RID: 89835
		public int Id;

		// Token: 0x04015EEC RID: 89836
		[Nullable(2)]
		public Action<int> OnSelectCallback;

		// Token: 0x020099A1 RID: 39329
		private class EComponent
		{
			// Token: 0x0402FE72 RID: 196210
			public const int SpriteIcon = 0;

			// Token: 0x0402FE73 RID: 196211
			public const int ExtendToggle = 1;
		}
	}
}
