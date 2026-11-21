using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002003 RID: 8195
[NullableContext(1)]
[Nullable(0)]
public class SpecialTransitionView : UiViewBase
{
	// Token: 0x060144E2 RID: 83170 RVA: 0x005E9CDA File Offset: 0x005E7EDA
	public SpecialTransitionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060144E3 RID: 83171 RVA: 0x005E9CEC File Offset: 0x005E7EEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060144E4 RID: 83172 RVA: 0x005E9D48 File Offset: 0x005E7F48
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialTransitionView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialTransitionView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060144E5 RID: 83173 RVA: 0x005E9D8C File Offset: 0x005E7F8C
	protected override void OnBeforeHide()
	{
		if (this.AudioHandle != -1)
		{
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
			this.AudioHandle = -1;
		}
	}

	// Token: 0x060144E6 RID: 83174 RVA: 0x005E9DC4 File Offset: 0x005E7FC4
	private UniTask InitContent()
	{
		SpecialTransitionView.<InitContent>d__8 <InitContent>d__;
		<InitContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitContent>d__.<>4__this = this;
		<InitContent>d__.<>1__state = -1;
		<InitContent>d__.<>t__builder.Start<SpecialTransitionView.<InitContent>d__8>(ref <InitContent>d__);
		return <InitContent>d__.<>t__builder.Task;
	}

	// Token: 0x060144E7 RID: 83175 RVA: 0x005E9E08 File Offset: 0x005E8008
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

	// Token: 0x060144E8 RID: 83176 RVA: 0x005E9E40 File Offset: 0x005E8040
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

	// Token: 0x060144E9 RID: 83177 RVA: 0x005E9E94 File Offset: 0x005E8094
	public void LoadTextureBg(string path)
	{
		base.TrySetTextureByPath(path, base.GetTexture(2), null, null);
	}

	// Token: 0x0400AC30 RID: 44080
	[Nullable(2)]
	private ISpecialTransitionViewParams Param;

	// Token: 0x0400AC31 RID: 44081
	[Nullable(2)]
	private ChildSpineView ChildSpineView;

	// Token: 0x0400AC32 RID: 44082
	private int AudioHandle = -1;

	// Token: 0x020082FA RID: 33530
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A52F RID: 173359
		PanelFull,
		// Token: 0x0402A530 RID: 173360
		SpineNode,
		// Token: 0x0402A531 RID: 173361
		TexBg,
		// Token: 0x0402A532 RID: 173362
		LoadingItem,
		// Token: 0x0402A533 RID: 173363
		NextButton,
		// Token: 0x0402A534 RID: 173364
		TxtInfo,
		// Token: 0x0402A535 RID: 173365
		DynamicNode1,
		// Token: 0x0402A536 RID: 173366
		DynamicNode2
	}
}
