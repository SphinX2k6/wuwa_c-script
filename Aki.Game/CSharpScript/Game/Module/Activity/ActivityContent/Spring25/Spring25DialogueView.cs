using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200501A RID: 20506
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25DialogueView : UiViewBase
	{
		// Token: 0x0603350A RID: 210186 RVA: 0x00E632C3 File Offset: 0x00E614C3
		public Spring25DialogueView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603350B RID: 210187 RVA: 0x00E632CC File Offset: 0x00E614CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603350C RID: 210188 RVA: 0x00E63378 File Offset: 0x00E61578
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25DialogueView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25DialogueView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603350D RID: 210189 RVA: 0x00E633BB File Offset: 0x00E615BB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603350E RID: 210190 RVA: 0x00E633D9 File Offset: 0x00E615D9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603350F RID: 210191 RVA: 0x00E633F7 File Offset: 0x00E615F7
		private void HandleConfirmClick(int _)
		{
			ActivitySpring25Controller.Instance.HandleConfirmClickInDialogueView();
		}

		// Token: 0x06033510 RID: 210192 RVA: 0x00E63404 File Offset: 0x00E61604
		private void HandleOnActivitySequenceEmitEvent(string passData)
		{
			Spring25DialogueViewData spring25DialogueViewData = this.OpenParam as Spring25DialogueViewData;
			int num;
			if (Spring25Define.Spring25DialogIndex.TryGetValue(passData, out num) && num < spring25DialogueViewData.ChatDataList.Count)
			{
				Spring25DialogueChatData spring25DialogueChatData = spring25DialogueViewData.ChatDataList[num];
				if (spring25DialogueChatData.Position == ESpring25DialogType.Left)
				{
					this.LeftItem.RefreshText(spring25DialogueChatData.ContentTextId);
					this.LeftItem.RefreshAnim(spring25DialogueChatData.SpineAnimName);
					return;
				}
				this.RightItem.RefreshText(spring25DialogueChatData.ContentTextId);
				this.RightItem.RefreshAnim(spring25DialogueChatData.SpineAnimName);
			}
		}

		// Token: 0x0401B49F RID: 111775
		private ButtonItem ConfirmItem;

		// Token: 0x0401B4A0 RID: 111776
		private RoleItem LeftItem;

		// Token: 0x0401B4A1 RID: 111777
		private RoleItem RightItem;

		// Token: 0x0200ACDC RID: 44252
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403573A RID: 218938
			public const int ConfirmItem = 0;

			// Token: 0x0403573B RID: 218939
			public const int RoleLeftItem = 1;

			// Token: 0x0403573C RID: 218940
			public const int RoleRightItem = 2;

			// Token: 0x0403573D RID: 218941
			public const int ButtonMaskItem = 3;
		}
	}
}
