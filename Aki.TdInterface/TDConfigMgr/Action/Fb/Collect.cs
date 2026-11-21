using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002936 RID: 10550
	public class Collect : ActionParams
	{
		// Token: 0x0600EA79 RID: 60025 RVA: 0x00229960 File Offset: 0x00227B60
		public static Collect Create(ICollect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Collect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x0600EA7A RID: 60026 RVA: 0x00229980 File Offset: 0x00227B80
		public virtual int? TargetEntity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetEntity);
			}
		}

		// Token: 0x0400813E RID: 33086
		private ICollect Instance;
	}
}
