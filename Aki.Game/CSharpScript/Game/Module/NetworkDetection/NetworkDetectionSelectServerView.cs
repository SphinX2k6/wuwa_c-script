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
	// Token: 0x02005364 RID: 21348
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerView : UiViewBase
	{
		// Token: 0x06036897 RID: 223383 RVA: 0x00CE9A0C File Offset: 0x00CE7C0C
		public NetworkDetectionSelectServerView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036898 RID: 223384 RVA: 0x00CE9A18 File Offset: 0x00CE7C18
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

		// Token: 0x06036899 RID: 223385 RVA: 0x00CE9B24 File Offset: 0x00CE7D24
		protected override UniTask OnBeforeStartAsync()
		{
			NetworkDetectionSelectServerView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NetworkDetectionSelectServerView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603689A RID: 223386 RVA: 0x00CE9B67 File Offset: 0x00CE7D67
		private NetworkDetectionSelectServerItem OnItemCreate(ILoginServersData data, UUIItem uiItem, int index)
		{
			return new NetworkDetectionSelectServerItem();
		}

		// Token: 0x0603689B RID: 223387 RVA: 0x00CE9B6E File Offset: 0x00CE7D6E
		private void OnClickExitBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603689C RID: 223388 RVA: 0x00CE9B78 File Offset: 0x00CE7D78
		private void OnClickComfirmBtn()
		{
			ILoginServersData currentUiSelectSeverData = NetworkDetectionModel.Instance.CurrentUiSelectSeverData;
			NetworkDetectionModel.Instance.CurrentSelectServerData = currentUiSelectSeverData;
			EventSystem.Instance.Emit(EEventName.OnConfirmNetworkDetectionItem);
			base.CloseMe(null);
		}

		// Token: 0x0603689D RID: 223389 RVA: 0x00CE9BAF File Offset: 0x00CE7DAF
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0603689E RID: 223390 RVA: 0x00CE9BB1 File Offset: 0x00CE7DB1
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0603689F RID: 223391 RVA: 0x00CE9BB4 File Offset: 0x00CE7DB4
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

		// Token: 0x060368A0 RID: 223392 RVA: 0x00CE9C00 File Offset: 0x00CE7E00
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

		// Token: 0x060368A1 RID: 223393 RVA: 0x00CE9C3A File Offset: 0x00CE7E3A
		protected override void OnBeforeDestroy()
		{
			this.ScrollView.ClearChildren();
			this.ScrollView = null;
		}

		// Token: 0x0401CD5F RID: 118111
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<NetworkDetectionSelectServerItem, NetworkDetectionSelectServerDynItem, ILoginServersData> ScrollView;

		// Token: 0x0200B5C9 RID: 46537
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037116 RID: 225558
			ExitBtn,
			// Token: 0x04037117 RID: 225559
			ComfirmBtn,
			// Token: 0x04037118 RID: 225560
			ScrollView,
			// Token: 0x04037119 RID: 225561
			ScrollItem
		}
	}
}
