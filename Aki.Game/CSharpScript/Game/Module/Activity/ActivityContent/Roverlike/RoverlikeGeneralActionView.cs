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
	// Token: 0x0200610B RID: 24843
	public class RoverlikeGeneralActionView : RoverlikeActionViewBase
	{
		// Token: 0x0603ECDC RID: 257244 RVA: 0x00F2AA71 File Offset: 0x00F28C71
		[NullableContext(1)]
		public RoverlikeGeneralActionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ECDD RID: 257245 RVA: 0x00F2AA7C File Offset: 0x00F28C7C
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

		// Token: 0x0603ECDE RID: 257246 RVA: 0x00F2AAE8 File Offset: 0x00F28CE8
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeGeneralActionView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeGeneralActionView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ECDF RID: 257247 RVA: 0x00F2AB2C File Offset: 0x00F28D2C
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

		// Token: 0x0603ECE0 RID: 257248 RVA: 0x00F2AB73 File Offset: 0x00F28D73
		protected override void OnBeforeShow()
		{
			RoverlikeBattleTopPanel topPanel = this.TopPanel;
			if (topPanel == null)
			{
				return;
			}
			topPanel.StartShow();
		}

		// Token: 0x0603ECE1 RID: 257249 RVA: 0x00F2AB85 File Offset: 0x00F28D85
		protected override void OnBeforeHide()
		{
			RoverlikeBattleTopPanel topPanel = this.TopPanel;
			if (topPanel == null)
			{
				return;
			}
			topPanel.EndShow();
		}

		// Token: 0x0603ECE2 RID: 257250 RVA: 0x00F2AB98 File Offset: 0x00F28D98
		protected override void OnBeforeDestroy()
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager != null)
			{
				actionSubViewManager.UnregisterHost();
			}
		}

		// Token: 0x0603ECE3 RID: 257251 RVA: 0x00F2ABB9 File Offset: 0x00F28DB9
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

		// Token: 0x04020CFD RID: 134397
		[Nullable(2)]
		protected RoverlikeBattleTopPanel TopPanel;

		// Token: 0x0200C35B RID: 50011
		private class EComponents
		{
			// Token: 0x0403AF5D RID: 241501
			public const int ItemRogueTop = 0;

			// Token: 0x0403AF5E RID: 241502
			public const int Content = 1;
		}
	}
}
