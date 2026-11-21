using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005089 RID: 20617
	public class RoverlikeGeneralActionView : RoverlikeActionViewBase
	{
		// Token: 0x0603399E RID: 211358 RVA: 0x00E71885 File Offset: 0x00E6FA85
		[NullableContext(1)]
		public RoverlikeGeneralActionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603399F RID: 211359 RVA: 0x00E71890 File Offset: 0x00E6FA90
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

		// Token: 0x060339A0 RID: 211360 RVA: 0x00E718FC File Offset: 0x00E6FAFC
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeGeneralActionView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeGeneralActionView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060339A1 RID: 211361 RVA: 0x00E71940 File Offset: 0x00E6FB40
		protected override void OnStart()
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager == null)
			{
				return;
			}
			actionSubViewManager.OnAllSubViewsFinished = delegate()
			{
				base.CloseMe(null);
			};
			actionSubViewManager.RegisterHost(base.GetItem(1));
			actionSubViewManager.RegisterTopPanel(this.TopPanel);
		}

		// Token: 0x060339A2 RID: 211362 RVA: 0x00E71987 File Offset: 0x00E6FB87
		protected override void OnBeforeShow()
		{
			RoverlikeBattleTopPanel topPanel = this.TopPanel;
			if (topPanel == null)
			{
				return;
			}
			topPanel.StartShow();
		}

		// Token: 0x060339A3 RID: 211363 RVA: 0x00E71999 File Offset: 0x00E6FB99
		protected override void OnBeforeHide()
		{
			RoverlikeBattleTopPanel topPanel = this.TopPanel;
			if (topPanel == null)
			{
				return;
			}
			topPanel.EndShow();
		}

		// Token: 0x060339A4 RID: 211364 RVA: 0x00E719AC File Offset: 0x00E6FBAC
		protected override void OnBeforeDestroy()
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager != null)
			{
				actionSubViewManager.UnregisterHost();
			}
		}

		// Token: 0x060339A5 RID: 211365 RVA: 0x00E719CD File Offset: 0x00E6FBCD
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			RoverlikeActionSubViewManager roverlikeActionSubViewManager = (instance != null) ? instance.ActionSubViewManager : null;
			if (roverlikeActionSubViewManager == null)
			{
				return null;
			}
			RoverlikeActionSubViewBase currentSubView = roverlikeActionSubViewManager.GetCurrentSubView();
			if (currentSubView == null)
			{
				return null;
			}
			return currentSubView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401B62A RID: 112170
		[Nullable(2)]
		protected RoverlikeBattleTopPanel TopPanel;

		// Token: 0x0200AD43 RID: 44355
		private class EComponents
		{
			// Token: 0x040358C2 RID: 219330
			public const int ItemRogueTop = 0;

			// Token: 0x040358C3 RID: 219331
			public const int Content = 1;
		}
	}
}
