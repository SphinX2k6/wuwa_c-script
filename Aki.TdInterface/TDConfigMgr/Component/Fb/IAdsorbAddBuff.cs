using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C05 RID: 3077
	public class IAdsorbAddBuff : IAddBuffMode
	{
		// Token: 0x060046A7 RID: 18087 RVA: 0x000B2636 File Offset: 0x000B0836
		[NullableContext(1)]
		public static IAdsorbAddBuff Create(IAdsorbAddBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdsorbAddBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x000B2655 File Offset: 0x000B0855
		public override EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x000B2662 File Offset: 0x000B0862
		public virtual int Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04002830 RID: 10288
		private IAdsorbAddBuff Instance;
	}
}
