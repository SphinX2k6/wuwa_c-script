using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295F RID: 10591
	public class ToggleMapMarkState : ActionParams
	{
		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00226124 File Offset: 0x00224324
		[NullableContext(1)]
		public static ToggleMapMarkState Create(IToggleMapMarkState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleMapMarkState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0600EAD1 RID: 60113 RVA: 0x00226143 File Offset: 0x00224343
		public virtual EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x04008167 RID: 33127
		private IToggleMapMarkState Instance;
	}
}
