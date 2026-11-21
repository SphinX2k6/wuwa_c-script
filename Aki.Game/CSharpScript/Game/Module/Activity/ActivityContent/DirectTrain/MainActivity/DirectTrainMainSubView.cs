using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200569E RID: 22174
	public class DirectTrainMainSubView : ActivitySubViewBase
	{
		// Token: 0x06036B5E RID: 224094 RVA: 0x00F43F94 File Offset: 0x00F42194
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

		// Token: 0x06036B5F RID: 224095 RVA: 0x00F44000 File Offset: 0x00F42200
		protected override UniTask OnBeforeStartAsync()
		{
			DirectTrainMainSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DirectTrainMainSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B60 RID: 224096 RVA: 0x00F44043 File Offset: 0x00F42243
		protected override void OnStart()
		{
		}

		// Token: 0x06036B61 RID: 224097 RVA: 0x00F44048 File Offset: 0x00F42248
		protected override UniTask OnBeforeShowSelfAsync()
		{
			DirectTrainMainSubView.<OnBeforeShowSelfAsync>d__7 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<DirectTrainMainSubView.<OnBeforeShowSelfAsync>d__7>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B62 RID: 224098 RVA: 0x00F4408C File Offset: 0x00F4228C
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
			IReadOnlyList<DirectTrainSubActivityViewModel> data = directTrainModel.BuildSubActivityViewModels(mainSubActivityIds, allSubActivityCaches, (activityBaseData != null) ? activityBaseData.Id : 0);
			this.ItemLayout.RefreshByData(data, delegate
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

		// Token: 0x06036B63 RID: 224099 RVA: 0x00F440EA File Offset: 0x00F422EA
		[NullableContext(1)]
		private DirectTrainSubActivityItem CreateSubActivityItem()
		{
			return new DirectTrainSubActivityItem();
		}

		// Token: 0x0401CE69 RID: 118377
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DirectTrainSubActivityItem, DirectTrainSubActivityViewModel> ItemLayout;

		// Token: 0x0401CE6A RID: 118378
		[Nullable(2)]
		private UUIInturnAnimController AnimController;

		// Token: 0x0401CE6B RID: 118379
		private bool PendingPlayStartAnim;

		// Token: 0x0200B296 RID: 45718
		private enum EPlotArriveGuideComponents
		{
			// Token: 0x040372DE RID: 226014
			Content,
			// Token: 0x040372DF RID: 226015
			SubItemPrefab
		}
	}
}
