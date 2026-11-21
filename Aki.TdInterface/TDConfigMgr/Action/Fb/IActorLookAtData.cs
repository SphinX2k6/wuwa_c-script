using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284A RID: 10314
	public class IActorLookAtData
	{
		// Token: 0x0600E62C RID: 58924 RVA: 0x00221665 File Offset: 0x0021F865
		public static IActorLookAtData Create(IActorLookAtData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x0600E62D RID: 58925 RVA: 0x00221684 File Offset: 0x0021F884
		public virtual EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x04007ED8 RID: 32472
		private IActorLookAtData Instance;
	}
}
