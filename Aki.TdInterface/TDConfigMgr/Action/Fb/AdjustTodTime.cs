using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279B RID: 10139
	public class AdjustTodTime : ActionParams
	{
		// Token: 0x0600E09B RID: 57499 RVA: 0x00210D6E File Offset: 0x0020EF6E
		public static AdjustTodTime Create(IAdjustTodTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600E09C RID: 57500 RVA: 0x00210D8D File Offset: 0x0020EF8D
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600E09D RID: 57501 RVA: 0x00210D9A File Offset: 0x0020EF9A
		public virtual int Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600E09E RID: 57502 RVA: 0x00210DA7 File Offset: 0x0020EFA7
		public virtual bool ShowUi
		{
			get
			{
				return this.Instance.ShowUi;
			}
		}

		// Token: 0x04007A25 RID: 31269
		private IAdjustTodTime Instance;
	}
}
