using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CC RID: 10188
	public class ILimitPlayerCamera : ILimitPlayerOption
	{
		// Token: 0x0600E285 RID: 57989 RVA: 0x00217322 File Offset: 0x00215522
		[NullableContext(1)]
		public static ILimitPlayerCamera Create(ILimitPlayerCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x0600E286 RID: 57990 RVA: 0x00217341 File Offset: 0x00215541
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007D9E RID: 32158
		private ILimitPlayerCamera Instance;
	}
}
