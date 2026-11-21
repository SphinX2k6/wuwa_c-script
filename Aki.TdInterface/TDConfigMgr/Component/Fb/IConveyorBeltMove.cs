using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAB RID: 3243
	public class IConveyorBeltMove
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x000BAAAF File Offset: 0x000B8CAF
		public static IConveyorBeltMove Create(IConveyorBeltMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x000BAACE File Offset: 0x000B8CCE
		public virtual EConveyorBeltMoveType Type
		{
			get
			{
				return (EConveyorBeltMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04002A08 RID: 10760
		private IConveyorBeltMove Instance;
	}
}
