using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002563 RID: 9571
	public class AvgFocusRole : ActionParams
	{
		// Token: 0x0600D6E6 RID: 55014 RVA: 0x002007E3 File Offset: 0x001FE9E3
		[NullableContext(1)]
		public static AvgFocusRole Create(IAvgFocusRole? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x00200802 File Offset: 0x001FEA02
		public virtual bool IsFocus
		{
			get
			{
				return this.Instance.IsFocus;
			}
		}

		// Token: 0x04007705 RID: 30469
		private IAvgFocusRole Instance;
	}
}
