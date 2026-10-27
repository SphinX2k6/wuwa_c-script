using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE5 RID: 19941
	public class RoguelikeRoleAffixDetailToggle : GridProxyAbstract<int>
	{
		// Token: 0x06033771 RID: 210801 RVA: 0x00C06444 File Offset: 0x00C04644
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

		// Token: 0x06033772 RID: 210802 RVA: 0x00C064EA File Offset: 0x00C046EA
		private void OnClickExtendToggle(EToggleState toggleState)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x06033773 RID: 210803 RVA: 0x00C06504 File Offset: 0x00C04704
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

		// Token: 0x06033774 RID: 210804 RVA: 0x00C06571 File Offset: 0x00C04771
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033775 RID: 210805 RVA: 0x00C06584 File Offset: 0x00C04784
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401B518 RID: 111896
		public int Id;

		// Token: 0x0401B519 RID: 111897
		[Nullable(2)]
		public Action<int> OnSelectCallback;

		// Token: 0x0200AF6C RID: 44908
		private class EComponent
		{
			// Token: 0x0403543F RID: 218175
			public const int SpriteIcon = 0;

			// Token: 0x04035440 RID: 218176
			public const int ExtendToggle = 1;
		}
	}
}
