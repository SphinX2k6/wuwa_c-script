using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005021 RID: 20513
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabItem : GridProxyAbstract<Spring25LetterListTabData>
	{
		// Token: 0x170063FD RID: 25597
		// (get) Token: 0x06033559 RID: 210265 RVA: 0x00E643A7 File Offset: 0x00E625A7
		// (set) Token: 0x0603355A RID: 210266 RVA: 0x00E643AF File Offset: 0x00E625AF
		private Spring25LetterListTabData DataCache { get; set; }

		// Token: 0x0603355B RID: 210267 RVA: 0x00E643B8 File Offset: 0x00E625B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.HandleClickTab));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603355C RID: 210268 RVA: 0x00E644A0 File Offset: 0x00E626A0
		protected override UniTask OnBeforeStartAsync()
		{
			TabItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603355D RID: 210269 RVA: 0x00E644E3 File Offset: 0x00E626E3
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Unbind();
		}

		// Token: 0x0603355E RID: 210270 RVA: 0x00E644FC File Offset: 0x00E626FC
		public override void Refresh(Spring25LetterListTabData data, bool isSelected, int gridIndex)
		{
			this.DataCache = data;
			UUITexture texture = base.GetTexture(1);
			base.TrySetTextureByPath(data.TexturePath, texture, null, null);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.TrySetLocalTextNew(text, data.DescriptionTextId, Array.Empty<object>());
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.IsNew);
		}

		// Token: 0x0603355F RID: 210271 RVA: 0x00E64584 File Offset: 0x00E62784
		private void HandleClickTab(EToggleState toggleState)
		{
			if (this.DataCache == null)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleLetterClickInLetterListView(this.DataCache.SignId);
		}

		// Token: 0x06033560 RID: 210272 RVA: 0x00E645A4 File Offset: 0x00E627A4
		private bool HandleCanExecuteChange()
		{
			return this.DataCache != null && !this.DataCache.IsChosen;
		}

		// Token: 0x0200ACEC RID: 44268
		[NullableContext(0)]
		private class ETabComponent
		{
			// Token: 0x0403578A RID: 219018
			public const int RootToggle = 0;

			// Token: 0x0403578B RID: 219019
			public const int HeadTexture = 1;

			// Token: 0x0403578C RID: 219020
			public const int DescriptionText = 2;

			// Token: 0x0403578D RID: 219021
			public const int NewItem = 3;
		}
	}
}
