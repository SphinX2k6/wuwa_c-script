using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001226 RID: 4646
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyBuffActiveView : DangoMonopolyViewBase
{
	// Token: 0x17000A97 RID: 2711
	// (get) Token: 0x06007DBA RID: 32186 RVA: 0x001AA87C File Offset: 0x001A8A7C
	public new DangoMonopolyBuffActiveViewParam OpenParam
	{
		get
		{
			return (DangoMonopolyBuffActiveViewParam)this.OpenParam;
		}
	}

	// Token: 0x06007DBB RID: 32187 RVA: 0x001AA889 File Offset: 0x001A8A89
	[NullableContext(1)]
	public DangoMonopolyBuffActiveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007DBC RID: 32188 RVA: 0x001AA8A0 File Offset: 0x001A8AA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnEmpty))
		};
	}

	// Token: 0x06007DBD RID: 32189 RVA: 0x001AA933 File Offset: 0x001A8B33
	private void InitDataParam()
	{
	}

	// Token: 0x06007DBE RID: 32190 RVA: 0x001AA938 File Offset: 0x001A8B38
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyBuffActiveView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007DBF RID: 32191 RVA: 0x001AA97C File Offset: 0x001A8B7C
	public UniTask InitDangoActorList()
	{
		DangoMonopolyBuffActiveView.<InitDangoActorList>d__10 <InitDangoActorList>d__;
		<InitDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDangoActorList>d__.<>4__this = this;
		<InitDangoActorList>d__.<>1__state = -1;
		<InitDangoActorList>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<InitDangoActorList>d__10>(ref <InitDangoActorList>d__);
		return <InitDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06007DC0 RID: 32192 RVA: 0x001AA9C0 File Offset: 0x001A8BC0
	public void PlayDangoAni()
	{
		if (this.DangoActorList.Count == 0)
		{
			return;
		}
		TsUiSceneDangoActor tsUiSceneDangoActor = this.DangoActorList[0];
		int[] activeDangoAniInfo = ActivityDangoMonopolyConfig.Instance.GetActiveDangoAniInfo();
		if (activeDangoAniInfo != null && activeDangoAniInfo.Length >= 2)
		{
			int num = activeDangoAniInfo[0];
			int num2 = activeDangoAniInfo[1];
			tsUiSceneDangoActor.SetState((EDangoState)num, (float)num2, 0f);
		}
		DangoData dangoData = DangoManager.Instance.GetDangoData(this.GetShowDangoId());
		if (dangoData != null && dangoData.DangoVoice != null)
		{
			AudioSystem.Instance.PostEvent(dangoData.DangoVoice);
		}
	}

	// Token: 0x06007DC1 RID: 32193 RVA: 0x001AAA42 File Offset: 0x001A8C42
	private int GetShowDangoId()
	{
		DangoData dangoData = this.OpenParam.GridData.GetDangoData();
		if (dangoData == null)
		{
			return 0;
		}
		return dangoData.Id;
	}

	// Token: 0x06007DC2 RID: 32194 RVA: 0x001AAA60 File Offset: 0x001A8C60
	private void DestroyDangoActor()
	{
		foreach (TsUiSceneDangoActor dango in this.DangoActorList)
		{
			UiSceneManager.Instance.DestroyDangoActor(dango);
		}
		this.DangoActorList.Clear();
	}

	// Token: 0x06007DC3 RID: 32195 RVA: 0x001AAAC4 File Offset: 0x001A8CC4
	protected override void OnStart()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x06007DC4 RID: 32196 RVA: 0x001AAAD7 File Offset: 0x001A8CD7
	protected override void OnBeforeShow()
	{
		this.UpdateData().Forget();
	}

	// Token: 0x06007DC5 RID: 32197 RVA: 0x001AAAE4 File Offset: 0x001A8CE4
	protected override void OnBeforeDestroy()
	{
		this.DestroyDangoActor();
		DangoMonopolyBuffActiveViewParam openParam = this.OpenParam;
		if (openParam != null)
		{
			CustomPromise promise = openParam.Promise;
			if (promise != null)
			{
				promise.SetResult();
			}
		}
		this.ActivityData.UpdateBoardGridUiInfoShow(true).Forget();
	}

	// Token: 0x06007DC6 RID: 32198 RVA: 0x001AAB19 File Offset: 0x001A8D19
	protected override void OnAfterDestroy()
	{
	}

	// Token: 0x06007DC7 RID: 32199 RVA: 0x001AAB1C File Offset: 0x001A8D1C
	public UniTask UpdateData()
	{
		DangoMonopolyBuffActiveView.<UpdateData>d__18 <UpdateData>d__;
		<UpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateData>d__.<>4__this = this;
		<UpdateData>d__.<>1__state = -1;
		<UpdateData>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<UpdateData>d__18>(ref <UpdateData>d__);
		return <UpdateData>d__.<>t__builder.Task;
	}

	// Token: 0x06007DC8 RID: 32200 RVA: 0x001AAB5F File Offset: 0x001A8D5F
	private void ShowDango()
	{
		this.SetBtnEmptyActive(true);
		this.PlayDangoAni();
	}

	// Token: 0x06007DC9 RID: 32201 RVA: 0x001AAB6E File Offset: 0x001A8D6E
	public void OnClickClose()
	{
		DangoMonopolyBuffActiveGetPanel getPanel = this.GetPanel;
		if (getPanel != null && getPanel.IsShow)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06007DCA RID: 32202 RVA: 0x001AAB8B File Offset: 0x001A8D8B
	protected override void OnHandleLoadScene()
	{
	}

	// Token: 0x06007DCB RID: 32203 RVA: 0x001AAB8D File Offset: 0x001A8D8D
	private void OnClickBtnEmpty()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007DCC RID: 32204 RVA: 0x001AAB98 File Offset: 0x001A8D98
	public void SetBtnEmptyActive(bool active)
	{
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(active);
	}

	// Token: 0x0400392A RID: 14634
	public DangoMonopolyBuffActiveShowPanel ShowPanel;

	// Token: 0x0400392B RID: 14635
	public DangoMonopolyBuffActiveGetPanel GetPanel;

	// Token: 0x0400392C RID: 14636
	[Nullable(1)]
	public List<TsUiSceneDangoActor> DangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x0200781A RID: 30746
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027952 RID: 162130
		ItemShow,
		// Token: 0x04027953 RID: 162131
		ItemGet,
		// Token: 0x04027954 RID: 162132
		ItemShowLayer,
		// Token: 0x04027955 RID: 162133
		BtnEmpty
	}
}
