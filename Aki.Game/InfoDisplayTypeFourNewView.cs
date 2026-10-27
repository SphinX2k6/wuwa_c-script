using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F9F RID: 8095
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayTypeFourNewView : UiTickViewBase
{
	// Token: 0x0600FB57 RID: 64343 RVA: 0x003CE77F File Offset: 0x003CC97F
	public InfoDisplayTypeFourNewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB58 RID: 64344 RVA: 0x003CE788 File Offset: 0x003CC988
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB59 RID: 64345 RVA: 0x003CE8D4 File Offset: 0x003CCAD4
	protected override void OnStart()
	{
		int configId = InfoDisplayModel.Instance.CurrentInformationId();
		this.AudioPlayer = new InfoDisplayAudioPlayerWithProgress();
		this.NiagaraSoundWave = base.GetUiNiagara(5);
		this.InitView(configId);
		this.InitAudioPlayer(configId);
	}

	// Token: 0x0600FB5A RID: 64346 RVA: 0x003CE913 File Offset: 0x003CCB13
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayerWithProgress audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Tick(delta);
		}
		this.TickNiagaraInterp(delta);
	}

	// Token: 0x0600FB5B RID: 64347 RVA: 0x003CE930 File Offset: 0x003CCB30
	private UniTask InitAudioPlayer(int configId)
	{
		InfoDisplayTypeFourNewView.<InitAudioPlayer>d__14 <InitAudioPlayer>d__;
		<InitAudioPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAudioPlayer>d__.<>4__this = this;
		<InitAudioPlayer>d__.configId = configId;
		<InitAudioPlayer>d__.<>1__state = -1;
		<InitAudioPlayer>d__.<>t__builder.Start<InfoDisplayTypeFourNewView.<InitAudioPlayer>d__14>(ref <InitAudioPlayer>d__);
		return <InitAudioPlayer>d__.<>t__builder.Task;
	}

	// Token: 0x0600FB5C RID: 64348 RVA: 0x003CE97C File Offset: 0x003CCB7C
	private void InitView(int configId)
	{
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(configId);
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(infoDisplayTitle, true);
		}
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(configId);
		UUIText text2 = base.GetText(0);
		if (text2 != null)
		{
			text2.SetText(infoDisplayDesc, true);
		}
	}

	// Token: 0x0600FB5D RID: 64349 RVA: 0x003CE9C7 File Offset: 0x003CCBC7
	private void InternalClose()
	{
		InfoDisplayAudioPlayerWithProgress audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Stop();
		}
		base.CloseMe(null);
	}

	// Token: 0x0600FB5E RID: 64350 RVA: 0x003CE9E1 File Offset: 0x003CCBE1
	private void SetNiagaraActive(bool isActive)
	{
		this.NeedInterpNiagara = true;
		this.InterpTime = 0f;
		this.ReverseInterp = !isActive;
	}

	// Token: 0x0600FB5F RID: 64351 RVA: 0x003CEA00 File Offset: 0x003CCC00
	[NullableContext(2)]
	private void NiagaraInterpImp(UUINiagara niagara, float t)
	{
		if (niagara == null)
		{
			return;
		}
		float value = this.ReverseInterp ? (3f - t * 3f) : (0f + t * 3f);
		niagara.SetNiagaraVarFloat("WPO", value);
		float value2 = this.ReverseInterp ? (1f - t * 1f) : (0f + t * 1f);
		niagara.SetNiagaraVarFloat("Dissolve", value2);
	}

	// Token: 0x0600FB60 RID: 64352 RVA: 0x003CEA74 File Offset: 0x003CCC74
	private void TickNiagaraInterp(float deltaTime)
	{
		if (!this.NeedInterpNiagara)
		{
			return;
		}
		this.InterpTime += deltaTime;
		float num = this.InterpTime / 100f;
		if (num >= 1f)
		{
			this.NeedInterpNiagara = false;
			this.InterpTime = 0f;
			num = 1f;
		}
		this.NiagaraInterpImp(this.NiagaraSoundWave, num);
	}

	// Token: 0x0600FB61 RID: 64353 RVA: 0x003CEAD2 File Offset: 0x003CCCD2
	private void OnClickClose()
	{
		this.InternalClose();
	}

	// Token: 0x0600FB62 RID: 64354 RVA: 0x003CEADA File Offset: 0x003CCCDA
	private void OnAudioEnd()
	{
		this.InternalClose();
	}

	// Token: 0x0600FB63 RID: 64355 RVA: 0x003CEAE2 File Offset: 0x003CCCE2
	private void OnAudioPlay()
	{
		this.SetNiagaraActive(true);
	}

	// Token: 0x0600FB64 RID: 64356 RVA: 0x003CEAEB File Offset: 0x003CCCEB
	private void OnAudioPause()
	{
		this.SetNiagaraActive(false);
	}

	// Token: 0x040074FE RID: 29950
	private const string NIAGARA_PARAM_WPO_KEY = "WPO";

	// Token: 0x040074FF RID: 29951
	private const float NIAGARA_PARAM_WPO_ACTIVE = 3f;

	// Token: 0x04007500 RID: 29952
	private const float NIAGARA_PARAM_WPO_INACTIVE = 0f;

	// Token: 0x04007501 RID: 29953
	private const string NIAGARA_PARAM_DISSOLVE_KEY = "Dissolve";

	// Token: 0x04007502 RID: 29954
	private const float NIAGARA_PARAM_DISSOLVE_ACTIVE = 1f;

	// Token: 0x04007503 RID: 29955
	private const float NIAGARA_PARAM_DISSOLVE_INACTIVE = 0f;

	// Token: 0x04007504 RID: 29956
	private const float NIAGARA_INTERP_TIME = 100f;

	// Token: 0x04007505 RID: 29957
	[Nullable(2)]
	private InfoDisplayAudioPlayerWithProgress AudioPlayer;

	// Token: 0x04007506 RID: 29958
	[Nullable(2)]
	private UUINiagara NiagaraSoundWave;

	// Token: 0x04007507 RID: 29959
	private bool NeedInterpNiagara;

	// Token: 0x04007508 RID: 29960
	private float InterpTime;

	// Token: 0x04007509 RID: 29961
	private bool ReverseInterp;

	// Token: 0x0200858C RID: 34188
	[NullableContext(0)]
	private class EInfoDisplayTypeFourNewView
	{
		// Token: 0x0402B79D RID: 178077
		public const int TextContent = 0;

		// Token: 0x0402B79E RID: 178078
		public const int TextTimer = 1;

		// Token: 0x0402B79F RID: 178079
		public const int AudioItem = 2;

		// Token: 0x0402B7A0 RID: 178080
		public const int BtnClose = 3;

		// Token: 0x0402B7A1 RID: 178081
		public const int TextTitle = 4;

		// Token: 0x0402B7A2 RID: 178082
		public const int NiagaraSoundWave = 5;

		// Token: 0x0402B7A3 RID: 178083
		public const int NiagaraSoundWaveRe = 6;
	}
}
