using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EED RID: 28397
	[NullableContext(1)]
	[Nullable(0)]
	internal class TabItem : GridProxyAbstract<int>
	{
		// Token: 0x0604527C RID: 283260 RVA: 0x0111AD4C File Offset: 0x01118F4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604527D RID: 283261 RVA: 0x0111AE13 File Offset: 0x01119013
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.TabIndex = data;
		}

		// Token: 0x0604527E RID: 283262 RVA: 0x0111AE1C File Offset: 0x0111901C
		private void OnClickToggle(EToggleState _)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x0604527F RID: 283263 RVA: 0x0111AE34 File Offset: 0x01119034
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x06045280 RID: 283264 RVA: 0x0111AE3D File Offset: 0x0111903D
		public void SetTabNameKey(string key)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), key, Array.Empty<object>());
		}

		// Token: 0x06045281 RID: 283265 RVA: 0x0111AE56 File Offset: 0x01119056
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x06045282 RID: 283266 RVA: 0x0111AE60 File Offset: 0x01119060
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0402405E RID: 147550
		private int TabIndex = -1;

		// Token: 0x0402405F RID: 147551
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;
	}
}
