using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A15 RID: 6677
public class PhoneMsgTipViewC : UiViewBase
{
	// Token: 0x060106F4 RID: 67316 RVA: 0x004CDF2F File Offset: 0x004CC12F
	[NullableContext(1)]
	public PhoneMsgTipViewC(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060106F5 RID: 67317 RVA: 0x004CDF38 File Offset: 0x004CC138
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060106F6 RID: 67318 RVA: 0x004CDF5C File Offset: 0x004CC15C
	protected override void OnStart()
	{
		this.MsgData = (this.OpenParam as ShortMessage?);
		if (this.MsgData == null)
		{
			Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[PhoneMsgTipViewC] MsgData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x060106F7 RID: 67319 RVA: 0x004CDFAB File Offset: 0x004CC1AB
	protected override void OnAfterShowImplement()
	{
		this.Timer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.Timer = null;
			this.CloseAndOpenPhoneMsgPanelViewSmall();
		}, 4000f, null, null, true, 1f);
	}

	// Token: 0x060106F8 RID: 67320 RVA: 0x004CDFD6 File Offset: 0x004CC1D6
	private void CloseAndOpenPhoneMsgPanelViewSmall()
	{
		UiManager.Instance.CloseAndOpenView(EUiViewName.PhoneMsgTipViewC, EUiViewName.PhoneMsgPanelViewSmall, this.MsgData, null, true);
	}

	// Token: 0x060106F9 RID: 67321 RVA: 0x004CDFF9 File Offset: 0x004CC1F9
	private void ReleaseTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x060106FA RID: 67322 RVA: 0x004CE01C File Offset: 0x004CC21C
	protected override void OnBeforeDestroy()
	{
		if (this.Timer != null)
		{
			Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[PhoneMsgTipViewC] Timer is not released", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ReleaseTimer();
		}
	}

	// Token: 0x040091DB RID: 37339
	private ShortMessage? MsgData;

	// Token: 0x040091DC RID: 37340
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x040091DD RID: 37341
	private const float CLOSE_TIME = 4000f;

	// Token: 0x02007C3E RID: 31806
	private enum EComponent
	{
		// Token: 0x040283DC RID: 164828
		TxtMsgInfo
	}
}
