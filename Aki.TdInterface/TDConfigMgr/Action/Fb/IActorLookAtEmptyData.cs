using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259E RID: 9630
	public class IActorLookAtEmptyData : IActorLookAtLockable
	{
		// Token: 0x0600D8BD RID: 55485 RVA: 0x00205A9E File Offset: 0x00203C9E
		[NullableContext(1)]
		public static IActorLookAtEmptyData Create(IActorLookAtEmptyData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEmptyData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0600D8BE RID: 55486 RVA: 0x00205ABD File Offset: 0x00203CBD
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0600D8BF RID: 55487 RVA: 0x00205ACC File Offset: 0x00203CCC
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

		// Token: 0x04007874 RID: 30836
		private IActorLookAtEmptyData Instance;
	}
}
