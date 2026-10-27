using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002AC5 RID: 10949
public class SurvivorsRogueCardComponent : UiPanelBase
{
	// Token: 0x06016CA7 RID: 93351 RVA: 0x005C9A16 File Offset: 0x005C7C16
	public void Refresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		this.OnRefresh(params_);
	}

	// Token: 0x06016CA8 RID: 93352 RVA: 0x005C9A1F File Offset: 0x005C7C1F
	[NullableContext(1)]
	public string GetResourceId()
	{
		return this.OnGetResourceId() ?? "";
	}

	// Token: 0x06016CA9 RID: 93353 RVA: 0x005C9A30 File Offset: 0x005C7C30
	public virtual ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Center;
	}

	// Token: 0x06016CAA RID: 93354 RVA: 0x005C9A34 File Offset: 0x005C7C34
	protected virtual void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "没有实现 OnRefresh";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06016CAB RID: 93355 RVA: 0x005C9A78 File Offset: 0x005C7C78
	[NullableContext(2)]
	protected virtual string OnGetResourceId()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "没有实现 GetResourceId";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06016CAC RID: 93356 RVA: 0x005C9ABA File Offset: 0x005C7CBA
	public override void SetActive(bool visibility)
	{
		base.SetActive(visibility);
		Action<SurvivorsRogueCardComponent, bool> onComponentVisibleChanged = this.OnComponentVisibleChanged;
		if (onComponentVisibleChanged == null)
		{
			return;
		}
		onComponentVisibleChanged(this, visibility);
	}

	// Token: 0x0400A94D RID: 43341
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorsRogueCardComponent, bool> OnComponentVisibleChanged;
}
