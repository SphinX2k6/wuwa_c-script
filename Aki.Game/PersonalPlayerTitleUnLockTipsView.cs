using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018C4 RID: 6340
public class PersonalPlayerTitleUnLockTipsView : UiTickViewBase
{
	// Token: 0x0600FA6C RID: 64108 RVA: 0x004939F6 File Offset: 0x00491BF6
	[NullableContext(1)]
	public PersonalPlayerTitleUnLockTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA6D RID: 64109 RVA: 0x004939FF File Offset: 0x00491BFF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600FA6E RID: 64110 RVA: 0x00493A24 File Offset: 0x00491C24
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleUnLockTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleUnLockTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA6F RID: 64111 RVA: 0x00493A68 File Offset: 0x00491C68
	protected override void OnStart()
	{
		PersonalPlayerTitleData personalPlayerTitleData = (PersonalPlayerTitleData)this.OpenParam;
		if (personalPlayerTitleData == null)
		{
			base.CloseMe(null);
			return;
		}
		int sex = PersonalModel.Instance.GetSex();
		this.PlayerTitleItem.Refresh(new int?(personalPlayerTitleData.PlayerTitleId), personalPlayerTitleData.StarLevel, new int?(sex));
	}

	// Token: 0x0600FA70 RID: 64112 RVA: 0x00493AB9 File Offset: 0x00491CB9
	protected override void OnTick(float delta)
	{
		if (this.HaveClosed)
		{
			return;
		}
		this.CloseTimerDown += delta;
		if (this.CloseTimerDown >= 4000f)
		{
			this.HaveClosed = true;
			base.CloseMe(null);
		}
	}

	// Token: 0x04008C26 RID: 35878
	private const int CLOSE_TIME = 4000;

	// Token: 0x04008C27 RID: 35879
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x04008C28 RID: 35880
	private float CloseTimerDown;

	// Token: 0x04008C29 RID: 35881
	private bool HaveClosed;

	// Token: 0x02007B0E RID: 31502
	private enum EComponent
	{
		// Token: 0x04027E22 RID: 163362
		ItemTitle
	}
}
