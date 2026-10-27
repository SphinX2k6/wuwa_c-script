using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DD RID: 10717
	public class PlayerInput : ActionParams
	{
		// Token: 0x0600ECC4 RID: 60612 RVA: 0x00228FCA File Offset: 0x002271CA
		[NullableContext(1)]
		public static PlayerInput Create(IPlayerInput? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerInput
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x0600ECC5 RID: 60613 RVA: 0x00228FE9 File Offset: 0x002271E9
		public virtual EPlayerInputType Input
		{
			get
			{
				return (EPlayerInputType)this.Instance.Input;
			}
		}

		// Token: 0x04008265 RID: 33381
		private IPlayerInput Instance;
	}
}
