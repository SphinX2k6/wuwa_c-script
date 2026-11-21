using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CAA RID: 19626
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSkillPanel : BattleVisibleChildView, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x0603103E RID: 200766 RVA: 0x00DADB0E File Offset: 0x00DABD0E
		public void CreateDynamic(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_SkillVisionB", parentItem, false).Forget();
		}

		// Token: 0x0603103F RID: 200767 RVA: 0x00DADB24 File Offset: 0x00DABD24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031040 RID: 200768 RVA: 0x00DADB90 File Offset: 0x00DABD90
		protected override UniTask OnBeforeStartAsync()
		{
			MoveSkillPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoveSkillPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031041 RID: 200769 RVA: 0x00DADBD4 File Offset: 0x00DABDD4
		public UniTask NewAllSkillItems()
		{
			MoveSkillPanel.<NewAllSkillItems>d__6 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<MoveSkillPanel.<NewAllSkillItems>d__6>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031042 RID: 200770 RVA: 0x00DADC18 File Offset: 0x00DABE18
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<MoveSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			MoveSkillPanel.<NewSkillItem>d__7 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<MoveSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<MoveSkillPanel.<NewSkillItem>d__7>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031043 RID: 200771 RVA: 0x00DADC6C File Offset: 0x00DABE6C
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveForward, 1f, true);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveForward, -1f, true);
			this.SkillItemList[0].RefreshKeyByActionName("向前移动");
			this.SkillItemList[1].RefreshKeyByActionName("向后移动");
			this.SkillItemList[0].RefreshSkillIconByResId("SP_IconVision01A");
			this.SkillItemList[1].RefreshSkillIconByResId("SP_IconVision01B");
		}

		// Token: 0x06031044 RID: 200772 RVA: 0x00DADD0C File Offset: 0x00DABF0C
		public void Tick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x06031045 RID: 200773 RVA: 0x00DADD60 File Offset: 0x00DABF60
		protected override void OnBeforeDestroy()
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEvents();
		}

		// Token: 0x06031046 RID: 200774 RVA: 0x00DADDC4 File Offset: 0x00DABFC4
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(MoveSkillPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031047 RID: 200775 RVA: 0x00DADDED File Offset: 0x00DABFED
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(MoveSkillPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031048 RID: 200776 RVA: 0x00DADE18 File Offset: 0x00DAC018
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (actionName == "向前移动")
			{
				this.SkillItemList[0].OnInputAction(false);
				return;
			}
			if (actionName == "向后移动")
			{
				this.SkillItemList[1].OnInputAction(false);
			}
		}

		// Token: 0x0603104A RID: 200778 RVA: 0x00DADE7C File Offset: 0x00DAC07C
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static MoveSkillPanel()
		{
			int num = 2;
			List<string> list = new List<string>(num);
			CollectionsMarshal.SetCount<string>(list, num);
			Span<string> span = CollectionsMarshal.AsSpan<string>(list);
			int num2 = 0;
			*span[num2] = "向前移动";
			num2++;
			*span[num2] = "向后移动";
			MoveSkillPanel.ActionNameList = list;
		}

		// Token: 0x04019FDE RID: 106462
		[StaticVariableRuleIgnore]
		private static readonly List<string> ActionNameList;

		// Token: 0x04019FDF RID: 106463
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0200A8D8 RID: 43224
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403428B RID: 213643
			Item1,
			// Token: 0x0403428C RID: 213644
			Item2
		}
	}
}
