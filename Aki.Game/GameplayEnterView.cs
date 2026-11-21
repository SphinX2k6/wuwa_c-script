using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200152A RID: 5418
public class GameplayEnterView : UiViewBase
{
	// Token: 0x0600D8D0 RID: 55504 RVA: 0x004046EE File Offset: 0x004028EE
	[NullableContext(1)]
	public GameplayEnterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D8D1 RID: 55505 RVA: 0x004046F7 File Offset: 0x004028F7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600D8D2 RID: 55506 RVA: 0x00404730 File Offset: 0x00402930
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
	}

	// Token: 0x0600D8D3 RID: 55507 RVA: 0x0040474E File Offset: 0x0040294E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
	}

	// Token: 0x0600D8D4 RID: 55508 RVA: 0x0040476C File Offset: 0x0040296C
	protected override void OnStart()
	{
		this.InitMain();
	}

	// Token: 0x0600D8D5 RID: 55509 RVA: 0x00404774 File Offset: 0x00402974
	[NullableContext(1)]
	private void OnTextLanguageChange(string oldLang, string newLang)
	{
		this.InitMain();
	}

	// Token: 0x0600D8D6 RID: 55510 RVA: 0x0040477C File Offset: 0x0040297C
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

	// Token: 0x0600D8D7 RID: 55511 RVA: 0x004047F2 File Offset: 0x004029F2
	protected override void OnAfterPlayStartSequence()
	{
		this.DelayClose();
	}

	// Token: 0x0600D8D8 RID: 55512 RVA: 0x004047FA File Offset: 0x004029FA
	private void DelayClose()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.CloseView();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600D8D9 RID: 55513 RVA: 0x00404825 File Offset: 0x00402A25
	private void CloseView()
	{
		this.TimerId = null;
		base.CloseMe(null);
	}

	// Token: 0x0600D8DA RID: 55514 RVA: 0x00404835 File Offset: 0x00402A35
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x04007936 RID: 31030
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x020077D5 RID: 30677
	private class EGameplayEnterViewCom
	{
		// Token: 0x04026E6A RID: 159338
		public const int InfoText = 0;

		// Token: 0x04026E6B RID: 159339
		public const int TitleText = 1;
	}
}
