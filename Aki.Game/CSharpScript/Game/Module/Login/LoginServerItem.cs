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
	// Token: 0x0200468D RID: 18061
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerItem : UiPanelBase, IDynamicScrollItem<ILoginServersData>
	{
		// Token: 0x0602D667 RID: 185959 RVA: 0x00CB5DF0 File Offset: 0x00CB3FF0
		public AUIBaseActor GetUsingItem(ILoginServersData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602D668 RID: 185960 RVA: 0x00CB5E04 File Offset: 0x00CB4004
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

		// Token: 0x0602D669 RID: 185961 RVA: 0x00CB5E4F File Offset: 0x00CB404F
		public void ClearItem()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectServerItem, new Action(this.OnSelectServerItem));
			base.Destroy(null);
		}

		// Token: 0x0602D66A RID: 185962 RVA: 0x00CB5E74 File Offset: 0x00CB4074
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

		// Token: 0x0602D66B RID: 185963 RVA: 0x00CB5FBF File Offset: 0x00CB41BF
		private void OnExtendToggleComfirmBtn(EToggleState state)
		{
			if (this.Data != null)
			{
				LoginServerModel.Instance.CurrentUiSelectSeverData = this.Data;
				EventSystem.Instance.Emit(EEventName.OnSelectServerItem);
			}
		}

		// Token: 0x0602D66C RID: 185964 RVA: 0x00CB5FE6 File Offset: 0x00CB41E6
		private void OnSelectServerItem()
		{
			this.RefreshToggleState();
		}

		// Token: 0x0602D66D RID: 185965 RVA: 0x00CB5FF0 File Offset: 0x00CB41F0
		private void RefreshToggleState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				bool flag = LoginServerModel.Instance.CurrentUiSelectSeverData == this.Data;
				extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0602D66E RID: 185966 RVA: 0x00CB602C File Offset: 0x00CB422C
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

		// Token: 0x0602D66F RID: 185967 RVA: 0x00CB6098 File Offset: 0x00CB4298
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

		// Token: 0x0602D670 RID: 185968 RVA: 0x00CB611A File Offset: 0x00CB431A
		protected override void OnBeforeDestroy()
		{
			this.Data = null;
		}

		// Token: 0x04018505 RID: 99589
		[Nullable(2)]
		private ILoginServersData Data;

		// Token: 0x04018506 RID: 99590
		private string Region = "";
	}
}
