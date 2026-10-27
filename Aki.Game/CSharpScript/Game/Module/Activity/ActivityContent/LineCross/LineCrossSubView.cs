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
	// Token: 0x02006568 RID: 25960
	public class LineCrossSubView : ActivitySubViewBase
	{
		// Token: 0x060410E8 RID: 266472 RVA: 0x00FC4620 File Offset: 0x00FC2820
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

		// Token: 0x060410E9 RID: 266473 RVA: 0x00FC468C File Offset: 0x00FC288C
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060410EA RID: 266474 RVA: 0x00FC46CF File Offset: 0x00FC28CF
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

		// Token: 0x060410EB RID: 266475 RVA: 0x00FC46ED File Offset: 0x00FC28ED
		protected override void OnStart()
		{
			this.LineCrossActivityData = (LineCrossActivityData)this.ActivityBaseData;
		}

		// Token: 0x060410EC RID: 266476 RVA: 0x00FC4700 File Offset: 0x00FC2900
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

		// Token: 0x060410ED RID: 266477 RVA: 0x00FC4754 File Offset: 0x00FC2954
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

		// Token: 0x060410EE RID: 266478 RVA: 0x00FC4790 File Offset: 0x00FC2990
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

		// Token: 0x04021E83 RID: 138883
		[Nullable(2)]
		private LineCrossActivityData LineCrossActivityData;

		// Token: 0x04021E84 RID: 138884
		[Nullable(2)]
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x0200C75F RID: 51039
		private class EComponent
		{
			// Token: 0x0403C3C4 RID: 246724
			public const int InfoItem = 0;

			// Token: 0x0403C3C5 RID: 246725
			public const int ProgressText = 1;
		}
	}
}
