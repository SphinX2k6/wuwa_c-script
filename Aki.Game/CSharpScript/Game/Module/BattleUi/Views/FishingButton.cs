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
	// Token: 0x02004D04 RID: 19716
	public class FishingButton : UiPanelBase
	{
		// Token: 0x06031671 RID: 202353 RVA: 0x00DCEFFC File Offset: 0x00DCD1FC
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

		// Token: 0x06031672 RID: 202354 RVA: 0x00DCF0CC File Offset: 0x00DCD2CC
		protected override UniTask OnBeforeStartAsync()
		{
			FishingButton.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingButton.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031673 RID: 202355 RVA: 0x00DCF10F File Offset: 0x00DCD30F
		protected override void OnBeforeShow()
		{
			if (this.ActionName == "切换角色3")
			{
				FishingModel.Instance.RefreshTechCanLevelUp();
			}
		}

		// Token: 0x06031674 RID: 202356 RVA: 0x00DCF12D File Offset: 0x00DCD32D
		private void OnClickedButton()
		{
			FishingController.Instance.FishingInputHandler(this.ActionName);
		}

		// Token: 0x06031675 RID: 202357 RVA: 0x00DCF13F File Offset: 0x00DCD33F
		protected override void OnBeforeDestroy()
		{
			if (this.ActionName == "切换角色3")
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingTech, base.GetItem(1), 0);
			}
		}

		// Token: 0x0401A2B0 RID: 107184
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401A2B1 RID: 107185
		[Nullable(1)]
		private string ActionName = string.Empty;

		// Token: 0x0200A9AD RID: 43437
		private enum EChildType
		{
			// Token: 0x040346E0 RID: 214752
			Button,
			// Token: 0x040346E1 RID: 214753
			RedDotItem,
			// Token: 0x040346E2 RID: 214754
			KeyItem
		}
	}
}
