using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F7 RID: 20727
	[NullableContext(2)]
	[Nullable(0)]
	internal class FilterTogItem : GridProxyAbstract<int>
	{
		// Token: 0x06034FD7 RID: 217047 RVA: 0x00C8D121 File Offset: 0x00C8B321
		public void SetOnFilterTogItemClick(Action<int, bool> callback)
		{
			this.OnFilterTogItemClick = callback;
		}

		// Token: 0x06034FD8 RID: 217048 RVA: 0x00C8D12A File Offset: 0x00C8B32A
		public void SetIsFilterSelected(Func<int, bool> callback)
		{
			this.IsFilterSelected = callback;
		}

		// Token: 0x06034FD9 RID: 217049 RVA: 0x00C8D134 File Offset: 0x00C8B334
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

		// Token: 0x06034FDA RID: 217050 RVA: 0x00C8D1B4 File Offset: 0x00C8B3B4
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

		// Token: 0x06034FDB RID: 217051 RVA: 0x00C8D280 File Offset: 0x00C8B480
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

		// Token: 0x06034FDC RID: 217052 RVA: 0x00C8D2BC File Offset: 0x00C8B4BC
		public override void Clear()
		{
		}

		// Token: 0x0401C373 RID: 115571
		private int? Id;

		// Token: 0x0401C374 RID: 115572
		private Action<int, bool> OnFilterTogItemClick;

		// Token: 0x0401C375 RID: 115573
		private Func<int, bool> IsFilterSelected;
	}
}
