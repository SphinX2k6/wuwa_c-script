using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB2 RID: 10930
	public class IStandControl : ILeisureInteractType
	{
		// Token: 0x0600F105 RID: 61701 RVA: 0x00234A50 File Offset: 0x00232C50
		public static IStandControl Create(IStandControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x0600F106 RID: 61702 RVA: 0x00234A6F File Offset: 0x00232C6F
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400847E RID: 33918
		private IStandControl Instance;
	}
}
