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
	// Token: 0x02004BB7 RID: 19383
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalStepItemContainer : GridProxyAbstract<CiacconaGalStepData>
	{
		// Token: 0x06030647 RID: 198215 RVA: 0x00D7C6DC File Offset: 0x00D7A8DC
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

		// Token: 0x06030648 RID: 198216 RVA: 0x00D7C788 File Offset: 0x00D7A988
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepItemContainer.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepItemContainer.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030649 RID: 198217 RVA: 0x00D7C7CC File Offset: 0x00D7A9CC
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

		// Token: 0x0603064A RID: 198218 RVA: 0x00D7C8CC File Offset: 0x00D7AACC
		private bool ShouldShowChosenItem()
		{
			return this.StepData.Type == ECiacconaGalStepType.Choice && this.StepData.Id != CiacconaGalController.Instance.GalPlayer.CurHandlingStepId;
		}

		// Token: 0x0603064B RID: 198219 RVA: 0x00D7C8FD File Offset: 0x00D7AAFD
		private bool ShouldShowTextItem()
		{
			return this.StepData.HasText;
		}

		// Token: 0x0603064C RID: 198220 RVA: 0x00D7C90A File Offset: 0x00D7AB0A
		private bool ShouldShowSubEndingItem()
		{
			return this.StepData.Type == ECiacconaGalStepType.End;
		}

		// Token: 0x0603064D RID: 198221 RVA: 0x00D7C91C File Offset: 0x00D7AB1C
		private bool ShouldShowChoiceListItem()
		{
			ECiacconaGalPlayerState curState = CiacconaGalController.Instance.GalPlayer.GetCurState();
			return this.StepData.Type == ECiacconaGalStepType.Choice && this.StepData.Id == CiacconaGalController.Instance.GalPlayer.CurHandlingStepId && (curState == ECiacconaGalPlayerState.Choosing || curState == ECiacconaGalPlayerState.ChoiceProtecting);
		}

		// Token: 0x0603064E RID: 198222 RVA: 0x00D7C970 File Offset: 0x00D7AB70
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

		// Token: 0x04019A36 RID: 105014
		private CiacconaGalStepChosenItem ChosenItem;

		// Token: 0x04019A37 RID: 105015
		private CiacconaGalStepTextItem TextItem;

		// Token: 0x04019A38 RID: 105016
		private CiacconaGalStepSubEndingItem SubEndingItem;

		// Token: 0x04019A39 RID: 105017
		private CiacconaGalStepChoiceList ChoiceListItem;

		// Token: 0x04019A3A RID: 105018
		private CiacconaGalStepData StepData;

		// Token: 0x0200A7BA RID: 42938
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D13 RID: 212243
			public const int ChosenItem = 0;

			// Token: 0x04033D14 RID: 212244
			public const int TextItem = 1;

			// Token: 0x04033D15 RID: 212245
			public const int SubEndingItem = 2;

			// Token: 0x04033D16 RID: 212246
			public const int ChoiceListItem = 3;
		}
	}
}
