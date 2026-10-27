using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259F RID: 9631
	public class IActorLookAtEntityData : IActorLookAtLockable
	{
		// Token: 0x0600D8C1 RID: 55489 RVA: 0x00205B0A File Offset: 0x00203D0A
		[NullableContext(1)]
		public static IActorLookAtEntityData Create(IActorLookAtEntityData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEntityData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0600D8C2 RID: 55490 RVA: 0x00205B29 File Offset: 0x00203D29
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x00205B38 File Offset: 0x00203D38
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

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x0600D8C4 RID: 55492 RVA: 0x00205B6E File Offset: 0x00203D6E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007875 RID: 30837
		private IActorLookAtEntityData Instance;
	}
}
