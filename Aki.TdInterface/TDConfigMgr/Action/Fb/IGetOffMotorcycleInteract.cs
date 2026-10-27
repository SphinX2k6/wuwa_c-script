using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002801 RID: 10241
	public class IGetOffMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600E34E RID: 58190 RVA: 0x0021838F File Offset: 0x0021658F
		[NullableContext(1)]
		public static IGetOffMotorcycleInteract Create(IGetOffMotorcycleInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetOffMotorcycleInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x0600E34F RID: 58191 RVA: 0x002183AE File Offset: 0x002165AE
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE5 RID: 32229
		private IGetOffMotorcycleInteract Instance;
	}
}
