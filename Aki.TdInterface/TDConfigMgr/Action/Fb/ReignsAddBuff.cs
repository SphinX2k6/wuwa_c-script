using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A54 RID: 10836
	public class ReignsAddBuff : ActionParams
	{
		// Token: 0x0600EE6F RID: 61039 RVA: 0x0022B543 File Offset: 0x00229743
		[NullableContext(1)]
		public static ReignsAddBuff Create(IReignsAddBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x0600EE70 RID: 61040 RVA: 0x0022B562 File Offset: 0x00229762
		public virtual int BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x04008330 RID: 33584
		private IReignsAddBuff Instance;
	}
}
