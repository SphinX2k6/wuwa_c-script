using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A87 RID: 10887
[NullableContext(1)]
[Nullable(0)]
public class SpecialTransitionView : UiViewBase
{
	// Token: 0x06016ABD RID: 92861 RVA: 0x005BDAAA File Offset: 0x005BBCAA
	public SpecialTransitionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016ABE RID: 92862 RVA: 0x005BDABC File Offset: 0x005BBCBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06016ABF RID: 92863 RVA: 0x005BDB18 File Offset: 0x005BBD18
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialTransitionView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialTransitionView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016AC0 RID: 92864 RVA: 0x005BDB5C File Offset: 0x005BBD5C
	protected override void OnBeforeHide()
	{
		if (this.AudioHandle != -1)
		{
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
			this.AudioHandle = -1;
		}
	}

	// Token: 0x06016AC1 RID: 92865 RVA: 0x005BDB94 File Offset: 0x005BBD94
	private UniTask InitContent()
	{
		SpecialTransitionView.<InitContent>d__8 <InitContent>d__;
		<InitContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitContent>d__.<>4__this = this;
		<InitContent>d__.<>1__state = -1;
		<InitContent>d__.<>t__builder.Start<SpecialTransitionView.<InitContent>d__8>(ref <InitContent>d__);
		return <InitContent>d__.<>t__builder.Task;
	}

	// Token: 0x06016AC2 RID: 92866 RVA: 0x005BDBD8 File Offset: 0x005BBDD8
	private void PlayAkEvent(string akEvent)
	{
		if (StringUtils.IsEmpty(akEvent))
		{
			return;
		}
		string text = AudioSystem.Instance.parseAudioEventPath(akEvent);
		if (text != null)
		{
			this.AudioHandle = AudioSystem.Instance.PostEvent(text);
		}
	}

	// Token: 0x06016AC3 RID: 92867 RVA: 0x005BDC10 File Offset: 0x005BBE10
	public UniTask LoadSpine(int id, bool isLoop)
	{
		SpecialTransitionView.<LoadSpine>d__10 <LoadSpine>d__;
		<LoadSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSpine>d__.<>4__this = this;
		<LoadSpine>d__.id = id;
		<LoadSpine>d__.isLoop = isLoop;
		<LoadSpine>d__.<>1__state = -1;
		<LoadSpine>d__.<>t__builder.Start<SpecialTransitionView.<LoadSpine>d__10>(ref <LoadSpine>d__);
		return <LoadSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06016AC4 RID: 92868 RVA: 0x005BDC64 File Offset: 0x005BBE64
	public void LoadTextureBg(string path)
	{
		base.TrySetTextureByPath(path, base.GetTexture(2), null, null);
	}

	// Token: 0x0400A82B RID: 43051
	[Nullable(2)]
	private ISpecialTransitionViewParams Param;

	// Token: 0x0400A82C RID: 43052
	[Nullable(2)]
	private ChildSpineView ChildSpineView;

	// Token: 0x0400A82D RID: 43053
	private int AudioHandle = -1;

	// Token: 0x020090B3 RID: 37043
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402EE35 RID: 192053
		PanelFull,
		// Token: 0x0402EE36 RID: 192054
		SpineNode,
		// Token: 0x0402EE37 RID: 192055
		TexBg,
		// Token: 0x0402EE38 RID: 192056
		LoadingItem,
		// Token: 0x0402EE39 RID: 192057
		NextButton,
		// Token: 0x0402EE3A RID: 192058
		TxtInfo,
		// Token: 0x0402EE3B RID: 192059
		DynamicNode1,
		// Token: 0x0402EE3C RID: 192060
		DynamicNode2
	}
}
