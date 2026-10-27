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
	// Token: 0x0200564F RID: 22095
	[NullableContext(1)]
	[Nullable(0)]
	public class SvInfo : UiPanelBase
	{
		// Token: 0x060382BF RID: 230079 RVA: 0x00D4E5EC File Offset: 0x00D4C7EC
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

		// Token: 0x060382C0 RID: 230080 RVA: 0x00D4E6E4 File Offset: 0x00D4C8E4
		protected override UniTask OnBeforeStartAsync()
		{
			SvInfo.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SvInfo.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382C1 RID: 230081 RVA: 0x00D4E727 File Offset: 0x00D4C927
		protected override void OnStart()
		{
			this.WeaponAttributeComponent.SetActive(true);
		}

		// Token: 0x060382C2 RID: 230082 RVA: 0x00D4E738 File Offset: 0x00D4C938
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

		// Token: 0x060382C3 RID: 230083 RVA: 0x00D4E76C File Offset: 0x00D4C96C
		public void SetTypeNameVisible(bool visible)
		{
			base.GetText(0).SetUIActive(visible);
		}

		// Token: 0x060382C4 RID: 230084 RVA: 0x00D4E77B File Offset: 0x00D4C97B
		public void SetDescVisible(bool visible)
		{
			base.GetText(3).SetUIActive(visible);
		}

		// Token: 0x060382C5 RID: 230085 RVA: 0x00D4E78A File Offset: 0x00D4C98A
		public void SetDescBgVisible(bool visible)
		{
			base.GetText(5).SetUIActive(visible);
		}

		// Token: 0x060382C6 RID: 230086 RVA: 0x00D4E799 File Offset: 0x00D4C999
		public void SetDesc(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x060382C7 RID: 230087 RVA: 0x00D4E7A9 File Offset: 0x00D4C9A9
		public void SetDescBg(string text)
		{
			base.GetText(5).SetText(text, true);
		}

		// Token: 0x060382C8 RID: 230088 RVA: 0x00D4E7B9 File Offset: 0x00D4C9B9
		public void SetWeaponAttribute(IWeaponForgingData data)
		{
			this.WeaponAttributeComponent.RefreshTips(data);
		}

		// Token: 0x0401D8CA RID: 121034
		[Nullable(2)]
		private WeaponAttributeView WeaponAttributeComponent;

		// Token: 0x0401D8CB RID: 121035
		[Nullable(2)]
		public Action ChangeRoleClickDelegate;

		// Token: 0x0200B803 RID: 47107
		[NullableContext(0)]
		private class ESvInfoComponents
		{
			// Token: 0x04037AB0 RID: 228016
			public const int TxtType = 0;

			// Token: 0x04037AB1 RID: 228017
			public const int WeaponView = 1;

			// Token: 0x04037AB2 RID: 228018
			public const int Desc = 3;

			// Token: 0x04037AB3 RID: 228019
			public const int Line = 4;

			// Token: 0x04037AB4 RID: 228020
			public const int DescBg = 5;

			// Token: 0x04037AB5 RID: 228021
			public const int InventoryView = 6;
		}
	}
}
