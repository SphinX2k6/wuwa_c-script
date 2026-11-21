using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x0200468E RID: 18062
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerView : UiViewBase
	{
		// Token: 0x0602D672 RID: 185970 RVA: 0x00CB6136 File Offset: 0x00CB4336
		public LoginServerView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D673 RID: 185971 RVA: 0x00CB6140 File Offset: 0x00CB4340
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

		// Token: 0x0602D674 RID: 185972 RVA: 0x00CB624C File Offset: 0x00CB444C
		protected override UniTask OnBeforeStartAsync()
		{
			LoginServerView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LoginServerView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D675 RID: 185973 RVA: 0x00CB6290 File Offset: 0x00CB4490
		protected override void OnStart()
		{
			LoginServerModel.Instance.CurrentUiSelectSeverData = LoginServerModel.Instance.CurrentSelectServerData;
			List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
			this.ScrollView.RefreshByData(loginServersByClientRegion.ToArray(), false, false);
			this.TryMoveToItem(loginServersByClientRegion);
		}

		// Token: 0x0602D676 RID: 185974 RVA: 0x00CB62D6 File Offset: 0x00CB44D6
		private LoginServerItem OnItemCreate(ILoginServersData data, UUIItem uiItem, int index)
		{
			return new LoginServerItem();
		}

		// Token: 0x0602D677 RID: 185975 RVA: 0x00CB62DD File Offset: 0x00CB44DD
		private void OnClickExitBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D678 RID: 185976 RVA: 0x00CB62E8 File Offset: 0x00CB44E8
		private void OnClickComfirmBtn()
		{
			ILoginServersData currentUiSelectSeverData = LoginServerModel.Instance.CurrentUiSelectSeverData;
			if (currentUiSelectSeverData == null)
			{
				return;
			}
			LoginServerModel.Instance.CurrentSelectServerData = currentUiSelectSeverData;
			LoginModel.Instance.SetServerName(currentUiSelectSeverData.name);
			LoginModel.Instance.SetServerIp(currentUiSelectSeverData.ip, 3);
			LoginModel.Instance.SetServerId(currentUiSelectSeverData.id);
			LauncherNetworkDetectionController.Instance.LoginNetworkDetectionConfig = null;
			EventSystem.Instance.Emit(EEventName.OnConfirmServerItem);
			base.CloseMe(null);
		}

		// Token: 0x0602D679 RID: 185977 RVA: 0x00CB635F File Offset: 0x00CB455F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnGetLoginPlayerInfo, new Action(this.OnGetLoginPlayerInfo));
		}

		// Token: 0x0602D67A RID: 185978 RVA: 0x00CB637A File Offset: 0x00CB457A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnGetLoginPlayerInfo, new Action(this.OnGetLoginPlayerInfo));
		}

		// Token: 0x0602D67B RID: 185979 RVA: 0x00CB6398 File Offset: 0x00CB4598
		private void OnGetLoginPlayerInfo()
		{
			if (this.ScrollView == null)
			{
				return;
			}
			int scrollItemCount = this.ScrollView.GetScrollItemCount();
			for (int i = 0; i < scrollItemCount; i++)
			{
				LoginServerItem scrollItemFromIndex = this.ScrollView.GetScrollItemFromIndex(i);
				if (scrollItemFromIndex != null)
				{
					scrollItemFromIndex.UpdatePlayerInfo();
				}
			}
		}

		// Token: 0x0602D67C RID: 185980 RVA: 0x00CB63E0 File Offset: 0x00CB45E0
		private void TryMoveToItem(List<ILoginServersData> dataList)
		{
			if (dataList == null || dataList.Count == 0)
			{
				return;
			}
			int recommendedServerIndex = this.GetRecommendedServerIndex(dataList);
			UUIDynScrollViewComponent uidynScrollViewComponent = base.GetUIDynScrollViewComponent(2);
			if (uidynScrollViewComponent == null)
			{
				return;
			}
			uidynScrollViewComponent.ScrollToItemIndex(recommendedServerIndex, true, 0f, false);
		}

		// Token: 0x0602D67D RID: 185981 RVA: 0x00CB641C File Offset: 0x00CB461C
		private int GetRecommendedServerIndex(List<ILoginServersData> dataList)
		{
			ILoginServersData currentUiSelectSeverData = LoginServerModel.Instance.CurrentUiSelectSeverData;
			if (currentUiSelectSeverData == null)
			{
				return 0;
			}
			for (int i = 0; i < dataList.Count; i++)
			{
				if (dataList[i] == currentUiSelectSeverData)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x0602D67E RID: 185982 RVA: 0x00CB6457 File Offset: 0x00CB4657
		protected override void OnBeforeDestroy()
		{
			if (this.ScrollView != null)
			{
				this.ScrollView.ClearChildren();
				this.ScrollView = null;
			}
		}

		// Token: 0x04018507 RID: 99591
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<LoginServerItem, LoginServerDynItem, ILoginServersData> ScrollView;

		// Token: 0x04018508 RID: 99592
		private LoginServerDynItem LoginServerDynItem;

		// Token: 0x0200A29F RID: 41631
		[NullableContext(0)]
		public enum EComponents
		{
			// Token: 0x0403277E RID: 206718
			ExitBtn,
			// Token: 0x0403277F RID: 206719
			ComfirmBtn,
			// Token: 0x04032780 RID: 206720
			ScrollView,
			// Token: 0x04032781 RID: 206721
			ScrollItem
		}
	}
}
