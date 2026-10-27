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
	// Token: 0x020064A4 RID: 25764
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreeRoleToggleItem : GridProxyAbstract<MatchThreeRoleToggleData>
	{
		// Token: 0x06040B28 RID: 265000 RVA: 0x00FA9D3C File Offset: 0x00FA7F3C
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

		// Token: 0x06040B29 RID: 265001 RVA: 0x00FA9E24 File Offset: 0x00FA8024
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06040B2A RID: 265002 RVA: 0x00FA9E30 File Offset: 0x00FA8030
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

		// Token: 0x06040B2B RID: 265003 RVA: 0x00FA9EBB File Offset: 0x00FA80BB
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06040B2C RID: 265004 RVA: 0x00FA9ED2 File Offset: 0x00FA80D2
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06040B2D RID: 265005 RVA: 0x00FA9EEC File Offset: 0x00FA80EC
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

		// Token: 0x06040B2E RID: 265006 RVA: 0x00FA9F24 File Offset: 0x00FA8124
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

		// Token: 0x06040B2F RID: 265007 RVA: 0x00FA9F6F File Offset: 0x00FA816F
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

		// Token: 0x04021AB2 RID: 137906
		[Nullable(2)]
		private MatchThreeRoleToggleData RoleData;

		// Token: 0x04021AB3 RID: 137907
		[Nullable(2)]
		private Action<int, int> ClickCallback;
	}
}
