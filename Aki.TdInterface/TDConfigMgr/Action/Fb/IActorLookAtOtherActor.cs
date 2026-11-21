using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002851 RID: 10321
	public class IActorLookAtOtherActor : IActorLookAtLockable
	{
		// Token: 0x0600E649 RID: 58953 RVA: 0x00221962 File Offset: 0x0021FB62
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

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x0600E64A RID: 58954 RVA: 0x00221981 File Offset: 0x0021FB81
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x0600E64B RID: 58955 RVA: 0x00221990 File Offset: 0x0021FB90
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

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x002219C6 File Offset: 0x0021FBC6
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x04007EE1 RID: 32481
		private IActorLookAtOtherActor Instance;
	}
}
