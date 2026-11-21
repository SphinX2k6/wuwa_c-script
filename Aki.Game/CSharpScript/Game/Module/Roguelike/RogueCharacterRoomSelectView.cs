using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DBF RID: 15807
	public class RogueCharacterRoomSelectView : UiViewBase
	{
		// Token: 0x06028671 RID: 165489 RVA: 0x00B51E8C File Offset: 0x00B5008C
		[NullableContext(1)]
		public RogueCharacterRoomSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028672 RID: 165490 RVA: 0x00B51E9C File Offset: 0x00B5009C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.BtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028673 RID: 165491 RVA: 0x00B51F84 File Offset: 0x00B50184
		private void BtnConfirmClick()
		{
			IRoguelikeCharacterSelectOpenParam roguelikeCharacterSelectOpenParam = this.OpenParam as IRoguelikeCharacterSelectOpenParam;
			RoguelikeController.Instance.RoguelikeRoleRoomSelectRequest(this.SelectRoomId, roguelikeCharacterSelectOpenParam.Index).ContinueWith(delegate(bool _)
			{
				base.CloseMe(null);
			}).Forget();
		}

		// Token: 0x06028674 RID: 165492 RVA: 0x00B51FCC File Offset: 0x00B501CC
		private void OnSelectRoom(int gridIndex, bool isSelected, int roomId)
		{
			if (isSelected)
			{
				GenericLayout<RogueCharacterRoomItem, int> genericLayout = this.GenericLayout;
				if (genericLayout != null)
				{
					genericLayout.DeselectCurrentGridProxy();
				}
				GenericLayout<RogueCharacterRoomItem, int> genericLayout2 = this.GenericLayout;
				if (genericLayout2 != null)
				{
					genericLayout2.SelectGridProxy(gridIndex, false);
				}
				this.SelectRoomId = roomId;
			}
			else
			{
				GenericLayout<RogueCharacterRoomItem, int> genericLayout3 = this.GenericLayout;
				if (genericLayout3 != null)
				{
					genericLayout3.DeselectCurrentGridProxy();
				}
			}
			base.GetButton(3).SetSelfInteractive(isSelected);
		}

		// Token: 0x06028675 RID: 165493 RVA: 0x00B52028 File Offset: 0x00B50228
		protected override UniTask OnBeforeStartAsync()
		{
			RogueCharacterRoomSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueCharacterRoomSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04015F16 RID: 89878
		[Nullable(2)]
		private TopPanel TopPanelComponent;

		// Token: 0x04015F17 RID: 89879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueCharacterRoomItem, int> GenericLayout;

		// Token: 0x04015F18 RID: 89880
		private int SelectRoomId = -1;

		// Token: 0x020099B3 RID: 39347
		private class ERogueCharacterRoomSelectViewDefine
		{
			// Token: 0x0402FEC9 RID: 196297
			public const int TopPanel = 0;

			// Token: 0x0402FECA RID: 196298
			public const int PanelLayout = 1;

			// Token: 0x0402FECB RID: 196299
			public const int RoomSelectItem = 2;

			// Token: 0x0402FECC RID: 196300
			public const int BtnConfirm = 3;
		}
	}
}
