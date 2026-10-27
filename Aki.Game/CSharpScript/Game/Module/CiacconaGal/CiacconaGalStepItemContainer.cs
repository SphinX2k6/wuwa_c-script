using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD7 RID: 23511
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalStepItemContainer : GridProxyAbstract<CiacconaGalStepData>
	{
		// Token: 0x0603B6FC RID: 243452 RVA: 0x00E2C3D4 File Offset: 0x00E2A5D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B6FD RID: 243453 RVA: 0x00E2C480 File Offset: 0x00E2A680
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepItemContainer.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepItemContainer.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B6FE RID: 243454 RVA: 0x00E2C4C4 File Offset: 0x00E2A6C4
		[NullableContext(1)]
		public override void Refresh(CiacconaGalStepData data, bool isSelected, int gridIndex)
		{
			this.StepData = data;
			this.ChosenItem.SetActive(this.ShouldShowChosenItem());
			this.TextItem.SetActive(this.ShouldShowTextItem());
			this.SubEndingItem.SetActive(this.ShouldShowSubEndingItem());
			this.ChoiceListItem.SetActive(this.ShouldShowChoiceListItem());
			if (this.ShouldShowChosenItem())
			{
				CiacconaGalChoiceData choiceDataById = CiacconaGalModel.Instance.GetChoiceDataById(data.ChosenId);
				this.ChosenItem.Refresh(choiceDataById);
			}
			if (this.ShouldShowTextItem())
			{
				this.TextItem.Refresh(data);
			}
			if (this.ShouldShowSubEndingItem())
			{
				CiacconaGalSubEndingData subEndingDataById = CiacconaGalModel.Instance.GetSubEndingDataById(data.SubEndingId);
				this.SubEndingItem.Refresh(subEndingDataById);
				bool flag = CiacconaGalController.Instance.GalPlayer.GetCurState() == ECiacconaGalPlayerState.SubEnding;
				this.SubEndingItem.GetRootItem().SetAlpha(flag > false);
				if (flag)
				{
					this.SubEndingItem.PlayStart();
				}
			}
			if (this.ShouldShowChoiceListItem())
			{
				this.ChoiceListItem.Refresh(data);
			}
		}

		// Token: 0x0603B6FF RID: 243455 RVA: 0x00E2C5C4 File Offset: 0x00E2A7C4
		private bool ShouldShowChosenItem()
		{
			return this.StepData.Type == ECiacconaGalStepType.Choice && this.StepData.Id != CiacconaGalController.Instance.GalPlayer.CurHandlingStepId;
		}

		// Token: 0x0603B700 RID: 243456 RVA: 0x00E2C5F5 File Offset: 0x00E2A7F5
		private bool ShouldShowTextItem()
		{
			return this.StepData.HasText;
		}

		// Token: 0x0603B701 RID: 243457 RVA: 0x00E2C602 File Offset: 0x00E2A802
		private bool ShouldShowSubEndingItem()
		{
			return this.StepData.Type == ECiacconaGalStepType.End;
		}

		// Token: 0x0603B702 RID: 243458 RVA: 0x00E2C614 File Offset: 0x00E2A814
		private bool ShouldShowChoiceListItem()
		{
			ECiacconaGalPlayerState curState = CiacconaGalController.Instance.GalPlayer.GetCurState();
			return this.StepData.Type == ECiacconaGalStepType.Choice && this.StepData.Id == CiacconaGalController.Instance.GalPlayer.CurHandlingStepId && (curState == ECiacconaGalPlayerState.Choosing || curState == ECiacconaGalPlayerState.ChoiceProtecting);
		}

		// Token: 0x0603B703 RID: 243459 RVA: 0x00E2C668 File Offset: 0x00E2A868
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "ChoicesSelect" && this.StepData.ChoiceIds.Length > 1 && this.ShouldShowChoiceListItem())
			{
				UUIItem item = base.GetItem(3);
				return new UUIItem[]
				{
					item,
					item
				};
			}
			if (!(a == "FirstChoice") || !this.ShouldShowChoiceListItem())
			{
				return null;
			}
			CiacconaGalStepChoiceList choiceListItem = this.ChoiceListItem;
			if (choiceListItem == null)
			{
				return null;
			}
			return choiceListItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401EF85 RID: 126853
		private CiacconaGalStepChosenItem ChosenItem;

		// Token: 0x0401EF86 RID: 126854
		private CiacconaGalStepTextItem TextItem;

		// Token: 0x0401EF87 RID: 126855
		private CiacconaGalStepSubEndingItem SubEndingItem;

		// Token: 0x0401EF88 RID: 126856
		private CiacconaGalStepChoiceList ChoiceListItem;

		// Token: 0x0401EF89 RID: 126857
		private CiacconaGalStepData StepData;

		// Token: 0x0200BDB1 RID: 48561
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403934E RID: 234318
			public const int ChosenItem = 0;

			// Token: 0x0403934F RID: 234319
			public const int TextItem = 1;

			// Token: 0x04039350 RID: 234320
			public const int SubEndingItem = 2;

			// Token: 0x04039351 RID: 234321
			public const int ChoiceListItem = 3;
		}
	}
}
