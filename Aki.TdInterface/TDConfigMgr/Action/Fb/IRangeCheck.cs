using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002852 RID: 10322
	public class IRangeCheck
	{
		// Token: 0x0600E4CB RID: 58571 RVA: 0x0021AAF1 File Offset: 0x00218CF1
		[NullableContext(1)]
		public static IRangeCheck Create(IRangeCheck? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeCheck
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x0021AB10 File Offset: 0x00218D10
		public virtual ERangeCheckType Type
		{
			get
			{
				return (ERangeCheckType)this.Instance.Type;
			}
		}

		// Token: 0x04007E96 RID: 32406
		private IRangeCheck Instance;
	}
}
