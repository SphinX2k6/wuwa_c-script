using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB4 RID: 19636
	public class BattleEntranceButton : BattleVisibleChildView
	{
		// Token: 0x06031163 RID: 201059 RVA: 0x00DB4D18 File Offset: 0x00DB2F18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedOnlineButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031164 RID: 201060 RVA: 0x00DB4DC0 File Offset: 0x00DB2FC0
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			if (param == null)
			{
				return;
			}
			EntranceButtonParameter entranceButtonParameter = param as EntranceButtonParameter;
			if (entranceButtonParameter == null)
			{
				throw new InvalidCastException();
			}
			this.HideInGamepad = new bool?(entranceButtonParameter.HideInGamepad);
			this.HideByRoleConfig = new bool?(entranceButtonParameter.HideByRoleConfig);
			ERedDotName? redDotName = entranceButtonParameter.RedDotName;
			if (redDotName != null)
			{
				this.RedDotName = redDotName;
				RedDotController.Instance.BindRedDot(redDotName.Value, base.GetItem(1), null, 0);
			}
			base.InitChildType(entranceButtonParameter.ChildType);
			EFunctionType? functionType = entranceButtonParameter.FunctionType;
			if (functionType != null)
			{
				this.FunctionType = functionType;
				this.SetFunctionOpen(functionType.Value, FunctionModel.Instance.IsOpen((int)functionType.Value));
			}
		}

		// Token: 0x06031165 RID: 201061 RVA: 0x00DB4E7C File Offset: 0x00DB307C
		public override void Reset()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
				this.RedDotName = null;
			}
			this.OnClicked = null;
			base.Reset();
		}

		// Token: 0x06031166 RID: 201062 RVA: 0x00DB4EBC File Offset: 0x00DB30BC
		public void SetFunctionOpen(EFunctionType functionType, bool isOpen)
		{
			EFunctionType? functionType2 = this.FunctionType;
			if (!(functionType == functionType2.GetValueOrDefault() & functionType2 != null))
			{
				return;
			}
			base.SetVisible(1, isOpen);
			Func<bool> getCurrentOtherHideCall = this.GetCurrentOtherHideCall;
			this.SetOtherHide(getCurrentOtherHideCall != null && getCurrentOtherHideCall());
		}

		// Token: 0x06031167 RID: 201063 RVA: 0x00DB4F05 File Offset: 0x00DB3105
		[NullableContext(1)]
		public void SetGetOtherHideCallCall(Func<bool> callBack)
		{
			this.GetCurrentOtherHideCall = callBack;
		}

		// Token: 0x06031168 RID: 201064 RVA: 0x00DB4F0E File Offset: 0x00DB310E
		public virtual void SetGamepadHide(bool isGamepad)
		{
			if (!this.HideInGamepad.GetValueOrDefault())
			{
				return;
			}
			base.SetVisible(2, !isGamepad);
		}

		// Token: 0x06031169 RID: 201065 RVA: 0x00DB4F29 File Offset: 0x00DB3129
		public void SetOtherHide(bool isHide)
		{
			base.SetVisible(4, !isHide);
		}

		// Token: 0x0603116A RID: 201066 RVA: 0x00DB4F36 File Offset: 0x00DB3136
		public void SetGmHide(bool isHide)
		{
			base.SetVisible(3, !isHide);
		}

		// Token: 0x0603116B RID: 201067 RVA: 0x00DB4F43 File Offset: 0x00DB3143
		[NullableContext(1)]
		public void BindOnClicked(Action onClicked)
		{
			this.OnClicked = onClicked;
		}

		// Token: 0x0603116C RID: 201068 RVA: 0x00DB4F4C File Offset: 0x00DB314C
		protected void OnClickedOnlineButton()
		{
			Action onClicked = this.OnClicked;
			if (onClicked == null)
			{
				return;
			}
			onClicked();
		}

		// Token: 0x0401A048 RID: 106568
		[Nullable(2)]
		private Action OnClicked;

		// Token: 0x0401A049 RID: 106569
		private ERedDotName? RedDotName;

		// Token: 0x0401A04A RID: 106570
		protected EFunctionType? FunctionType;

		// Token: 0x0401A04B RID: 106571
		protected bool? HideInGamepad;

		// Token: 0x0401A04C RID: 106572
		protected bool? HideByRoleConfig;

		// Token: 0x0401A04D RID: 106573
		[Nullable(2)]
		private Func<bool> GetCurrentOtherHideCall;

		// Token: 0x0200A927 RID: 43303
		private enum EChildType
		{
			// Token: 0x04034433 RID: 214067
			Button,
			// Token: 0x04034434 RID: 214068
			RedDotItem
		}

		// Token: 0x0200A928 RID: 43304
		private enum EVisibleReason
		{
			// Token: 0x04034436 RID: 214070
			Default,
			// Token: 0x04034437 RID: 214071
			FunctionOpen,
			// Token: 0x04034438 RID: 214072
			Gamepad,
			// Token: 0x04034439 RID: 214073
			Gm,
			// Token: 0x0403443A RID: 214074
			Other
		}
	}
}
