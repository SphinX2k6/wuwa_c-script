using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259D RID: 9629
	public class IActorLookAtTalkerData : IActorLookAtLockable
	{
		// Token: 0x0600D8B9 RID: 55481 RVA: 0x00205A32 File Offset: 0x00203C32
		[NullableContext(1)]
		public static IActorLookAtTalkerData Create(IActorLookAtTalkerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtTalkerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0600D8BA RID: 55482 RVA: 0x00205A51 File Offset: 0x00203C51
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0600D8BB RID: 55483 RVA: 0x00205A60 File Offset: 0x00203C60
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

		// Token: 0x04007873 RID: 30835
		private IActorLookAtTalkerData Instance;
	}
}
