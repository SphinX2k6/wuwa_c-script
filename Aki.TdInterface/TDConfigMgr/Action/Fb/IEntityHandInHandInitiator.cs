using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D45 RID: 11589
	public class IEntityHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x0600FD12 RID: 64786 RVA: 0x00248FBA File Offset: 0x002471BA
		public static IEntityHandInHandInitiator Create(IEntityHandInHandInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x0600FD13 RID: 64787 RVA: 0x00248FD9 File Offset: 0x002471D9
		public override EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x0600FD14 RID: 64788 RVA: 0x00248FE6 File Offset: 0x002471E6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008A27 RID: 35367
		private IEntityHandInHandInitiator Instance;
	}
}
