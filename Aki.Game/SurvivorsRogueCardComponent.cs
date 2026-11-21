using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002041 RID: 8257
public class SurvivorsRogueCardComponent : UiPanelBase
{
	// Token: 0x060146D8 RID: 83672 RVA: 0x005F656A File Offset: 0x005F476A
	public void Refresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		this.OnRefresh(params_);
	}

	// Token: 0x060146D9 RID: 83673 RVA: 0x005F6573 File Offset: 0x005F4773
	[NullableContext(1)]
	public string GetResourceId()
	{
		return this.OnGetResourceId() ?? "";
	}

	// Token: 0x060146DA RID: 83674 RVA: 0x005F6584 File Offset: 0x005F4784
	public virtual ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Center;
	}

	// Token: 0x060146DB RID: 83675 RVA: 0x005F6588 File Offset: 0x005F4788
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

	// Token: 0x060146DC RID: 83676 RVA: 0x005F65CC File Offset: 0x005F47CC
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

	// Token: 0x060146DD RID: 83677 RVA: 0x005F660E File Offset: 0x005F480E
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

	// Token: 0x0400AD53 RID: 44371
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SurvivorsRogueCardComponent, bool> OnComponentVisibleChanged;
}
