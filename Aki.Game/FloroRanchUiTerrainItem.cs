using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BAC RID: 7084
public class FloroRanchUiTerrainItem : FloroRanchUiItemBase
{
	// Token: 0x0600D31E RID: 54046 RVA: 0x00308A04 File Offset: 0x00306C04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickPos));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D31F RID: 54047 RVA: 0x00308ACB File Offset: 0x00306CCB
	[NullableContext(1)]
	public void BindClickPosCallback(Action callback)
	{
		this.OnClickPosCallback = callback;
	}

	// Token: 0x0600D320 RID: 54048 RVA: 0x00308AD4 File Offset: 0x00306CD4
	public void OnClickPos(EToggleState toggleState)
	{
		Action onClickPosCallback = this.OnClickPosCallback;
		if (onClickPosCallback == null)
		{
			return;
		}
		onClickPosCallback();
	}

	// Token: 0x0600D321 RID: 54049 RVA: 0x00308AE8 File Offset: 0x00306CE8
	public override UniTask RefreshItem()
	{
		FloroRanchUiTerrainItem.<RefreshItem>d__5 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<RefreshItem>d__5>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D322 RID: 54050 RVA: 0x00308B2B File Offset: 0x00306D2B
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetRootActor().GetTransform());
	}

	// Token: 0x0600D323 RID: 54051 RVA: 0x00308B40 File Offset: 0x00306D40
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiTerrainItem.<PlayShowAnim>d__7 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<PlayShowAnim>d__7>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D324 RID: 54052 RVA: 0x00308B84 File Offset: 0x00306D84
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiTerrainItem.<PlayHideAnim>d__8 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<PlayHideAnim>d__8>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D325 RID: 54053 RVA: 0x00308BC7 File Offset: 0x00306DC7
	public void SetSelectState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D326 RID: 54054 RVA: 0x00308BE5 File Offset: 0x00306DE5
	public void SetInteractive(bool isInteractive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(isInteractive);
	}

	// Token: 0x040060B4 RID: 24756
	[Nullable(1)]
	private Action OnClickPosCallback = delegate()
	{
	};

	// Token: 0x02008164 RID: 33124
	private class EItemComponentDefine
	{
		// Token: 0x0402A39F RID: 172959
		public const int ItemToggle = 0;

		// Token: 0x0402A3A0 RID: 172960
		public const int TerrainNormalSprite = 1;

		// Token: 0x0402A3A1 RID: 172961
		public const int TerrainChangeTexture = 2;
	}
}
