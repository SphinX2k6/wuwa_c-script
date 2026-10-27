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
	// Token: 0x02004DF6 RID: 19958
	public class RogueCharacterRoomSelectView : UiViewBase
	{
		// Token: 0x06033806 RID: 210950 RVA: 0x00C0897C File Offset: 0x00C06B7C
		[NullableContext(1)]
		public RogueCharacterRoomSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033807 RID: 210951 RVA: 0x00C0898C File Offset: 0x00C06B8C
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

		// Token: 0x06033808 RID: 210952 RVA: 0x00C08A74 File Offset: 0x00C06C74
		private void BtnConfirmClick()
		{
			IRoguelikeCharacterSelectOpenParam roguelikeCharacterSelectOpenParam = this.OpenParam as IRoguelikeCharacterSelectOpenParam;
			RoguelikeController.Instance.RoguelikeRoleRoomSelectRequest(this.SelectRoomId, roguelikeCharacterSelectOpenParam.Index).ContinueWith(delegate(bool _)
			{
				base.CloseMe(null);
			}).Forget();
		}

		// Token: 0x06033809 RID: 210953 RVA: 0x00C08ABC File Offset: 0x00C06CBC
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

		// Token: 0x0603380A RID: 210954 RVA: 0x00C08B18 File Offset: 0x00C06D18
		protected override UniTask OnBeforeStartAsync()
		{
			RogueCharacterRoomSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueCharacterRoomSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B543 RID: 111939
		[Nullable(2)]
		private TopPanel TopPanelComponent;

		// Token: 0x0401B544 RID: 111940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueCharacterRoomItem, int> GenericLayout;

		// Token: 0x0401B545 RID: 111941
		private int SelectRoomId = -1;

		// Token: 0x0200AF7E RID: 44926
		private class ERogueCharacterRoomSelectViewDefine
		{
			// Token: 0x04035496 RID: 218262
			public const int TopPanel = 0;

			// Token: 0x04035497 RID: 218263
			public const int PanelLayout = 1;

			// Token: 0x04035498 RID: 218264
			public const int RoomSelectItem = 2;

			// Token: 0x04035499 RID: 218265
			public const int BtnConfirm = 3;
		}
	}
}
