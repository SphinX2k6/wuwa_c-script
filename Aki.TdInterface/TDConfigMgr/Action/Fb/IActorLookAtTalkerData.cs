using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284C RID: 10316
	public class IActorLookAtTalkerData : IActorLookAtLockable
	{
		// Token: 0x0600E633 RID: 58931 RVA: 0x00221706 File Offset: 0x0021F906
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

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x0600E634 RID: 58932 RVA: 0x00221725 File Offset: 0x0021F925
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x0600E635 RID: 58933 RVA: 0x00221734 File Offset: 0x0021F934
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

		// Token: 0x04007EDA RID: 32474
		private IActorLookAtTalkerData Instance;
	}
}
