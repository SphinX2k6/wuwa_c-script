using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD8 RID: 10968
	public class IFoxPickUp : ILeisureInteractType
	{
		// Token: 0x0600F180 RID: 61824 RVA: 0x002352D0 File Offset: 0x002334D0
		public static IFoxPickUp Create(IFoxPickUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x0600F181 RID: 61825 RVA: 0x002352EF File Offset: 0x002334EF
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x0600F182 RID: 61826 RVA: 0x002352FC File Offset: 0x002334FC
		public virtual int DataTableIndex
		{
			get
			{
				return this.Instance.DataTableIndex;
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x0600F183 RID: 61827 RVA: 0x0023530C File Offset: 0x0023350C
		public virtual bool? MouthOpen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.MouthOpen);
			}
		}

		// Token: 0x040084A6 RID: 33958
		private IFoxPickUp Instance;
	}
}
