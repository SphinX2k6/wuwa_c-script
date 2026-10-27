using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006354 RID: 25428
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemGridComponentBase : UiPanelBase
	{
		// Token: 0x0603FFE2 RID: 262114 RVA: 0x00F7B4A0 File Offset: 0x00F796A0
		public void Refresh(params object[] args)
		{
			this.OnRefresh(args);
		}

		// Token: 0x0603FFE3 RID: 262115 RVA: 0x00F7B4A9 File Offset: 0x00F796A9
		public string GetResourceId()
		{
			return this.OnGetResourceId() ?? "";
		}

		// Token: 0x0603FFE4 RID: 262116 RVA: 0x00F7B4BC File Offset: 0x00F796BC
		protected virtual void OnRefresh(params object[] args)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "没有实现 OnRefresh";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603FFE5 RID: 262117 RVA: 0x00F7B500 File Offset: 0x00F79700
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

		// Token: 0x0603FFE6 RID: 262118 RVA: 0x00F7B542 File Offset: 0x00F79742
		public override void SetActive(bool visibility)
		{
			base.SetUiActive(visibility);
			Action<PinballItemGridComponentBase, bool> onComponentVisibleChanged = this.OnComponentVisibleChanged;
			if (onComponentVisibleChanged == null)
			{
				return;
			}
			onComponentVisibleChanged(this, visibility);
		}

		// Token: 0x040215D2 RID: 136658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<PinballItemGridComponentBase, bool> OnComponentVisibleChanged;
	}
}
