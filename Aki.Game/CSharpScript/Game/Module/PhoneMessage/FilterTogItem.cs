using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C7 RID: 16583
	[NullableContext(2)]
	[Nullable(0)]
	internal class FilterTogItem : GridProxyAbstract<int>
	{
		// Token: 0x06029ED0 RID: 171728 RVA: 0x00BDA3FD File Offset: 0x00BD85FD
		public void SetOnFilterTogItemClick(Action<int, bool> callback)
		{
			this.OnFilterTogItemClick = callback;
		}

		// Token: 0x06029ED1 RID: 171729 RVA: 0x00BDA406 File Offset: 0x00BD8606
		public void SetIsFilterSelected(Func<int, bool> callback)
		{
			this.IsFilterSelected = callback;
		}

		// Token: 0x06029ED2 RID: 171730 RVA: 0x00BDA410 File Offset: 0x00BD8610
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTogItemClick))
			};
		}

		// Token: 0x06029ED3 RID: 171731 RVA: 0x00BDA490 File Offset: 0x00BD8690
		public override void Refresh(int filterId, bool isSelected, int gridIndex)
		{
			this.Id = new int?(filterId);
			ChatPartnerFilter? chatPartnerFilterConfig = PhoneMsgConfig.Instance.GetChatPartnerFilterConfig(filterId);
			if (chatPartnerFilterConfig == null)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, chatPartnerFilterConfig.Value.Name, Array.Empty<object>());
			}
			base.SetTextureByPath(chatPartnerFilterConfig.Value.Icon, base.GetTexture(2), null, null);
			bool flag = this.IsFilterSelected != null && this.Id != null && this.IsFilterSelected(this.Id.Value);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06029ED4 RID: 171732 RVA: 0x00BDA55C File Offset: 0x00BD875C
		private void OnTogItemClick(EToggleState state)
		{
			if (this.Id == null)
			{
				return;
			}
			bool arg = state == EToggleState.ETT_Checked;
			Action<int, bool> onFilterTogItemClick = this.OnFilterTogItemClick;
			if (onFilterTogItemClick == null)
			{
				return;
			}
			onFilterTogItemClick(this.Id.Value, arg);
		}

		// Token: 0x06029ED5 RID: 171733 RVA: 0x00BDA598 File Offset: 0x00BD8798
		public override void Clear()
		{
		}

		// Token: 0x04016DA6 RID: 93606
		private int? Id;

		// Token: 0x04016DA7 RID: 93607
		private Action<int, bool> OnFilterTogItemClick;

		// Token: 0x04016DA8 RID: 93608
		private Func<int, bool> IsFilterSelected;
	}
}
