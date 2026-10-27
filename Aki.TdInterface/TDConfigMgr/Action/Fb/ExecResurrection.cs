using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002999 RID: 10649
	public class ExecResurrection : ActionParams
	{
		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00227680 File Offset: 0x00225880
		[NullableContext(1)]
		public static ExecResurrection Create(IExecResurrection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x0600EBB7 RID: 60343 RVA: 0x0022769F File Offset: 0x0022589F
		public virtual int ReviveId
		{
			get
			{
				return this.Instance.ReviveId;
			}
		}

		// Token: 0x040081CD RID: 33229
		private IExecResurrection Instance;
	}
}
