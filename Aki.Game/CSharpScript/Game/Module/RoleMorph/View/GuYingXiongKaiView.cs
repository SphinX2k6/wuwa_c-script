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
	// Token: 0x02003D31 RID: 15665
	public class GuYingXiongKaiView : UiTickViewBase
	{
		// Token: 0x06028208 RID: 164360 RVA: 0x00B3B4AE File Offset: 0x00B396AE
		[NullableContext(1)]
		public GuYingXiongKaiView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028209 RID: 164361 RVA: 0x00B3B4C4 File Offset: 0x00B396C4
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

		// Token: 0x0602820A RID: 164362 RVA: 0x00B3B630 File Offset: 0x00B39830
		protected override UniTask OnBeforeStartAsync()
		{
			GuYingXiongKaiView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuYingXiongKaiView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x00B3B674 File Offset: 0x00B39874
		public UniTask NewAllSkillItems()
		{
			GuYingXiongKaiView.<NewAllSkillItems>d__10 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<GuYingXiongKaiView.<NewAllSkillItems>d__10>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x00B3B6B8 File Offset: 0x00B398B8
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

		// Token: 0x0602820D RID: 164365 RVA: 0x00B3B70C File Offset: 0x00B3990C
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

		// Token: 0x0602820E RID: 164366 RVA: 0x00B3B782 File Offset: 0x00B39982
		protected override void OnRemoveEventListener()
		{
			if (this.BtnAttack != null)
			{
				this.BtnAttack.OnPointDownCallBack.Unbind();
				this.BtnAttack.OnPointUpCallBack.Unbind();
				this.BtnAttack.OnPointCancelCallBack.Unbind();
			}
		}

		// Token: 0x0602820F RID: 164367 RVA: 0x00B3B7BC File Offset: 0x00B399BC
		protected override void OnBeforeDestroy()
		{
			foreach (GuYingXiongKaiSkillItem guYingXiongKaiSkillItem in this.SkillItemList)
			{
				guYingXiongKaiSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.BtnAttack = null;
		}

		// Token: 0x06028210 RID: 164368 RVA: 0x00B3B820 File Offset: 0x00B39A20
		private void OnClickClose()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "玩法放弃");
		}

		// Token: 0x06028211 RID: 164369 RVA: 0x00B3B837 File Offset: 0x00B39A37
		private void OnAttackButtonPressed()
		{
			InputDistributeController.Instance.InputAction("攻击", true);
		}

		// Token: 0x06028212 RID: 164370 RVA: 0x00B3B84A File Offset: 0x00B39A4A
		private void OnAttackButtonCancel()
		{
			InputDistributeController.Instance.InputAction("攻击", false);
		}

		// Token: 0x06028213 RID: 164371 RVA: 0x00B3B85D File Offset: 0x00B39A5D
		private void OnAttackButtonReleased()
		{
			InputDistributeController.Instance.InputAction("攻击", false);
		}

		// Token: 0x06028214 RID: 164372 RVA: 0x00B3B870 File Offset: 0x00B39A70
		protected override void OnTick(float delta)
		{
			foreach (GuYingXiongKaiSkillItem guYingXiongKaiSkillItem in this.SkillItemList)
			{
				guYingXiongKaiSkillItem.Tick(delta);
			}
			this.OnTickGetCursorInput();
		}

		// Token: 0x06028215 RID: 164373 RVA: 0x00B3B8C8 File Offset: 0x00B39AC8
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

		// Token: 0x04015CEF RID: 89327
		[Nullable(1)]
		private readonly List<GuYingXiongKaiSkillItem> SkillItemList = new List<GuYingXiongKaiSkillItem>();

		// Token: 0x04015CF0 RID: 89328
		[Nullable(2)]
		private UUIButtonComponent BtnAttack;

		// Token: 0x04015CF1 RID: 89329
		private const float SECTOR_ANGLE_SIZE = 0.022222223f;

		// Token: 0x04015CF2 RID: 89330
		private const float HALF_SECTOR_ANGLE_SIZE = 22.5f;

		// Token: 0x04015CF3 RID: 89331
		private const int SECTOR_NUM = 8;

		// Token: 0x04015CF4 RID: 89332
		private GuYingXiongKaiView.ESectorScreen LastSector;

		// Token: 0x0200990C RID: 39180
		private enum EChildType
		{
			// Token: 0x0402FBD3 RID: 195539
			LeftContainer,
			// Token: 0x0402FBD4 RID: 195540
			Item1,
			// Token: 0x0402FBD5 RID: 195541
			Item2,
			// Token: 0x0402FBD6 RID: 195542
			Item3,
			// Token: 0x0402FBD7 RID: 195543
			Item4,
			// Token: 0x0402FBD8 RID: 195544
			BtnReset,
			// Token: 0x0402FBD9 RID: 195545
			BtnClose,
			// Token: 0x0402FBDA RID: 195546
			BtnHelp
		}

		// Token: 0x0200990D RID: 39181
		private enum ESectorScreen
		{
			// Token: 0x0402FBDC RID: 195548
			Right,
			// Token: 0x0402FBDD RID: 195549
			UpRight,
			// Token: 0x0402FBDE RID: 195550
			Up,
			// Token: 0x0402FBDF RID: 195551
			UpLeft,
			// Token: 0x0402FBE0 RID: 195552
			Left,
			// Token: 0x0402FBE1 RID: 195553
			DowLeft,
			// Token: 0x0402FBE2 RID: 195554
			Down,
			// Token: 0x0402FBE3 RID: 195555
			DownRight
		}
	}
}
