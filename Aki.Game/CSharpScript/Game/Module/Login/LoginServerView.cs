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
	// Token: 0x020056B8 RID: 22200
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerView : UiViewBase
	{
		// Token: 0x06038775 RID: 231285 RVA: 0x00D67F72 File Offset: 0x00D66172
		public LoginServerView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038776 RID: 231286 RVA: 0x00D67F7C File Offset: 0x00D6617C
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

		// Token: 0x06038777 RID: 231287 RVA: 0x00D68088 File Offset: 0x00D66288
		protected override UniTask OnBeforeStartAsync()
		{
			LoginServerView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LoginServerView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038778 RID: 231288 RVA: 0x00D680CC File Offset: 0x00D662CC
		protected override void OnStart()
		{
			LoginServerModel.Instance.CurrentUiSelectSeverData = LoginServerModel.Instance.CurrentSelectServerData;
			List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
			this.ScrollView.RefreshByData(loginServersByClientRegion.ToArray(), false, false);
			this.TryMoveToItem(loginServersByClientRegion);
		}

		// Token: 0x06038779 RID: 231289 RVA: 0x00D68112 File Offset: 0x00D66312
		private LoginServerItem OnItemCreate(ILoginServersData data, UUIItem uiItem, int index)
		{
			return new LoginServerItem();
		}

		// Token: 0x0603877A RID: 231290 RVA: 0x00D68119 File Offset: 0x00D66319
		private void OnClickExitBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603877B RID: 231291 RVA: 0x00D68124 File Offset: 0x00D66324
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

		// Token: 0x0603877C RID: 231292 RVA: 0x00D6819B File Offset: 0x00D6639B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnGetLoginPlayerInfo, new Action(this.OnGetLoginPlayerInfo));
		}

		// Token: 0x0603877D RID: 231293 RVA: 0x00D681B6 File Offset: 0x00D663B6
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnGetLoginPlayerInfo, new Action(this.OnGetLoginPlayerInfo));
		}

		// Token: 0x0603877E RID: 231294 RVA: 0x00D681D4 File Offset: 0x00D663D4
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

		// Token: 0x0603877F RID: 231295 RVA: 0x00D6821C File Offset: 0x00D6641C
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

		// Token: 0x06038780 RID: 231296 RVA: 0x00D68258 File Offset: 0x00D66458
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

		// Token: 0x06038781 RID: 231297 RVA: 0x00D68293 File Offset: 0x00D66493
		protected override void OnBeforeDestroy()
		{
			if (this.ScrollView != null)
			{
				this.ScrollView.ClearChildren();
				this.ScrollView = null;
			}
		}

		// Token: 0x0401DA7C RID: 121468
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<LoginServerItem, LoginServerDynItem, ILoginServersData> ScrollView;

		// Token: 0x0401DA7D RID: 121469
		private LoginServerDynItem LoginServerDynItem;

		// Token: 0x0200B878 RID: 47224
		[NullableContext(0)]
		public enum EComponents
		{
			// Token: 0x04037D64 RID: 228708
			ExitBtn,
			// Token: 0x04037D65 RID: 228709
			ComfirmBtn,
			// Token: 0x04037D66 RID: 228710
			ScrollView,
			// Token: 0x04037D67 RID: 228711
			ScrollItem
		}
	}
}
