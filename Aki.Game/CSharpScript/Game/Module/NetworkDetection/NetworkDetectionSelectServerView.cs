using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02004347 RID: 17223
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerView : UiViewBase
	{
		// Token: 0x0602B7DD RID: 178141 RVA: 0x00C38894 File Offset: 0x00C36A94
		public NetworkDetectionSelectServerView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B7DE RID: 178142 RVA: 0x00C388A0 File Offset: 0x00C36AA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickExitBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickComfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602B7DF RID: 178143 RVA: 0x00C389AC File Offset: 0x00C36BAC
		protected override UniTask OnBeforeStartAsync()
		{
			NetworkDetectionSelectServerView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NetworkDetectionSelectServerView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B7E0 RID: 178144 RVA: 0x00C389EF File Offset: 0x00C36BEF
		private NetworkDetectionSelectServerItem OnItemCreate(ILoginServersData data, UUIItem uiItem, int index)
		{
			return new NetworkDetectionSelectServerItem();
		}

		// Token: 0x0602B7E1 RID: 178145 RVA: 0x00C389F6 File Offset: 0x00C36BF6
		private void OnClickExitBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B7E2 RID: 178146 RVA: 0x00C38A00 File Offset: 0x00C36C00
		private void OnClickComfirmBtn()
		{
			ILoginServersData currentUiSelectSeverData = NetworkDetectionModel.Instance.CurrentUiSelectSeverData;
			NetworkDetectionModel.Instance.CurrentSelectServerData = currentUiSelectSeverData;
			EventSystem.Instance.Emit(EEventName.OnConfirmNetworkDetectionItem);
			base.CloseMe(null);
		}

		// Token: 0x0602B7E3 RID: 178147 RVA: 0x00C38A37 File Offset: 0x00C36C37
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602B7E4 RID: 178148 RVA: 0x00C38A39 File Offset: 0x00C36C39
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602B7E5 RID: 178149 RVA: 0x00C38A3C File Offset: 0x00C36C3C
		private UniTask TryMoveToItem(List<ILoginServersData> dataList)
		{
			NetworkDetectionSelectServerView.<TryMoveToItem>d__10 <TryMoveToItem>d__;
			<TryMoveToItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryMoveToItem>d__.<>4__this = this;
			<TryMoveToItem>d__.dataList = dataList;
			<TryMoveToItem>d__.<>1__state = -1;
			<TryMoveToItem>d__.<>t__builder.Start<NetworkDetectionSelectServerView.<TryMoveToItem>d__10>(ref <TryMoveToItem>d__);
			return <TryMoveToItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602B7E6 RID: 178150 RVA: 0x00C38A88 File Offset: 0x00C36C88
		private int GetRecommendedServerIndex(List<ILoginServersData> dataList)
		{
			int result = 0;
			int count = dataList.Count;
			for (int i = 0; i < count; i++)
			{
				if (NetworkDetectionModel.Instance.CurrentUiSelectSeverData == dataList[i])
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0602B7E7 RID: 178151 RVA: 0x00C38AC2 File Offset: 0x00C36CC2
		protected override void OnBeforeDestroy()
		{
			this.ScrollView.ClearChildren();
			this.ScrollView = null;
		}

		// Token: 0x040177F3 RID: 96243
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<NetworkDetectionSelectServerItem, NetworkDetectionSelectServerDynItem, ILoginServersData> ScrollView;

		// Token: 0x0200A002 RID: 40962
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04031B6E RID: 203630
			ExitBtn,
			// Token: 0x04031B6F RID: 203631
			ComfirmBtn,
			// Token: 0x04031B70 RID: 203632
			ScrollView,
			// Token: 0x04031B71 RID: 203633
			ScrollItem
		}
	}
}
