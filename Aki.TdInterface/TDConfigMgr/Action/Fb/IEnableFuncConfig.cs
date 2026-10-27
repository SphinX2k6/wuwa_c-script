using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACD RID: 10957
	public class IEnableFuncConfig
	{
		// Token: 0x0600F058 RID: 61528 RVA: 0x0022E6B5 File Offset: 0x0022C8B5
		[NullableContext(1)]
		public static IEnableFuncConfig Create(IEnableFuncConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableFuncConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x0600F059 RID: 61529 RVA: 0x0022E6D4 File Offset: 0x0022C8D4
		public virtual float? DelayDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayDuration);
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x0600F05A RID: 61530 RVA: 0x0022E70C File Offset: 0x0022C90C
		public virtual bool? IsEnableEsc
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableEsc);
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x0600F05B RID: 61531 RVA: 0x0022E744 File Offset: 0x0022C944
		public virtual bool? IsEnablePhoto
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnablePhoto);
			}
		}

		// Token: 0x04008435 RID: 33845
		private IEnableFuncConfig Instance;
	}
}
