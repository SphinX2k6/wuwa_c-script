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
	// Token: 0x020060A3 RID: 24739
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabItem : GridProxyAbstract<Spring25LetterListTabData>
	{
		// Token: 0x1700909B RID: 37019
		// (get) Token: 0x0603E895 RID: 256149 RVA: 0x00F1D5E3 File Offset: 0x00F1B7E3
		// (set) Token: 0x0603E896 RID: 256150 RVA: 0x00F1D5EB File Offset: 0x00F1B7EB
		private Spring25LetterListTabData DataCache { get; set; }

		// Token: 0x0603E897 RID: 256151 RVA: 0x00F1D5F4 File Offset: 0x00F1B7F4
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

		// Token: 0x0603E898 RID: 256152 RVA: 0x00F1D6DC File Offset: 0x00F1B8DC
		protected override UniTask OnBeforeStartAsync()
		{
			TabItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E899 RID: 256153 RVA: 0x00F1D71F File Offset: 0x00F1B91F
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Unbind();
		}

		// Token: 0x0603E89A RID: 256154 RVA: 0x00F1D738 File Offset: 0x00F1B938
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

		// Token: 0x0603E89B RID: 256155 RVA: 0x00F1D7C0 File Offset: 0x00F1B9C0
		private void HandleClickTab(EToggleState toggleState)
		{
			if (this.DataCache == null)
			{
				return;
			}
			ActivitySpring25Controller.Instance.HandleLetterClickInLetterListView(this.DataCache.SignId);
		}

		// Token: 0x0603E89C RID: 256156 RVA: 0x00F1D7E0 File Offset: 0x00F1B9E0
		private bool HandleCanExecuteChange()
		{
			return this.DataCache != null && !this.DataCache.IsChosen;
		}

		// Token: 0x0200C301 RID: 49921
		[NullableContext(0)]
		private class ETabComponent
		{
			// Token: 0x0403AE22 RID: 241186
			public const int RootToggle = 0;

			// Token: 0x0403AE23 RID: 241187
			public const int HeadTexture = 1;

			// Token: 0x0403AE24 RID: 241188
			public const int DescriptionText = 2;

			// Token: 0x0403AE25 RID: 241189
			public const int NewItem = 3;
		}
	}
}
