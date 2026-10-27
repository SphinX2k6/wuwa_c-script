using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C04 RID: 3076
	public class IImmediateAddBuff : IAddBuffMode
	{
		// Token: 0x060046A4 RID: 18084 RVA: 0x000B2602 File Offset: 0x000B0802
		[NullableContext(1)]
		public static IImmediateAddBuff Create(IImmediateAddBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IImmediateAddBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x000B2621 File Offset: 0x000B0821
		public override EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x0400282F RID: 10287
		private IImmediateAddBuff Instance;
	}
}
