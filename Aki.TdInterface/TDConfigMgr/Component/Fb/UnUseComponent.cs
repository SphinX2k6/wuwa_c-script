using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A53 RID: 2643
	public class UnUseComponent : IComponentBase
	{
		// Token: 0x06003CDE RID: 15582 RVA: 0x0009C9B9 File Offset: 0x0009ABB9
		[NullableContext(1)]
		public static UnUseComponent Create(IUnUseComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x0009C9D8 File Offset: 0x0009ABD8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x0009CA10 File Offset: 0x0009AC10
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040021F0 RID: 8688
		private IUnUseComponent Instance;
	}
}
