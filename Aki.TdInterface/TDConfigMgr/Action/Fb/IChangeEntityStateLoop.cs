using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002930 RID: 10544
	public class IChangeEntityStateLoop : ChangeEntityState
	{
		// Token: 0x0600EA60 RID: 60000 RVA: 0x00229686 File Offset: 0x00227886
		public static IChangeEntityStateLoop Create(IChangeEntityStateLoop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x002296A5 File Offset: 0x002278A5
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x0600EA62 RID: 60002 RVA: 0x002296B2 File Offset: 0x002278B2
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x0600EA63 RID: 60003 RVA: 0x002296BF File Offset: 0x002278BF
		public virtual ELoopStateType Circulation
		{
			get
			{
				return (ELoopStateType)this.Instance.Circulation;
			}
		}

		// Token: 0x04008132 RID: 33074
		private IChangeEntityStateLoop Instance;
	}
}
