using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002939 RID: 10553
	public class IHealthBarDisplayClientFunction : EnableClientFunction
	{
		// Token: 0x0600EA10 RID: 59920 RVA: 0x002248B1 File Offset: 0x00222AB1
		[NullableContext(1)]
		public static IHealthBarDisplayClientFunction Create(IHealthBarDisplayClientFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x0600EA11 RID: 59921 RVA: 0x002248D0 File Offset: 0x00222AD0
		public override EEnableClientFunctionType Type
		{
			get
			{
				return (EEnableClientFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x0600EA12 RID: 59922 RVA: 0x002248DD File Offset: 0x00222ADD
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x002248EA File Offset: 0x00222AEA
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x04008117 RID: 33047
		private IHealthBarDisplayClientFunction Instance;
	}
}
