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
	// Token: 0x02005CC8 RID: 23752
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSkillPanel : BattleVisibleChildView, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x0603C0E9 RID: 245993 RVA: 0x00E5D3FA File Offset: 0x00E5B5FA
		public void CreateDynamic(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_SkillVisionB", parentItem, false).Forget();
		}

		// Token: 0x0603C0EA RID: 245994 RVA: 0x00E5D410 File Offset: 0x00E5B610
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

		// Token: 0x0603C0EB RID: 245995 RVA: 0x00E5D47C File Offset: 0x00E5B67C
		protected override UniTask OnBeforeStartAsync()
		{
			MoveSkillPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoveSkillPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C0EC RID: 245996 RVA: 0x00E5D4C0 File Offset: 0x00E5B6C0
		public UniTask NewAllSkillItems()
		{
			MoveSkillPanel.<NewAllSkillItems>d__6 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<MoveSkillPanel.<NewAllSkillItems>d__6>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C0ED RID: 245997 RVA: 0x00E5D504 File Offset: 0x00E5B704
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

		// Token: 0x0603C0EE RID: 245998 RVA: 0x00E5D558 File Offset: 0x00E5B758
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveForward, 1f, true);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveForward, -1f, true);
			this.SkillItemList[0].RefreshKeyByActionName("向前移动");
			this.SkillItemList[1].RefreshKeyByActionName("向后移动");
			this.SkillItemList[0].RefreshSkillIconByResId("SP_IconVision01A");
			this.SkillItemList[1].RefreshSkillIconByResId("SP_IconVision01B");
		}

		// Token: 0x0603C0EF RID: 245999 RVA: 0x00E5D5F8 File Offset: 0x00E5B7F8
		public void Tick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x0603C0F0 RID: 246000 RVA: 0x00E5D64C File Offset: 0x00E5B84C
		protected override void OnBeforeDestroy()
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEvents();
		}

		// Token: 0x0603C0F1 RID: 246001 RVA: 0x00E5D6B0 File Offset: 0x00E5B8B0
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(MoveSkillPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603C0F2 RID: 246002 RVA: 0x00E5D6D9 File Offset: 0x00E5B8D9
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(MoveSkillPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603C0F3 RID: 246003 RVA: 0x00E5D704 File Offset: 0x00E5B904
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

		// Token: 0x0603C0F5 RID: 246005 RVA: 0x00E5D768 File Offset: 0x00E5B968
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

		// Token: 0x0401F525 RID: 128293
		[StaticVariableRuleIgnore]
		private static readonly List<string> ActionNameList;

		// Token: 0x0401F526 RID: 128294
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0200BED2 RID: 48850
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040398CA RID: 235722
			Item1,
			// Token: 0x040398CB RID: 235723
			Item2
		}
	}
}
