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
	// Token: 0x02004D6A RID: 19818
	[NullableContext(1)]
	[Nullable(0)]
	public class LiuLiDaoLingView : UiTickViewBase
	{
		// Token: 0x060333B1 RID: 209841 RVA: 0x00BF2A62 File Offset: 0x00BF0C62
		public LiuLiDaoLingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060333B2 RID: 209842 RVA: 0x00BF2A78 File Offset: 0x00BF0C78
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
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickReset));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060333B3 RID: 209843 RVA: 0x00BF2C08 File Offset: 0x00BF0E08
		protected override UniTask OnBeforeStartAsync()
		{
			LiuLiDaoLingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LiuLiDaoLingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060333B4 RID: 209844 RVA: 0x00BF2C4C File Offset: 0x00BF0E4C
		public UniTask NewAllSkillItems()
		{
			LiuLiDaoLingView.<NewAllSkillItems>d__5 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<LiuLiDaoLingView.<NewAllSkillItems>d__5>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x060333B5 RID: 209845 RVA: 0x00BF2C90 File Offset: 0x00BF0E90
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<LiuLiDaoLingSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			LiuLiDaoLingView.<NewSkillItem>d__6 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<LiuLiDaoLingSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<LiuLiDaoLingView.<NewSkillItem>d__6>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x060333B6 RID: 209846 RVA: 0x00BF2CE4 File Offset: 0x00BF0EE4
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(0, EInputAxis.MoveRight, -1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[1].RefreshByMoveType(1, EInputAxis.MoveRight, 1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[2].RefreshByMoveType(2, EInputAxis.MoveForward, 1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[3].RefreshByMoveType(3, EInputAxis.MoveForward, -1f, new Action<int>(this.OnPressItem));
		}

		// Token: 0x060333B7 RID: 209847 RVA: 0x00BF2D94 File Offset: 0x00BF0F94
		private void OnPressItem(int index)
		{
			for (int i = 0; i < this.SkillItemList.Count; i++)
			{
				if (i != index)
				{
					this.SkillItemList[i].Press(false);
				}
			}
		}

		// Token: 0x060333B8 RID: 209848 RVA: 0x00BF2DD0 File Offset: 0x00BF0FD0
		protected override void OnAddEventListener()
		{
			InputDistributeController.Instance.BindActions(new List<string>
			{
				"UI方向上",
				"UI方向下",
				"UI方向左",
				"UI方向右"
			}, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x060333B9 RID: 209849 RVA: 0x00BF2E40 File Offset: 0x00BF1040
		protected override void OnRemoveEventListener()
		{
			this.ClearPress();
			InputDistributeController.Instance.UnBindActions(new List<string>
			{
				"UI方向上",
				"UI方向下",
				"UI方向左",
				"UI方向右"
			}, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x060333BA RID: 209850 RVA: 0x00BF2EB8 File Offset: 0x00BF10B8
		protected override void OnBeforeDestroy()
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
		}

		// Token: 0x060333BB RID: 209851 RVA: 0x00BF2F14 File Offset: 0x00BF1114
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			bool isPress = actionType == InputDistributeDefine.EActionType.Press;
			if (actionName == "UI方向左")
			{
				this.SkillItemList[0].Press(isPress);
				return;
			}
			if (actionName == "UI方向右")
			{
				this.SkillItemList[1].Press(isPress);
				return;
			}
			if (actionName == "UI方向上")
			{
				this.SkillItemList[2].Press(isPress);
				return;
			}
			if (actionName == "UI方向下")
			{
				this.SkillItemList[3].Press(isPress);
			}
		}

		// Token: 0x060333BC RID: 209852 RVA: 0x00BF2FB4 File Offset: 0x00BF11B4
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (last == EInputControllerMainType.Gamepad)
			{
				this.ClearPress();
			}
		}

		// Token: 0x060333BD RID: 209853 RVA: 0x00BF2FC0 File Offset: 0x00BF11C0
		private void ClearPress()
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Press(false);
			}
		}

		// Token: 0x060333BE RID: 209854 RVA: 0x00BF3014 File Offset: 0x00BF1214
		private void OnClickReset()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "重新挑战");
		}

		// Token: 0x060333BF RID: 209855 RVA: 0x00BF302B File Offset: 0x00BF122B
		private void OnClickClose()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "玩法放弃");
		}

		// Token: 0x060333C0 RID: 209856 RVA: 0x00BF3044 File Offset: 0x00BF1244
		protected override void OnTick(float delta)
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Tick(delta);
			}
		}

		// Token: 0x0401B328 RID: 111400
		private readonly List<LiuLiDaoLingSkillItem> SkillItemList = new List<LiuLiDaoLingSkillItem>();

		// Token: 0x0200AEDF RID: 44767
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040351C5 RID: 217541
			LeftContainer,
			// Token: 0x040351C6 RID: 217542
			Item1,
			// Token: 0x040351C7 RID: 217543
			Item2,
			// Token: 0x040351C8 RID: 217544
			Item3,
			// Token: 0x040351C9 RID: 217545
			Item4,
			// Token: 0x040351CA RID: 217546
			BtnReset,
			// Token: 0x040351CB RID: 217547
			BtnClose,
			// Token: 0x040351CC RID: 217548
			BtnHelp
		}
	}
}
