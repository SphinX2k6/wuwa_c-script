using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200252E RID: 9518
public class PhoneMsgTipViewC : UiViewBase
{
	// Token: 0x06013234 RID: 78388 RVA: 0x004C0223 File Offset: 0x004BE423
	[NullableContext(1)]
	public PhoneMsgTipViewC(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013235 RID: 78389 RVA: 0x004C022C File Offset: 0x004BE42C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06013236 RID: 78390 RVA: 0x004C0250 File Offset: 0x004BE450
	protected override void OnStart()
	{
		this.MsgData = (this.OpenParam as ShortMessage?);
		if (this.MsgData == null)
		{
			Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[PhoneMsgTipViewC] MsgData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06013237 RID: 78391 RVA: 0x004C029F File Offset: 0x004BE49F
	protected override void OnAfterShowImplement()
	{
		this.Timer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.Timer = null;
			this.CloseAndOpenPhoneMsgPanelViewSmall();
		}, 4000f, null, null, true, 1f);
	}

	// Token: 0x06013238 RID: 78392 RVA: 0x004C02CA File Offset: 0x004BE4CA
	private void CloseAndOpenPhoneMsgPanelViewSmall()
	{
		UiManager.Instance.CloseAndOpenView(EUiViewName.PhoneMsgTipViewC, EUiViewName.PhoneMsgPanelViewSmall, this.MsgData, null, true);
	}

	// Token: 0x06013239 RID: 78393 RVA: 0x004C02ED File Offset: 0x004BE4ED
	private void ReleaseTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0601323A RID: 78394 RVA: 0x004C0310 File Offset: 0x004BE510
	protected override void OnBeforeDestroy()
	{
		if (this.Timer != null)
		{
			Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[PhoneMsgTipViewC] Timer is not released", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ReleaseTimer();
		}
	}

	// Token: 0x04009086 RID: 36998
	private ShortMessage? MsgData;

	// Token: 0x04009087 RID: 36999
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x04009088 RID: 37000
	private const float CLOSE_TIME = 4000f;

	// Token: 0x02008AB7 RID: 35511
	private enum EComponent
	{
		// Token: 0x0402D0C8 RID: 184520
		TxtMsgInfo
	}
}
