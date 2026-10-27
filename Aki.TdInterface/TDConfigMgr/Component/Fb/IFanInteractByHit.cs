using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCD RID: 3277
	public class IFanInteractByHit : IFanInteractType
	{
		// Token: 0x06004AEC RID: 19180 RVA: 0x000BB707 File Offset: 0x000B9907
		[NullableContext(1)]
		public static IFanInteractByHit Create(IFanInteractByHit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x000BB726 File Offset: 0x000B9926
		public override EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002AE2 RID: 10978
		private IFanInteractByHit Instance;
	}
}
