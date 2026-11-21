using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007A6 RID: 1958
public class BuildingRoleItem : UiPanelBase
{
	// Token: 0x060059C2 RID: 22978 RVA: 0x001D2688 File Offset: 0x001D0888
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060059C3 RID: 22979 RVA: 0x001D26E2 File Offset: 0x001D08E2
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060059C4 RID: 22980 RVA: 0x001D26F8 File Offset: 0x001D08F8
	public UniTask RefreshSpine(int roleId)
	{
		BuildingRoleItem.<RefreshSpine>d__3 <RefreshSpine>d__;
		<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSpine>d__.<>4__this = this;
		<RefreshSpine>d__.roleId = roleId;
		<RefreshSpine>d__.<>1__state = -1;
		<RefreshSpine>d__.<>t__builder.Start<BuildingRoleItem.<RefreshSpine>d__3>(ref <RefreshSpine>d__);
		return <RefreshSpine>d__.<>t__builder.Task;
	}

	// Token: 0x02006AAA RID: 27306
	private static class EComponentDefine
	{
		// Token: 0x040231A2 RID: 143778
		public const int Spine = 0;

		// Token: 0x040231A3 RID: 143779
		public const int DialogItem = 1;

		// Token: 0x040231A4 RID: 143780
		public const int Dialog = 2;
	}
}
