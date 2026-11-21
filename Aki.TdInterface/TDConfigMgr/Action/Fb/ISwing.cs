using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC5 RID: 10949
	public class ISwing : ILeisureInteractType
	{
		// Token: 0x0600F141 RID: 61761 RVA: 0x00234E7A File Offset: 0x0023307A
		public static ISwing Create(ISwing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x0600F142 RID: 61762 RVA: 0x00234E99 File Offset: 0x00233099
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x0600F143 RID: 61763 RVA: 0x00234EA6 File Offset: 0x002330A6
		public virtual string SwingDa
		{
			get
			{
				return this.Instance.SwingDa;
			}
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x0600F144 RID: 61764 RVA: 0x00234EB3 File Offset: 0x002330B3
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008493 RID: 33939
		private ISwing Instance;
	}
}
