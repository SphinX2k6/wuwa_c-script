using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F8 RID: 9720
	public class SetMoveSpeed : ActionParams
	{
		// Token: 0x0600DA66 RID: 55910 RVA: 0x00208C12 File Offset: 0x00206E12
		[NullableContext(1)]
		public static SetMoveSpeed Create(ISetMoveSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x00208C31 File Offset: 0x00206E31
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04007942 RID: 31042
		private ISetMoveSpeed Instance;
	}
}
