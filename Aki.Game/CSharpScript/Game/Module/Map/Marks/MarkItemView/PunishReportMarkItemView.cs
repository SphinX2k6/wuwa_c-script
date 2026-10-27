using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200551E RID: 21790
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A58 RID: 227928 RVA: 0x00D35823 File Offset: 0x00D33A23
		public PunishReportMarkItemView(PunishReportMarkItem holder) : base(holder)
		{
			this.PunishReportMarkItem = holder;
		}

		// Token: 0x06037A59 RID: 227929 RVA: 0x00D35833 File Offset: 0x00D33A33
		protected override void OnViewRefresh()
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x06037A5A RID: 227930 RVA: 0x00D35851 File Offset: 0x00D33A51
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnPunishMarkStateChanged, new Action(this.OnPunishMarkStateChanged));
		}

		// Token: 0x06037A5B RID: 227931 RVA: 0x00D3586F File Offset: 0x00D33A6F
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnPunishMarkStateChanged, new Action(this.OnPunishMarkStateChanged));
		}

		// Token: 0x06037A5C RID: 227932 RVA: 0x00D3588D File Offset: 0x00D33A8D
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x06037A5D RID: 227933 RVA: 0x00D358AB File Offset: 0x00D33AAB
		private void OnPunishMarkStateChanged()
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0401D427 RID: 119847
		[Nullable(2)]
		private readonly PunishReportMarkItem PunishReportMarkItem;
	}
}
