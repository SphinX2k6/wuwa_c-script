using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B77 RID: 11127
	public class IBaseCurve
	{
		// Token: 0x0600F475 RID: 62581 RVA: 0x0023A53C File Offset: 0x0023873C
		public static IBaseCurve Create(IBaseCurve? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseCurve
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x0600F476 RID: 62582 RVA: 0x0023A55B File Offset: 0x0023875B
		public virtual EBaseCurveType Type
		{
			get
			{
				return (EBaseCurveType)this.Instance.Type;
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x0600F477 RID: 62583 RVA: 0x0023A568 File Offset: 0x00238768
		public virtual float N
		{
			get
			{
				return this.Instance.N;
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x0600F478 RID: 62584 RVA: 0x0023A575 File Offset: 0x00238775
		[Nullable(2)]
		public virtual string CurveAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CurveAsset;
			}
		}

		// Token: 0x04008611 RID: 34321
		private IBaseCurve Instance;
	}
}
