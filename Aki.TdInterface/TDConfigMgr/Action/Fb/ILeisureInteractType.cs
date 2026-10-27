using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D2 RID: 10194
	public class ILeisureInteractType
	{
		// Token: 0x0600E29C RID: 58012 RVA: 0x0021749B File Offset: 0x0021569B
		[NullableContext(1)]
		public static ILeisureInteractType Create(ILeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x0600E29D RID: 58013 RVA: 0x002174BA File Offset: 0x002156BA
		public virtual ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DA4 RID: 32164
		private ILeisureInteractType Instance;
	}
}
