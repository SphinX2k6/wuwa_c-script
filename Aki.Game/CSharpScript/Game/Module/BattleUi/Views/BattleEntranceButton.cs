using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD2 RID: 23762
	public class BattleEntranceButton : BattleVisibleChildView
	{
		// Token: 0x0603C20D RID: 246285 RVA: 0x00E6473C File Offset: 0x00E6293C
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

		// Token: 0x0603C20E RID: 246286 RVA: 0x00E647E4 File Offset: 0x00E629E4
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

		// Token: 0x0603C20F RID: 246287 RVA: 0x00E648A0 File Offset: 0x00E62AA0
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

		// Token: 0x0603C210 RID: 246288 RVA: 0x00E648E0 File Offset: 0x00E62AE0
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

		// Token: 0x0603C211 RID: 246289 RVA: 0x00E64929 File Offset: 0x00E62B29
		[NullableContext(1)]
		public void SetGetOtherHideCallCall(Func<bool> callBack)
		{
			this.GetCurrentOtherHideCall = callBack;
		}

		// Token: 0x0603C212 RID: 246290 RVA: 0x00E64932 File Offset: 0x00E62B32
		public virtual void SetGamepadHide(bool isGamepad)
		{
			if (!this.HideInGamepad.GetValueOrDefault())
			{
				return;
			}
			base.SetVisible(2, !isGamepad);
		}

		// Token: 0x0603C213 RID: 246291 RVA: 0x00E6494D File Offset: 0x00E62B4D
		public void SetOtherHide(bool isHide)
		{
			base.SetVisible(4, !isHide);
		}

		// Token: 0x0603C214 RID: 246292 RVA: 0x00E6495A File Offset: 0x00E62B5A
		public void SetGmHide(bool isHide)
		{
			base.SetVisible(3, !isHide);
		}

		// Token: 0x0603C215 RID: 246293 RVA: 0x00E64967 File Offset: 0x00E62B67
		[NullableContext(1)]
		public void BindOnClicked(Action onClicked)
		{
			this.OnClicked = onClicked;
		}

		// Token: 0x0603C216 RID: 246294 RVA: 0x00E64970 File Offset: 0x00E62B70
		protected void OnClickedOnlineButton()
		{
			Action onClicked = this.OnClicked;
			if (onClicked == null)
			{
				return;
			}
			onClicked();
		}

		// Token: 0x0401F58F RID: 128399
		[Nullable(2)]
		private Action OnClicked;

		// Token: 0x0401F590 RID: 128400
		private ERedDotName? RedDotName;

		// Token: 0x0401F591 RID: 128401
		protected EFunctionType? FunctionType;

		// Token: 0x0401F592 RID: 128402
		protected bool? HideInGamepad;

		// Token: 0x0401F593 RID: 128403
		protected bool? HideByRoleConfig;

		// Token: 0x0401F594 RID: 128404
		[Nullable(2)]
		private Func<bool> GetCurrentOtherHideCall;

		// Token: 0x0200BF21 RID: 48929
		private enum EChildType
		{
			// Token: 0x04039A71 RID: 236145
			Button,
			// Token: 0x04039A72 RID: 236146
			RedDotItem
		}

		// Token: 0x0200BF22 RID: 48930
		private enum EVisibleReason
		{
			// Token: 0x04039A74 RID: 236148
			Default,
			// Token: 0x04039A75 RID: 236149
			FunctionOpen,
			// Token: 0x04039A76 RID: 236150
			Gamepad,
			// Token: 0x04039A77 RID: 236151
			Gm,
			// Token: 0x04039A78 RID: 236152
			Other
		}
	}
}
