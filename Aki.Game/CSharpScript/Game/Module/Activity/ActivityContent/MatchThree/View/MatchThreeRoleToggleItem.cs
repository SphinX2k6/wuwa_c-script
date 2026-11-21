using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005422 RID: 21538
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreeRoleToggleItem : GridProxyAbstract<MatchThreeRoleToggleData>
	{
		// Token: 0x060357EC RID: 219116 RVA: 0x00EF0D84 File Offset: 0x00EEEF84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060357ED RID: 219117 RVA: 0x00EF0E6C File Offset: 0x00EEF06C
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060357EE RID: 219118 RVA: 0x00EF0E78 File Offset: 0x00EEF078
		public override void Refresh(MatchThreeRoleToggleData data, bool isSelected, int gridIndex)
		{
			this.RoleData = data;
			this.RefreshLockState(data.IsUnlocked);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(data.ShowRedDot && data.IsUnlocked);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(data.RoleId);
			if (roleConfig != null)
			{
				this.RefreshRoleHeadIcon(roleConfig.Value).Forget();
			}
		}

		// Token: 0x060357EF RID: 219119 RVA: 0x00EF0F03 File Offset: 0x00EEF103
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060357F0 RID: 219120 RVA: 0x00EF0F1A File Offset: 0x00EEF11A
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060357F1 RID: 219121 RVA: 0x00EF0F34 File Offset: 0x00EEF134
		private void RefreshLockState(bool isUnlocked)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!isUnlocked);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.bLockStateOnSelect = isUnlocked;
			}
		}

		// Token: 0x060357F2 RID: 219122 RVA: 0x00EF0F6C File Offset: 0x00EEF16C
		private UniTask RefreshRoleHeadIcon(MatchThreeRole roleConfig)
		{
			MatchThreeRoleToggleItem.<RefreshRoleHeadIcon>d__8 <RefreshRoleHeadIcon>d__;
			<RefreshRoleHeadIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleHeadIcon>d__.<>4__this = this;
			<RefreshRoleHeadIcon>d__.roleConfig = roleConfig;
			<RefreshRoleHeadIcon>d__.<>1__state = -1;
			<RefreshRoleHeadIcon>d__.<>t__builder.Start<MatchThreeRoleToggleItem.<RefreshRoleHeadIcon>d__8>(ref <RefreshRoleHeadIcon>d__);
			return <RefreshRoleHeadIcon>d__.<>t__builder.Task;
		}

		// Token: 0x060357F3 RID: 219123 RVA: 0x00EF0FB7 File Offset: 0x00EEF1B7
		private void OnClickToggle(EToggleState state)
		{
			if (this.RoleData == null)
			{
				return;
			}
			Action<int, int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.RoleData.RoleId, base.GridIndex);
		}

		// Token: 0x0401C3E3 RID: 115683
		[Nullable(2)]
		private MatchThreeRoleToggleData RoleData;

		// Token: 0x0401C3E4 RID: 115684
		[Nullable(2)]
		private Action<int, int> ClickCallback;
	}
}
