using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006DA RID: 1754
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyBuffActiveView : DangoMonopolyViewBase
{
	// Token: 0x17000AB7 RID: 2743
	// (get) Token: 0x06005151 RID: 20817 RVA: 0x001B353C File Offset: 0x001B173C
	public new DangoMonopolyBuffActiveViewParam OpenParam
	{
		get
		{
			return (DangoMonopolyBuffActiveViewParam)this.OpenParam;
		}
	}

	// Token: 0x06005152 RID: 20818 RVA: 0x001B3549 File Offset: 0x001B1749
	[NullableContext(1)]
	public DangoMonopolyBuffActiveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005153 RID: 20819 RVA: 0x001B3560 File Offset: 0x001B1760
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

	// Token: 0x06005154 RID: 20820 RVA: 0x001B35F3 File Offset: 0x001B17F3
	private void InitDataParam()
	{
	}

	// Token: 0x06005155 RID: 20821 RVA: 0x001B35F8 File Offset: 0x001B17F8
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyBuffActiveView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005156 RID: 20822 RVA: 0x001B363C File Offset: 0x001B183C
	public UniTask InitDangoActorList()
	{
		DangoMonopolyBuffActiveView.<InitDangoActorList>d__10 <InitDangoActorList>d__;
		<InitDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDangoActorList>d__.<>4__this = this;
		<InitDangoActorList>d__.<>1__state = -1;
		<InitDangoActorList>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<InitDangoActorList>d__10>(ref <InitDangoActorList>d__);
		return <InitDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06005157 RID: 20823 RVA: 0x001B3680 File Offset: 0x001B1880
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

	// Token: 0x06005158 RID: 20824 RVA: 0x001B3702 File Offset: 0x001B1902
	private int GetShowDangoId()
	{
		DangoData dangoData = this.OpenParam.GridData.GetDangoData();
		if (dangoData == null)
		{
			return 0;
		}
		return dangoData.Id;
	}

	// Token: 0x06005159 RID: 20825 RVA: 0x001B3720 File Offset: 0x001B1920
	private void DestroyDangoActor()
	{
		foreach (TsUiSceneDangoActor dango in this.DangoActorList)
		{
			UiSceneManager.Instance.DestroyDangoActor(dango);
		}
		this.DangoActorList.Clear();
	}

	// Token: 0x0600515A RID: 20826 RVA: 0x001B3784 File Offset: 0x001B1984
	protected override void OnStart()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x0600515B RID: 20827 RVA: 0x001B3797 File Offset: 0x001B1997
	protected override void OnBeforeShow()
	{
		this.UpdateData().Forget();
	}

	// Token: 0x0600515C RID: 20828 RVA: 0x001B37A4 File Offset: 0x001B19A4
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

	// Token: 0x0600515D RID: 20829 RVA: 0x001B37D9 File Offset: 0x001B19D9
	protected override void OnAfterDestroy()
	{
	}

	// Token: 0x0600515E RID: 20830 RVA: 0x001B37DC File Offset: 0x001B19DC
	public UniTask UpdateData()
	{
		DangoMonopolyBuffActiveView.<UpdateData>d__18 <UpdateData>d__;
		<UpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateData>d__.<>4__this = this;
		<UpdateData>d__.<>1__state = -1;
		<UpdateData>d__.<>t__builder.Start<DangoMonopolyBuffActiveView.<UpdateData>d__18>(ref <UpdateData>d__);
		return <UpdateData>d__.<>t__builder.Task;
	}

	// Token: 0x0600515F RID: 20831 RVA: 0x001B381F File Offset: 0x001B1A1F
	private void ShowDango()
	{
		this.SetBtnEmptyActive(true);
		this.PlayDangoAni();
	}

	// Token: 0x06005160 RID: 20832 RVA: 0x001B382E File Offset: 0x001B1A2E
	public void OnClickClose()
	{
		DangoMonopolyBuffActiveGetPanel getPanel = this.GetPanel;
		if (getPanel != null && getPanel.IsShow)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06005161 RID: 20833 RVA: 0x001B384B File Offset: 0x001B1A4B
	protected override void OnHandleLoadScene()
	{
	}

	// Token: 0x06005162 RID: 20834 RVA: 0x001B384D File Offset: 0x001B1A4D
	private void OnClickBtnEmpty()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005163 RID: 20835 RVA: 0x001B3858 File Offset: 0x001B1A58
	public void SetBtnEmptyActive(bool active)
	{
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(active);
	}

	// Token: 0x040039C2 RID: 14786
	public DangoMonopolyBuffActiveShowPanel ShowPanel;

	// Token: 0x040039C3 RID: 14787
	public DangoMonopolyBuffActiveGetPanel GetPanel;

	// Token: 0x040039C4 RID: 14788
	[Nullable(1)]
	public List<TsUiSceneDangoActor> DangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x020069A5 RID: 27045
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022C83 RID: 142467
		ItemShow,
		// Token: 0x04022C84 RID: 142468
		ItemGet,
		// Token: 0x04022C85 RID: 142469
		ItemShowLayer,
		// Token: 0x04022C86 RID: 142470
		BtnEmpty
	}
}
