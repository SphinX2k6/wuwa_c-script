using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002058 RID: 8280
public class GameplayFirstPassView : UiViewBase
{
	// Token: 0x06010474 RID: 66676 RVA: 0x003F82F3 File Offset: 0x003F64F3
	[NullableContext(1)]
	public GameplayFirstPassView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010475 RID: 66677 RVA: 0x003F82FC File Offset: 0x003F64FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06010476 RID: 66678 RVA: 0x003F8338 File Offset: 0x003F6538
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

	// Token: 0x06010477 RID: 66679 RVA: 0x003F8391 File Offset: 0x003F6591
	[NullableContext(1)]
	private void InitMain([Nullable(2)] string info, string title)
	{
		base.GetText(0).SetText(info ?? "", true);
		base.GetText(1).SetText(title, true);
	}

	// Token: 0x06010478 RID: 66680 RVA: 0x003F83B8 File Offset: 0x003F65B8
	protected override void OnAfterPlayStartSequence()
	{
		this.DelayClose();
	}

	// Token: 0x06010479 RID: 66681 RVA: 0x003F83C0 File Offset: 0x003F65C0
	private void DelayClose()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.CloseView();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0601047A RID: 66682 RVA: 0x003F83EB File Offset: 0x003F65EB
	private void CloseView()
	{
		this.TimerId = null;
		base.CloseMe(null);
	}

	// Token: 0x0601047B RID: 66683 RVA: 0x003F83FB File Offset: 0x003F65FB
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

	// Token: 0x0400784E RID: 30798
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x0200864F RID: 34383
	private class EGameplayFirstPassViewCom
	{
		// Token: 0x0402BB5D RID: 179037
		public const int InfoText = 0;

		// Token: 0x0402BB5E RID: 179038
		public const int TitleText = 1;
	}
}
