using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3F RID: 11071
	public class IDragActor : IUiGame
	{
		// Token: 0x0600F372 RID: 62322 RVA: 0x00238670 File Offset: 0x00236870
		public static IDragActor Create(IDragActor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragActor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x0600F373 RID: 62323 RVA: 0x0023868F File Offset: 0x0023688F
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x0600F374 RID: 62324 RVA: 0x0023869C File Offset: 0x0023689C
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x0400858B RID: 34187
		private IDragActor Instance;
	}
}
