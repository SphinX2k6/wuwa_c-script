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
	// Token: 0x02005363 RID: 21347
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerItem : UiPanelBase, IDynamicScrollItem<ILoginServersData>
	{
		// Token: 0x0603688A RID: 223370 RVA: 0x00CE9773 File Offset: 0x00CE7973
		public AUIBaseActor GetUsingItem(ILoginServersData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603688B RID: 223371 RVA: 0x00CE9788 File Offset: 0x00CE7988
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

		// Token: 0x0603688C RID: 223372 RVA: 0x00CE97D3 File Offset: 0x00CE79D3
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0603688D RID: 223373 RVA: 0x00CE97DC File Offset: 0x00CE79DC
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

		// Token: 0x0603688E RID: 223374 RVA: 0x00CE9927 File Offset: 0x00CE7B27
		protected override void OnStart()
		{
			base.GetItem(7).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0603688F RID: 223375 RVA: 0x00CE9943 File Offset: 0x00CE7B43
		private void OnExtendToggleComfirmBtn(EToggleState state)
		{
			if (this.Data != null)
			{
				NetworkDetectionModel.Instance.CurrentUiSelectSeverData = this.Data;
				EventSystem.Instance.Emit(EEventName.OnNetworkDetectionSelectServerItem);
			}
		}

		// Token: 0x06036890 RID: 223376 RVA: 0x00CE996A File Offset: 0x00CE7B6A
		private void OnSelectServerItem()
		{
			this.RefreshToggleState();
		}

		// Token: 0x06036891 RID: 223377 RVA: 0x00CE9972 File Offset: 0x00CE7B72
		private void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState((NetworkDetectionModel.Instance.CurrentUiSelectSeverData == this.Data) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06036892 RID: 223378 RVA: 0x00CE999A File Offset: 0x00CE7B9A
		public void Update(ILoginServersData data, int index)
		{
			this.Data = data;
			base.GetText(1).SetText(data.name, true);
			this.RefreshToggleState();
		}

		// Token: 0x06036893 RID: 223379 RVA: 0x00CE99BC File Offset: 0x00CE7BBC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnNetworkDetectionSelectServerItem, new Action(this.OnSelectServerItem));
			this.Data = null;
		}

		// Token: 0x0401CD5E RID: 118110
		[Nullable(2)]
		private ILoginServersData Data;

		// Token: 0x0200B5C7 RID: 46535
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037109 RID: 225545
			ComfirmBtn,
			// Token: 0x0403710A RID: 225546
			ServerName,
			// Token: 0x0403710B RID: 225547
			ServerInfo,
			// Token: 0x0403710C RID: 225548
			Gou,
			// Token: 0x0403710D RID: 225549
			RoleNode,
			// Token: 0x0403710E RID: 225550
			RoleLevel,
			// Token: 0x0403710F RID: 225551
			SuggestLabel = 7
		}
	}
}
