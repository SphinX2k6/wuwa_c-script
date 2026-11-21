using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005891 RID: 22673
	public class SolarSchoolConditionAttrCount : ActivityConditionProgressBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B37 RID: 27447
		// (get) Token: 0x06037DD2 RID: 228818 RVA: 0x00F9FDAA File Offset: 0x00F9DFAA
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DD3 RID: 228819 RVA: 0x00F9FDB0 File Offset: 0x00F9DFB0
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(p.GetInt("Attr", 0));
			if (attr == null)
			{
				return false;
			}
			this.Attr = (ESolarSchoolSecondAttr)attr.Value.AttrType;
			this.TargetCount = p.GetInt("Count", 0);
			return true;
		}

		// Token: 0x06037DD4 RID: 228820 RVA: 0x00F9FE08 File Offset: 0x00F9E008
		public override int GetCurrent()
		{
			int rawCurrent = this.GetRawCurrent();
			if (!this.UseLocalProgress)
			{
				return rawCurrent;
			}
			return Math.Max(rawCurrent - this.ProgressBaseline, 0);
		}

		// Token: 0x06037DD5 RID: 228821 RVA: 0x00F9FE34 File Offset: 0x00F9E034
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037DD6 RID: 228822 RVA: 0x00F9FE3C File Offset: 0x00F9E03C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037DD7 RID: 228823 RVA: 0x00F9FE5A File Offset: 0x00F9E05A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037DD8 RID: 228824 RVA: 0x00F9FE78 File Offset: 0x00F9E078
		protected override void OnClear()
		{
			this.Attr = ESolarSchoolSecondAttr.None;
			this.TargetCount = 0;
			this.UseLocalProgress = false;
			this.ProgressBaseline = 0;
		}

		// Token: 0x06037DD9 RID: 228825 RVA: 0x00F9FE96 File Offset: 0x00F9E096
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			this.ProgressBaseline = Math.Max(this.GetRawCurrent() - progress, 0);
		}

		// Token: 0x06037DDA RID: 228826 RVA: 0x00F9FEB3 File Offset: 0x00F9E0B3
		public int GetSaveProgress()
		{
			return Math.Clamp(this.GetCurrent(), 0, this.GetTarget());
		}

		// Token: 0x06037DDB RID: 228827 RVA: 0x00F9FEC7 File Offset: 0x00F9E0C7
		private int GetRawCurrent()
		{
			return SolarSchoolGamePlayModel.Instance.GetConditionAttr(this.Attr);
		}

		// Token: 0x06037DDC RID: 228828 RVA: 0x00F9FED9 File Offset: 0x00F9E0D9
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr == this.Attr)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7C2 RID: 120770
		private ESolarSchoolSecondAttr Attr;

		// Token: 0x0401D7C3 RID: 120771
		private int TargetCount;

		// Token: 0x0401D7C4 RID: 120772
		private bool UseLocalProgress;

		// Token: 0x0401D7C5 RID: 120773
		private int ProgressBaseline;
	}
}
