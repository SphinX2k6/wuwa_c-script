using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005516 RID: 21782
	public class LevelPlayReportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379DF RID: 227807 RVA: 0x00D33F35 File Offset: 0x00D32135
		[NullableContext(1)]
		public LevelPlayReportMarkItemView(LevelPlayReportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379E0 RID: 227808 RVA: 0x00D33F40 File Offset: 0x00D32140
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateDetailUpdate));
			EventSystem.Instance.Add(EEventName.LevelPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayStateChanged));
			EventSystem.Instance.Add(EEventName.CommonPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayStateChanged));
		}

		// Token: 0x060379E1 RID: 227809 RVA: 0x00D33FA4 File Offset: 0x00D321A4
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateDetailUpdate));
			EventSystem.Instance.Remove(EEventName.LevelPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayStateChanged));
			EventSystem.Instance.Remove(EEventName.CommonPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayStateChanged));
		}

		// Token: 0x060379E2 RID: 227810 RVA: 0x00D34005 File Offset: 0x00D32205
		private void OnLevelPlayStateDetailUpdate()
		{
			base.MarkItemTopRightIconHandle.Update();
		}

		// Token: 0x060379E3 RID: 227811 RVA: 0x00D34012 File Offset: 0x00D32212
		private void OnLevelPlayStateChanged(int markId)
		{
			if (markId != this.Holder.MarkId)
			{
				return;
			}
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}

		// Token: 0x060379E4 RID: 227812 RVA: 0x00D34039 File Offset: 0x00D32239
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x060379E5 RID: 227813 RVA: 0x00D34041 File Offset: 0x00D32241
		public override void UpdateIcon()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			base.MarkItemTopRightIconHandle.Update();
		}
	}
}
