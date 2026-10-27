using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CA RID: 10186
	public class ILimitPlayerMove : ILimitPlayerOption
	{
		// Token: 0x0600E27E RID: 57982 RVA: 0x00217284 File Offset: 0x00215484
		[NullableContext(1)]
		public static ILimitPlayerMove Create(ILimitPlayerMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x0600E27F RID: 57983 RVA: 0x002172A3 File Offset: 0x002154A3
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x0600E280 RID: 57984 RVA: 0x002172B0 File Offset: 0x002154B0
		public virtual bool? IsOnlyForward
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOnlyForward);
			}
		}

		// Token: 0x04007D9C RID: 32156
		private ILimitPlayerMove Instance;
	}
}
