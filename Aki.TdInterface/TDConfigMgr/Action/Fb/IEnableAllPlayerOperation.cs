using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293A RID: 10554
	public class IEnableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600EA15 RID: 59925 RVA: 0x002248FF File Offset: 0x00222AFF
		[NullableContext(1)]
		public static IEnableAllPlayerOperation Create(IEnableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x0600EA16 RID: 59926 RVA: 0x0022491E File Offset: 0x00222B1E
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x0022492C File Offset: 0x00222B2C
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsUiFadeEffect);
			}
		}

		// Token: 0x04008118 RID: 33048
		private IEnableAllPlayerOperation Instance;
	}
}
