using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025ED RID: 9709
	public class IMpcEffectParamBase
	{
		// Token: 0x0600DA32 RID: 55858 RVA: 0x0020856F File Offset: 0x0020676F
		[NullableContext(1)]
		public static IMpcEffectParamBase Create(IMpcEffectParamBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMpcEffectParamBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0600DA33 RID: 55859 RVA: 0x0020858E File Offset: 0x0020678E
		public virtual EMpcEffectParamType Type
		{
			get
			{
				return (EMpcEffectParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007927 RID: 31015
		private IMpcEffectParamBase Instance;
	}
}
