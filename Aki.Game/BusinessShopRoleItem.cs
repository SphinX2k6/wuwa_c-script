using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001327 RID: 4903
public class BusinessShopRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06008820 RID: 34848 RVA: 0x001D0B90 File Offset: 0x001CED90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06008821 RID: 34849 RVA: 0x001D0C00 File Offset: 0x001CEE00
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06008822 RID: 34850 RVA: 0x001D0C14 File Offset: 0x001CEE14
	public void SwitchRoleSpineAnim(ESpineAnimation animName, float mixDuration)
	{
		UTrackEntry utrackEntry = base.GetSpine(0).SetAnimation(0, animName.ToString(), true);
		if (utrackEntry == null)
		{
			return;
		}
		utrackEntry.SetMixDuration(mixDuration);
	}

	// Token: 0x06008823 RID: 34851 RVA: 0x001D0C3C File Offset: 0x001CEE3C
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		this.Refresh(roleId);
	}

	// Token: 0x06008824 RID: 34852 RVA: 0x001D0C45 File Offset: 0x001CEE45
	public void Refresh(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06008825 RID: 34853 RVA: 0x001D0C50 File Offset: 0x001CEE50
	public UniTask RefreshAsync()
	{
		BusinessShopRoleItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<BusinessShopRoleItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008826 RID: 34854 RVA: 0x001D0C93 File Offset: 0x001CEE93
	[NullableContext(1)]
	public void ShowDialog(string textId)
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x04003CB6 RID: 15542
	protected int RoleId;

	// Token: 0x02007975 RID: 31093
	private static class ERoleItem
	{
		// Token: 0x04027FF7 RID: 163831
		public const int RoleSpine = 0;

		// Token: 0x04027FF8 RID: 163832
		public const int DialogItem = 1;

		// Token: 0x04027FF9 RID: 163833
		public const int Dialog = 2;

		// Token: 0x04027FFA RID: 163834
		public const int SpineItem = 3;
	}
}
