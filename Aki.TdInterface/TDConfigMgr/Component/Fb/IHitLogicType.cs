using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B84 RID: 2948
	public class IHitLogicType
	{
		// Token: 0x060043DA RID: 17370 RVA: 0x000ACB12 File Offset: 0x000AAD12
		[NullableContext(1)]
		public static IHitLogicType Create(IHitLogicType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x000ACB31 File Offset: 0x000AAD31
		public virtual EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x04002643 RID: 9795
		private IHitLogicType Instance;
	}
}
