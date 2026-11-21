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
	// Token: 0x02003DD6 RID: 15830
	public class RoguelikeExitTips : UiViewBase
	{
		// Token: 0x0602873D RID: 165693 RVA: 0x00B55D3E File Offset: 0x00B53F3E
		[NullableContext(1)]
		public RoguelikeExitTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602873E RID: 165694 RVA: 0x00B55D48 File Offset: 0x00B53F48
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

		// Token: 0x0602873F RID: 165695 RVA: 0x00B55DF4 File Offset: 0x00B53FF4
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeExitTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeExitTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028740 RID: 165696 RVA: 0x00B55E38 File Offset: 0x00B54038
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoguelikeExitTipsCurRoom", new <>z__ReadOnlyArray<object>(new object[]
			{
				RoguelikeModel.Instance.CurRoomCount,
				RoguelikeModel.Instance.TotalRoomCount
			}));
			this.ButtonItemSettle.GetBtn().RootUIComp.Get().SetUIActive(!RoguelikeModel.Instance.CheckIsGuideDungeon());
		}

		// Token: 0x06028741 RID: 165697 RVA: 0x00B55EB4 File Offset: 0x00B540B4
		private void OnClickBtnSettle(int _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
			{
				RoguelikeController.Instance.RoguelikeResultRequest(0, null);
			});
		}

		// Token: 0x06028742 RID: 165698 RVA: 0x00B55EEA File Offset: 0x00B540EA
		private void OnClickBtnExit(int _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
			{
				RoguelikeController.Instance.RoguelikeQuitRequest();
			});
		}

		// Token: 0x04015F54 RID: 89940
		[Nullable(2)]
		private ButtonItem ButtonItemSettle;

		// Token: 0x04015F55 RID: 89941
		[Nullable(2)]
		private ButtonItem ButtonItemExit;

		// Token: 0x020099D7 RID: 39383
		private class ERoguelikeExitTipsDefine
		{
			// Token: 0x0402FF59 RID: 196441
			public const int TxtCurRoom = 0;

			// Token: 0x0402FF5A RID: 196442
			public const int BtnSettle = 1;

			// Token: 0x0402FF5B RID: 196443
			public const int BtnExit = 2;

			// Token: 0x0402FF5C RID: 196444
			public const int TxtTips = 3;
		}
	}
}
