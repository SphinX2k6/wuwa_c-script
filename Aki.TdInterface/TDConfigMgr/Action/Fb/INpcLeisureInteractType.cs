using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002816 RID: 10262
	public class INpcLeisureInteractType
	{
		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00218B1E File Offset: 0x00216D1E
		[NullableContext(1)]
		public static INpcLeisureInteractType Create(INpcLeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcLeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x00218B3D File Offset: 0x00216D3D
		public virtual ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x00218B4C File Offset: 0x00216D4C
		public virtual bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x04007E0A RID: 32266
		private INpcLeisureInteractType Instance;
	}
}
