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
	// Token: 0x02004346 RID: 17222
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerItem : UiPanelBase, IDynamicScrollItem<ILoginServersData>
	{
		// Token: 0x0602B7D0 RID: 178128 RVA: 0x00C385FB File Offset: 0x00C367FB
		public AUIBaseActor GetUsingItem(ILoginServersData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602B7D1 RID: 178129 RVA: 0x00C38610 File Offset: 0x00C36810
		public UniTask Init(UUIItem actor)
		{
			NetworkDetectionSelectServerItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<NetworkDetectionSelectServerItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602B7D2 RID: 178130 RVA: 0x00C3865B File Offset: 0x00C3685B
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0602B7D3 RID: 178131 RVA: 0x00C38664 File Offset: 0x00C36864
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

		// Token: 0x0602B7D4 RID: 178132 RVA: 0x00C387AF File Offset: 0x00C369AF
		protected override void OnStart()
		{
			base.GetItem(7).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602B7D5 RID: 178133 RVA: 0x00C387CB File Offset: 0x00C369CB
		private void OnExtendToggleComfirmBtn(EToggleState state)
		{
			if (this.Data != null)
			{
				NetworkDetectionModel.Instance.CurrentUiSelectSeverData = this.Data;
				EventSystem.Instance.Emit(EEventName.OnNetworkDetectionSelectServerItem);
			}
		}

		// Token: 0x0602B7D6 RID: 178134 RVA: 0x00C387F2 File Offset: 0x00C369F2
		private void OnSelectServerItem()
		{
			this.RefreshToggleState();
		}

		// Token: 0x0602B7D7 RID: 178135 RVA: 0x00C387FA File Offset: 0x00C369FA
		private void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState((NetworkDetectionModel.Instance.CurrentUiSelectSeverData == this.Data) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602B7D8 RID: 178136 RVA: 0x00C38822 File Offset: 0x00C36A22
		public void Update(ILoginServersData data, int index)
		{
			this.Data = data;
			base.GetText(1).SetText(data.name, true);
			this.RefreshToggleState();
		}

		// Token: 0x0602B7D9 RID: 178137 RVA: 0x00C38844 File Offset: 0x00C36A44
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnNetworkDetectionSelectServerItem, new Action(this.OnSelectServerItem));
			this.Data = null;
		}

		// Token: 0x040177F2 RID: 96242
		[Nullable(2)]
		private ILoginServersData Data;

		// Token: 0x0200A000 RID: 40960
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04031B61 RID: 203617
			ComfirmBtn,
			// Token: 0x04031B62 RID: 203618
			ServerName,
			// Token: 0x04031B63 RID: 203619
			ServerInfo,
			// Token: 0x04031B64 RID: 203620
			Gou,
			// Token: 0x04031B65 RID: 203621
			RoleNode,
			// Token: 0x04031B66 RID: 203622
			RoleLevel,
			// Token: 0x04031B67 RID: 203623
			SuggestLabel = 7
		}
	}
}
