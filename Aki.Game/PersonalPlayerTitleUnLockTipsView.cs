using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023DF RID: 9183
public class PersonalPlayerTitleUnLockTipsView : UiTickViewBase
{
	// Token: 0x060125BA RID: 75194 RVA: 0x004864EA File Offset: 0x004846EA
	[NullableContext(1)]
	public PersonalPlayerTitleUnLockTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125BB RID: 75195 RVA: 0x004864F3 File Offset: 0x004846F3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060125BC RID: 75196 RVA: 0x00486518 File Offset: 0x00484718
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleUnLockTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleUnLockTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125BD RID: 75197 RVA: 0x0048655C File Offset: 0x0048475C
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

	// Token: 0x060125BE RID: 75198 RVA: 0x004865AD File Offset: 0x004847AD
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

	// Token: 0x04008ADF RID: 35551
	private const int CLOSE_TIME = 4000;

	// Token: 0x04008AE0 RID: 35552
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x04008AE1 RID: 35553
	private float CloseTimerDown;

	// Token: 0x04008AE2 RID: 35554
	private bool HaveClosed;

	// Token: 0x02008985 RID: 35205
	private enum EComponent
	{
		// Token: 0x0402CB07 RID: 183047
		ItemTitle
	}
}
