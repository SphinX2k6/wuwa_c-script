using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB1 RID: 3505
	public class IRangeConstraint
	{
		// Token: 0x06004F97 RID: 20375 RVA: 0x000C5099 File Offset: 0x000C3299
		[NullableContext(1)]
		public static IRangeConstraint Create(IRangeConstraint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeConstraint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x000C50B8 File Offset: 0x000C32B8
		public virtual ERangeConstraint Type
		{
			get
			{
				return (ERangeConstraint)this.Instance.Type;
			}
		}

		// Token: 0x04002DA8 RID: 11688
		private IRangeConstraint Instance;
	}
}
