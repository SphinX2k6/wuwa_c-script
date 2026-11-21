using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F1 RID: 17649
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C927 RID: 182567 RVA: 0x00C83613 File Offset: 0x00C81813
		public PunishReportMarkItemView(PunishReportMarkItem holder) : base(holder)
		{
			this.PunishReportMarkItem = holder;
		}

		// Token: 0x0602C928 RID: 182568 RVA: 0x00C83623 File Offset: 0x00C81823
		protected override void OnViewRefresh()
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C929 RID: 182569 RVA: 0x00C83641 File Offset: 0x00C81841
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnPunishMarkStateChanged, new Action(this.OnPunishMarkStateChanged));
		}

		// Token: 0x0602C92A RID: 182570 RVA: 0x00C8365F File Offset: 0x00C8185F
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnPunishMarkStateChanged, new Action(this.OnPunishMarkStateChanged));
		}

		// Token: 0x0602C92B RID: 182571 RVA: 0x00C8367D File Offset: 0x00C8187D
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C92C RID: 182572 RVA: 0x00C8369B File Offset: 0x00C8189B
		private void OnPunishMarkStateChanged()
		{
			this.PunishReportMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x04017EAA RID: 97962
		[Nullable(2)]
		private readonly PunishReportMarkItem PunishReportMarkItem;
	}
}
