using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D2 RID: 21202
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemGridComponentBase : UiPanelBase
	{
		// Token: 0x06034CA3 RID: 216227 RVA: 0x00EC2400 File Offset: 0x00EC0600
		public void Refresh(params object[] args)
		{
			this.OnRefresh(args);
		}

		// Token: 0x06034CA4 RID: 216228 RVA: 0x00EC2409 File Offset: 0x00EC0609
		public string GetResourceId()
		{
			return this.OnGetResourceId() ?? "";
		}

		// Token: 0x06034CA5 RID: 216229 RVA: 0x00EC241C File Offset: 0x00EC061C
		protected virtual void OnRefresh(params object[] args)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "没有实现 OnRefresh";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06034CA6 RID: 216230 RVA: 0x00EC2460 File Offset: 0x00EC0660
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

		// Token: 0x06034CA7 RID: 216231 RVA: 0x00EC24A2 File Offset: 0x00EC06A2
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

		// Token: 0x0401BF01 RID: 114433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<PinballItemGridComponentBase, bool> OnComponentVisibleChanged;
	}
}
