using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D22 RID: 23842
	public class FishingButton : UiPanelBase
	{
		// Token: 0x0603C718 RID: 247576 RVA: 0x00E7E85C File Offset: 0x00E7CA5C
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
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			}
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603C719 RID: 247577 RVA: 0x00E7E92C File Offset: 0x00E7CB2C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingButton.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingButton.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C71A RID: 247578 RVA: 0x00E7E96F File Offset: 0x00E7CB6F
		protected override void OnBeforeShow()
		{
			if (this.ActionName == "切换角色3")
			{
				FishingModel.Instance.RefreshTechCanLevelUp();
			}
		}

		// Token: 0x0603C71B RID: 247579 RVA: 0x00E7E98D File Offset: 0x00E7CB8D
		private void OnClickedButton()
		{
			FishingController.Instance.FishingInputHandler(this.ActionName);
		}

		// Token: 0x0603C71C RID: 247580 RVA: 0x00E7E99F File Offset: 0x00E7CB9F
		protected override void OnBeforeDestroy()
		{
			if (this.ActionName == "切换角色3")
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingTech, base.GetItem(1), 0);
			}
		}

		// Token: 0x0401F7F7 RID: 129015
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401F7F8 RID: 129016
		[Nullable(1)]
		private string ActionName = string.Empty;

		// Token: 0x0200BFA7 RID: 49063
		private enum EChildType
		{
			// Token: 0x04039D1E RID: 236830
			Button,
			// Token: 0x04039D1F RID: 236831
			RedDotItem,
			// Token: 0x04039D20 RID: 236832
			KeyItem
		}
	}
}
