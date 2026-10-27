using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E0D RID: 19981
	public class RoguelikeExitTips : UiViewBase
	{
		// Token: 0x060338D2 RID: 211154 RVA: 0x00C0C832 File Offset: 0x00C0AA32
		[NullableContext(1)]
		public RoguelikeExitTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060338D3 RID: 211155 RVA: 0x00C0C83C File Offset: 0x00C0AA3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060338D4 RID: 211156 RVA: 0x00C0C8E8 File Offset: 0x00C0AAE8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeExitTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeExitTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060338D5 RID: 211157 RVA: 0x00C0C92C File Offset: 0x00C0AB2C
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoguelikeExitTipsCurRoom", new <>z__ReadOnlyArray<object>(new object[]
			{
				RoguelikeModel.Instance.CurRoomCount,
				RoguelikeModel.Instance.TotalRoomCount
			}));
			this.ButtonItemSettle.GetBtn().RootUIComp.Get().SetUIActive(!RoguelikeModel.Instance.CheckIsGuideDungeon());
		}

		// Token: 0x060338D6 RID: 211158 RVA: 0x00C0C9A8 File Offset: 0x00C0ABA8
		private void OnClickBtnSettle(int _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
			{
				RoguelikeController.Instance.RoguelikeResultRequest(0, null);
			});
		}

		// Token: 0x060338D7 RID: 211159 RVA: 0x00C0C9DE File Offset: 0x00C0ABDE
		private void OnClickBtnExit(int _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
			{
				RoguelikeController.Instance.RoguelikeQuitRequest();
			});
		}

		// Token: 0x0401B581 RID: 112001
		[Nullable(2)]
		private ButtonItem ButtonItemSettle;

		// Token: 0x0401B582 RID: 112002
		[Nullable(2)]
		private ButtonItem ButtonItemExit;

		// Token: 0x0200AFA2 RID: 44962
		private class ERoguelikeExitTipsDefine
		{
			// Token: 0x04035526 RID: 218406
			public const int TxtCurRoom = 0;

			// Token: 0x04035527 RID: 218407
			public const int BtnSettle = 1;

			// Token: 0x04035528 RID: 218408
			public const int BtnExit = 2;

			// Token: 0x04035529 RID: 218409
			public const int TxtTips = 3;
		}
	}
}
