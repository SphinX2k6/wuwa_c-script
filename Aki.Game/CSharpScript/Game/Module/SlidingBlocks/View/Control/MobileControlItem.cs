using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02003B47 RID: 15175
	[NullableContext(2)]
	[Nullable(0)]
	public class MobileControlItem : ControlItem
	{
		// Token: 0x06027013 RID: 159763 RVA: 0x00AEB978 File Offset: 0x00AE9B78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnRotateBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnFallDownBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClimbBtnClick));
			num++;
			ref ValueTuple<int, Delegate> ptr = ref span2[num];
			int item = 4;
			Action item2;
			if ((item2 = MobileControlItem.<>O.<0>__OnJumpBtnClick) == null)
			{
				item2 = (MobileControlItem.<>O.<0>__OnJumpBtnClick = new Action(MobileControlItem.OnJumpBtnClick));
			}
			ptr = new ValueTuple<int, Delegate>(item, item2);
			num++;
			ref ValueTuple<int, Delegate> ptr2 = ref span2[num];
			int item3 = 5;
			Action item4;
			if ((item4 = MobileControlItem.<>O.<1>__OnDodgeBtnClick) == null)
			{
				item4 = (MobileControlItem.<>O.<1>__OnDodgeBtnClick = new Action(MobileControlItem.OnDodgeBtnClick));
			}
			ptr2 = new ValueTuple<int, Delegate>(item3, item4);
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027014 RID: 159764 RVA: 0x00AEBB50 File Offset: 0x00AE9D50
		protected override UniTask OnBeforeStartAsync()
		{
			MobileControlItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MobileControlItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027015 RID: 159765 RVA: 0x00AEBB93 File Offset: 0x00AE9D93
		public override void OnTick(float delta)
		{
			base.OnTick(delta);
			SlidingBlocksJoystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.Tick(delta);
		}

		// Token: 0x06027016 RID: 159766 RVA: 0x00AEBBB0 File Offset: 0x00AE9DB0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<SlidingBlocksJoystick> InitializeJoystick()
		{
			MobileControlItem.<InitializeJoystick>d__9 <InitializeJoystick>d__;
			<InitializeJoystick>d__.<>t__builder = AsyncUniTaskMethodBuilder<SlidingBlocksJoystick>.Create();
			<InitializeJoystick>d__.<>4__this = this;
			<InitializeJoystick>d__.<>1__state = -1;
			<InitializeJoystick>d__.<>t__builder.Start<MobileControlItem.<InitializeJoystick>d__9>(ref <InitializeJoystick>d__);
			return <InitializeJoystick>d__.<>t__builder.Task;
		}

		// Token: 0x06027017 RID: 159767 RVA: 0x00AEBBF3 File Offset: 0x00AE9DF3
		private static void OnJumpBtnClick()
		{
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Press);
		}

		// Token: 0x06027018 RID: 159768 RVA: 0x00AEBC05 File Offset: 0x00AE9E05
		private static void OnDodgeBtnClick()
		{
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
		}

		// Token: 0x06027019 RID: 159769 RVA: 0x00AEBC17 File Offset: 0x00AE9E17
		protected override void OnClimbBtnClick()
		{
			base.OnClimbBtnClick();
		}

		// Token: 0x0602701A RID: 159770 RVA: 0x00AEBC1F File Offset: 0x00AE9E1F
		protected override void OnRotateBtnClick()
		{
			base.OnRotateBtnClick();
		}

		// Token: 0x0602701B RID: 159771 RVA: 0x00AEBC27 File Offset: 0x00AE9E27
		protected override void OnFallDownBtnClick()
		{
			base.OnFallDownBtnClick();
		}

		// Token: 0x040154C8 RID: 87240
		private SlidingBlocksJoystick Joystick;

		// Token: 0x040154C9 RID: 87241
		private UUIButtonComponent RotateBtn;

		// Token: 0x040154CA RID: 87242
		private UUIButtonComponent FallDownBtn;

		// Token: 0x040154CB RID: 87243
		private UUIButtonComponent ClimbBtn;

		// Token: 0x040154CC RID: 87244
		private CharacterClimbComponent ClimbComp;

		// Token: 0x020097E3 RID: 38883
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x0402F61A RID: 194074
			public const int JoystickItem = 0;

			// Token: 0x0402F61B RID: 194075
			public const int RotateBtn = 1;

			// Token: 0x0402F61C RID: 194076
			public const int FallDownBtn = 2;

			// Token: 0x0402F61D RID: 194077
			public const int ClimbBtn = 3;

			// Token: 0x0402F61E RID: 194078
			public const int JumpBtn = 4;

			// Token: 0x0402F61F RID: 194079
			public const int DodgeBtn = 5;
		}

		// Token: 0x020097E4 RID: 38884
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402F620 RID: 194080
			[Nullable(0)]
			public static Action <0>__OnJumpBtnClick;

			// Token: 0x0402F621 RID: 194081
			[Nullable(0)]
			public static Action <1>__OnDodgeBtnClick;
		}
	}
}
