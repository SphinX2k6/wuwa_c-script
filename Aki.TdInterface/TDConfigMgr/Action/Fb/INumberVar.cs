using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025FE RID: 9726
	[NullableContext(1)]
	[Nullable(0)]
	public class INumberVar
	{
		// Token: 0x0600DA7E RID: 55934 RVA: 0x00208ED3 File Offset: 0x002070D3
		public static INumberVar Create(INumberVar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberVar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x0600DA7F RID: 55935 RVA: 0x00208EF2 File Offset: 0x002070F2
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x0600DA80 RID: 55936 RVA: 0x00208EFF File Offset: 0x002070FF
		public virtual float Value
		{
			get
			{
				return this.Instance.Value;
			}
		}

		// Token: 0x04007956 RID: 31062
		private INumberVar Instance;
	}
}
