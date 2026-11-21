using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004625 RID: 17957
	[NullableContext(1)]
	[Nullable(0)]
	public class SvInfo : UiPanelBase
	{
		// Token: 0x0602D1BD RID: 184765 RVA: 0x00C9C33C File Offset: 0x00C9A53C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602D1BE RID: 184766 RVA: 0x00C9C434 File Offset: 0x00C9A634
		protected override UniTask OnBeforeStartAsync()
		{
			SvInfo.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SvInfo.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D1BF RID: 184767 RVA: 0x00C9C477 File Offset: 0x00C9A677
		protected override void OnStart()
		{
			this.WeaponAttributeComponent.SetActive(true);
		}

		// Token: 0x0602D1C0 RID: 184768 RVA: 0x00C9C488 File Offset: 0x00C9A688
		public void SetTypeName(string tag = null)
		{
			UUIText text = base.GetText(0);
			if (!string.IsNullOrEmpty(tag))
			{
				text.SetUIActive(true);
				text.SetText(tag, true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0602D1C1 RID: 184769 RVA: 0x00C9C4BC File Offset: 0x00C9A6BC
		public void SetTypeNameVisible(bool visible)
		{
			base.GetText(0).SetUIActive(visible);
		}

		// Token: 0x0602D1C2 RID: 184770 RVA: 0x00C9C4CB File Offset: 0x00C9A6CB
		public void SetDescVisible(bool visible)
		{
			base.GetText(3).SetUIActive(visible);
		}

		// Token: 0x0602D1C3 RID: 184771 RVA: 0x00C9C4DA File Offset: 0x00C9A6DA
		public void SetDescBgVisible(bool visible)
		{
			base.GetText(5).SetUIActive(visible);
		}

		// Token: 0x0602D1C4 RID: 184772 RVA: 0x00C9C4E9 File Offset: 0x00C9A6E9
		public void SetDesc(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x0602D1C5 RID: 184773 RVA: 0x00C9C4F9 File Offset: 0x00C9A6F9
		public void SetDescBg(string text)
		{
			base.GetText(5).SetText(text, true);
		}

		// Token: 0x0602D1C6 RID: 184774 RVA: 0x00C9C509 File Offset: 0x00C9A709
		public void SetWeaponAttribute(IWeaponForgingData data)
		{
			this.WeaponAttributeComponent.RefreshTips(data);
		}

		// Token: 0x04018355 RID: 99157
		[Nullable(2)]
		private WeaponAttributeView WeaponAttributeComponent;

		// Token: 0x04018356 RID: 99158
		[Nullable(2)]
		public Action ChangeRoleClickDelegate;

		// Token: 0x0200A22E RID: 41518
		[NullableContext(0)]
		private class ESvInfoComponents
		{
			// Token: 0x040324DA RID: 206042
			public const int TxtType = 0;

			// Token: 0x040324DB RID: 206043
			public const int WeaponView = 1;

			// Token: 0x040324DC RID: 206044
			public const int Desc = 3;

			// Token: 0x040324DD RID: 206045
			public const int Line = 4;

			// Token: 0x040324DE RID: 206046
			public const int DescBg = 5;

			// Token: 0x040324DF RID: 206047
			public const int InventoryView = 6;
		}
	}
}
