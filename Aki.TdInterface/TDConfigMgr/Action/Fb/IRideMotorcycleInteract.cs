using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002800 RID: 10240
	public class IRideMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600E34A RID: 58186 RVA: 0x0021834E File Offset: 0x0021654E
		[NullableContext(1)]
		public static IRideMotorcycleInteract Create(IRideMotorcycleInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x0600E34B RID: 58187 RVA: 0x0021836D File Offset: 0x0021656D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x0600E34C RID: 58188 RVA: 0x0021837A File Offset: 0x0021657A
		public virtual int MotorcycleEntityId
		{
			get
			{
				return this.Instance.MotorcycleEntityId;
			}
		}

		// Token: 0x04007DE4 RID: 32228
		private IRideMotorcycleInteract Instance;
	}
}
