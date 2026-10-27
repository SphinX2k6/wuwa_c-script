using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBC RID: 3004
	public class INpcUiInteractType
	{
		// Token: 0x060044E0 RID: 17632 RVA: 0x000AEBE6 File Offset: 0x000ACDE6
		[NullableContext(1)]
		public static INpcUiInteractType Create(INpcUiInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x000AEC05 File Offset: 0x000ACE05
		public virtual ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040026F5 RID: 9973
		private INpcUiInteractType Instance;
	}
}
