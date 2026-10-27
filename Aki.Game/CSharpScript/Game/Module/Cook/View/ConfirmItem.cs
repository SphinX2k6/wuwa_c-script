using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B19 RID: 23321
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfirmItem : UiPanelBase
	{
		// Token: 0x0603B097 RID: 241815 RVA: 0x00E13088 File Offset: 0x00E11288
		public UniTask Initialize(UUIItem uiItem)
		{
			ConfirmItem.<Initialize>d__2 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.uiItem = uiItem;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<ConfirmItem.<Initialize>d__2>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0603B098 RID: 241816 RVA: 0x00E130D4 File Offset: 0x00E112D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(delegate()
			{
				this.OnConfirm();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B099 RID: 241817 RVA: 0x00E1319B File Offset: 0x00E1139B
		protected override void OnStart()
		{
			base.GetButton(0).SetCanClickWhenDisable(true);
		}

		// Token: 0x0603B09A RID: 241818 RVA: 0x00E131AA File Offset: 0x00E113AA
		public void ShowConfirmItem(bool isShow)
		{
			this.SetActive(isShow);
		}

		// Token: 0x0603B09B RID: 241819 RVA: 0x00E131B4 File Offset: 0x00E113B4
		public void SetEnable()
		{
			int cookerMaxLevel = CookModel.Instance.GetCookerMaxLevel();
			int cookingLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			int selectedCookerLevel = CookModel.Instance.SelectedCookerLevel;
			AUIBaseActor auibaseActor = base.GetButton(0).GetOwner() as AUIBaseActor;
			if (cookingLevel >= cookerMaxLevel || selectedCookerLevel >= cookerMaxLevel || selectedCookerLevel < cookingLevel)
			{
				auibaseActor.GetUIItem().SetUIActive(false);
				return;
			}
			auibaseActor.GetUIItem().SetUIActive(true);
			int totalProficiencys = CookModel.Instance.GetCookerInfo().TotalProficiencys;
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.SelectedCookerLevel);
			base.GetButton(0).SetSelfInteractive(totalProficiencys >= sumExpByLevel);
			base.GetItem(2).SetUIActive(totalProficiencys >= sumExpByLevel);
		}

		// Token: 0x0603B09C RID: 241820 RVA: 0x00E1326F File Offset: 0x00E1146F
		[NullableContext(2)]
		public UUIItem GetRedDot()
		{
			return base.GetItem(2);
		}

		// Token: 0x0603B09D RID: 241821 RVA: 0x00E13278 File Offset: 0x00E11478
		public void BindOnClickedCallback(Action onConfirmCallback)
		{
			this.OnConfirmCallback = onConfirmCallback;
		}

		// Token: 0x0603B09E RID: 241822 RVA: 0x00E13281 File Offset: 0x00E11481
		private void OnConfirm()
		{
			if (this.OnConfirmCallback != null)
			{
				if (base.GetButton(0).GetSelfInteractive())
				{
					this.OnConfirmCallback();
					return;
				}
				GenericPromptController.Instance.ShowPromptByCode("CookUpgrade", Array.Empty<object>());
			}
		}

		// Token: 0x0401ECB9 RID: 126137
		[Nullable(2)]
		private Action OnConfirmCallback;
	}
}
