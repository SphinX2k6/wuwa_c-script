using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002057 RID: 8279
public class GameplayEnterView : UiViewBase
{
	// Token: 0x06010468 RID: 66664 RVA: 0x003F8182 File Offset: 0x003F6382
	[NullableContext(1)]
	public GameplayEnterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010469 RID: 66665 RVA: 0x003F818B File Offset: 0x003F638B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0601046A RID: 66666 RVA: 0x003F81C4 File Offset: 0x003F63C4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
	}

	// Token: 0x0601046B RID: 66667 RVA: 0x003F81E2 File Offset: 0x003F63E2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
	}

	// Token: 0x0601046C RID: 66668 RVA: 0x003F8200 File Offset: 0x003F6400
	protected override void OnStart()
	{
		this.InitMain();
	}

	// Token: 0x0601046D RID: 66669 RVA: 0x003F8208 File Offset: 0x003F6408
	[NullableContext(1)]
	private void OnTextLanguageChange(string oldLang, string newLang)
	{
		this.InitMain();
	}

	// Token: 0x0601046E RID: 66670 RVA: 0x003F8210 File Offset: 0x003F6410
	private void InitMain()
	{
		GameplayEnterViewData gameplayEnterViewData = this.OpenParam as GameplayEnterViewData;
		if (gameplayEnterViewData == null)
		{
			return;
		}
		string textById = TextConfig.Instance.GetTextById(gameplayEnterViewData.InfoId ?? "");
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(gameplayEnterViewData.TitleId ?? "");
		base.GetText(0).SetText(textById ?? "", true);
		base.GetText(1).SetText(configTextByKey, true);
	}

	// Token: 0x0601046F RID: 66671 RVA: 0x003F8286 File Offset: 0x003F6486
	protected override void OnAfterPlayStartSequence()
	{
		this.DelayClose();
	}

	// Token: 0x06010470 RID: 66672 RVA: 0x003F828E File Offset: 0x003F648E
	private void DelayClose()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.CloseView();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x06010471 RID: 66673 RVA: 0x003F82B9 File Offset: 0x003F64B9
	private void CloseView()
	{
		this.TimerId = null;
		base.CloseMe(null);
	}

	// Token: 0x06010472 RID: 66674 RVA: 0x003F82C9 File Offset: 0x003F64C9
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x0400784D RID: 30797
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x0200864E RID: 34382
	private class EGameplayEnterViewCom
	{
		// Token: 0x0402BB5B RID: 179035
		public const int InfoText = 0;

		// Token: 0x0402BB5C RID: 179036
		public const int TitleText = 1;
	}
}
