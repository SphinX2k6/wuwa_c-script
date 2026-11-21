using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001461 RID: 5217
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayTypeFourNewView : UiTickViewBase
{
	// Token: 0x0600CF79 RID: 53113 RVA: 0x003DA33F File Offset: 0x003D853F
	public InfoDisplayTypeFourNewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CF7A RID: 53114 RVA: 0x003DA348 File Offset: 0x003D8548
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

	// Token: 0x0600CF7B RID: 53115 RVA: 0x003DA494 File Offset: 0x003D8694
	protected override void OnStart()
	{
		int configId = InfoDisplayModel.Instance.CurrentInformationId();
		this.AudioPlayer = new InfoDisplayAudioPlayerWithProgress();
		this.NiagaraSoundWave = base.GetUiNiagara(5);
		this.InitView(configId);
		this.InitAudioPlayer(configId);
	}

	// Token: 0x0600CF7C RID: 53116 RVA: 0x003DA4D3 File Offset: 0x003D86D3
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayerWithProgress audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Tick(delta);
		}
		this.TickNiagaraInterp(delta);
	}

	// Token: 0x0600CF7D RID: 53117 RVA: 0x003DA4F0 File Offset: 0x003D86F0
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

	// Token: 0x0600CF7E RID: 53118 RVA: 0x003DA53C File Offset: 0x003D873C
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

	// Token: 0x0600CF7F RID: 53119 RVA: 0x003DA587 File Offset: 0x003D8787
	private void InternalClose()
	{
		InfoDisplayAudioPlayerWithProgress audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Stop();
		}
		base.CloseMe(null);
	}

	// Token: 0x0600CF80 RID: 53120 RVA: 0x003DA5A1 File Offset: 0x003D87A1
	private void SetNiagaraActive(bool isActive)
	{
		this.NeedInterpNiagara = true;
		this.InterpTime = 0f;
		this.ReverseInterp = !isActive;
	}

	// Token: 0x0600CF81 RID: 53121 RVA: 0x003DA5C0 File Offset: 0x003D87C0
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

	// Token: 0x0600CF82 RID: 53122 RVA: 0x003DA634 File Offset: 0x003D8834
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

	// Token: 0x0600CF83 RID: 53123 RVA: 0x003DA692 File Offset: 0x003D8892
	private void OnClickClose()
	{
		this.InternalClose();
	}

	// Token: 0x0600CF84 RID: 53124 RVA: 0x003DA69A File Offset: 0x003D889A
	private void OnAudioEnd()
	{
		this.InternalClose();
	}

	// Token: 0x0600CF85 RID: 53125 RVA: 0x003DA6A2 File Offset: 0x003D88A2
	private void OnAudioPlay()
	{
		this.SetNiagaraActive(true);
	}

	// Token: 0x0600CF86 RID: 53126 RVA: 0x003DA6AB File Offset: 0x003D88AB
	private void OnAudioPause()
	{
		this.SetNiagaraActive(false);
	}

	// Token: 0x040075E0 RID: 30176
	private const string NIAGARA_PARAM_WPO_KEY = "WPO";

	// Token: 0x040075E1 RID: 30177
	private const float NIAGARA_PARAM_WPO_ACTIVE = 3f;

	// Token: 0x040075E2 RID: 30178
	private const float NIAGARA_PARAM_WPO_INACTIVE = 0f;

	// Token: 0x040075E3 RID: 30179
	private const string NIAGARA_PARAM_DISSOLVE_KEY = "Dissolve";

	// Token: 0x040075E4 RID: 30180
	private const float NIAGARA_PARAM_DISSOLVE_ACTIVE = 1f;

	// Token: 0x040075E5 RID: 30181
	private const float NIAGARA_PARAM_DISSOLVE_INACTIVE = 0f;

	// Token: 0x040075E6 RID: 30182
	private const float NIAGARA_INTERP_TIME = 100f;

	// Token: 0x040075E7 RID: 30183
	[Nullable(2)]
	private InfoDisplayAudioPlayerWithProgress AudioPlayer;

	// Token: 0x040075E8 RID: 30184
	[Nullable(2)]
	private UUINiagara NiagaraSoundWave;

	// Token: 0x040075E9 RID: 30185
	private bool NeedInterpNiagara;

	// Token: 0x040075EA RID: 30186
	private float InterpTime;

	// Token: 0x040075EB RID: 30187
	private bool ReverseInterp;

	// Token: 0x02007711 RID: 30481
	[NullableContext(0)]
	private class EInfoDisplayTypeFourNewView
	{
		// Token: 0x04026AC0 RID: 158400
		public const int TextContent = 0;

		// Token: 0x04026AC1 RID: 158401
		public const int TextTimer = 1;

		// Token: 0x04026AC2 RID: 158402
		public const int AudioItem = 2;

		// Token: 0x04026AC3 RID: 158403
		public const int BtnClose = 3;

		// Token: 0x04026AC4 RID: 158404
		public const int TextTitle = 4;

		// Token: 0x04026AC5 RID: 158405
		public const int NiagaraSoundWave = 5;

		// Token: 0x04026AC6 RID: 158406
		public const int NiagaraSoundWaveRe = 6;
	}
}
