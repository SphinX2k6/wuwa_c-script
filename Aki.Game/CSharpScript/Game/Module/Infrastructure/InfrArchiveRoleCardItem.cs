using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005908 RID: 22792
	public class InfrArchiveRoleCardItem : GridProxyAbstract<int>
	{
		// Token: 0x17008AD9 RID: 35545
		// (get) Token: 0x06039E10 RID: 237072 RVA: 0x00DBF0FC File Offset: 0x00DBD2FC
		public int MsgId
		{
			get
			{
				return this.Id;
			}
		}

		// Token: 0x06039E11 RID: 237073 RVA: 0x00DBF104 File Offset: 0x00DBD304
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

		// Token: 0x06039E12 RID: 237074 RVA: 0x00DBF22E File Offset: 0x00DBD42E
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Id = data;
			this.RefreshCardView();
		}

		// Token: 0x06039E13 RID: 237075 RVA: 0x00DBF240 File Offset: 0x00DBD440
		private void RefreshCardView()
		{
			InfrPhoneMessage? infrPhoneMessageConfigById = InfrastructureConfig.Instance.GetInfrPhoneMessageConfigById(this.Id);
			bool flag = PhoneMsgModel.Instance.IsPhoneMsgUnlock(this.Id);
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(flag);
			base.SetTextureByPath(infrPhoneMessageConfigById.Value.RoleTexturePath, base.GetTexture(4), null, null);
			base.GetText(5).ShowTextNew(infrPhoneMessageConfigById.Value.Name);
		}

		// Token: 0x06039E14 RID: 237076 RVA: 0x00DBF2CD File Offset: 0x00DBD4CD
		[NullableContext(1)]
		public void SetSelectedCallBack(Action<int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x06039E15 RID: 237077 RVA: 0x00DBF2D6 File Offset: 0x00DBD4D6
		private void OnClickBtnItem()
		{
			Action<int> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(base.GridIndex);
		}

		// Token: 0x0401E309 RID: 123657
		private int Id;

		// Token: 0x0401E30A RID: 123658
		[Nullable(2)]
		public Action<int> SelectedCallBack;

		// Token: 0x0200BB6F RID: 47983
		private class EChildType
		{
			// Token: 0x04038935 RID: 231733
			public const int BtnItem = 0;

			// Token: 0x04038936 RID: 231734
			public const int PanelLock = 1;

			// Token: 0x04038937 RID: 231735
			public const int TextLockTitle = 2;

			// Token: 0x04038938 RID: 231736
			public const int PanelUnlock = 3;

			// Token: 0x04038939 RID: 231737
			public const int TextureCardRole = 4;

			// Token: 0x0403893A RID: 231738
			public const int TextTitle = 5;
		}
	}
}
