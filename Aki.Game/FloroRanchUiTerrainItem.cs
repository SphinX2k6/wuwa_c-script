using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200106B RID: 4203
public class FloroRanchUiTerrainItem : FloroRanchUiItemBase
{
	// Token: 0x0600A72F RID: 42799 RVA: 0x00313AE4 File Offset: 0x00311CE4
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

	// Token: 0x0600A730 RID: 42800 RVA: 0x00313BAB File Offset: 0x00311DAB
	[NullableContext(1)]
	public void BindClickPosCallback(Action callback)
	{
		this.OnClickPosCallback = callback;
	}

	// Token: 0x0600A731 RID: 42801 RVA: 0x00313BB4 File Offset: 0x00311DB4
	public void OnClickPos(EToggleState toggleState)
	{
		Action onClickPosCallback = this.OnClickPosCallback;
		if (onClickPosCallback == null)
		{
			return;
		}
		onClickPosCallback();
	}

	// Token: 0x0600A732 RID: 42802 RVA: 0x00313BC8 File Offset: 0x00311DC8
	public override UniTask RefreshItem()
	{
		FloroRanchUiTerrainItem.<RefreshItem>d__5 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<RefreshItem>d__5>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A733 RID: 42803 RVA: 0x00313C0B File Offset: 0x00311E0B
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetRootActor().GetTransform());
	}

	// Token: 0x0600A734 RID: 42804 RVA: 0x00313C20 File Offset: 0x00311E20
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiTerrainItem.<PlayShowAnim>d__7 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<PlayShowAnim>d__7>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A735 RID: 42805 RVA: 0x00313C64 File Offset: 0x00311E64
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiTerrainItem.<PlayHideAnim>d__8 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiTerrainItem.<PlayHideAnim>d__8>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A736 RID: 42806 RVA: 0x00313CA7 File Offset: 0x00311EA7
	public void SetSelectState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A737 RID: 42807 RVA: 0x00313CC5 File Offset: 0x00311EC5
	public void SetInteractive(bool isInteractive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(isInteractive);
	}

	// Token: 0x04006183 RID: 24963
	[Nullable(1)]
	private Action OnClickPosCallback = delegate()
	{
	};

	// Token: 0x020072F2 RID: 29426
	private class EItemComponentDefine
	{
		// Token: 0x040256D3 RID: 153299
		public const int ItemToggle = 0;

		// Token: 0x040256D4 RID: 153300
		public const int TerrainNormalSprite = 1;

		// Token: 0x040256D5 RID: 153301
		public const int TerrainChangeTexture = 2;
	}
}
