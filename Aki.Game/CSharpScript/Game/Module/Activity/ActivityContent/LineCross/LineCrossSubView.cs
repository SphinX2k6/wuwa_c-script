using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054E6 RID: 21734
	public class LineCrossSubView : ActivitySubViewBase
	{
		// Token: 0x06035DAD RID: 220589 RVA: 0x00F0B604 File Offset: 0x00F09804
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035DAE RID: 220590 RVA: 0x00F0B670 File Offset: 0x00F09870
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035DAF RID: 220591 RVA: 0x00F0B6B3 File Offset: 0x00F098B3
		[NullableContext(1)]
		private void FunctionExecute(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				if (unFinishPreGuideQuestId > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
				{
					MarkId = new int?(LineCrossConfig.Instance.GetLineCrossActivityById(this.ActivityBaseData.Id).Value.MarkId),
					MarkType = EMarkType.None,
					OpenFogId = new int?(0)
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
			});
		}

		// Token: 0x06035DB0 RID: 220592 RVA: 0x00F0B6D1 File Offset: 0x00F098D1
		protected override void OnStart()
		{
			this.LineCrossActivityData = (LineCrossActivityData)this.ActivityBaseData;
		}

		// Token: 0x06035DB1 RID: 220593 RVA: 0x00F0B6E4 File Offset: 0x00F098E4
		protected override void OnBeforeShow()
		{
			if (this.ActivityBaseData.GetUnFinishPreGuideQuestId() > 0)
			{
				this.InfoComponent.SetBtnText("LineCrossQuestUnFinish", Array.Empty<object>());
			}
			else
			{
				this.InfoComponent.SetBtnText("LineCrossQuestFinish", Array.Empty<object>());
			}
			this.RefreshProgressText();
			this.UpdateRedDotActivity();
		}

		// Token: 0x06035DB2 RID: 220594 RVA: 0x00F0B738 File Offset: 0x00F09938
		public void RefreshProgressText()
		{
			string progressByActivityId = LineCrossModel.Instance.GetProgressByActivityId(this.LineCrossActivityData.Id, "LineCross_Finish_Progress_Activity");
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(progressByActivityId, true);
		}

		// Token: 0x06035DB3 RID: 220595 RVA: 0x00F0B774 File Offset: 0x00F09974
		private void UpdateRedDotActivity()
		{
			bool redPointShowState = this.LineCrossActivityData.RedPointShowState;
			ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
			if (infoComponent == null)
			{
				return;
			}
			infoComponent.SetFunctionRedDotVisible(redPointShowState);
		}

		// Token: 0x0401C7B4 RID: 116660
		[Nullable(2)]
		private LineCrossActivityData LineCrossActivityData;

		// Token: 0x0401C7B5 RID: 116661
		[Nullable(2)]
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x0200B144 RID: 45380
		private class EComponent
		{
			// Token: 0x04036D16 RID: 224534
			public const int InfoItem = 0;

			// Token: 0x04036D17 RID: 224535
			public const int ProgressText = 1;
		}
	}
}
