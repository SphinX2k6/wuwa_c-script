using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02002C5A RID: 11354
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviourHomeBtn : IUiBehavior
{
	// Token: 0x06017B3B RID: 97083 RVA: 0x006069F4 File Offset: 0x00604BF4
	public void SetViewInfo(UiViewBase baseView)
	{
		this.CurrentView = baseView;
	}

	// Token: 0x06017B3C RID: 97084 RVA: 0x006069FD File Offset: 0x00604BFD
	public UniTask OnUiCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06017B3D RID: 97085 RVA: 0x00606A04 File Offset: 0x00604C04
	public void OnAfterUiStart()
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.CreateHomeBtnFromView(this.CurrentView);
	}

	// Token: 0x06017B3E RID: 97086 RVA: 0x00606A1F File Offset: 0x00604C1F
	public void OnAfterUiShow()
	{
	}

	// Token: 0x06017B3F RID: 97087 RVA: 0x00606A21 File Offset: 0x00604C21
	public void OnBeforeUiHide()
	{
	}

	// Token: 0x06017B40 RID: 97088 RVA: 0x00606A23 File Offset: 0x00604C23
	public void OnBeforeDestroy()
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.RemoveExtraCallback(this.CurrentView.ViewInfo.Name);
	}

	// Token: 0x06017B41 RID: 97089 RVA: 0x00606A48 File Offset: 0x00604C48
	public void AddExtraAsyncCallback(Func<UniTask> callback)
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.AddExtraAsyncCallback(this.CurrentView.ViewInfo.Name, callback);
	}

	// Token: 0x06017B42 RID: 97090 RVA: 0x00606A6E File Offset: 0x00604C6E
	public void AddExtraCallback(Action callback)
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.AddExtraCallback(this.CurrentView.ViewInfo.Name, callback);
	}

	// Token: 0x0400B095 RID: 45205
	[Nullable(2)]
	private UiViewBase CurrentView;
}
