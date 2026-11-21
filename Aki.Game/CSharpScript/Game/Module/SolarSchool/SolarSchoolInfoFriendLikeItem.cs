using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B3 RID: 22963
	public class SolarSchoolInfoFriendLikeItem : GridProxyAbstract<SolarSchoolItem>
	{
		// Token: 0x060389B4 RID: 231860 RVA: 0x00FD6DA0 File Offset: 0x00FD4FA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060389B5 RID: 231861 RVA: 0x00FD6E48 File Offset: 0x00FD5048
		public override void Refresh(SolarSchoolItem data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.Id;
			string text = data.Icon ?? string.Empty;
			bool flag = !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureShowUntilLoaded(text, base.GetTexture(1), null);
			}
			this.SetToggleState();
		}

		// Token: 0x060389B6 RID: 231862 RVA: 0x00FD6EA8 File Offset: 0x00FD50A8
		public override void Clear()
		{
			this.ItemId = 0;
		}

		// Token: 0x060389B7 RID: 231863 RVA: 0x00FD6EB1 File Offset: 0x00FD50B1
		private void OnClickToggle(EToggleState _)
		{
			this.SetToggleState();
			if (this.ItemId != 0)
			{
				SolarSchoolUtils.ShowItemDetailPopup(this.ItemId, 0, null);
			}
		}

		// Token: 0x060389B8 RID: 231864 RVA: 0x00FD6ECE File Offset: 0x00FD50CE
		private void SetToggleState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0401DCFC RID: 122108
		private int ItemId;

		// Token: 0x0200B55E RID: 46430
		private class EComponent
		{
			// Token: 0x0403813E RID: 229694
			public const int Toggle = 0;

			// Token: 0x0403813F RID: 229695
			public const int Icon = 1;
		}
	}
}
