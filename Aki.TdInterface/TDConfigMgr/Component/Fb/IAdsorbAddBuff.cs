using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD5 RID: 3285
	public class IAdsorbAddBuff : IAddBuffMode
	{
		// Token: 0x06004B0A RID: 19210 RVA: 0x000BC802 File Offset: 0x000BAA02
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

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x000BC821 File Offset: 0x000BAA21
		public override EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x000BC82E File Offset: 0x000BAA2E
		public virtual int Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04002A7C RID: 10876
		private IAdsorbAddBuff Instance;
	}
}
