using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E01 RID: 11777
	public class IChangeElementalBoxStateTargetBoxId : IChangeElementalBoxStateTarget
	{
		// Token: 0x06010001 RID: 65537 RVA: 0x0024DB02 File Offset: 0x0024BD02
		public static IChangeElementalBoxStateTargetBoxId Create(IChangeElementalBoxStateTargetBoxId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x06010002 RID: 65538 RVA: 0x0024DB21 File Offset: 0x0024BD21
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x06010003 RID: 65539 RVA: 0x0024DB2E File Offset: 0x0024BD2E
		public virtual int TargetBoxId
		{
			get
			{
				return this.Instance.TargetBoxId;
			}
		}

		// Token: 0x04008BB7 RID: 35767
		private IChangeElementalBoxStateTargetBoxId Instance;
	}
}
