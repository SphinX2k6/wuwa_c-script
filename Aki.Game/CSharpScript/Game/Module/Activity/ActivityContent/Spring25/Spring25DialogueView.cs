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
	// Token: 0x0200609C RID: 24732
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25DialogueView : UiViewBase
	{
		// Token: 0x0603E846 RID: 256070 RVA: 0x00F1C4FF File Offset: 0x00F1A6FF
		public Spring25DialogueView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603E847 RID: 256071 RVA: 0x00F1C508 File Offset: 0x00F1A708
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

		// Token: 0x0603E848 RID: 256072 RVA: 0x00F1C5B4 File Offset: 0x00F1A7B4
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25DialogueView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25DialogueView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E849 RID: 256073 RVA: 0x00F1C5F7 File Offset: 0x00F1A7F7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603E84A RID: 256074 RVA: 0x00F1C615 File Offset: 0x00F1A815
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
		}

		// Token: 0x0603E84B RID: 256075 RVA: 0x00F1C633 File Offset: 0x00F1A833
		private void HandleConfirmClick(int _)
		{
			ActivitySpring25Controller.Instance.HandleConfirmClickInDialogueView();
		}

		// Token: 0x0603E84C RID: 256076 RVA: 0x00F1C640 File Offset: 0x00F1A840
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

		// Token: 0x04020B72 RID: 134002
		private ButtonItem ConfirmItem;

		// Token: 0x04020B73 RID: 134003
		private RoleItem LeftItem;

		// Token: 0x04020B74 RID: 134004
		private RoleItem RightItem;

		// Token: 0x0200C2F1 RID: 49905
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403ADD2 RID: 241106
			public const int ConfirmItem = 0;

			// Token: 0x0403ADD3 RID: 241107
			public const int RoleLeftItem = 1;

			// Token: 0x0403ADD4 RID: 241108
			public const int RoleRightItem = 2;

			// Token: 0x0403ADD5 RID: 241109
			public const int ButtonMaskItem = 3;
		}
	}
}
