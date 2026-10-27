using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFA RID: 3322
	public class ICustomViewDistance : IViewDistanceMode
	{
		// Token: 0x06004BDB RID: 19419 RVA: 0x000BD458 File Offset: 0x000BB658
		[NullableContext(1)]
		public static ICustomViewDistance Create(ICustomViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x000BD477 File Offset: 0x000BB677
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x000BD484 File Offset: 0x000BB684
		public virtual int Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002B5D RID: 11101
		private ICustomViewDistance Instance;
	}
}
