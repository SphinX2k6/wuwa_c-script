using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259C RID: 9628
	public class IActorLookAtLockable : IActorLookAtData
	{
		// Token: 0x0600D8B5 RID: 55477 RVA: 0x002059C5 File Offset: 0x00203BC5
		[NullableContext(1)]
		public static IActorLookAtLockable Create(IActorLookAtLockable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtLockable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x0600D8B6 RID: 55478 RVA: 0x002059E4 File Offset: 0x00203BE4
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0600D8B7 RID: 55479 RVA: 0x002059F4 File Offset: 0x00203BF4
		public virtual bool? Lock
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Lock);
			}
		}

		// Token: 0x04007872 RID: 30834
		private IActorLookAtLockable Instance;
	}
}
