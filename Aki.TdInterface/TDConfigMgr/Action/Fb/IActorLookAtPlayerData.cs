using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A1 RID: 9633
	public class IActorLookAtPlayerData : IActorLookAtLockable
	{
		// Token: 0x0600D8CB RID: 55499 RVA: 0x00205C22 File Offset: 0x00203E22
		[NullableContext(1)]
		public static IActorLookAtPlayerData Create(IActorLookAtPlayerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtPlayerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x00205C41 File Offset: 0x00203E41
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0600D8CD RID: 55501 RVA: 0x00205C50 File Offset: 0x00203E50
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

		// Token: 0x04007879 RID: 30841
		private IActorLookAtPlayerData Instance;
	}
}
