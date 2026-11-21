using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E1 RID: 18657
	public class InfrArchiveRoleCardItem : GridProxyAbstract<int>
	{
		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x0602ED33 RID: 191795 RVA: 0x00D0E394 File Offset: 0x00D0C594
		public int MsgId
		{
			get
			{
				return this.Id;
			}
		}

		// Token: 0x0602ED34 RID: 191796 RVA: 0x00D0E39C File Offset: 0x00D0C59C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602ED35 RID: 191797 RVA: 0x00D0E4C6 File Offset: 0x00D0C6C6
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Id = data;
			this.RefreshCardView();
		}

		// Token: 0x0602ED36 RID: 191798 RVA: 0x00D0E4D8 File Offset: 0x00D0C6D8
		private void RefreshCardView()
		{
			InfrPhoneMessage? infrPhoneMessageConfigById = InfrastructureConfig.Instance.GetInfrPhoneMessageConfigById(this.Id);
			bool flag = PhoneMsgModel.Instance.IsPhoneMsgUnlock(this.Id);
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(flag);
			base.SetTextureByPath(infrPhoneMessageConfigById.Value.RoleTexturePath, base.GetTexture(4), null, null);
			base.GetText(5).ShowTextNew(infrPhoneMessageConfigById.Value.Name);
		}

		// Token: 0x0602ED37 RID: 191799 RVA: 0x00D0E565 File Offset: 0x00D0C765
		[NullableContext(1)]
		public void SetSelectedCallBack(Action<int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x0602ED38 RID: 191800 RVA: 0x00D0E56E File Offset: 0x00D0C76E
		private void OnClickBtnItem()
		{
			Action<int> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(base.GridIndex);
		}

		// Token: 0x04018DA6 RID: 101798
		private int Id;

		// Token: 0x04018DA7 RID: 101799
		[Nullable(2)]
		public Action<int> SelectedCallBack;

		// Token: 0x0200A57F RID: 42367
		private class EChildType
		{
			// Token: 0x0403331F RID: 209695
			public const int BtnItem = 0;

			// Token: 0x04033320 RID: 209696
			public const int PanelLock = 1;

			// Token: 0x04033321 RID: 209697
			public const int TextLockTitle = 2;

			// Token: 0x04033322 RID: 209698
			public const int PanelUnlock = 3;

			// Token: 0x04033323 RID: 209699
			public const int TextureCardRole = 4;

			// Token: 0x04033324 RID: 209700
			public const int TextTitle = 5;
		}
	}
}
