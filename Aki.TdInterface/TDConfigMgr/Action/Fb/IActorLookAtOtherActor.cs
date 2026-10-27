using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A2 RID: 9634
	public class IActorLookAtOtherActor : IActorLookAtLockable
	{
		// Token: 0x0600D8CF RID: 55503 RVA: 0x00205C8E File Offset: 0x00203E8E
		[NullableContext(1)]
		public static IActorLookAtOtherActor Create(IActorLookAtOtherActor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtOtherActor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x00205CAD File Offset: 0x00203EAD
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x00205CBC File Offset: 0x00203EBC
		public override bool? Lock
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

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x00205CF2 File Offset: 0x00203EF2
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x0400787A RID: 30842
		private IActorLookAtOtherActor Instance;
	}
}
