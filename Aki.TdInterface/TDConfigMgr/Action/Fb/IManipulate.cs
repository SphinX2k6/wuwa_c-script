using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB1 RID: 10929
	public class IManipulate : ILeisureInteractType
	{
		// Token: 0x0600F101 RID: 61697 RVA: 0x00234A0F File Offset: 0x00232C0F
		public static IManipulate Create(IManipulate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IManipulate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x0600F102 RID: 61698 RVA: 0x00234A2E File Offset: 0x00232C2E
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x0600F103 RID: 61699 RVA: 0x00234A3B File Offset: 0x00232C3B
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x0400847D RID: 33917
		private IManipulate Instance;
	}
}
