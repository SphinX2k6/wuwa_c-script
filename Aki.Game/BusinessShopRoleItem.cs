using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007DB RID: 2011
public class BusinessShopRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06005BBB RID: 23483 RVA: 0x001D99FC File Offset: 0x001D7BFC
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

	// Token: 0x06005BBC RID: 23484 RVA: 0x001D9A6C File Offset: 0x001D7C6C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x001D9A80 File Offset: 0x001D7C80
	public void SwitchRoleSpineAnim(ESpineAnimation animName, float mixDuration)
	{
		UTrackEntry utrackEntry = base.GetSpine(0).SetAnimation(0, animName.ToString(), true);
		if (utrackEntry == null)
		{
			return;
		}
		utrackEntry.SetMixDuration(mixDuration);
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x001D9AA8 File Offset: 0x001D7CA8
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		this.Refresh(roleId);
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x001D9AB1 File Offset: 0x001D7CB1
	public void Refresh(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x001D9ABC File Offset: 0x001D7CBC
	public UniTask RefreshAsync()
	{
		BusinessShopRoleItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<BusinessShopRoleItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x001D9AFF File Offset: 0x001D7CFF
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

	// Token: 0x04003D4E RID: 15694
	protected int RoleId;

	// Token: 0x02006AFF RID: 27391
	private static class ERoleItem
	{
		// Token: 0x04023324 RID: 144164
		public const int RoleSpine = 0;

		// Token: 0x04023325 RID: 144165
		public const int DialogItem = 1;

		// Token: 0x04023326 RID: 144166
		public const int Dialog = 2;

		// Token: 0x04023327 RID: 144167
		public const int SpineItem = 3;
	}
}
