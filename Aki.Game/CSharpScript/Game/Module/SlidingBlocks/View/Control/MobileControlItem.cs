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
	// Token: 0x02004B9D RID: 19357
	[NullableContext(2)]
	[Nullable(0)]
	public class MobileControlItem : ControlItem
	{
		// Token: 0x06032283 RID: 205443 RVA: 0x00BA782C File Offset: 0x00BA5A2C
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

		// Token: 0x06032284 RID: 205444 RVA: 0x00BA7A04 File Offset: 0x00BA5C04
		protected override UniTask OnBeforeStartAsync()
		{
			MobileControlItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MobileControlItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032285 RID: 205445 RVA: 0x00BA7A47 File Offset: 0x00BA5C47
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

		// Token: 0x06032286 RID: 205446 RVA: 0x00BA7A64 File Offset: 0x00BA5C64
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

		// Token: 0x06032287 RID: 205447 RVA: 0x00BA7AA7 File Offset: 0x00BA5CA7
		private static void OnJumpBtnClick()
		{
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Press);
		}

		// Token: 0x06032288 RID: 205448 RVA: 0x00BA7AB9 File Offset: 0x00BA5CB9
		private static void OnDodgeBtnClick()
		{
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
		}

		// Token: 0x06032289 RID: 205449 RVA: 0x00BA7ACB File Offset: 0x00BA5CCB
		protected override void OnClimbBtnClick()
		{
			base.OnClimbBtnClick();
		}

		// Token: 0x0603228A RID: 205450 RVA: 0x00BA7AD3 File Offset: 0x00BA5CD3
		protected override void OnRotateBtnClick()
		{
			base.OnRotateBtnClick();
		}

		// Token: 0x0603228B RID: 205451 RVA: 0x00BA7ADB File Offset: 0x00BA5CDB
		protected override void OnFallDownBtnClick()
		{
			base.OnFallDownBtnClick();
		}

		// Token: 0x0401AB74 RID: 109428
		private SlidingBlocksJoystick Joystick;

		// Token: 0x0401AB75 RID: 109429
		private UUIButtonComponent RotateBtn;

		// Token: 0x0401AB76 RID: 109430
		private UUIButtonComponent FallDownBtn;

		// Token: 0x0401AB77 RID: 109431
		private UUIButtonComponent ClimbBtn;

		// Token: 0x0401AB78 RID: 109432
		private CharacterClimbComponent ClimbComp;

		// Token: 0x0200ADC4 RID: 44484
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x04034C73 RID: 216179
			public const int JoystickItem = 0;

			// Token: 0x04034C74 RID: 216180
			public const int RotateBtn = 1;

			// Token: 0x04034C75 RID: 216181
			public const int FallDownBtn = 2;

			// Token: 0x04034C76 RID: 216182
			public const int ClimbBtn = 3;

			// Token: 0x04034C77 RID: 216183
			public const int JumpBtn = 4;

			// Token: 0x04034C78 RID: 216184
			public const int DodgeBtn = 5;
		}

		// Token: 0x0200ADC5 RID: 44485
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034C79 RID: 216185
			[Nullable(0)]
			public static Action <0>__OnJumpBtnClick;

			// Token: 0x04034C7A RID: 216186
			[Nullable(0)]
			public static Action <1>__OnDodgeBtnClick;
		}
	}
}
