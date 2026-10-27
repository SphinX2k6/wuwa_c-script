using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200674E RID: 26446
	public class DirectTrainMainSubView : ActivitySubViewBase
	{
		// Token: 0x0604200C RID: 270348 RVA: 0x01002B54 File Offset: 0x01000D54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604200D RID: 270349 RVA: 0x01002BC0 File Offset: 0x01000DC0
		protected override UniTask OnBeforeStartAsync()
		{
			DirectTrainMainSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DirectTrainMainSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604200E RID: 270350 RVA: 0x01002C03 File Offset: 0x01000E03
		protected override void OnStart()
		{
		}

		// Token: 0x0604200F RID: 270351 RVA: 0x01002C08 File Offset: 0x01000E08
		protected override UniTask OnBeforeShowSelfAsync()
		{
			DirectTrainMainSubView.<OnBeforeShowSelfAsync>d__7 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<DirectTrainMainSubView.<OnBeforeShowSelfAsync>d__7>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042010 RID: 270352 RVA: 0x01002C4C File Offset: 0x01000E4C
		protected override void OnRefreshView()
		{
			if (this.ItemLayout == null)
			{
				return;
			}
			DirectTrainModel instance = DirectTrainModel.Instance;
			if (instance == null)
			{
				return;
			}
			DirectTrainModel directTrainModel = instance;
			IReadOnlyList<int> mainSubActivityIds = instance.GetMainSubActivityIds();
			IReadOnlyDictionary<int, IDirectTrainSubActivityCache> allSubActivityCaches = instance.GetAllSubActivityCaches();
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			IReadOnlyList<DirectTrainSubActivityViewModel> source = directTrainModel.BuildSubActivityViewModels(mainSubActivityIds, allSubActivityCaches, (activityBaseData != null) ? activityBaseData.Id : 0);
			this.ItemLayout.RefreshByData(source.ToList<DirectTrainSubActivityViewModel>(), delegate
			{
				if (this.PendingPlayStartAnim)
				{
					this.PendingPlayStartAnim = false;
					UUIInturnAnimController animController = this.AnimController;
					if (animController == null)
					{
						return;
					}
					animController.Play("Start", -1, false);
				}
			}, false);
		}

		// Token: 0x06042011 RID: 270353 RVA: 0x01002CAF File Offset: 0x01000EAF
		[NullableContext(1)]
		private DirectTrainSubActivityItem CreateSubActivityItem()
		{
			return new DirectTrainSubActivityItem();
		}

		// Token: 0x04022610 RID: 140816
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DirectTrainSubActivityItem, DirectTrainSubActivityViewModel> ItemLayout;

		// Token: 0x04022611 RID: 140817
		[Nullable(2)]
		private UUIInturnAnimController AnimController;

		// Token: 0x04022612 RID: 140818
		private bool PendingPlayStartAnim;

		// Token: 0x0200C8C7 RID: 51399
		private enum EPlotArriveGuideComponents
		{
			// Token: 0x0403C9E4 RID: 248292
			Content,
			// Token: 0x0403C9E5 RID: 248293
			SubItemPrefab
		}
	}
}
