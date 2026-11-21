using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA8 RID: 3240
	public class IConveyorBeltField
	{
		// Token: 0x06004A1D RID: 18973 RVA: 0x000BA9DF File Offset: 0x000B8BDF
		public static IConveyorBeltField Create(IConveyorBeltField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x000BA9FE File Offset: 0x000B8BFE
		public virtual EConveyorBeltFieldType Type
		{
			get
			{
				return (EConveyorBeltFieldType)this.Instance.Type;
			}
		}

		// Token: 0x04002A03 RID: 10755
		private IConveyorBeltField Instance;
	}
}
