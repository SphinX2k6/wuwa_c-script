using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAC RID: 3244
	public class IFixSpeed : IConveyorBeltMove
	{
		// Token: 0x06004A2A RID: 18986 RVA: 0x000BAAE3 File Offset: 0x000B8CE3
		public static IFixSpeed Create(IFixSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x000BAB02 File Offset: 0x000B8D02
		public override EConveyorBeltMoveType Type
		{
			get
			{
				return (EConveyorBeltMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06004A2C RID: 18988 RVA: 0x000BAB0F File Offset: 0x000B8D0F
		public virtual int Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04002A09 RID: 10761
		private IFixSpeed Instance;
	}
}
