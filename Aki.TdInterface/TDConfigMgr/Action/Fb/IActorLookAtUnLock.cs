using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002852 RID: 10322
	public class IActorLookAtUnLock : IActorLookAtData
	{
		// Token: 0x0600E64E RID: 58958 RVA: 0x002219DB File Offset: 0x0021FBDB
		public static IActorLookAtUnLock Create(IActorLookAtUnLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtUnLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0600E64F RID: 58959 RVA: 0x002219FA File Offset: 0x0021FBFA
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x04007EE2 RID: 32482
		private IActorLookAtUnLock Instance;
	}
}
