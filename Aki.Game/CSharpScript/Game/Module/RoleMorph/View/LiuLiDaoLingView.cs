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
	// Token: 0x02003D33 RID: 15667
	[NullableContext(1)]
	[Nullable(0)]
	public class LiuLiDaoLingView : UiTickViewBase
	{
		// Token: 0x0602821F RID: 164383 RVA: 0x00B3BC86 File Offset: 0x00B39E86
		public LiuLiDaoLingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028220 RID: 164384 RVA: 0x00B3BC9C File Offset: 0x00B39E9C
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

		// Token: 0x06028221 RID: 164385 RVA: 0x00B3BE2C File Offset: 0x00B3A02C
		protected override UniTask OnBeforeStartAsync()
		{
			LiuLiDaoLingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LiuLiDaoLingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028222 RID: 164386 RVA: 0x00B3BE70 File Offset: 0x00B3A070
		public UniTask NewAllSkillItems()
		{
			LiuLiDaoLingView.<NewAllSkillItems>d__5 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<LiuLiDaoLingView.<NewAllSkillItems>d__5>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06028223 RID: 164387 RVA: 0x00B3BEB4 File Offset: 0x00B3A0B4
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

		// Token: 0x06028224 RID: 164388 RVA: 0x00B3BF08 File Offset: 0x00B3A108
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(0, EInputAxis.MoveRight, -1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[1].RefreshByMoveType(1, EInputAxis.MoveRight, 1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[2].RefreshByMoveType(2, EInputAxis.MoveForward, 1f, new Action<int>(this.OnPressItem));
			this.SkillItemList[3].RefreshByMoveType(3, EInputAxis.MoveForward, -1f, new Action<int>(this.OnPressItem));
		}

		// Token: 0x06028225 RID: 164389 RVA: 0x00B3BFB8 File Offset: 0x00B3A1B8
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

		// Token: 0x06028226 RID: 164390 RVA: 0x00B3BFF4 File Offset: 0x00B3A1F4
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

		// Token: 0x06028227 RID: 164391 RVA: 0x00B3C064 File Offset: 0x00B3A264
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

		// Token: 0x06028228 RID: 164392 RVA: 0x00B3C0DC File Offset: 0x00B3A2DC
		protected override void OnBeforeDestroy()
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x00B3C138 File Offset: 0x00B3A338
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

		// Token: 0x0602822A RID: 164394 RVA: 0x00B3C1D8 File Offset: 0x00B3A3D8
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (last == EInputControllerMainType.Gamepad)
			{
				this.ClearPress();
			}
		}

		// Token: 0x0602822B RID: 164395 RVA: 0x00B3C1E4 File Offset: 0x00B3A3E4
		private void ClearPress()
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Press(false);
			}
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x00B3C238 File Offset: 0x00B3A438
		private void OnClickReset()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "重新挑战");
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x00B3C24F File Offset: 0x00B3A44F
		private void OnClickClose()
		{
			EventSystem.Instance.Emit<string>(EEventName.ChallengeAgain, "玩法放弃");
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x00B3C268 File Offset: 0x00B3A468
		protected override void OnTick(float delta)
		{
			foreach (LiuLiDaoLingSkillItem liuLiDaoLingSkillItem in this.SkillItemList)
			{
				liuLiDaoLingSkillItem.Tick(delta);
			}
		}

		// Token: 0x04015CFA RID: 89338
		private readonly List<LiuLiDaoLingSkillItem> SkillItemList = new List<LiuLiDaoLingSkillItem>();

		// Token: 0x02009912 RID: 39186
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402FBF6 RID: 195574
			LeftContainer,
			// Token: 0x0402FBF7 RID: 195575
			Item1,
			// Token: 0x0402FBF8 RID: 195576
			Item2,
			// Token: 0x0402FBF9 RID: 195577
			Item3,
			// Token: 0x0402FBFA RID: 195578
			Item4,
			// Token: 0x0402FBFB RID: 195579
			BtnReset,
			// Token: 0x0402FBFC RID: 195580
			BtnClose,
			// Token: 0x0402FBFD RID: 195581
			BtnHelp
		}
	}
}
