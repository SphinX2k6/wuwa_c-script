using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200152B RID: 5419
public class GameplayFirstPassView : UiViewBase
{
	// Token: 0x0600D8DC RID: 55516 RVA: 0x0040485F File Offset: 0x00402A5F
	[NullableContext(1)]
	public GameplayFirstPassView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D8DD RID: 55517 RVA: 0x00404868 File Offset: 0x00402A68
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600D8DE RID: 55518 RVA: 0x004048A4 File Offset: 0x00402AA4
	protected override void OnStart()
	{
		GameplayFirstPassViewData gameplayFirstPassViewData = this.OpenParam as GameplayFirstPassViewData;
		if (gameplayFirstPassViewData == null)
		{
			return;
		}
		string textById = TextConfig.Instance.GetTextById(gameplayFirstPassViewData.InfoId ?? "");
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(gameplayFirstPassViewData.TitleId ?? "");
		this.InitMain(textById, configTextByKey);
	}

	// Token: 0x0600D8DF RID: 55519 RVA: 0x004048FD File Offset: 0x00402AFD
	[NullableContext(1)]
	private void InitMain([Nullable(2)] string info, string title)
	{
		base.GetText(0).SetText(info ?? "", true);
		base.GetText(1).SetText(title, true);
	}

	// Token: 0x0600D8E0 RID: 55520 RVA: 0x00404924 File Offset: 0x00402B24
	protected override void OnAfterPlayStartSequence()
	{
		this.DelayClose();
	}

	// Token: 0x0600D8E1 RID: 55521 RVA: 0x0040492C File Offset: 0x00402B2C
	private void DelayClose()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.CloseView();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600D8E2 RID: 55522 RVA: 0x00404957 File Offset: 0x00402B57
	private void CloseView()
	{
		this.TimerId = null;
		base.CloseMe(null);
	}

	// Token: 0x0600D8E3 RID: 55523 RVA: 0x00404967 File Offset: 0x00402B67
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			this.TimerId = null;
		}
	}

	// Token: 0x04007937 RID: 31031
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x020077D6 RID: 30678
	private class EGameplayFirstPassViewCom
	{
		// Token: 0x04026E6C RID: 159340
		public const int InfoText = 0;

		// Token: 0x04026E6D RID: 159341
		public const int TitleText = 1;
	}
}
