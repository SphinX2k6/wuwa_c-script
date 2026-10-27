using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DE RID: 10206
	public class IManipulate : ILeisureInteractType
	{
		// Token: 0x0600E2DC RID: 58076 RVA: 0x00217BAC File Offset: 0x00215DAC
		[NullableContext(1)]
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

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x00217BCB File Offset: 0x00215DCB
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x00217BD8 File Offset: 0x00215DD8
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x04007DC0 RID: 32192
		private IManipulate Instance;
	}
}
