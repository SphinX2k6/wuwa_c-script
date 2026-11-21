using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB3 RID: 10931
	public class IStandControl2 : ILeisureInteractType
	{
		// Token: 0x0600F108 RID: 61704 RVA: 0x00234A84 File Offset: 0x00232C84
		public static IStandControl2 Create(IStandControl2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x0600F109 RID: 61705 RVA: 0x00234AA3 File Offset: 0x00232CA3
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400847F RID: 33919
		private IStandControl2 Instance;
	}
}
