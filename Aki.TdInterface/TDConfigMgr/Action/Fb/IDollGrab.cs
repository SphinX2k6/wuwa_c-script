using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283F RID: 10303
	public class IDollGrab : IUiGame
	{
		// Token: 0x0600E46D RID: 58477 RVA: 0x00219F8C File Offset: 0x0021818C
		[NullableContext(1)]
		public static IDollGrab Create(IDollGrab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x0600E46E RID: 58478 RVA: 0x00219FAB File Offset: 0x002181AB
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x0600E46F RID: 58479 RVA: 0x00219FB8 File Offset: 0x002181B8
		public virtual int TargetDollGrabMachineId
		{
			get
			{
				return this.Instance.TargetDollGrabMachineId;
			}
		}

		// Token: 0x04007E65 RID: 32357
		private IDollGrab Instance;
	}
}
