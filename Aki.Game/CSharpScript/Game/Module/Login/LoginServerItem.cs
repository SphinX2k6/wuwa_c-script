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

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056B7 RID: 22199
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerItem : UiPanelBase, IDynamicScrollItem<ILoginServersData>
	{
		// Token: 0x0603876A RID: 231274 RVA: 0x00D67C2C File Offset: 0x00D65E2C
		public AUIBaseActor GetUsingItem(ILoginServersData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603876B RID: 231275 RVA: 0x00D67C40 File Offset: 0x00D65E40
		public UniTask Init(UUIItem actor)
		{
			LoginServerItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<LoginServerItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603876C RID: 231276 RVA: 0x00D67C8B File Offset: 0x00D65E8B
		public void ClearItem()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectServerItem, new Action(this.OnSelectServerItem));
			base.Destroy(null);
		}

		// Token: 0x0603876D RID: 231277 RVA: 0x00D67CB0 File Offset: 0x00D65EB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleComfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603876E RID: 231278 RVA: 0x00D67DFB File Offset: 0x00D65FFB
		private void OnExtendToggleComfirmBtn(EToggleState state)
		{
			if (this.Data != null)
			{
				LoginServerModel.Instance.CurrentUiSelectSeverData = this.Data;
				EventSystem.Instance.Emit(EEventName.OnSelectServerItem);
			}
		}

		// Token: 0x0603876F RID: 231279 RVA: 0x00D67E22 File Offset: 0x00D66022
		private void OnSelectServerItem()
		{
			this.RefreshToggleState();
		}

		// Token: 0x06038770 RID: 231280 RVA: 0x00D67E2C File Offset: 0x00D6602C
		private void RefreshToggleState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				bool flag = LoginServerModel.Instance.CurrentUiSelectSeverData == this.Data;
				extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06038771 RID: 231281 RVA: 0x00D67E68 File Offset: 0x00D66068
		public void Update(ILoginServersData data, int index)
		{
			this.Data = data;
			this.Region = data.Region;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(data.name, true);
			}
			bool uiactive = LoginServerModel.Instance.OnBeginSuggestServerData == this.Data;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			this.UpdatePlayerInfo();
			this.RefreshToggleState();
		}

		// Token: 0x06038772 RID: 231282 RVA: 0x00D67ED4 File Offset: 0x00D660D4
		public void UpdatePlayerInfo()
		{
			SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
			string sdkUid = ((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "";
			int loginLevel = LoginServerModel.Instance.GetLoginLevel(sdkUid, this.Region);
			bool flag = loginLevel > 0;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText text = base.GetText(5);
				if (text != null)
				{
					LguiUtil.Instance.SetLocalText(text, "OverSeaServerLv", new <>z__ReadOnlySingleElementList<object>(loginLevel));
				}
			}
		}

		// Token: 0x06038773 RID: 231283 RVA: 0x00D67F56 File Offset: 0x00D66156
		protected override void OnBeforeDestroy()
		{
			this.Data = null;
		}

		// Token: 0x0401DA7A RID: 121466
		[Nullable(2)]
		private ILoginServersData Data;

		// Token: 0x0401DA7B RID: 121467
		private string Region = "";
	}
}
