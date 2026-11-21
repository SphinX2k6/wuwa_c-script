using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD4 RID: 3284
	public class IImmediateAddBuff : IAddBuffMode
	{
		// Token: 0x06004B07 RID: 19207 RVA: 0x000BC7CE File Offset: 0x000BA9CE
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

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x000BC7ED File Offset: 0x000BA9ED
		public override EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002A7B RID: 10875
		private IImmediateAddBuff Instance;
	}
}
