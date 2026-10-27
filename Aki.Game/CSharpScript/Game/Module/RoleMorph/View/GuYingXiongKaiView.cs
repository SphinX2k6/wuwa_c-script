using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleMorph.View
{
	// Token: 0x02004D68 RID: 19816
	public class GuYingXiongKaiView : UiTickViewBase
	{
		// Token: 0x0603339A RID: 209818 RVA: 0x00BF228A File Offset: 0x00BF048A
		[NullableContext(1)]
		public GuYingXiongKaiView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603339B RID: 209819 RVA: 0x00BF22A0 File Offset: 0x00BF04A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603339C RID: 209820 RVA: 0x00BF240C File Offset: 0x00BF060C
		protected override UniTask OnBeforeStartAsync()
		{
			GuYingXiongKaiView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuYingXiongKaiView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603339D RID: 209821 RVA: 0x00BF2450 File Offset: 0x00BF0650
		public UniTask NewAllSkillItems()
		{
			GuYingXiongKaiView.<NewAllSkillItems>d__10 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<GuYingXiongKaiView.<NewAllSkillItems>d__10>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603339E RID: 209822 RVA: 0x00BF2494 File Offset: 0x00BF0694
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<GuYingXiongKaiSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			GuYingXiongKaiView.<NewSkillItem>d__11 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<GuYingXiongKaiSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<GuYingXiongKaiView.<NewSkillItem>d__11>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603339F RID: 209823 RVA: 0x00BF24E8 File Offset: 0x00BF06E8
		protected override void OnAddEventListener()
		{
			this.BtnAttack = base.GetButton(5);
			if (this.BtnAttack != null)
			{
				this.BtnAttack.OnPointDownCallBack.Bind(new Action(this.OnAttackButtonPressed));
				this.BtnAttack.OnPointUpCallBack.Bind(new Action(this.OnAttackButtonReleased));
				this.BtnAttack.OnPointCancelCallBack.Bind(new Action(this.OnAttackButtonCancel));
			}
		}

		// Token: 0x060333A0 RID: 209824 RVA: 0x00BF255E File Offset: 0x00BF075E
		protected override void OnRemoveEventListener()
		{
			if (this.BtnAttack != null)
			{
				this.BtnAttack.OnPointDownCallBack.Unbind();
				this.BtnAttack.OnPointUpCallBack.Unbind();
				this.BtnAttack.OnPointCancelCallBack.Unbind();
			}
		}

		// Token: 0x060333A1 RID: 209825 RVA: 0x00BF2598 File Offset: 0x00BF0798
		protected override void OnBeforeDestroy()
		{
			foreach (GuYingXiongKaiSkillItem guYingXiongKaiSkillItem in this.SkillItemList)
			{
				guYingXiongKaiSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.BtnAttack = null;
		}

		// Token: 0x060333A2 RID: 209826 RVA: 0x00BF25FC File Offset: 0x00BF07FC
		private void OnClickClose()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "玩法放弃");
		}

		// Token: 0x060333A3 RID: 209827 RVA: 0x00BF2613 File Offset: 0x00BF0813
		private void OnAttackButtonPressed()
		{
			InputDistributeController.Instance.InputAction("攻击", true);
		}

		// Token: 0x060333A4 RID: 209828 RVA: 0x00BF2626 File Offset: 0x00BF0826
		private void OnAttackButtonCancel()
		{
			InputDistributeController.Instance.InputAction("攻击", false);
		}

		// Token: 0x060333A5 RID: 209829 RVA: 0x00BF2639 File Offset: 0x00BF0839
		private void OnAttackButtonReleased()
		{
			InputDistributeController.Instance.InputAction("攻击", false);
		}

		// Token: 0x060333A6 RID: 209830 RVA: 0x00BF264C File Offset: 0x00BF084C
		protected override void OnTick(float delta)
		{
			foreach (GuYingXiongKaiSkillItem guYingXiongKaiSkillItem in this.SkillItemList)
			{
				guYingXiongKaiSkillItem.Tick(delta);
			}
			this.OnTickGetCursorInput();
		}

		// Token: 0x060333A7 RID: 209831 RVA: 0x00BF26A4 File Offset: 0x00BF08A4
		private void OnTickGetCursorInput()
		{
			if (!Info.Instance.IsInKeyBoard())
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			Vector2D cursorPosition = characterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			characterController.GetViewportSize(ref num, ref num2);
			float num3 = (float)num * 0.5f;
			float num4 = (float)num2 * 0.5f;
			float num5 = num3 * 0.4f;
			float num6 = num4 * 0.4f;
			double num7 = cursorPosition.X - (double)num3;
			double num8 = (double)num4 - cursorPosition.Y;
			if (Math.Abs(num7) < (double)num5 && Math.Abs(num8) < (double)num6)
			{
				return;
			}
			double num9 = Math.Atan2(num8, num7) * 57.295780181884766;
			if (num9 < 0.0)
			{
				num9 += 360.0;
			}
			GuYingXiongKaiView.ESectorScreen esectorScreen = (GuYingXiongKaiView.ESectorScreen)Math.Floor((num9 + 22.5) * 0.02222222276031971) % (GuYingXiongKaiView.ESectorScreen)8;
			if (esectorScreen == this.LastSector)
			{
				return;
			}
			this.LastSector = esectorScreen;
			switch (esectorScreen)
			{
			case GuYingXiongKaiView.ESectorScreen.Right:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.UpRight:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.Up:
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.UpLeft:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.Left:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.DowLeft:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.Down:
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			case GuYingXiongKaiView.ESectorScreen.DownRight:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			default:
				return;
			}
		}

		// Token: 0x0401B31D RID: 111389
		[Nullable(1)]
		private readonly List<GuYingXiongKaiSkillItem> SkillItemList = new List<GuYingXiongKaiSkillItem>();

		// Token: 0x0401B31E RID: 111390
		[Nullable(2)]
		private UUIButtonComponent BtnAttack;

		// Token: 0x0401B31F RID: 111391
		private const float SECTOR_ANGLE_SIZE = 0.022222223f;

		// Token: 0x0401B320 RID: 111392
		private const float HALF_SECTOR_ANGLE_SIZE = 22.5f;

		// Token: 0x0401B321 RID: 111393
		private const int SECTOR_NUM = 8;

		// Token: 0x0401B322 RID: 111394
		private GuYingXiongKaiView.ESectorScreen LastSector;

		// Token: 0x0200AED9 RID: 44761
		private enum EChildType
		{
			// Token: 0x040351A2 RID: 217506
			LeftContainer,
			// Token: 0x040351A3 RID: 217507
			Item1,
			// Token: 0x040351A4 RID: 217508
			Item2,
			// Token: 0x040351A5 RID: 217509
			Item3,
			// Token: 0x040351A6 RID: 217510
			Item4,
			// Token: 0x040351A7 RID: 217511
			BtnReset,
			// Token: 0x040351A8 RID: 217512
			BtnClose,
			// Token: 0x040351A9 RID: 217513
			BtnHelp
		}

		// Token: 0x0200AEDA RID: 44762
		private enum ESectorScreen
		{
			// Token: 0x040351AB RID: 217515
			Right,
			// Token: 0x040351AC RID: 217516
			UpRight,
			// Token: 0x040351AD RID: 217517
			Up,
			// Token: 0x040351AE RID: 217518
			UpLeft,
			// Token: 0x040351AF RID: 217519
			Left,
			// Token: 0x040351B0 RID: 217520
			DowLeft,
			// Token: 0x040351B1 RID: 217521
			Down,
			// Token: 0x040351B2 RID: 217522
			DownRight
		}
	}
}
